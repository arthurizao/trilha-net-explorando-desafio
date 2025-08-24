using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> listaDePessoas = new List<Pessoa>();

Pessoa primeiroHospede = new Pessoa(nome: "Cliente A");
Pessoa segundoHospede = new Pessoa(nome: "Cliente B");

listaDePessoas.Add(primeiroHospede);
listaDePessoas.Add(segundoHospede);

Suite tipoDeAcomodacao = new Suite(tipoSuite: "Executiva", capacidade: 2, valorDiaria: 30);

Reserva novaReserva = new Reserva(diasReservados: 5);
novaReserva.CadastrarSuite(tipoDeAcomodacao);
novaReserva.CadastrarHospedes(listaDePessoas);

Console.WriteLine($"Número de ocupantes: {novaReserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Custo da reserva: {novaReserva.CalcularValorDiaria()}");
