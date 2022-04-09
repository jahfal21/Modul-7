using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_1302204034
{
    public class BankTransferConfig
    {
        public string CONFIG1 { get; set; } = "en";
        public int CONFIG2 { get; set; } = 150000;
        public int CONFIG3 { get; set; } = 6500;
        public int CONFIG4 { get; set; } = 25000000;
        public string CONFIG5 { get; set; } = "RTO(real-time)";
        public string CONFIG6 { get; set; } = "yes";
        public string CONFIG7 { get; set; } = "no";

        public string lang { get; set; }
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
        public string methods { get; set; }
        public string en { get; set; }
        public string id { get; set; }
    }
}