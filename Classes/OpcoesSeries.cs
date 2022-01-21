using System;


namespace MacFlix
{
    public class OpcoesSeries
    {  
		static SerieRepositorio repositorio = new SerieRepositorio();
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

        public virtual void Atualizar()
		{
			Console.Write("Digite o id: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Lançamento: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição: ");
			string entradaDescricao = Console.ReadLine();

			Serie atualizaSerie = new Serie(id: indiceSerie,
										    genero: (Genero)entradaGenero,
										    titulo: entradaTitulo,
										    ano: entradaAno,
										    descricao: entradaDescricao);

			repositorio.Atualiza(indiceSerie, atualizaSerie);
		}
        public virtual void Listar()
		{
			Console.WriteLine("Listar séries");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = serie.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "Série Excluida" : ""));
			}
		}

        public virtual void Inserir()
		{
			Console.WriteLine("Inserir nova série");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Lançamento: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição: ");
			string entradaDescricao = Console.ReadLine();

			Serie novaSerie = new Serie(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Insere(novaSerie);
		}
    }
}