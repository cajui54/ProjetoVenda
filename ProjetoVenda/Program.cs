using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoVenda.Dominio;

namespace ProjetoVenda
{
    class Program
    {
        public static List<Produto> produtos = new List<Dominio.Produto>();
        static void Main(string[] args)
        {
            int opcao = 0;
            produtos.Add(new Produto(1001, "Cadeira simples", 500));
            produtos.Add(new Produto(1002, "Cadeira acolchoada", 900));
            produtos.Add(new Produto(1003, "Sofá de três lugares", 2000 ));
            produtos.Add(new Produto(1004,"Mesa retangular",1500));
            produtos.Add(new Produto(1005, "Mesa retangular", 2000));

            while(opcao != 5)
            {
                Console.Clear();
                Tela.mostrarMenu();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }catch(Exception erro)
                {
                    Console.WriteLine("Erro inesperado !"+ erro);
                    opcao = 0;
                }
                switch (opcao)
                {
                    case 1:
                        Tela.mostrarProdutos();
                         break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Fim do Programa!");
                        break;
                    default :
                        Console.WriteLine("Opção inválida ["+ opcao +"]");
                        break;
                }

            }

            Console.ReadKey();
        }
    }
}
