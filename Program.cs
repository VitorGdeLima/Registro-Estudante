namespace Registro_Estudante;
class Program
{
	// Alunos Vitor Guilherme,Thiago Michel, Luiz Felipe, Cristyan
	
	static void Main()
	{
		// Criando alguns estudantes, adicionando notas, calculando média e imprimindo informações
		Estudante estudante1 = new Estudante("André Iuri", new DateTime(2005, 6, 25), "2023982", "Literatura");
		Estudante estudante2 = new Estudante("Geovana Marina", new DateTime(2006, 8, 21), "2023874", "Artes");

		estudante1.AdicionarNota(10.0);
		estudante1.AdicionarNota(6.0);
		estudante2.AdicionarNota(8.5);
		estudante2.AdicionarNota(9.0);
		estudante2.AdicionarNota(7.5);

		estudante1.ImprimirInformacoes();
		estudante2.ImprimirInformacoes();
	}
}
