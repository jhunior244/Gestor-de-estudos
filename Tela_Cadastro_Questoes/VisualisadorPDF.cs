using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_estudos
{
    class VisualisadorPDF
    {

        public void openFilePDF(TabControl tab)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(*.pdf)|*.pdf";
            openFile.ShowDialog();

            TabPage page = new TabPage(RenameGuia(openFile.FileName));    
            tab.Controls.Add(page);
            tab.SelectTab(tab.TabCount - 1);
            Button buttonClose = new Button();

            WebBrowser browser = new WebBrowser();

            browser.Parent = page;
            browser.Dock = DockStyle.Fill;
            tab.Visible = true;
            browser.Navigate(openFile.FileName);
        }
        private string RenameGuia(string nameFile)
        {
            string[] aux = nameFile.Split('\\');
            
            if(aux[aux.Length -1].Length > 6)
            {//verifica o tamanho do nome do arquivo para que o tamanho da guia nao fique muito grande
                nameFile = aux[aux.Length - 1].Remove(aux[aux.Length - 1].Length - aux[aux.Length - 1].Length + 11, aux[aux.Length - 1].Length - 11);
                nameFile += "...    ";
            }
            else
            {
                nameFile = aux[aux.Length - 1].Remove(aux.Length - 4, 4);
            }
            
            return nameFile;
        }       
    }
}
