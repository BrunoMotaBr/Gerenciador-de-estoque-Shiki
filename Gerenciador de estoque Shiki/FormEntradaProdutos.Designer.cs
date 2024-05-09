namespace Gerenciador_de_estoque_Shiki
{
    partial class FormEntradaProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txb_Nome = new TextBox();
            lbl_Nome = new Label();
            Lbl_Posicao = new Label();
            lbl_CodigoDoProduto = new Label();
            txb_CodigoDoProduto = new TextBox();
            lbl_quantidadePorCaixaPequena = new Label();
            txb_quantidadePorCaixaPequena = new TextBox();
            lbl_quantidadeTot = new Label();
            txb_quantidadeTot = new TextBox();
            bnt_Enviar = new Button();
            cbx_Posicao = new ComboBox();
            SuspendLayout();
            // 
            // txb_Nome
            // 
            txb_Nome.Location = new Point(338, 22);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(294, 23);
            txb_Nome.TabIndex = 0;
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Nome.Location = new Point(12, 19);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(64, 23);
            lbl_Nome.TabIndex = 1;
            lbl_Nome.Text = "label1";
            // 
            // Lbl_Posicao
            // 
            Lbl_Posicao.AutoSize = true;
            Lbl_Posicao.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Posicao.Location = new Point(12, 193);
            Lbl_Posicao.Name = "Lbl_Posicao";
            Lbl_Posicao.Size = new Size(64, 23);
            Lbl_Posicao.TabIndex = 3;
            Lbl_Posicao.Text = "label2";
            // 
            // lbl_CodigoDoProduto
            // 
            lbl_CodigoDoProduto.AutoSize = true;
            lbl_CodigoDoProduto.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CodigoDoProduto.Location = new Point(12, 150);
            lbl_CodigoDoProduto.Name = "lbl_CodigoDoProduto";
            lbl_CodigoDoProduto.Size = new Size(64, 23);
            lbl_CodigoDoProduto.TabIndex = 5;
            lbl_CodigoDoProduto.Text = "label3";
            // 
            // txb_CodigoDoProduto
            // 
            txb_CodigoDoProduto.Location = new Point(338, 153);
            txb_CodigoDoProduto.Name = "txb_CodigoDoProduto";
            txb_CodigoDoProduto.Size = new Size(294, 23);
            txb_CodigoDoProduto.TabIndex = 4;
            // 
            // lbl_quantidadePorCaixaPequena
            // 
            lbl_quantidadePorCaixaPequena.AutoSize = true;
            lbl_quantidadePorCaixaPequena.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_quantidadePorCaixaPequena.Location = new Point(12, 102);
            lbl_quantidadePorCaixaPequena.Name = "lbl_quantidadePorCaixaPequena";
            lbl_quantidadePorCaixaPequena.Size = new Size(64, 23);
            lbl_quantidadePorCaixaPequena.TabIndex = 7;
            lbl_quantidadePorCaixaPequena.Text = "label4";
            // 
            // txb_quantidadePorCaixaPequena
            // 
            txb_quantidadePorCaixaPequena.Location = new Point(338, 105);
            txb_quantidadePorCaixaPequena.Name = "txb_quantidadePorCaixaPequena";
            txb_quantidadePorCaixaPequena.Size = new Size(294, 23);
            txb_quantidadePorCaixaPequena.TabIndex = 6;
            // 
            // lbl_quantidadeTot
            // 
            lbl_quantidadeTot.AutoSize = true;
            lbl_quantidadeTot.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_quantidadeTot.Location = new Point(12, 57);
            lbl_quantidadeTot.Name = "lbl_quantidadeTot";
            lbl_quantidadeTot.Size = new Size(64, 23);
            lbl_quantidadeTot.TabIndex = 9;
            lbl_quantidadeTot.Text = "label5";
            // 
            // txb_quantidadeTot
            // 
            txb_quantidadeTot.Location = new Point(338, 60);
            txb_quantidadeTot.Name = "txb_quantidadeTot";
            txb_quantidadeTot.Size = new Size(294, 23);
            txb_quantidadeTot.TabIndex = 8;
            // 
            // bnt_Enviar
            // 
            bnt_Enviar.Location = new Point(277, 243);
            bnt_Enviar.Name = "bnt_Enviar";
            bnt_Enviar.Size = new Size(140, 23);
            bnt_Enviar.TabIndex = 12;
            bnt_Enviar.Text = "button1";
            bnt_Enviar.UseVisualStyleBackColor = true;
            bnt_Enviar.Click += bnt_Enviar_Click;
            // 
            // cbx_Posicao
            // 
            cbx_Posicao.FormattingEnabled = true;
            cbx_Posicao.Location = new Point(338, 199);
            cbx_Posicao.Name = "cbx_Posicao";
            cbx_Posicao.Size = new Size(294, 23);
            cbx_Posicao.TabIndex = 13;
            // 
            // FormEntradaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 290);
            Controls.Add(cbx_Posicao);
            Controls.Add(bnt_Enviar);
            Controls.Add(lbl_quantidadeTot);
            Controls.Add(txb_quantidadeTot);
            Controls.Add(lbl_quantidadePorCaixaPequena);
            Controls.Add(txb_quantidadePorCaixaPequena);
            Controls.Add(lbl_CodigoDoProduto);
            Controls.Add(txb_CodigoDoProduto);
            Controls.Add(Lbl_Posicao);
            Controls.Add(lbl_Nome);
            Controls.Add(txb_Nome);
            Name = "FormEntradaProdutos";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_Nome;
        private Label lbl_Nome;
        private Label Lbl_Posicao;
        private Label lbl_CodigoDoProduto;
        private TextBox txb_CodigoDoProduto;
        private Label lbl_quantidadePorCaixaPequena;
        private TextBox txb_quantidadePorCaixaPequena;
        private Label lbl_quantidadeTot;
        private TextBox txb_quantidadeTot;
        private Button bnt_Enviar;
        private ComboBox cbx_Posicao;
    }
}