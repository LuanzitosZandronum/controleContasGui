using controleContasGui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContasGui
{
    public class Conta
    {
        public Conta(long numero, decimal saldoInicial, Cliente titular, Agencia agencia) //Método construtor da classe Conta que recebe quatro parâmetros (numero, saldo inicial, titular e agencia)
        {
            if (titular == null)
            {
                throw new ArgumentNullException(nameof(titular), "Deve haver um titular.");
            }
            if (agencia == null)
            {
                throw new ArgumentException(nameof(agencia), "Deve haver agência.");
            }
            if (numero <= 0)
            {
                throw new ArgumentException("É preciso informar um número de conta válido.");
            }
            if (saldoInicial < 10.0m)
            {
                throw new ArgumentException("O saldo inicial deve ser superior a R$10,00.");
            }
            Numero = numero;
            Saldo = saldoInicial;
            Titular = titular;
            AgenciaReferente = agencia;
        }

        public Conta() //Construtor padrão, sem parâmetros
        {
            Numero = 0;
            Saldo = 0;
            Titular = null;
            AgenciaReferente = null;
        }

        public long Numero { get; set; }
        public decimal Saldo { get; private set; }
        public Cliente Titular { get; private set; }
        public Agencia AgenciaReferente { get; private set; }


        public void deposito(decimal valor) //Método depósito que permite adicionar um valor ao saldo da conta
        {
            if (valor > 0)
                Saldo += valor;
        }

        public void Saque(decimal valor) //Método saque
        {
            if (valor > 0)
            {
                if (Saldo - valor - 0.10m >= 0)
                {
                    Saldo -= (valor + 0.10m); //Realiza o saque com a taxação de R$0,10
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para o saque.");
                }
            }
            else
            {
                Console.WriteLine("O valor do saque deve ser maior do que zero");
            }
        }

        public void Transferencia(Conta destino, decimal valor) //Método Transferência
        {
            if (valor > 0)
            {
                if (Saldo >= valor) // Verifica se há saldo suficiente na conta
                {
                    Saque(valor); // Realiza o saque da conta de origem
                    destino.deposito(valor); // Realiza o depósito na conta desejada
                    Console.WriteLine($"Transferência de R${valor} realizada com sucesso.");
                    Console.WriteLine($"Saldo da conta {Numero}: R${Saldo}");
                    Console.WriteLine($"Saldo da conta {destino.Numero}: R${destino.Saldo}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para realizar a transferência.");
                }
            }
            else
            {
                Console.WriteLine("O valor da transferência deve ser maior que zero.");
            }
        }
    }
}