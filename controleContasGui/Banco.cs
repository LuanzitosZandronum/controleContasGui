using System;

public class Banco
{
    public Banco(int numero, string nome) //Método construtor da classe Banco que recebe dois parâmetros (numero e nome)
    {
        // Define a propriedade Nome e Numero com o valor passado como argumento
        Nome = nome;
        Numero = numero;
    }
    public Banco() //Construtor padrão, sem parâmetros
    {
        Nome = string.Empty;
        Numero = 0;
    }
    public string Nome { get; set; }
    public int Numero { get; set; }
}