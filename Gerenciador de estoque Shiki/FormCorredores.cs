using Gerenciador_de_estoque_Shiki.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_estoque_Shiki
{
    public partial class FormCorredores : Form
    {
        public FormCorredores()
        {
            InitializeComponent();


        }

        private void bnt_posicao1_Click(object sender, EventArgs e)
        {
            Posicao local = new Posicao();
            local.prateleira = bnt_posicao1.Text[0];
            local.coluna = bnt_posicao1.Text[1];
            local.corredor = bnt_posicao1.Text[2];
            FormPratileira chamadaPratileira = new FormPratileira(local);
            chamadaPratileira.Show();
        }

        private void bnt_cadastrarProduto_Click(object sender, EventArgs e)
        {
            FormEntradaProdutos entradaDeProdutos = new FormEntradaProdutos();
            entradaDeProdutos.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Regex regex01 = new Regex("Padrao", RegexOptions.IgnoreCase);
            Regex regex02 = new Regex("Padrao", RegexOptions.IgnoreCase);
            Regex regex03 = new Regex("Padrao", RegexOptions.IgnoreCase);

            if (regex01.IsMatch("Entrada") ||
                regex02.IsMatch("Entrada") ||
                regex03.IsMatch("Entrada"))
            {
                //Identifica se o usuario esta pesquisando por nome, posição do produto ou codigo
                //Se identificado o padrão sera realizada uma busca no banco de dados
            }
            else
            {
                //Caso nenhum dos padroes corresponda dara um retorno para o operador
            }

        }
    }
}
