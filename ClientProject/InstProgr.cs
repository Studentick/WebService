using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClientProject
{
    [DataContract]
    class InstProgr
    {
        [DataMember]
        public object Name { get; set; }
        [DataMember]
        public object Version { get; set; }
        [DataMember]
        public object InstDate { get; set; }

        public InstProgr(object name, object version, object date)
        {
            this.Name = name;
            this.Version = version;
            this.InstDate = date;
        }
    }
}
