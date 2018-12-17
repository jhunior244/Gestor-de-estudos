using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Gestor_de_estudos;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Tela_Cadastro_Questoes
{
    class AddQuestoes
    {
        
        public void addBanca(string banca, frmInicial obj)
        {
            try
            {
                StreamWriter writer = new StreamWriter("banca.gte", true, Encoding.UTF8);
                writer.WriteLine(banca);
                writer.Close();
                obj.tbNovaBanca.Text = "NOVA BANCA";
                MessageBox.Show("Nova banca gravada com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        public void addArea(string area, frmInicial obj)
        {
            try
            {
                StreamWriter writer = new StreamWriter("area.gte", true, Encoding.UTF8);
                writer.WriteLine(area);
                writer.Close();
                obj.tbNovaArea.Text = "NOVA AREA";
                MessageBox.Show("Nova area gravada com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        public void addMateria(string materia, frmInicial obj)
        {
            try
            {
                StreamWriter writer = new StreamWriter("materia.gte", true, Encoding.UTF8);
                
                writer.WriteLine(materia);
                writer.Close();
                obj.tbNovaMateria.Text = "NOVA MATERIA";
                MessageBox.Show("Nova materia gravada com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        public void addAssunto(string assunto, frmInicial obj)
        {
            try
            {
                StreamWriter writer = new StreamWriter("assunto.gte", true, Encoding.UTF8);
                writer.WriteLine(assunto);
                writer.Close();
                obj.tbNovoAssunto.Text = "NOVO ASSUNTO";
                MessageBox.Show("Novo assunto gravado com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);               
            }
        }
        public void AtualizaAtributosQuestoes(ComboBox combo, string path)
        {
            StreamReader stream = new StreamReader(path, Encoding.Default);
            string linha = stream.ReadLine();
            combo.Items.Clear();
            while (linha != null && linha != "")
            {
                combo.Items.Add(linha);
                linha = stream.ReadLine();
            }
            stream.Close();
        }
        public void AddQuestão(OleDbConnection objConection, Questoes questão)
         {
            try
            {
                if (questão.AlternativaA != "" && questão.AlternativaB != "" && questão.AlternativaC != "" && questão.AlternativaD != "" && questão.AlternativaE != "")
                {
                    objConection.Open();
                    string query = "insert into tb_questoes(area, materia, assunto, banca, enunciado, alternativaA, alternativaB, alternativaC, alternativaD, alternativaE, validadeA, validadeB, validadeC, validadeD, validadeE)";
                    query += "values ('" + questão.Area + "', '" + questão.Materia + "', '" + questão.Assunto + "', '" + questão.Banca + "', '" + questão.Enunciado + "' , '" + questão.AlternativaA + "' , '" + questão.AlternativaB + "' ,";
                    query += "'" + questão.AlternativaC + "' , '" + questão.AlternativaD + "' , '" + questão.AlternativaE + "' , '" + Convert.ToByte(questão.ValidadeA) + "' ,'" + Convert.ToByte(questão.ValidadeB) + "' ,'" + Convert.ToByte(questão.ValidadeC) + "' ,'" + Convert.ToByte(questão.ValidadeD) + "' ,'" + Convert.ToByte(questão.ValidadeE) + "')";
                    OleDbCommand cmd = new OleDbCommand(query, objConection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dado inserido");
                    objConection.Close();

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                objConection.Close();
            }
           
        }
    }
}
