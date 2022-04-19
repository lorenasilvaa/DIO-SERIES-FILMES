using System;
using DIO.series;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {

			string opcaoMenuUsuario = ObterOpcaoMenuUsuario();
			while (opcaoMenuUsuario.ToUpper() != "X")
			{
				switch (opcaoMenuUsuario)
				{
					case "1":
						MenuFilme.Filme();
						break;
					case "2":
						MenuSerie.Serie();
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoMenuUsuario = ObterOpcaoMenuUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
            
			
		}

		public static string ObterOpcaoMenuUsuario(){

			Console.WriteLine();
			Console.WriteLine("Olá, seja bem vido(a)!");

			Console.WriteLine("Você deseja: ");

			Console.WriteLine("1- Acessar o menu de Filmes");
			Console.WriteLine("2- Acessar o menu de Séries");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoMenuUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();

			return opcaoMenuUsuario;

		}
    }
}
