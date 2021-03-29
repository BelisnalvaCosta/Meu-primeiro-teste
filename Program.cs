using System;

nomespace Projeto1CadastroSerieFilmes
{
   0 references
    class Program 
    {
        0 references
        static SerieRepositorio  = new Projeto1_SerieFilmes());

        0 references
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                case "1":
                    Listar filme
                    break;
                case "2":
                    Inserir filme
                    break;
                case "3":
                    Atualizar fime 
                    break;
                case "4":
                    Excluir filme
                    break;
                case "5":
                    Visualizar filme
                    break;
                case "X":
                    sair
                    break;
                case "C":
                    Cancelar
                    break;

                default:  
                    throw new ArgumentOutOfRangeException();
                }
            }
            
            console.writeLine ("Obrigado(a) por utilizar nossos serviços.");
            console.ReadLine();
            }

            1 reference
            private static void AtualizarSerie();
            console.writeLine("Digite o id da série: ")
            int indice Serie = int.Parse(console.ReadLine());

            1 reference
            private static void ExcluirSerie();
            console.writeLine("Digite o id da serie para ser excluido: ")
            int 
            }
            var s = new Cadastro_filme(),
            console.writeLine("Informe a opção desejada:");
            consele.writeLine("1- Inserir cadastro de novo filme");
            console.writeLine("2- Listar filmes");
            console.writeLine("3- Descrição");
            console.writeLine("4- Ano")
            console.writeLine("X- Sair");
            console.writeLine();

            opcao = console.ReadLine();

        }
    }
}