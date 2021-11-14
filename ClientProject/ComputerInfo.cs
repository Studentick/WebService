using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClientProject
{
    [DataContract]
    class ComputerInfo
    {
        [DataMember]
        string comp_id;
        // Нужно будет свойства добавить
        [DataMember]
        public string inventory_number;
        [DataMember]
        public string location;
        [DataMember]
        public List<InstProgr> instprogs = new List<InstProgr>();

        public ComputerInfo(string comp_id, List<InstProgr> instprogs,
            string location = "Другое", string inventory_number = "null")
        {
            this.comp_id = comp_id;
            this.instprogs = instprogs;
            this.location = location;
            this.inventory_number = inventory_number;
        }

        static public string GetBoardSerialNumber(ref bool need_test)
        {
            List<string> results = new List<string>();

            string query = "SELECT * FROM Win32_BaseBoard";
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(query);
            foreach (ManagementObject info in searcher.Get())
            {
                results.Add(
                    info.GetPropertyValue("SerialNumber").ToString());
            }
            need_test = true;
            return results[0];
        }

        public static List<InstProgr> GetInstProgLst()
        {
            string regkey_classic = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            string regkey_64 = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

            List<InstProgr> prs = new List<InstProgr>();
            prs.AddRange(GetAllInstProgLst(regkey_classic));

            if (Environment.Is64BitOperatingSystem)
            {
                prs.AddRange(GetAllInstProgLst(regkey_classic, false));
                prs.AddRange(GetAllInstProgLst(regkey_64));
            }

            prs = DeleteDublicate(prs);
            return prs;
        }

        static List<InstProgr> DeleteDublicate(List<InstProgr> prs)
        {
            List<InstProgr> new_prs = new List<InstProgr>();
            foreach (var it in prs)
            {
                foreach (var new_it in new_prs)
                {
                    if (new_it.Name == it.Name && new_it.Version == it.Version)
                    {
                        goto metka;
                    }
                }
                new_prs.Add(it);
                metka:
                continue;
            }
            return new_prs;
        }

        // Получить список всех установленных программ
        static List<InstProgr> GetAllInstProgLst(string registry_key, bool lm = true)
        {
            List<InstProgr> instPr = new List<InstProgr>();
            using (RegistryKey key = lm ? Registry.LocalMachine.OpenSubKey(registry_key) : Registry.CurrentUser.OpenSubKey(registry_key))
            {

                foreach (string subkey_name in key.GetSubKeyNames())
                {

                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        var name = subkey.GetValue("DisplayName");
                        var version = subkey.GetValue("DisplayVersion");
                        var uninstall = subkey.GetValue("UninstallString");
                        var date = subkey.GetValue("InstallDate");
                        var system = subkey.GetValue("SystemComponent");
                        bool s_b = false;

                        try { s_b = system.ToString() == "1" ? true : false; } catch (Exception ex) { s_b = false; }

                        if (name != null && !s_b)
                        {
                            instPr.Add(new InstProgr(name, version, date));
                        }
                    }
                }
            }

            return instPr;
        }
    }
}
