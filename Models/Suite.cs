namespace DesafioProjetoHospedagem.Models
{
    public class Acomodacao
    {
        public Acomodacao() { }

        public Acomodacao(string tipo, int capacidadeMaxima, decimal custoPorDiaria)
        {
            TipoSuite = tipo;
            Capacidade = capacidadeMaxima;
            ValorDiaria = custoPorDiaria;
        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}
