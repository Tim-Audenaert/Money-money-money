using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_money_money
{
    class Program
    {
        static void Main(string[] args)
        {
            BankRekening bank = new BankRekening();
            bank.VoegGeldToe(10000);

            SpaarRekening spaar = new SpaarRekening();
            spaar.VoegGeldToe(10000);

            ProRekening pro = new ProRekening();
            pro.VoegGeldToe(10000);


            Console.WriteLine("Bankrekening Saldo: " + bank.Saldo + " - Rente: " + bank.BerekenRente());
            Console.WriteLine("Spaarrekening Saldo: " + spaar.Saldo + " - Rente: " + spaar.BerekenRente());
            Console.WriteLine("Prorekening Saldo: " + pro.Saldo + " - Rente: " + pro.BerekenRente());
            Console.ReadLine();
        }
    }
}
