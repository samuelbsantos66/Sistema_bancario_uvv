using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario_uvv.SistemaBancario_uvv.model
{
    internal class Model
    {

        public class Cliente
        {
            public string nome { get; set; }
            public string cpf { get; set; }

            public string email {  get; set; }

            public Conta conta;

            public Cliente(string numeroConta)
            {
                NumeroConta = numeroConta;
                Saldo = 0;
            }

            public void Depositar(decimal valor)
            {
                if (valor > 0)
                {
                    Saldo += valor;
                }
            }
        }

        public class Conta
        {
            public string id { get; set; }
            public decimal Saldo { get; private set; }

            public ContaBancaria(string numeroConta)
            {
                NumeroConta = numeroConta;
                Saldo = 0;
            }

            public void Depositar(decimal valor)
            {
                if (valor > 0)
                {
                    Saldo += valor;
                }
            }
        }

    }
}
