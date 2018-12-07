using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Gestor_de_estudos
{
    public partial class frmInicial : Form
    {
        
        VisualisadorPDF viewPdf = new VisualisadorPDF();
        EditorDeResumos Editor = new EditorDeResumos();
        ControleImpressao impressao = new ControleImpressao();
        public frmInicial()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;
            richTextBox2.Text = "dsfsdfasfasfasfafO ser humano e criado por amor, feito a imagem e à semelhança de Deus. É capas de se conhecer, de se possui e de livremente se dar e entrar em comunhão com outras pessoas.   A existência humana se baseia sobre três relações fundamentais intimamente ligadas: as relações com Deus, com o próximo e com a terra. Segundo a bíblia essas relações vitais romperam - se dentro e fora de nós.Esta ruptura é o pecado. Existe uma acusação lançada contra o pensamento judaico-cristão que é equivocada, onde fala que o homem é convidado a dominar a terra e isso favoreceria a exploração selvagem da natureza.A palavra cita cultivar e quer dizer, lavrar ou trabalhar um terreno. O ser humano e criado por amor, feito a imagem e à semelhança de Deus. É capas de se conhecer, de se possui e de livremente se dar e entrar em comunhão com outras pessoas.   A existência humana se baseia sobre três relações fundamentais intimamente ligadas: as relações com Deus, com o próximo e com a terra. Segundo a bíblia essas relações vitais romperam - se dentro e fora de nós.Esta ruptura é o pecado. Existe uma acusação lançada contra o pensamento judaico-cristão que é equivocada, onde fala que o homem é convidado a dominar a terra e isso favoreceria a exploração selvagem da natureza.A palavra cita cultivar e quer dizer, lavrar ou trabalhar um terreno.";
            Control control = new Control();
            CheckedListBox checkedListBox = new CheckedListBox();
            checkedListBox.Items.Add("fsadfsadfasdfr humano e criado por amor, feito a imagem e à semelhança de Deus. É capas de se conhecer, de se possui e de livremen");
            checkedListBox.Items.Add("fsadfsadfasdf");
            checkedListBox.Items.Add("fsadfsadfasdf");
            checkedListBox.Items.Add("fsadfsadfasdf");
            control = checkedListBox;
            control.Text = "dsfsdfasfasfasfafO ser humano e criado por amor, feito a imagem e à semelhança de Deus. É capas de se conhecer, de se possui e de livremente se dar e entrar em comunhão com outras pessoas.   A existência humana se baseia sobre três relações fundamentais intimamente ligadas: as relações com Deus, com o próximo e com a terra. Segundo a bíblia essas relações vitais romperam - se dentro e fora de nós.Esta ruptura é o pecado. Existe uma acusação lançada contra o pensamento judaico-cristão q";
            control.Text =  "dsfsdfasfasfasfafO ser humano e criado por amor, feito a imagem e à semelhança de Deus. É capas de se conhecer, de se possui e de livremente se dar e entrar em comunhão com outras pessoas.   A existência humana se baseia sobre três relações fundamentais intimamente ligadas: as relações com Deus, com o próximo e com a terra. Segundo a bíblia essas relações vitais romperam - se dentro e fora de nós.Esta ruptura é o pecado. Existe uma acusação lançada contra o pensamento judaico-cristão q";
            control.Location = new Point(0, 150);
            
            richTextBox2.Controls.Add(control);
            WindowState = FormWindowState.Maximized;           
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void documentoPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewPdf.openFilePDF(tabViewPDF);
        }
        private void tabViewPDF_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("X", e.Font, Brushes.Red, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabViewPDF.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }
        private void tabViewPDF_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabViewPDF.TabPages.Count; i++)
            {
                Rectangle r = tabViewPDF.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Gostaria de fechar essa aba?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tabViewPDF.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
            if(tabViewPDF.TabPages.Count == 0)
            {
                tabViewPDF.Visible = false;
            }
        }
        private void toolStripNovo_Click(object sender, EventArgs e)
        {
            if (ChamaSalvarArquivo())
            {
                richEditTexto.Clear();
                richEditTexto.Focus();
            }        
        }
        private bool ChamaSalvarArquivo()
        {
            if (!string.IsNullOrEmpty(richEditTexto.Text))
            {
                DialogResult = MessageBox.Show("Deseja Salvar o arquivo ?", "Salvar Arquivo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult == DialogResult.Yes) { Editor.Salvar_Arquivo(richEditTexto); }
                else if(DialogResult == DialogResult.No) { return true; }
                else { return false; }                          
            }
            return true;
        }
        private void toolStripAbrit_Click(object sender, EventArgs e)
        {
            Editor.AbrirArquivo(richEditTexto);
        }
        private void toolStripSalvar_Click(object sender, EventArgs e)
        {
            Editor.Salvar_Arquivo(richEditTexto);
        }
        private void toolStripCopiar_Click(object sender, EventArgs e)
        {
            Editor.Copiar(richEditTexto);
        }
        private void toolStripColar_Click(object sender, EventArgs e)
        {
            Editor.Colar(richEditTexto);
        }
        private void toolStripNegrito_Click(object sender, EventArgs e)
        {
            Editor.Negritar(richEditTexto);
        }
        private void toolStripItalico_Click(object sender, EventArgs e)
        {
            Editor.Italico(richEditTexto);
        }
        private void toolStripSublinhado_Click(object sender, EventArgs e)
        {
            Editor.Sublinhar(richEditTexto);
        }
        private void toolStripFonte_Click(object sender, EventArgs e)
        {
            Editor.AlterarFonte(richEditTexto);
        }
        private void toolStripEsquerda_Click(object sender, EventArgs e)
        {
            richEditTexto.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void toolStripCentralizado_Click(object sender, EventArgs e)
        {
            richEditTexto.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void toolStripDireita_Click(object sender, EventArgs e)
        {
            richEditTexto.SelectionAlignment = HorizontalAlignment.Right;           
        }
        private void configuraçõesImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            impressao.ConfiguracoesImpressora(prntdlg1, prntdoc1);
        }
        private void visualizarImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            impressao.visualizaImpressao(richEditTexto,prntdoc1);
        }
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            impressao.Imprimir(prntdlg1, prntdoc1, richEditTexto);
        }
        private void prntdoc1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            impressao.PrintPage(sender, e, richEditTexto);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int lent = richTextBox2.TextLength;
            richTextBox2.ZoomFactor = 50;
        }
    }
}
