﻿using System;
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
using Tela_Cadastro_Questoes;

namespace Gestor_de_estudos
{
    public partial class frmInicial : Form
    {
        GeradorDeSimulados gerador = new GeradorDeSimulados();
        VisualisadorPDF viewPdf = new VisualisadorPDF();
        EditorDeResumos Editor = new EditorDeResumos();
        ControleImpressao impressao = new ControleImpressao();
        OleDbConnection objConection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dbQuestoes.accdb");
        AddQuestoes addQuestoes = new AddQuestoes();
        List<Questao> resposta = new List<Questao>();
        
        public frmInicial()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;           
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
            if (tabViewPDF.TabPages.Count == 0)
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
                else if (DialogResult == DialogResult.No) { return true; }
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
            impressao.visualizaImpressao(richEditTexto, prntdoc1);
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
        private void btnAddBanca_Click(object sender, EventArgs e)
        {
            addQuestoes.addItem("banca.gte",tbNovaBanca.Text, this);
        }
        private void btnAddArea_Click(object sender, EventArgs e)
        {
            addQuestoes.addItem("area.gte",tbNovaArea.Text, this);
        }
        private void tbNovaArea_Click(object sender, EventArgs e)
        {
            tbNovaArea.Text = "";
        }
        private void btnAddMateria_Click(object sender, EventArgs e)
        {
            addQuestoes.addItem("materia.gte",tbNovaMateria.Text, this);
        }
        private void btnAddAssunto_Click(object sender, EventArgs e)
        {
            addQuestoes.addItem("assunto.gte",tbNovoAssunto.Text, this);
        }
        private void tbNovaMateria_Click(object sender, EventArgs e)
        {
            tbNovaMateria.Text = "";
        }
        private void tbNovoAssunto_Click(object sender, EventArgs e)
        {
            tbNovoAssunto.Text = "";
        }
        private void btnAddQuestao_Click(object sender, EventArgs e)
        {
            Questao questao = new Questao(cbArea.Text, cbMateria.Text, cbAssunto.Text, cbBanca.Text, richEnunciado.Text, richAltA.Text, richAltB.Text, richAltC.Text, richAltD.Text, richAltE.Text, rdbletraA.Checked, rdbletraB.Checked, rdbletraC.Checked, rdbletraD.Checked, rdbletraE.Checked);
            AddQuestoes addQuestoes = new AddQuestoes();
            addQuestoes.AddQuestão(objConection, questao);
        }
        private void tbNovaBanca_MouseClick(object sender, MouseEventArgs e)
        {
            tbNovaBanca.Text = "";
        }
        private void cbAssunto_Click(object sender, EventArgs e)
        {
            ComboBox combo = this.cbAssunto;
            addQuestoes.AtualizaAtributosQuestoes(combo, "assunto.gte");
        }
        private void cbMateria_Click(object sender, EventArgs e)
        {
            ComboBox combo = this.cbMateria; 
            addQuestoes.AtualizaAtributosQuestoes(combo, "materia.gte");
        }
        private void cbBanca_Click(object sender, EventArgs e)
        {
            ComboBox combo = this.cbBanca;         
            addQuestoes.AtualizaAtributosQuestoes(combo, "banca.gte");           
        }
        private void cbArea_Click(object sender, EventArgs e)
        {
            ComboBox combo = this.cbArea;
            addQuestoes.AtualizaAtributosQuestoes(combo, "area.gte");
        }
        private void cbBancaNewSimulado_Click(object sender, EventArgs e)
        {
            ComboBox combo = this.cbBancaNewSimulado;
            addQuestoes.AtualizaAtributosQuestoes(combo, "banca.gte");
        }
        private void cbAreaNewSimulado_Click(object sender, EventArgs e)
        {
            ComboBox combo = this.cbAreaNewSimulado;
            addQuestoes.AtualizaAtributosQuestoes(combo, "area.gte");
        }
        private void cbMateriaNewSimulado_Click(object sender, EventArgs e)
        {
            ComboBox combo = this.cbMateriaNewSimulado;
            addQuestoes.AtualizaAtributosQuestoes(combo, "materia.gte");
        }
        private void cbAssuntoNewSimulado_Click(object sender, EventArgs e)
        {
            ComboBox combo = this.cbAssuntoNewSimulado;
            addQuestoes.AtualizaAtributosQuestoes(combo, "assunto.gte");
        }
        private void btnGerarSimulado_Click(object sender, EventArgs e)
        {
            if(tbQtdQuestoes.Text != "")
            {
                gerador.BuscarQuestoes(objConection, cbBancaNewSimulado.Text, cbAreaNewSimulado.Text, cbAssuntoNewSimulado.Text, cbMateriaNewSimulado.Text);
                if (gerador.IniciarSimul)
                {
                    btnIniciarSimul.Enabled = true;
                    btnGerarSimulado.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Determine o número de questões o simulado terá.");
            }                                  
        }
        private void btnProxQuest_Click(object sender, EventArgs e)
        {
            Questao questaoRespondida = new Questao(controleExibeQuestao1.rdbA.Checked, controleExibeQuestao1.rdbB.Checked, controleExibeQuestao1.rdbC.Checked, controleExibeQuestao1.rdbD.Checked, controleExibeQuestao1.rdbE.Checked);
            resposta[gerador.indexQuestoes] = questaoRespondida;
            gerador.indexQuestoes++;
            if(gerador.indexQuestoes == gerador.Simulado.Length -1)
            {
                gerador.exibirQuestaoSemResposta(controleExibeQuestao1);
                btnProxQuest.Enabled = false;               
            }
            else if(gerador.indexQuestoes > 0)
            {
                btnAntQuest.Enabled = true;
                gerador.exibirQuestaoSemResposta(controleExibeQuestao1);               
            }
            else
            {
                gerador.exibirQuestaoSemResposta(controleExibeQuestao1);               
            }           
        }
        private void btnIniciarSimul_Click(object sender, EventArgs e)
        {          
            gerador.selectQuestoes(Convert.ToInt32(tbQtdQuestoes.Text));
            gerador.indexQuestoes = 0;   
            gerador.exibirQuestaoSemResposta(controleExibeQuestao1);
            btnIniciarSimul.Enabled = false;
            if (gerador.Simulado.Length > 1)
            {
                btnProxQuest.Enabled = true;
            }
        }
        private void tbQtdQuestoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void btnFinaSimulado_Click(object sender, EventArgs e)
        {
            controleExibeQuestao1.label2.BackColor = Color.GreenYellow;
        }
        private void btnAntQuest_Click(object sender, EventArgs e)
        {
            gerador.indexQuestoes--;
            if(gerador.indexQuestoes == 0)
            {
                btnAntQuest.Enabled = false;
                gerador.exibirQuestaoSemResposta(controleExibeQuestao1);
            }
            else
            {
                gerador.exibirQuestaoSemResposta(controleExibeQuestao1);
            }
        }
    }
}
