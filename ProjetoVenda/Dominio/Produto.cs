using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVenda.Dominio
{
    class Produto
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

    }
}
