using System;
using System.Collections.Generic;
using MacFlix.Interfaces;

namespace MacFlix
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        public List<Filme> listaFilme = new List<Filme>();
        public void Atualiza(int id, Filme entidade)
        {
            listaFilme[id] = entidade;
        }
        public void Exclui(int id)
        {
            listaFilme[id].Excluir();
        }

        public void Insere(Filme entidade)
        {
            listaFilme.Add(entidade);
        }

        public List<Filme> Lista()
        {
            return listaFilme;
        }

        public int ProximoId()
        {
            return listaFilme.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return listaFilme[id];
        }
    }
}