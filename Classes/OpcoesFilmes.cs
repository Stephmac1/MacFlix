using System;

namespace MacFlix
{
    public class OpcoesFilmes : OpcoesSeries
    {
        static FilmeRepositorio repositorio = new FilmeRepositorio();
        public void Excluir()
		{            
			Console.Write("Digite o id: ");
			int indice = int.Parse(Console.ReadLine());
            repositorio.Exclui(indice);
		}

        public void Visualizar()
		{
			Console.Write("Digite o id: ");
			int indice = int.Parse(Console.ReadLine());
			var midia = repositorio.RetornaPorId(indice);

			Console.WriteLine(midia);
		}
         public override void Atualizar()
		{
			Console.Write("Digite o id: ");
			int indicefilme = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Filme: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Lançamento: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição: ");
			string entradaDescricao = Console.ReadLine();

			Filme atualizafilme = new Filme(id: indicefilme,
										    genero: (Genero)entradaGenero,
										    titulo: entradaTitulo,
										    ano: entradaAno,
										    descricao: entradaDescricao);

			repositorio.Atualiza(indicefilme, atualizafilme);
		}
        public override void Listar()
		{
			Console.WriteLine("Listar filmes");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum filme cadastrado.");
				return;
			}

			foreach (var filme in lista)
			{
                var excluido = filme.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "Filme Excluido" : ""));
			}
		}

        public override void Inserir()
		{
			Console.WriteLine("Inserir novo filme");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Filme: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Lançamento: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição: ");
			string entradaDescricao = Console.ReadLine();

			Filme novoFilme = new Filme(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Insere(novoFilme);
		}
    }
}