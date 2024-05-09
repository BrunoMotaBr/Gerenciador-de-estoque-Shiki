using Gerenciador_de_estoque_Shiki.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_estoque_Shiki
{
    public partial class FormEntradaProdutos : Form
    {
        public Uteis uteis = new Uteis();


        public FormEntradaProdutos()
        {
            InitializeComponent();
            lbl_CodigoDoProduto.Text = "Codigo do produto: ";
            lbl_Nome.Text = "Nome do produto: ";
            lbl_quantidadePorCaixaPequena.Text = "Quantidade P/ caixa pequena: ";
            lbl_quantidadeTot.Text = "Quantidade total: ";
            Lbl_Posicao.Text = "Posição: ";
            string[] posicoes = ["p", "p1", "p2", "p3"];
            PosicoesDosProdutos(posicoes);
        }

        public void PosicoesDosProdutos(string[] posicoes)
        {
            foreach (string posicao in posicoes)
            {
                cbx_Posicao.Items.Add(posicao);
            }
        }

        private void bnt_Enviar_Click(object sender, EventArgs e)
        {
            if(txb_quantidadeTot.Text.Trim().Length == 0 && 
                txb_quantidadePorCaixaPequena.Text.Trim().Length == 0 &&
                txb_Nome.Text.Trim().Length == 0 &&
                txb_CodigoDoProduto.Text.Trim().Length == 0 &&
                cbx_Posicao.Text.Trim().Length == 0
                )
            {
                MessageBox.Show("Verifique o formulario", "Shiki", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (cbx_Posicao.Items.Contains(cbx_Posicao.Text))
                {
                    if(uteis.ENumero(txb_quantidadePorCaixaPequena.Text.Trim()) && uteis.ENumero(txb_quantidadeTot.Text.Trim()))
                    {
                        int quantidadeTotal = Convert.ToInt32(txb_quantidadeTot.Text.Trim());
                        int quantidadePorCaixaPequena = Convert.ToInt32(txb_quantidadePorCaixaPequena.Text.Trim());
                        Posicao posicao = new Posicao();
                        posicao.corredor = 1;
                        posicao.prateleira = 1;
                        posicao.coluna = 1;
                        int numeroCaixasPequenas = 1;
                        Produtos produto = new Produtos(txb_Nome.Text.Trim(), quantidadeTotal, quantidadePorCaixaPequena, numeroCaixasPequenas, txb_CodigoDoProduto.Text.Trim(), posicao);
                        DialogResult respostaDoOperador = MessageBox.Show($"Nome do produto: {txb_Nome.Text}\n" +
                            $"Quantidade total: {quantidadeTotal}\n" +
                            $"Número de caixas pequenas: {numeroCaixasPequenas}\n" +
                            $"Codigo do produto: {txb_CodigoDoProduto.Text.Trim()}\n" +
                            $"Posição: {cbx_Posicao.Text}\n", "Shiki", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (respostaDoOperador == DialogResult.Yes)
                        {
                            MessageBox.Show("Armazenado", "Shiki", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show($"Verifique o formulario {txb_quantidadePorCaixaPequena.Text} ou {txb_quantidadeTot.Text} não é número", "Shiki", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Verifique o formulario {cbx_Posicao.Text} não existe", "Shiki", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
