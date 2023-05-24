using System;

class Program
{
    static void Main()
    {

        Pessoa hóspede = new Pessoa { Nome = "João", Idade = 30 };
        Suíte suíte101 = new Suíte { Número = 101, ValorDiária = 150 };
        Reserva reserva = new Reserva
        {
            Hóspede = hóspede,
            Suíte = suíte101,
            DataInício = new DateTime(2023, 5, 1),
            DataFim = new DateTime(2023, 5, 15)
        };

        
        decimal valorTotal = reserva.CalcularValorTotal();

   
        Console.WriteLine("Dados do Hóspede:");
        Console.WriteLine("Nome: " + reserva.Hóspede.Nome);
        Console.WriteLine("Idade: " + reserva.Hóspede.Idade);
        Console.WriteLine("\nDados da Reserva:");
        Console.WriteLine("Suíte: " + reserva.Suíte.Número);
        Console.WriteLine("Data de Início: " + reserva.DataInício.ToString("dd/MM/yyyy"));
        Console.WriteLine("Data de Fim: " + reserva.DataFim.ToString("dd/MM/yyyy"));
        Console.WriteLine("Valor Total da Reserva: " + valorTotal.ToString("C"));
    }
}
