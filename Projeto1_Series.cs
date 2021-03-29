using System;

namespace Projeto1_Serie : EntidadeBase
{
    2 references
    public class Serie : EntidadeBase
    {
        // Atributos

        private GENERO Genero {get, set;}

        private string Título {get, set;}

        private string Descrição {get, set;}

        private int Ano {get; set;}

        private bool Excluido {get; set;}
    }
    
    }
        // Metados
        1 reference
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id; 
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descrição = descricao;
            this.Ano = ano;
            this.Excluir = false
        }

        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newLine?view-netcore-3.1
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descrição + Environment.NewLine;
            retorno += "Ano de início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
         }

         public string retornaTitulo()
         {
             this.Titlulo;
         }
         public int retornaId()
         {
             this.Id;
         }

         public bool retornaExcluido()
         {
             this.Excluido;
         }

         public void Excluir()
         {
             this.Excluido = true;
         }
    }
}
