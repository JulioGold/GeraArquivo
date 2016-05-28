using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GeraArquivo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            cboEscala.SelectedIndex = 0;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                long tamanho = 1;
                switch (cboEscala.Text)
                {
                    case "byte":
                        tamanho = 1;
                        break;

                    case "Kbyte":
                        tamanho = 1024;
                        break;

                    case "Mbyte":
                        tamanho = 1048576;
                        break;

                    case "Gbyte":
                        tamanho = 1073741824;
                        break;

                    default:
                        tamanho = 1;
                        break;
                }

                DriveInfo drv = new DriveInfo(txtCaminho.Text);
                if ((tamanho * nudTamanho.Value) >= drv.TotalFreeSpace)
                {
                    throw new System.IO.IOException("Não há espaço suficiente em disco.");
                }

                StringBuilder bloco = new StringBuilder();
                for (int i = 0; i < tamanho; i++)
                {
                    bloco.Append("J");
                }

                StringBuilder conteudoArquivo = new StringBuilder();
                for (int i = 0; i < nudTamanho.Value; i++)
                {
                    conteudoArquivo.Append(bloco);
                }

                StreamWriter sw = new StreamWriter(txtCaminho.Text);
                sw.Write(conteudoArquivo);
                sw.Flush();
                sw.Close();

                MessageBox.Show("Terminou.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCaminho_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();

            if (svd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtCaminho.Text = svd.FileName;
            }
        }

        private void cboEscala_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculaTamanho();
        }

        private void nudTamanho_ValueChanged(object sender, EventArgs e)
        {
            RecalculaTamanho();
        }

        /// <summary>
        /// Recalcula o tamanho conforme a escala escolhida.
        /// Referências:
        /// http://igorbh.wordpress.com/2012/02/06/formatando-numeros-de-ponto-flutuante/
        /// https://sites.google.com/site/tecguia/formatar-string-c-string-format
        /// http://alanrossi.wordpress.com/2009/11/20/formatando-strings-no-c/
        /// </summary>
        private void RecalculaTamanho()
        {
            long tamanho = 1;
            string notacao = "bytes";

            switch (cboEscala.Text)
            {
                case "byte":
                    tamanho = (long)nudTamanho.Value;
                    if ((long)nudTamanho.Value == 1) { notacao = "byte"; } else { notacao = "bytes"; }
                    break;

                case "Kbyte":
                    tamanho = 1024 * (long)nudTamanho.Value;
                    break;

                case "Mbyte":
                    tamanho = 1048576 * (long)nudTamanho.Value;
                    break;

                case "Gbyte":
                    tamanho = 1073741824 * (long)nudTamanho.Value;
                    break;

                default:
                    tamanho = (long)nudTamanho.Value;
                    break;
            }

            lblDescricaoTamanho.Text = "Tamanho " + String.Format("{0:#,0}", tamanho) + " " + notacao;
        }
    }
}
