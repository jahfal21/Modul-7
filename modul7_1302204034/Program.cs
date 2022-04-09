using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_1302204034
{
    class Program
    {
        public static void Main()
        {
            BankTransferConfig config = new BankTransferConfig();
            config.Load();

            if (config.lang == "id")
            {
                Console.WriteLine("Masukkan jumlah uang yang akan di-transfer");
            }
            else
            {
                Console.WriteLine("Please insert the amount of money to transfer:");
            }
            int input1 = int.Parse(Console.ReadLine());

            int biayaTransfer;
            if (input1 <= config.transfer.threshold)
            {
                biayaTransfer = config.transfer.low_fee;
            }
            else
            {
                biayaTransfer = config.transfer.high_fee;
            }

            if (config.lang == "id")
            {
                Console.WriteLine($"Total biaya = {input1 + biayaTransfer}");
                Console.WriteLine("Pilih metode transfer:");
            }
            else
            {
                Console.WriteLine($"Total amount = {input1 + biayaTransfer}");
                Console.WriteLine("Select transfer method:");
            }

            int iter = 1;
            foreach (string item in config.methods)
            {
                Console.WriteLine(iter.ToString() + ". " + item);
                iter++;
            }
            string input2 = Console.ReadLine();

            if (config.lang == "id")
            {
                Console.WriteLine($"Ketik { config.confirmation.id } untuk mengkonfirmasi transaksi:");
                if (Console.ReadLine() == config.confirmation.id)
                {
                    Console.WriteLine("Proses transfer berhasil");
                }
                else
                {
                    Console.WriteLine("Transfer dibatalkan");
                }
            }
            else
            {
                Console.WriteLine($"Please type { config.confirmation.en } to confirm the transaction:");
                if (Console.ReadLine() == config.confirmation.en)
                {
                    Console.WriteLine("The transfer is completed");
                }
                else
                {
                    Console.WriteLine("Transfer is cancelled");
                }
            }
        }
    }
}