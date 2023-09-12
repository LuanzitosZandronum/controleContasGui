using controleContasGui;
using System;

public class Agencia
{
    public Agencia(int numero, string cep, string telefoneContato, Banco banco) ////Método construtor da classe Agencia que recebe quatro parâmetros (numero, cep, telefone e banco). A classe Banco encontrasse ligada diretamente aqui
    {
        // Define a propriedade Numero, Cep, TelefoneContato e BancoReferente com o valor passado como argumento
        Numero = numero;
        Cep = cep;
        TelefoneContato = telefoneContato;
        BancoReferente = banco;
    }
    public int Numero { get; set; }
    public string Cep { get; set; }
    public string TelefoneContato { get; set; }
    public Banco BancoReferente { get; set; }

}