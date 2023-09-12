using controleContasGui;

//Criação de instâncias de Cliente, Banco, Agencia e Conta
Cliente cliente1 = new Cliente("12345678910", "José", 2000); //(CPF, Nome e Ano de nascimento do Cliente)
Banco banco1 = new Banco(10, "Budega"); //(Número e Nome do Banco)
Agencia agencia1 = new Agencia(10, "170365-1", "32325657", banco1); //(Número, CEP, Telefone e Banco referente da Agência)
Conta conta1 = new Conta(1, 1000m, cliente1, agencia1); //(Número, Saldo, Titular e Agência referente da Conta)

Cliente cliente2 = new Cliente("10987654321", "João", 1980);
Banco banco2 = new Banco(20, "Santana");
Agencia agencia2 = new Agencia(20, "169242004", "265739", banco2);
Conta conta2 = new Conta(2, 500m, cliente2, agencia2);

//conta1.Saque(50m);  //CHAMANDO MÉTODO DE SAQUE
//conta1.Transferencia(conta2, 100m);   //CHAMANDO MÉTODO DE TRANSFERÊNCIA
//conta1.deposito(50.0m); //CHAMANDO MÉTODO DE DEPÓSITO


float maior, menor;

if (conta1.Saldo > conta2.Saldo) //Verifica qual o maior saldo
{
    maior = (conta1.Numero);
    menor = (conta2.Numero);
}
else
{
    maior = (conta2.Numero);
    menor = (conta1.Numero);
}

//Exibição de Informações das Contas
Console.WriteLine($"Número da Conta: {conta1.Numero} com saldo {conta1.Saldo}. Titular: {conta1.Titular.Nome}");
Console.WriteLine($"Número da Conta: {conta2.Numero} com saldo {conta2.Saldo}. Titular: {conta2.Titular.Nome}");
Console.WriteLine($"A conta com o maior saldo é a conta {maior}");

//Testes com Agência e Banco da Conta Número 1
Console.WriteLine($"{cliente1.Nome} = CPF: {cliente1.Cpf}, Nascimento: {cliente1.anoNascimento}, Número da Agência:{conta1.AgenciaReferente.Numero}");
Console.WriteLine($"CEP da Agência: {conta1.AgenciaReferente.Cep}, Nome do Banco:{conta1.AgenciaReferente.BancoReferente.Nome}, Número do Banco: {conta1.AgenciaReferente.BancoReferente.Numero}");

//Teste com Conta Número 2
Console.WriteLine($"{cliente2.Nome} = {cliente2.Cpf}");
Console.ReadLine();
