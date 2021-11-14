using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProject
{
    public partial class Form1 : Form
    {
        // Table
        // https://docs.google.com/spreadsheets/d/15tH_DVHCHzBBBCKNOrvmZ8lzMqlakxiJYhPdiPREDiQ/edit#gid=430250496
        // 
        // Script
        // https://script.google.com/home/projects/1kUsozfzInKrjJnkkZtIjsBmntxLRh5PF9gEDH3NaAdKLUXKhFbnJnNW5/edit



        string url = "https://script.google.com/macros/s/AKfycbzMNo_6OE19CCzW0UZZtvjMdFpHCCTP69mZhKpd8A/exec";
        static bool n_t = false;
        string mb_id;
        WebClient webClient;
        NameValueCollection pars;
        ComputerInfo pc;
        string loc = "", inventory = "";

        List<InstProgr> prs;

        public Form1()
        {
            mb_id = ComputerInfo.GetBoardSerialNumber(ref n_t);
            prs = new List<InstProgr>();
            this.webClient = new WebClient();
            this.pars = new NameValueCollection();


            InitializeComponent();


            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(mb_id));
            //dgvInstProgr.DataSource = prs;

            tbId.Text = Convert.ToBase64String(hash);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DowloadPCInfo(ref loc, ref inventory);
            tbInventory.Text = inventory;
            tbLoc.Text = loc;


        }

        private void DowloadPCInfo(ref string loc, ref string inventory)
        {
            //Получение информации о компьютере по айди
            pars.Add("get_pc_info", mb_id);
            var response = webClient.UploadValues(url, pars);
            var pc2 = GetPcsDataFromByteArr(response);
            //Возвращает объект компьютер

            loc = pc2.location;
            inventory = pc2.inventory_number;
            pars.Remove("get_pc_info");
        }


        private void DowloadFullPCInfo(string mb_id, ref string loc, ref string inventory, ref List<InstProgr> progs)
        {
            //Получение информации о компьютере по айди
            pars.Add("get_full_pc_info", mb_id);
            var response = webClient.UploadValues(url, pars);
            var pc2 = GetPcsDataFromByteArr(response);
            //Возвращает объект компьютер

            loc = pc2.location;
            inventory = pc2.inventory_number;
            progs.AddRange(pc2.instprogs);
            pars.Remove("get_full_pc_info");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbInventory.Text = inventory;
            tbLoc.Text = loc;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
            prs.RemoveRange(0, prs.Count);
            var gg = ComputerInfo.GetInstProgLst();
            gg.RemoveRange(4, gg.Count - 4);
            prs.AddRange(gg);

            ResetDataTable(prs);
            

            pc = new ComputerInfo(mb_id, prs);
        }

        private void ResetDataTable(List<InstProgr> progs)
        {
            dgvInstProgr.DataSource = null;
            dgvInstProgr.DataSource = prs;
            dgvInstProgr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                pc.inventory_number = tbInventory.Text;
                pc.location = tbLoc.Text;
                string json = GetJSONfromPc(pc);
                // Запись инф-ии о компе
                pars.Add("set_inst_prog", json);
                var response = webClient.UploadValues(url, pars);
                //pars.Remove("set_inst_prog");
                //pars.Remove("get_pc_info");
                var ans = GetAnsw(response);
                //Возвращает первое число 0 - ошибка, 1 - данные были внесены, 2 - данные были обновлены
                switch(ans)
                {
                    case 0: MessageBox.Show("Ошибка на стороне сервера"); break;
                    case 1: MessageBox.Show("Компьютер бы добавлен в БД"); break;
                    case 2: MessageBox.Show("Данные про этот компьютер были обновлены в БД"); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка, считайте данные для начала");
            }
            finally
            {
                pars.Remove("set_inst_prog");
            }
        }


        // Массив байт в список Объектов компьютер
        private static ComputerInfo GetPcsDataFromByteArr(byte[] response)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ComputerInfo));
            MemoryStream stream2 = new MemoryStream();
            stream2.Position = 0;
            stream2.Write(response, 0, response.Length);
            stream2.Position = 0;

            var sr = new StreamReader(stream2);
            stream2.Position = 0;
            string json = sr.ReadToEnd();
            //return null;
            stream2.Position = 0;
            //DataContractJsonSerializer serializer1 = new DataContractJsonSerializer(typeof(int));
            //var gg = (int)serializer1.ReadObject(stream2);
            var ff2 = (ComputerInfo)serializer.ReadObject(stream2);
            //MemoryStream stream = new MemoryStream();
            //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List <ComputerInfo>));
            //stream = new MemoryStream(response);
            //stream.Position = 0;
            ////return nulializer.ReadObject(stream);
            //return null;
            //var ff = (ComputerInfo)serializer.ReadObject(stream);
            //return (ComputerInfo)serializer.ReadObject(stream);

            return ff2;
        }

        private static int GetAnsw(byte[] response)
        {
            DataContractJsonSerializer serializer1 = new DataContractJsonSerializer(typeof(int));
            MemoryStream stream2 = new MemoryStream();
            stream2.Position = 0;
            stream2.Write(response, 0, response.Length);
            stream2.Position = 0;

            var sr = new StreamReader(stream2);
            stream2.Position = 0;
            string json = sr.ReadToEnd();
            //return 0;
            stream2.Position = 0;

            var gg = (int)serializer1.ReadObject(stream2);


            return gg;
        }

        private void btnGetCount_Click(object sender, EventArgs e)
        {
            var krit = cbKriteriy.Text;
            var pattern = tbPattern.Text;
            string result = "";
            switch(krit)
            {
                case "Инвентарный номер": result = GetCountInv(pattern); break;
                case "Расположение": result = GetCountLocation(pattern); break;
                default: result = "0"; break;
            }

            tbRes.Text = result;

        }

        private string GetCountInv(string pattern)
        {
            pars.Add("count_by_inventory", pattern);
            var response = webClient.UploadValues(url, pars);
            var ans = GetAnsw(response);

            pars.Remove("count_by_inventory");
            return ans.ToString();
        }

        private string GetCountLocation(string pattern)
        {
            pars.Add("count_by_location", pattern);
            var response = webClient.UploadValues(url, pars);
            var ans = GetAnsw(response);

            pars.Remove("count_by_location");
            return ans.ToString();
        }

        private void btnReadSelected_Click(object sender, EventArgs e)
        {
            dgvProgInfo.DataSource = null;
            string glob = "", inventory = "", s_mb_id = tbSeId.Text;
            List<InstProgr> progs = new List<InstProgr>();
            try
            {
                DowloadFullPCInfo(s_mb_id, ref glob, ref inventory, ref progs);
                dgvProgInfo.DataSource = progs;
                dgvProgInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Такого компьютера нет в системе");
                pars.Remove("get_full_pc_info");
            }
            finally
            {
                tbSeIn.Text = inventory;
                tbSeLoc.Text = glob;
            }
        }

        private static string GetJSONfromPc(ComputerInfo pc)
        {
            // Сериализация в json
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ComputerInfo));

            MemoryStream stream = new MemoryStream();
            MemoryStream stream2 = new MemoryStream();
            // записать в поток объект
            serializer.WriteObject(stream, pc);
            var arr = stream.GetBuffer();
            stream2.Write(arr, 0, arr.Length);
            stream.Position = 0;
            stream2.Position = 0;
            var sr = new StreamReader(stream);
            //stream.Position = 0;
            //stream2.Position = 0;
            //var ff = (ComputerInfo)serializer.ReadObject(stream);
            //var ff2 = (ComputerInfo)serializer.ReadObject(stream2);
            stream.Position = 0;
            string json = sr.ReadToEnd();
            return json;
        }
    }
}
