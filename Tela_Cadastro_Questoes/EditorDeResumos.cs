using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Gestor_de_estudos
{
    class EditorDeResumos
    {
        
        public void Salvar_Arquivo(RichTextBox rich)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "(*.rtf)|*.rtf";
            try
            {
                // Pega o nome do arquivo para salvar
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    // abre um stream para escrita e cria um StreamWriter para implementar o stream
                    FileStream fs = new FileStream(saveFile.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter m_streamWriter = new StreamWriter(fs);
                    m_streamWriter.Flush();
                    // Escreve para o arquivo usando a classe StreamWriter
                    m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    // escreve no controle richtextbox
                    m_streamWriter.Write(rich.Text);
                    // fecha o arquivo
                    m_streamWriter.Flush();
                    m_streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AbrirArquivo(RichTextBox rich)
        {
            //define as propriedades do controle 
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "Selecionar Arquivo";
            ofd.InitialDirectory = @"C:\Dados\";
            //filtra para exibir somente arquivos textos
            ofd.Filter = "(*.txt)|*.txt|" + "(*.rtf)|*.rtf";

            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;
            DialogResult dr = ofd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader m_streamReader = new StreamReader(fs);
                    // Lê o arquivo usando a classe StreamReader
                    m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    // Lê cada linha do stream e faz o parse até a última linha
                    rich.Text = "";
                    string strLine = m_streamReader.ReadLine();
                    while (strLine != null)
                    {
                        rich.Text += strLine + "\n";
                        strLine = m_streamReader.ReadLine();
                    }
                    // Fecha o stream
                    m_streamReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Copiar(RichTextBox rich)
        {
            if (rich.SelectionLength > 0)
            {
                rich.Copy();
            }
        }
        public void Colar(RichTextBox rich)
        {
            rich.Paste();
        }
        public void Negritar(RichTextBox rich)
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool negrito = false;
            nome_fonte = rich.Font.Name;
            tamanho_fonte = rich.Font.Size;
            negrito = rich.Font.Bold;
            if (negrito == false)
            {
                rich.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
            }
            else
            {
                rich.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);
            }
        }
        public void Italico(RichTextBox rich)
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool italico = false;
            nome_fonte = rich.Font.Name;
            tamanho_fonte = rich.Font.Size;
            italico = rich.Font.Italic;
            if (italico == false)
            {
                rich.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
            }
            else
            {
                rich.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
            }
        }
        public void Sublinhar(RichTextBox rich)
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool sublinha = false;
            nome_fonte = rich.Font.Name;
            tamanho_fonte = rich.Font.Size;
            sublinha = rich.Font.Underline;
            if (sublinha == false)
            {
                rich.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
            }
            else
            {
                rich.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
            }
        }
        public void AlterarFonte(RichTextBox rich)
        {
            FontDialog font = new FontDialog();
            DialogResult result = font.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (rich.SelectionFont != null)
                {
                    rich.SelectionFont = font.Font;
                }
            }
        }
    }
}
