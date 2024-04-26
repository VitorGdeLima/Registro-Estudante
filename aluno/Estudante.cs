public class Estudante : Pessoa
{
	public string Nome = "";
	public string Matricula = "";
	public string Curso = "";
	public List<double> Notas ;
	public Estudante(string nome, DateTime dataDeNascimento, string matricula, string curso)
	{
		Nome = nome;
		DataDeNascimento = dataDeNascimento;
		Matricula = matricula;
		Curso = curso;
		Notas = new List<double>();
	}
	public void AdicionarNota(double nota)
	{
		Notas.Add(nota);
	}
	public double CalcularMedia()
	{
		if (Notas.Count == 0)
		{
			return 0;
		}

		double soma = 0;
		foreach (double nota in Notas)
		{
			soma += nota;
		}

		return soma / Notas.Count;
	}
	public void ImprimirInformacoes()
	{
		Console.WriteLine($"Estudante: {Nome}");
		Console.WriteLine($"Idade: {CalcularIdade()} anos");
		Console.WriteLine($"Matrícula: {Matricula}");
		Console.WriteLine($"Curso: {Curso}");
		Console.WriteLine("Notas:");
		foreach (double nota in Notas)
		{
			Console.WriteLine($"- {nota}");
		}
		Console.WriteLine($"Média das Notas: {CalcularMedia()}");
	}
}