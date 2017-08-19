namespace _52_Semanas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblValor = new System.Windows.Forms.Label();
            this.gBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.numericValor = new System.Windows.Forms.NumericUpDown();
            this.listViewDetalhes = new System.Windows.Forms.ListView();
            this.groupBoxDetalhes = new System.Windows.Forms.GroupBox();
            this.columnHeaderSemana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeposito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblValorSelecionado = new System.Windows.Forms.Label();
            this.lblTotalValorEscolhido = new System.Windows.Forms.Label();
            this.lblTotalDepositado = new System.Windows.Forms.Label();
            this.lblValorTotalDepositado = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.lblGerarLista = new System.Windows.Forms.Label();
            this.gBoxPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericValor)).BeginInit();
            this.groupBoxDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(28, 44);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(101, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Selecione um Valor:";
            // 
            // gBoxPrincipal
            // 
            this.gBoxPrincipal.Controls.Add(this.lblGerarLista);
            this.gBoxPrincipal.Controls.Add(this.btnVisualizar);
            this.gBoxPrincipal.Controls.Add(this.lblValorTotalDepositado);
            this.gBoxPrincipal.Controls.Add(this.lblTotalDepositado);
            this.gBoxPrincipal.Controls.Add(this.lblTotalValorEscolhido);
            this.gBoxPrincipal.Controls.Add(this.lblValorSelecionado);
            this.gBoxPrincipal.Controls.Add(this.groupBoxDetalhes);
            this.gBoxPrincipal.Controls.Add(this.numericValor);
            this.gBoxPrincipal.Controls.Add(this.lblValor);
            this.gBoxPrincipal.Location = new System.Drawing.Point(12, 12);
            this.gBoxPrincipal.Name = "gBoxPrincipal";
            this.gBoxPrincipal.Size = new System.Drawing.Size(442, 347);
            this.gBoxPrincipal.TabIndex = 1;
            this.gBoxPrincipal.TabStop = false;
            this.gBoxPrincipal.Text = "52 Semanas";
            // 
            // numericValor
            // 
            this.numericValor.Location = new System.Drawing.Point(135, 42);
            this.numericValor.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericValor.Name = "numericValor";
            this.numericValor.Size = new System.Drawing.Size(80, 20);
            this.numericValor.TabIndex = 1;
            this.numericValor.ValueChanged += new System.EventHandler(this.numericValor_ValueChanged);
            // 
            // listViewDetalhes
            // 
            this.listViewDetalhes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSemana,
            this.columnHeaderValor,
            this.columnHeaderDeposito,
            this.columnHeaderSaldo});
            this.listViewDetalhes.Enabled = false;
            this.listViewDetalhes.FullRowSelect = true;
            this.listViewDetalhes.GridLines = true;
            this.listViewDetalhes.Location = new System.Drawing.Point(6, 25);
            this.listViewDetalhes.Name = "listViewDetalhes";
            this.listViewDetalhes.Size = new System.Drawing.Size(407, 174);
            this.listViewDetalhes.TabIndex = 2;
            this.listViewDetalhes.UseCompatibleStateImageBehavior = false;
            this.listViewDetalhes.View = System.Windows.Forms.View.Details;
            // 
            // groupBoxDetalhes
            // 
            this.groupBoxDetalhes.Controls.Add(this.listViewDetalhes);
            this.groupBoxDetalhes.Location = new System.Drawing.Point(9, 85);
            this.groupBoxDetalhes.Name = "groupBoxDetalhes";
            this.groupBoxDetalhes.Size = new System.Drawing.Size(419, 218);
            this.groupBoxDetalhes.TabIndex = 2;
            this.groupBoxDetalhes.TabStop = false;
            this.groupBoxDetalhes.Text = "Detalhes";
            // 
            // columnHeaderSemana
            // 
            this.columnHeaderSemana.Text = "Semana";
            this.columnHeaderSemana.Width = 79;
            // 
            // columnHeaderValor
            // 
            this.columnHeaderValor.Text = "Valor";
            this.columnHeaderValor.Width = 122;
            // 
            // columnHeaderDeposito
            // 
            this.columnHeaderDeposito.Text = "Depositado ?";
            this.columnHeaderDeposito.Width = 99;
            // 
            // columnHeaderSaldo
            // 
            this.columnHeaderSaldo.Text = "Saldo";
            this.columnHeaderSaldo.Width = 103;
            // 
            // lblValorSelecionado
            // 
            this.lblValorSelecionado.AutoSize = true;
            this.lblValorSelecionado.Location = new System.Drawing.Point(12, 320);
            this.lblValorSelecionado.Name = "lblValorSelecionado";
            this.lblValorSelecionado.Size = new System.Drawing.Size(83, 13);
            this.lblValorSelecionado.TabIndex = 3;
            this.lblValorSelecionado.Text = "Valor Escolhido:";
            // 
            // lblTotalValorEscolhido
            // 
            this.lblTotalValorEscolhido.AutoSize = true;
            this.lblTotalValorEscolhido.Location = new System.Drawing.Point(101, 320);
            this.lblTotalValorEscolhido.Name = "lblTotalValorEscolhido";
            this.lblTotalValorEscolhido.Size = new System.Drawing.Size(30, 13);
            this.lblTotalValorEscolhido.TabIndex = 4;
            this.lblTotalValorEscolhido.Text = "R$ 0";
            // 
            // lblTotalDepositado
            // 
            this.lblTotalDepositado.AutoSize = true;
            this.lblTotalDepositado.Location = new System.Drawing.Point(257, 320);
            this.lblTotalDepositado.Name = "lblTotalDepositado";
            this.lblTotalDepositado.Size = new System.Drawing.Size(91, 13);
            this.lblTotalDepositado.TabIndex = 5;
            this.lblTotalDepositado.Text = "Total Depositado:";
            // 
            // lblValorTotalDepositado
            // 
            this.lblValorTotalDepositado.AutoSize = true;
            this.lblValorTotalDepositado.Location = new System.Drawing.Point(355, 320);
            this.lblValorTotalDepositado.Name = "lblValorTotalDepositado";
            this.lblValorTotalDepositado.Size = new System.Drawing.Size(30, 13);
            this.lblValorTotalDepositado.TabIndex = 6;
            this.lblValorTotalDepositado.Text = "R$ 0";
            // 
            // btnGravar
            // 
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(101, 384);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(285, 384);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(345, 39);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(34, 23);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // lblGerarLista
            // 
            this.lblGerarLista.AutoSize = true;
            this.lblGerarLista.Location = new System.Drawing.Point(270, 44);
            this.lblGerarLista.Name = "lblGerarLista";
            this.lblGerarLista.Size = new System.Drawing.Size(61, 13);
            this.lblGerarLista.TabIndex = 8;
            this.lblGerarLista.Text = "Gerar Lista:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 419);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.gBoxPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desafio 52 Semanas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gBoxPrincipal.ResumeLayout(false);
            this.gBoxPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericValor)).EndInit();
            this.groupBoxDetalhes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox gBoxPrincipal;
        private System.Windows.Forms.GroupBox groupBoxDetalhes;
        private System.Windows.Forms.ListView listViewDetalhes;
        private System.Windows.Forms.NumericUpDown numericValor;
        private System.Windows.Forms.Label lblValorTotalDepositado;
        private System.Windows.Forms.Label lblTotalDepositado;
        private System.Windows.Forms.Label lblTotalValorEscolhido;
        private System.Windows.Forms.Label lblValorSelecionado;
        private System.Windows.Forms.ColumnHeader columnHeaderSemana;
        private System.Windows.Forms.ColumnHeader columnHeaderValor;
        private System.Windows.Forms.ColumnHeader columnHeaderDeposito;
        private System.Windows.Forms.ColumnHeader columnHeaderSaldo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblGerarLista;
        private System.Windows.Forms.Button btnVisualizar;
    }
}

