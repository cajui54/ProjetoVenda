using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoVenda.Dominio;

namespace ProjetoVenda
{
    class Tela
    {
        //Classe responsável por interagir com o usuário

        public static void mostrarMenu()
        {
             Console.WriteLine("1 - Listar produtos ordenadamente");
             Console.WriteLine("2 - Cadastrar produto");
             Console.WriteLine("3 - Cadastrar pedido");
             Console.WriteLine("4 - Mostrar dados de um pedido");
            Console.WriteLine("5 - Sair");
            Console.Write("Opção: ");

        }
        public static void mostrarProdutos()
        {
            Console.WriteLine();
            Console.WriteLine("LISTAGEM DE PRODUTOS: ");
            for(int i = 0; i < Program.produtos.Count; i++)
            {

                Console.WriteLine(Program.produtos[i]);

            }
            Console.ReadLine();

        }
        public static void cadastrarProduto()
        {
            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço R$:");
            double preco = double.Parse(Console.ReadLine());
            Produto produto = new Produto(codigo, descricao, preco);
            Program.produtos.Add(produto);
            Program.produtos.Sort();

        }


    }
}
