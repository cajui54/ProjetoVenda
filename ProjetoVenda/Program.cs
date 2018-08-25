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
        static void Main(string[] args)
        {
            Produto P = new Produto(1001, "Cadeira simples", 500);
            Console.WriteLine(P);

            Console.ReadKey();
        }
    }
}
