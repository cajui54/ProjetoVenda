﻿using System;
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
        public static void cadastrarPedido()
        {

            Console.WriteLine("Digite os dados do pedido:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Pedido P = new Pedido(codigo, dia, mes, ano);
            Console.Write("Quantos itens tem o pedido?");
            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i <= N; i++)
            {
                Console.WriteLine("Digite os dados do"+(i+1)+"item:");
                Console.Write("Produto (Código):");
                int codProduto = int.Parse(Console.ReadLine());
                int pos = Program.produtos.FindIndex(x => x.codigo == codProduto);
                if (pos == -1)
                {
                    throw new ModelException("Código de produto não encontrado: " + codProduto);
                }
                Console.Write("Quantidade: ");
                int qte = int.Parse(Console.ReadLine());
                Console.Write("Porcentagem de desconto: ");
                double porcent = double.Parse(Console.ReadLine());
                ItemPedido ip = new ItemPedido(qte, porcent, P, Program.produtos[pos]);
                P.itens.Add(ip);

            }
            Program.pedidos.Add(P);

        }
        public static void mostrarPedido()
        {
            Console.Write("Digite o código do pedido: ");
            int codPedido = int.Parse(Console.ReadLine());
            int pos = Program.pedidos.FindIndex(x => x.codigo == codPedido);
            if(pos == -1)
            {
                throw new ModelException("Código de pedido não encontrado: "+ codPedido);
            }
            Console.WriteLine(Program.pedidos[pos]);
            Console.WriteLine();
        }

    }
}
