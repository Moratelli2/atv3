
using AtvSalaPOO;

Cliente cliente = new Cliente()
{
    Id = 1,
    Nome = "Gabriel",
    Telefone = "(17) 1232-1423",
    Endereco = new Endereco()
    {
        Cidade = "Araraquara",
        Estado = "São Paulo",
        Logradouro = "Rua dos blabla",
        Numero = 12,
        Pais = "Brasil"
    },
    Segmento = new Segmento()
    {
        Id = 1,
        Descricao = "Desenvolvimento"
    }
};

TipoMoeda real = new TipoMoeda()
{
    Id = 1,
    Descricao = "Real Brasileiro"
};

TipoConta empresarial = new TipoConta()
{
    Id = 4,
    Descricao = "Conta Empresarial",
    ClasseBonus = "0"
};

ContaCorrente contaCorrente = new ContaCorrente()
{
    Id = 1,
    Descricao = "Conta Corrente",
    TipoMoeda = real,
    TipoConta = empresarial,
    Saldo = 15000,
    Limite = 100000
};

ContaPoupanca contaPoupanca = new ContaPoupanca()
{
    Id = 1,
    Descricao = "Conta Poupança",
    TipoMoeda = real,
    TipoConta = empresarial,
    Saldo = 89000,
    QtdTempo = 20,
    TaxaJuros = 2,
};

ClienteConta clienteConta = new ClienteConta()
{
    Cliente = cliente,
    ContaCorrente = contaCorrente,
    ContaPoupanca = contaPoupanca,
    Data = DateTime.Now
};


Console.WriteLine(cliente);

Console.WriteLine(clienteConta);


