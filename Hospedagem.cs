using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

class Suíte
{
    public int Número { get; set; }
    public decimal ValorDiária { get; set; }
}

class Reserva
{
    public Pessoa Hóspede { get; set; }
    public Suíte Suíte { get; set; }
    public DateTime DataInício { get; set; }
    public DateTime DataFim { get; set; }

    public decimal CalcularValorTotal()
    {
        TimeSpan duraçãoReserva = DataFim - DataInício;
        int diasReserva = duraçãoReserva.Days + 1;
        decimal valorTotal = Suíte.ValorDiária * diasReserva;

        if (diasReserva > 10)
        {
            valorTotal *= 0.9m; 
        }

        return valorTotal;
    }
}


