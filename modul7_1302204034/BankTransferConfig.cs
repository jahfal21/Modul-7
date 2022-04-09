using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Newtonsoft.Json;
using System.IO;

namespace modul7_1302204034
{
	public class BankTransferConfig
	{
		//Set Default Value
		public string CONFIG1 { get; set; } = "en";
		public int CONFIG2 { get; set; } = 25000000;
		public int CONFIG3 { get; set; } = 6500;
		public int CONFIG4 { get; set; } = 15000;
		public string[] CONFIG5 { get; set; } = new string[] { "RTO(real - time)", "SKN", "RTGS", "BI FAST" };
		public string CONFIG6 { get; set; } = "yes";
		public string CONFIG7 { get; set; } = "ya";

		//Class Attributes
		public string lang { get; set; }
		public Transfer transfer { get; set; }
		public string[] methods { get; set; }
		public Confirmation confirmation { get; set; }





		public void Load()
		{
			try
			{
				string jsonText = File.ReadAllText("bank_transfer_config.json");
				var json = JsonConvert.DeserializeObject<BankTransferConfig>(jsonText);

				this.lang = json.lang;
				this.transfer = json.transfer;
				this.methods = json.methods;
				this.confirmation = json.confirmation;

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		public class Transfer
		{
			public int CONFIG2 { get; set; } = 25000000;
			public int CONFIG3 { get; set; } = 6500;
			public int CONFIG4 { get; set; } = 15000;
			public int threshold { get; set; }
			public int low_fee { get; set; }
			public int high_fee { get; set; }
		}

		public class Confirmation
		{
			public string CONFIG6 { get; set; } = "yes";
			public string CONFIG7 { get; set; } = "ya";
			public string en { get; set; }
			public string id { get; set; }
		}
	}

}