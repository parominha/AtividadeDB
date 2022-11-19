using System;
using System.Data;

namespace AtividadeDB
{
    class Program
    {
        static void Main(string[] args)
        {

            PesquisaDB.Cliente Pesquisa = new PesquisaDB.Cliente();

        Inicio:
            Console.WriteLine("-- BANCO DE DADOS --");
            Console.WriteLine("1- LISTAR");
            Console.WriteLine("2- CADASTRAR");
            Console.WriteLine("3- ALTERAR");
            Console.WriteLine("4- DELETAR");
            Console.Write("-> ");
            string opcao = Console.ReadLine();
            Console.WriteLine(" ");

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("P- Produto");
                    Console.WriteLine("G- Grupo");
                    Console.Write("-> ");
                    string opcaoPG1 = Console.ReadLine();
                    Console.WriteLine(" ");
                    if (opcaoPG1.ToUpper() == "P")
                    {
                        Console.WriteLine("Digite o nome do produto que deseja pesquisar:");
                        Console.Write("-> ");
                        string nomeProduto1 = Console.ReadLine();
                        Console.WriteLine(Pesquisa.Listar_Produto(nomeProduto1));
                    }
                    else if (opcaoPG1.ToUpper() == "G")
                    {
                        Console.WriteLine("Digite o nome do grupo que deseja pesquisar:");
                        Console.Write("-> ");
                        string nomeGrupo1 = Console.ReadLine();
                        Console.WriteLine(Pesquisa.Listar_Grupo(nomeGrupo1));
                    }
                    break;
                case "2":
                    Console.WriteLine("Digite o nome do produto que deseja cadastrar:");
                    Console.Write("-> ");
                    string nomeProduto2 = Console.ReadLine();
                    Console.WriteLine("Digite o nome do grupo:");
                    Console.Write("-> ");
                    string nomeGrupo2 = Console.ReadLine();
                    //if (este grupo nao existir no banco de dados)
                    //{
                    //    Console.WriteLine(nomeGrupo2 + " não consta no Banco de Dados. Deseja cadastrar? S/N");
                    //    string resposta = Console.ReadLine();
                    //    if (resposta.ToUpper() == "S")
                    //    {
                    //        //cadastrar
                    //    }
                    //    else
                    //    { goto Inicio; }
                    //}
                    //else
                    //{
                    //    //cadastrar
                    //}
                    break;
                case "3":
                    Console.WriteLine("Digite o nome do produto que deseja alterar:");
                    Console.Write("-> ");
                    string nomeProdutoAlterar = Console.ReadLine();
                    Console.Write("Digite o novo nome do produto:");
                    Console.Write("-> ");
                    string nomeProdutoAlterado = Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Digite o nome do produto que deseja deletar:");
                    Console.Write("-> ");
                    string nomeProdutoDeletar = Console.ReadLine();
                    break;
            }
        }
    }
}
