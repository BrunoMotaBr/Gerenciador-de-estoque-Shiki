using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_estoque_Shiki.Classes
{
    public class Produtos
    {

        string _nome {  get; set; }
        int _quantidadeTotal {  get; set; }
        int _quantidadePorCaixaPequena { get; set; }

        int _numeroCaixasPequenas { get; set; }
        string _codigo { get; set; }
        Posicao _posicao { get; set; }

        public Produtos(string nome, int quantidadeTotal, int quantidadePorCaixaPequena, int numeroCaixasPequenas, string codigo, Posicao posicao)
        {
            this._nome = nome;
            this._quantidadeTotal = quantidadeTotal;
            this._quantidadePorCaixaPequena = quantidadePorCaixaPequena;
            this._numeroCaixasPequenas = numeroCaixasPequenas;
            this._codigo = codigo;
            this._posicao = posicao;
            
        }
        public Produtos()
        {

        }

        public Produtos RetornaListaDeClienteADependerDaPosicao(string conexao, Posicao posicao)
        {
            return new Produtos();
        }
    }
}
