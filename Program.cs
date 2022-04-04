using CadastroPessoa.Classes;

PessoaFisica novaPf = new PessoaFisica();
PessoaFisica metodoPF = new PessoaFisica();
endereco novoEnd = new endereco();

novaPf.Nome = "novo nome";
novaPf.dataNasc = new DateTime (2000,01,01);
novaPf.Cpf = "1234567890";
novaPf.rendimento = 5000.5f;

novoEnd.logradouro = "Alameda";
novoEnd.numero = 539;
novoEnd.Complemento = "apto 423";
novoEnd.endComercial = true;

novaPf.Endereco = novoEnd;

Console.WriteLine(@$"

Nome: {novaPf.Nome}
CPF: {novaPf.Cpf}
Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}

");



// Console.WriteLine(novaPf.Nome);
// Console.WriteLine(novaPf.Nome);

// Console.WriteLine($"Nome: {novaPf.Nome} Rendimento: {novaPf.rendimento}");


// Console.WriteLine($"{metodoPF.novaPf.ValidarDataNasc(new DateTime(2000,01,01))}");

Console.WriteLine($"{metodoPF.ValidarDataNasc("01/01/2000")}");

 