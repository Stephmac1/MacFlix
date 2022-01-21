using System;

namespace MacFlix
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static FilmeRepositorio repositorio2 = new FilmeRepositorio();

        static void Main(string[] args)
        {
            string primeiraEscolha = PrimeiraEscolha();
            OpcoesSeries opcaoSerie = new OpcoesSeries();
            OpcoesFilmes opcaoFilme = new OpcoesFilmes();

            if (primeiraEscolha == "1")
            {
                string opcaoUsuario = ObterOpcaoUsuario();

                while (opcaoUsuario.ToUpper() !="X")
                {
                    switch(opcaoUsuario)
                    {
                        case "1":
                            opcaoFilme.Listar();
                            break;
                        case "2":
                            opcaoFilme.Inserir();
                            break;
                        case "3":
                            opcaoFilme.Atualizar();
                            break;
                        case "4":
                            opcaoFilme.Excluir();
                            break;
                        case "5":
                            opcaoFilme.Visualizar();
                            break;
                         case "6":
                            primeiraEscolha = PrimeiraEscolha();
                            break;
                        case "C":
                            Console.Clear();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    opcaoUsuario = ObterOpcaoUsuario();
                }
            }
            else if (primeiraEscolha == "2")
            {
                string opcaoUsuario = ObterOpcaoUsuario();

                while (opcaoUsuario.ToUpper() != "X")
                {
                    switch (opcaoUsuario)
                    {
                        case "1":
                            opcaoSerie.Listar();
                            break;
                        case "2":
                            opcaoSerie.Inserir();
                            break;
                        case "3":
                            opcaoSerie.Atualizar();
                            break;
                        case "4":
                            opcaoSerie.Excluir();
                            break;
                        case "5":
                            opcaoSerie.Visualizar();
                            break;
                        case "6":
                            primeiraEscolha = PrimeiraEscolha();
                            break;
                        case "C":
                            Console.Clear();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    opcaoUsuario = ObterOpcaoUsuario();
                }                
            }
            else
            {
                Console.WriteLine("Coloque uma opção válida");
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }
        
        private static string PrimeiraEscolha()
        {
            Console.WriteLine("Dio Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Filmes");
            Console.WriteLine("2- Séries");

            string primeiraEscolha = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return primeiraEscolha;
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar");
            Console.WriteLine("2- Inserir novo(a)");
            Console.WriteLine("3- Atualizar");
            Console.WriteLine("4- Excluir");
            Console.WriteLine("5- Vizualizar");
            Console.WriteLine("6- Retornar para o menu inicial");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
        }
    }
}
