using System;
using System.Windows.Forms;

namespace _52_Semanas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja encerrar o App ?", "Encerrar App", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericValor_ValueChanged(object sender, EventArgs e)
        {
            lblTotalValorEscolhido.Text = string.Format("R$ {0}",numericValor.Value.ToString());
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            int semana = 0;
            decimal saldo = 0;
            decimal valor = 0;
            decimal valorAcumulado = 0;

            string[] colunas = new string[4];

            for (int i = 1; i < 53; i++)
            {
                semana += 1;
                colunas[0] = semana.ToString();
                if (i == 1)
                {
                    valorAcumulado = valor + numericValor.Value;
                    colunas[1] = string.Format("R$ {0}", valorAcumulado.ToString());
                    colunas[2] = "Não";
                    colunas[3] = string.Format("R$ {0}", valorAcumulado.ToString());
                    valor = numericValor.Value;
                }
                else
                {
                    valor += numericValor.Value;
                    colunas[1] = string.Format("R$ {0}", valor.ToString());
                    colunas[2] = "Não";
                    valorAcumulado += valor;
                    colunas[3] = string.Format("R$ {0}", valorAcumulado);
                }
                try
                {
                    ListViewItem lstView = new ListViewItem(colunas);
                    listViewDetalhes.Enabled = true;
                    listViewDetalhes.Items.Add(lstView);
                }
                catch(Exception error)
                {
                    MessageBox.Show(string.Format("Ocorreu o erro: {0}", error), "Erro ao Gerar Lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }
    }
}
