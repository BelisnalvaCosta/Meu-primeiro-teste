using System;
using System.Collections.Generic;
using RepositorioSerieFilme;

nomespace RepositorioSerieFilmes
{
    public class SerieRepositorio : IRepositorio<SerieFilmes>
    {

        private Lista <Serie> lista = new Lista<Serie>();

        public void Atualizar (int id, Serie objeto)
        {
            listar Serie [id] = objeto
        }   

        public void Excluir (int id) 
        {
            listaSerie [id].Excluir();
        }  

        public void Inserir(Serie entidade)  
        {
            listaSerie.Add (objeto);
        }

        public List<Série> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.count;
        }

        public SerieRepositorio RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}

