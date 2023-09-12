using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContasGui
{
    public class Cliente
    {
        public Cliente(string cpf, string nome, int anonascimento) //Método construtor da classe Cliente que recebe três parâmetros (cpf, nome e data de nascimento)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome do cliente não deve estar em branco.");
            }
            if (cpf == null)
            {
                throw new ArgumentException("O CPF do cliente deve ser informado.");
            }
            if (!ValidCPF(cpf))
            {
                throw new ArgumentException("O CPF do cliente deve ser válido.");
            }
            if (DateTime.Now.Year - anonascimento < 18)
            {
                throw new ArgumentException("Não deve ser menor de idade.");
            }
            // Define a propriedade Cpf, Nome e anoNascimento com o valor passado como argumento
            Cpf = cpf;
            Nome = nome;
            anoNascimento = anonascimento;
        }
        public Cliente() //Construtor padrão, sem parâmetros
        {
            Cpf = string.Empty;
            Nome = string.Empty;
            anoNascimento = 0;
        }

        public string Cpf { get; set; }
        public string Nome { get; set; }
        public int anoNascimento { get; set; }

        private static bool ValidCPF(string cpf) //Método de Validação de CPF
        {
            string cpfNumerico = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpfNumerico.Length != 11) //Se o CPF não tiver 11 Dígitos, ele será recusado
            {
                return false;
            }
            if (cpfNumerico.Distinct().Count() == 1) //Se o CPF tiver apenas dígitos repetidos (ex: 11111111111), ele será recusado
            {
                return false;
            }

            return true;
        }
    }
}