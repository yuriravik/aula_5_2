using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class Conta
    {
        public int numConta;
        public float saldo;
        public Cliente cliente;

        public void depositar(float deposito)
        {
            saldo += deposito;
        }
        public Boolean sacar(float saque)
        {
            if(saque <= saldo)
            {
                saldo = saldo - saque;
                return true;
            }
            else
            {
                return false;
                Console.WriteLine("Você não tem saldo suficiente para esse saque");
            }
        }
        public void criarConta(int numerConta, float saldo, Cliente cliente)
        {
            numerConta = numerConta;
            saldo = saldo;
            cliente = cliente;
        }
    }
}