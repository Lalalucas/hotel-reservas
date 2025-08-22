using System;
using HotelReservas.Models;
using HotelReservas.Services;
class Program {
    static void Main() {
        Atualizador.AtualizarPacotes();
        Console.WriteLine("\n--- Sistema de Reservas de Hotel ---");
        Suite luxo = new Suite { Tipo = "Luxo", ValorDiaria = 500, Capacidade = 4 };
        Reserva reserva = new Reserva { Suite = luxo, DiasReservados = 15 };
        reserva.AdicionarHospede(new Pessoa { Nome = "Lucas Gabriel", Idade = 30 });
        reserva.AdicionarHospede(new Pessoa { Nome = "Maria Silva", Idade = 28 });
        Console.WriteLine($"Hóspedes na suíte {reserva.Suite.Tipo}: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor total da diária (com desconto): R${reserva.CalcularValorTotal():F2}");
    }
}
