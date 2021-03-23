using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_money_money
{
    abstract class Rekening
    {
        public string Naam { get; set; }
        public double Saldo { get; private set; }
        public double Rente { get; set; }
        public void VoegGeldToe(double bedrag)
        {
            Saldo += bedrag;
        }
        public void HaalGeldAf(double bedrag)
        {
            Saldo -= bedrag;
        }
        public abstract double BerekenRente();
    }

    class BankRekening : Rekening
    {
        public override double BerekenRente()
        {
            if (Saldo > 100)
            {
                Rente = Saldo * 0.05;
            }
            return Rente;
        }
    }

    class SpaarRekening : Rekening
    {
        public override double BerekenRente()
        {
            Rente = Saldo * 0.02;
            return Rente;
        }
    }

    class ProRekening : SpaarRekening
    {
        public override double BerekenRente()
        {
            double temp = Saldo;
            double extraRente = 0;
            while (temp >= 1000)
            {
                temp -= 1000;
                extraRente += 10;
            }

            return base.BerekenRente() + extraRente;
        }
    }
}
