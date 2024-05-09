using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Console.WriteLine("Quantas pessoas estarão hospedadas?");
int quantidadeHospedes = Int32.Parse(Console.ReadLine());

for (int i = 0; i < quantidadeHospedes; i++)
{
  Console.WriteLine($"Qual o nome do {i + 1}º hóspede?");
  string nome = Console.ReadLine();

  Pessoa pessoa = new Pessoa(nome: nome);

  hospedes.Add(pessoa);
}

Console.WriteLine("Em qual Suite voces desejam ficar? (Comum ou Premium)");
string tipoSuite = Console.ReadLine();

Console.WriteLine("Quantos dias vocês pretendem ficar?");
int quantidadeDias = Int32.Parse(Console.ReadLine());


// Cria a suíte
Suite suite = new Suite(tipoSuite: tipoSuite);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: quantidadeDias);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");