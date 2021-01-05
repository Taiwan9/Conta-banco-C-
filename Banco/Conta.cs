using System;
using System.Globalization;

namespace Banco
{
    class Conta
    {
        public double Saldo { get; private set; }
        public string Titular { get; set; }
        public int Id { get; private set; }


        public Conta(int id, string titular){
            Id = id;
            Titular = titular;
        }

        public Conta(int id, string titular, double depositoInicial):this(id, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo = Saldo - quantia - 5.00;
        }

        public override string ToString()
        {
            return "Conta "
                + Id
                + " Saldo R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
