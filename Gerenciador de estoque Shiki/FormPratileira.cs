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
    public partial class FormPratileira : Form
    {
        public FormPratileira(Posicao local)
        {
            InitializeComponent();

            Produtos produtosDaPratileira = new Produtos();
            produtosDaPratileira = produtosDaPratileira.RetornaListaDeClienteADependerDaPosicao("entra o caminho", local);
            
        }
    }
}
