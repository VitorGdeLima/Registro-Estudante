
public class Pessoa
{
    public DateTime DataDeNascimento { get; set; }
    public int CalcularIdade()
    {
        DateTime dataAtual = DateTime.Today;
        int idade = dataAtual.Year - DataDeNascimento.Year;
        if (dataAtual < DataDeNascimento.AddYears(idade))
        {
            idade--;
        }
        return idade;
    }
}