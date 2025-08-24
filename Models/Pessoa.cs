namespace DesafioProjetoHospedagem.Models;

public class Cliente
{
    public Cliente() { }

    public Cliente(string primeiroNome)
    {
        PrimeiroNome = primeiroNome;
    }

    public Cliente(string primeiroNome, string ultimoNome)
    {
        PrimeiroNome = primeiroNome;
        UltimoNome = ultimoNome;
    }

    public string PrimeiroNome { get; set; }
    public string UltimoNome { get; set; }
    public string NomeIntegral => $"{PrimeiroNome} {UltimoNome}".ToUpper();
}
