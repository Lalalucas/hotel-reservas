using System;
using System.Collections.Generic;
namespace HotelReservas.Models {
    public class Reserva {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public void AdicionarHospede(Pessoa hospede) { if (Hospedes.Count < Suite.Capacidade) Hospedes.Add(hospede); else Console.WriteLine("Capacidade máxima da suíte atingida!"); }
        public int ObterQuantidadeHospedes() => Hospedes.Count;
        public decimal CalcularValorTotal() {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados > 10) valor *= 0.9m; // Desconto de 10%
            return valor;
        }
    }
}
