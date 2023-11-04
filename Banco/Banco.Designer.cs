namespace Banco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSaldoValor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxDeposito = new System.Windows.Forms.TextBox();
            this.buttonDepositar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSacar = new System.Windows.Forms.Button();
            this.textBoxSacar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCifrao = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            // 
            // labelSaldoValor
            // 
            this.labelSaldoValor.AutoSize = true;
            this.labelSaldoValor.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoValor.Location = new System.Drawing.Point(38, 22);
            this.labelSaldoValor.Name = "labelSaldoValor";
            this.labelSaldoValor.Size = new System.Drawing.Size(51, 29);
            this.labelSaldoValor.TabIndex = 2;
            this.labelSaldoValor.Text = "0,00";
            this.labelSaldoValor.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCifrao);
            this.groupBox1.Controls.Add(this.labelSaldoValor);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saldo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelNomeCliente);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(218, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 66);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nome do Cliente";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.Location = new System.Drawing.Point(6, 22);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(247, 29);
            this.labelNomeCliente.TabIndex = 3;
            this.labelNomeCliente.Text = "Carolyne Oliveira Moraes";
            this.labelNomeCliente.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Opções:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDepositar);
            this.groupBox3.Controls.Add(this.textBoxDeposito);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 73);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Depósito";
            // 
            // textBoxDeposito
            // 
            this.textBoxDeposito.Location = new System.Drawing.Point(11, 30);
            this.textBoxDeposito.Name = "textBoxDeposito";
            this.textBoxDeposito.Size = new System.Drawing.Size(275, 20);
            this.textBoxDeposito.TabIndex = 0;
            // 
            // buttonDepositar
            // 
            this.buttonDepositar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDepositar.Location = new System.Drawing.Point(292, 29);
            this.buttonDepositar.Name = "buttonDepositar";
            this.buttonDepositar.Size = new System.Drawing.Size(75, 23);
            this.buttonDepositar.TabIndex = 1;
            this.buttonDepositar.Text = "Depositar";
            this.buttonDepositar.UseVisualStyleBackColor = false;
            this.buttonDepositar.Click += new System.EventHandler(this.buttonDepositar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSacar);
            this.groupBox4.Controls.Add(this.textBoxSacar);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(408, 165);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(380, 73);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Saque";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // buttonSacar
            // 
            this.buttonSacar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSacar.Location = new System.Drawing.Point(292, 29);
            this.buttonSacar.Name = "buttonSacar";
            this.buttonSacar.Size = new System.Drawing.Size(75, 23);
            this.buttonSacar.TabIndex = 1;
            this.buttonSacar.Text = "Sacar";
            this.buttonSacar.UseVisualStyleBackColor = false;
            this.buttonSacar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSacar
            // 
            this.textBoxSacar.Location = new System.Drawing.Point(11, 30);
            this.textBoxSacar.Name = "textBoxSacar";
            this.textBoxSacar.Size = new System.Drawing.Size(275, 20);
            this.textBoxSacar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Todos os direitos reservados © 2023";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // labelCifrao
            // 
            this.labelCifrao.AutoSize = true;
            this.labelCifrao.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCifrao.Location = new System.Drawing.Point(6, 22);
            this.labelCifrao.Name = "labelCifrao";
            this.labelCifrao.Size = new System.Drawing.Size(38, 29);
            this.labelCifrao.TabIndex = 3;
            this.labelCifrao.Text = "R$";
            this.labelCifrao.Click += new System.EventHandler(this.labelCifrao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Página incial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.Label labelSaldoValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDepositar;
        private System.Windows.Forms.TextBox textBoxDeposito;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSacar;
        private System.Windows.Forms.TextBox textBoxSacar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCifrao;
    }
}

