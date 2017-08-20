using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Drawing;

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
            int cont = 1;

            decimal valor = 0;
            decimal valorAcumulado = 0;
            decimal valorDepositoMensal = 0;

            string[] colunas = new string[4];
            string linha = string.Empty;
            listViewDetalhes.Items.Clear();

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
                    valorDepositoMensal += valor;
                    linha = string.Join(", ", colunas);
                    cont++;
                }
                else
                {
                    valor += numericValor.Value;
                    valorDepositoMensal += valor;
                    colunas[1] = string.Format("R$ {0}", valor.ToString());
                    colunas[2] = "Não";
                    valorAcumulado += valor;
                    colunas[3] = string.Format("R$ {0}", valorAcumulado);
                    linha = linha + (string.Format("{0}", System.Environment.NewLine) + string.Join(", ", colunas));
                    cont++;
                }
                try
                {
                    ListViewItem lstView = new ListViewItem(colunas);
                    listViewDetalhes.Enabled = true;
                    listViewDetalhes.Items.Add(lstView);
                    if(cont == 5)
                    {
                        colunas[0] = "Mês encerrado";
                        colunas[1] = string.Format("Deposito Mês: R${0}", valorDepositoMensal);
                        colunas[2] = "*****";
                        colunas[3] = string.Format("Saldo Mês: R${0}", valorAcumulado);
                        ListViewItem lstView2 = new ListViewItem(colunas);
                        lstView2.BackColor = Color.LightGoldenrodYellow;
                        listViewDetalhes.Items.Add(lstView2);

                        valorDepositoMensal = 0;
                        cont = 1;
                    }
                }
                catch(Exception error)
                {
                    MessageBox.Show(string.Format("Ocorreu o erro: {0}", error), "Erro ao Gerar Lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //CriarTxt(linha);
        }

        private void listViewDetalhes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(MessageBox.Show("Deseja atualizar está linha ?", "Atualizar Depósito", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {              
                
            }
        }

        private void CriarTxt(string linha)
        {
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Emílio Andrade\Documents\Desenvolvimento\EmilioAndrade\52Semanas.txt");
                file.WriteLine(linha);
                file.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Erro ao criar o arquivo no diretório", "Erro ao Criar o Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Não foi possível criar o arquivo no diretório, falha de permissão", "Erro ao Criar o Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show(string.Format("Ocorreu o erro: {0}", error), "Erro ao Criar o Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizaDeposito()
        {

        }
    }
}
