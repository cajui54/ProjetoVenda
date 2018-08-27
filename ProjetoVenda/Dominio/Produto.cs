using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVenda.Dominio
{
    class Produto : IComparable
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }

        public Produto(int codigo, string descricao, double preco)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
        }
        public override string ToString()
        {
            return "Codigo: "+ codigo +" ,Descrição: "+ descricao +" ,Preço R$: "+preco.ToString("F2");
        }

        public int CompareTo(object obj)
        {
            Produto outro = (Produto)obj;
            int resultado = descricao.CompareTo(outro.descricao); // se retornar 0 os objetos são iguais 

            if(resultado != 0)
            {
                return resultado;
            }
            else
            {
                return -preco.CompareTo(outro.preco);
                // - descrecente

            }

        }

    }
}
