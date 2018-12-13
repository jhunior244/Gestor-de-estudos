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
using MySql.Data.MySqlClient;
using System.Data.OleDb;


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
            Label label = new Label();
            OleDbConnection con = new OleDbConnection();
            label.MaximumSize = new Size(18, 0);
            label.AutoSize = true;
            label.Text = "1,2,3,4,5,6,7,88,9,0,98,67,54,,345,34,534,53,45,,76,567,65,56,7,56,34,5,45,,6,7,7,5,65,6,56,7,,3,654,654,65,6,765,7,567,657,65,765,87658888888888886,755555555555 ,657          ,76666666666665, 45555555555553 ,6555555555555554,66666666666663345,6";
            //userControl1.Height = label.Bottom;
            //userControl1.Controls.Add(label);
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
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection sqlConnection = new MySqlConnection("server=localhost;port=3306;User Id=root;database=dataTeste;password=881100jr");
                sqlConnection.Open();
                MessageBox.Show("Conectado");
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Nao conectado");
            }
        }
    }
}
