using System;
using System.Diagnostics;
namespace HotelReservas.Services {
    public static class Atualizador {
        public static void AtualizarPacotes() {
            Console.WriteLine("🔄 Restaurando pacotes .NET...");
            try {
                Process.Start(new ProcessStartInfo("dotnet", "restore") { RedirectStandardOutput = false, UseShellExecute = false, CreateNoWindow = true }).WaitForExit();
                Console.WriteLine("✅ Pacotes restaurados com sucesso!");
            } catch (Exception ex) {
                Console.WriteLine($"❌ Erro: {ex.Message}");
            }
        }
    }
}
