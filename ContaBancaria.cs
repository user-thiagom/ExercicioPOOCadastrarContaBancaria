using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOCadastrarContaBancaria
{
    public class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroDaConta, string titular)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
            Saldo = 0;
        }

        public ContaBancaria(double depositoInicial, int numeroDaConta, string titular) : this(numeroDaConta,titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= (valor + 5.0);
        }

        public override string ToString()
        {
            return $"Conta {NumeroDaConta}, Titular: {Titular}, Saldo: $ {Saldo}";
        }
    }
}
