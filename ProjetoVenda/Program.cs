﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoVenda.Dominio;

namespace ProjetoVenda
{
    class Program
    {
        public static List<Produto> produtos = new List<Produto>();
        public static List<Pedido> pedidos = new List<Pedido>();

        static void Main(string[] args)
        {
            int opcao = 0;
            produtos.Add(new Produto(1001, "Cadeira simples", 500));
            produtos.Add(new Produto(1002, "Cadeira acolchoada", 900));
            produtos.Add(new Produto(1003, "Sofá de três lugares", 2000 ));
            produtos.Add(new Produto(1004,"Mesa retangular",1500));
            produtos.Add(new Produto(1005, "Mesa retangular", 2000));
            produtos.Sort();

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
                        try{Tela.cadastrarProduto();}
                        catch (Exception error){Console.WriteLine("Erro inesperado: "+error.Message); }                       
                        break;
                    case 3:
                        try{Tela.cadastrarPedido(); }
                        catch (ModelException error) { Console.WriteLine("Erro inesperado: "+error.Message); }
                        break;
                    case 4:
                        try { Tela.mostrarPedido(); }
                        catch(ModelException error) { Console.WriteLine("Erro inesperado: " + error.Message); }
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
