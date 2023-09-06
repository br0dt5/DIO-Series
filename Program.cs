using static System.Console;

namespace DIO.Series;

public class Program
{
	static SeriesRepositorio repositorio = new SeriesRepositorio();

	public static void Main(string[] args)
	{
		string opcaoUsuario = ObterOpcaoUsuario();

		while (opcaoUsuario.ToUpper() != "X")
		{
			switch (opcaoUsuario)
			{
				case "1":
					//ListarSeries();
					break;
				case "2":
					//InserirSerie();
					break;
				case "3":
					//AtualizarSerie();
					break;
				case "4":
					//ExcluirSerie();
					break;
				case "5":
					//VisualizarSerie();
					break;
				case "C":
					Clear();
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}
	}

	private static string ObterOpcaoUsuario()
	{
		WriteLine();
		WriteLine("DIO Séries a seu dispor!!!");
		WriteLine("Informe a opção desejada:");

		WriteLine("1 - Listar séries");
		WriteLine("2 - Inserir nova série");
		WriteLine("3 - Atualiza série");
		WriteLine("4 - Excluir série");
		WriteLine("5 - Visualizar série");
		WriteLine("C - Limpar Tela");
		WriteLine("X - Sair");
		WriteLine();

		string opcaoUsuario = ReadLine().ToUpper();
		WriteLine();
		return opcaoUsuario;
	}
}
