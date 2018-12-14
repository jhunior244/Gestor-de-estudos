using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_estudos
{
    class ControleImpressao
    {
        private StringReader leitor = null;
        public void ConfiguracoesImpressora(PrintDialog prntdlg1, PrintDocument prntdoc1)
        {
            try
            {
                prntdlg1.Document = prntdoc1;
                prntdlg1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void visualizaImpressao(RichTextBox rich, PrintDocument print)
        {
            //visualiza a impressao
            try
            {
                string strTexto = rich.Text;
                leitor = new StringReader(strTexto);
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                var prn = printPreviewDialog1;
                prn.Document = print;
                prn.Text = "Jhunior - Visualizando a impressão";
                prn.WindowState = FormWindowState.Maximized;
                prn.PrintPreviewControl.Zoom = 1;
                prn.FormBorderStyle = FormBorderStyle.Fixed3D;
                prn.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Imprimir(PrintDialog printDialog, PrintDocument printDocument, RichTextBox rich)
        {
            printDialog.Document = printDocument;
            string strTexto = rich.Text;
            leitor = new StringReader(strTexto);
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        public void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e, RichTextBox rich)
        {
            float linhasPorPagina = 0;
            float Posicao_Y = 0;
            int contador = 0;
            //defina as margens e o valor minimo
            float MargemEsquerda = e.MarginBounds.Left - 50;
            float MargemSuperior = e.MarginBounds.Top - 50;
            if (MargemEsquerda < 5)
                MargemEsquerda = 20;
            if (MargemSuperior < 5)
                MargemSuperior = 20;

            //define a fonte 
            string linha = null;
            Font FonteDeImpressao = rich.Font;
            SolidBrush meupincel = new SolidBrush(Color.Black);
            //StreamReader leitor = null;
            //Calcula o numero de linhas por página usando as medidas das margens
            linhasPorPagina = e.MarginBounds.Height / FonteDeImpressao.GetHeight(e.Graphics);
            // Vamos imprimir cada linha implementando um StringReader
            linha = leitor.ReadLine();
            while (contador < linhasPorPagina)
            {
                // calcula a posicao da proxima linha baseado  na altura da fonte de acordo com o dispositivo de impressão
                Posicao_Y = (MargemSuperior + (contador * FonteDeImpressao.GetHeight(e.Graphics)));
                // desenha a proxima linha no controle richtextbox
                e.Graphics.DrawString(linha, FonteDeImpressao, meupincel, MargemEsquerda, Posicao_Y, new StringFormat());
                //conta a linha e incrementa uma unidade
                contador += 1;
                linha = leitor.ReadLine();
            }
            // se existir mais linhas imprime outra página
            if ((linha != null))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            meupincel.Dispose();
        }
    }
}
