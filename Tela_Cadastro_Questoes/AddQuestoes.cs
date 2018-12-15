using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Gestor_de_estudos;
using System.Windows.Forms;
using System.Data;

namespace Tela_Cadastro_Questoes
{
    class AddQuestoes
    {
        public void addBanca(OleDbConnection objConection, frmInicial obj)
        {
            try
            {
                objConection.Open();
                string sql;
                sql = "insert into tb_questoes(banca) values ('" + obj.tbNovaBanca.Text + "')";
                OleDbCommand cmd = new OleDbCommand(sql, objConection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dado inserido");
                objConection.Close();
                obj.tbNovaBanca.Text = "NOVA BANCA";
                atualizarAtributosQuestoes(objConection, obj);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                objConection.Close();
            }
        }
        public void addArea(OleDbConnection objConection, frmInicial obj)
        {
            try
            {
                objConection.Open();
                string sql;
                sql = "insert into tb_questoes(area) values ('" + obj.tbNovaArea.Text + "')";
                OleDbCommand cmd = new OleDbCommand(sql, objConection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dado inserido");
                objConection.Close();
                obj.tbNovaArea.Text = "NOVA AREA";
                atualizarAtributosQuestoes(objConection, obj);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                objConection.Close();
            }
        }
        public void addMateria(OleDbConnection objConection, frmInicial obj)
        {
            try
            {
                objConection.Open();
                string sql;
                sql = "insert into tb_questoes(materia) values ('" + obj.tbNovaMateria.Text + "')";
                OleDbCommand cmd = new OleDbCommand(sql, objConection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dado inserido");
                objConection.Close();
                obj.tbNovaMateria.Text = "NOVA MATERIA";
                atualizarAtributosQuestoes(objConection, obj);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                objConection.Close();
            }
        }
        public void addAssunto(OleDbConnection objConection, frmInicial obj)
        {
            try
            {
                objConection.Open();
                string sql;
                sql = "insert into tb_questoes(assunto) values ('" + obj.tbNovoAssunto.Text + "')";
                OleDbCommand cmd = new OleDbCommand(sql, objConection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dado inserido");
                objConection.Close();
                obj.tbNovoAssunto.Text = "NOVO ASSUNTO";
                atualizarAtributosQuestoes(objConection, obj);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                objConection.Close();
            }
        }
        public void atualizarAtributosQuestoes(OleDbConnection objConection, frmInicial obj)
        {
            try
            {               
                objConection.Open();
                string query = "select validadeA from tb_questoes";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, objConection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "tb_questoes");
                DataTable tabela = dataSet.Tables["tb_questoes"];
                //obj.dataGridView1.DataSource =  dataSet.Tables["tb_questoes"];

                OleDbCommand cmm = new OleDbCommand();
                cmm.CommandText = "select validadeA from tb_questoes";
                cmm.CommandType = CommandType.Text;
                cmm.Connection = objConection;
                OleDbDataReader DR;
                DR = cmm.ExecuteReader();
                int c = DR.Depth ;
                DR.Read();
                bool z = DR.GetBoolean(0);
                DR.Read();
                z = DR.GetBoolean(0);
                if (!DR.Read())
                {
                    z = DR.GetBoolean(0);
                }
                    
                

                objConection.Close();
                
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
                objConection.Close();
            }
        }

        public void AddQuestão(OleDbConnection objConection, Questoes questão)
         {
            try
            {
                if (questão.AlternativaA != "" && questão.AlternativaB != "" && questão.AlternativaC != "" && questão.AlternativaD != "" && questão.AlternativaE != "")
                {
                    objConection.Open();
                    string query = "insert into tb_questoes(area, materia, assunto, banca, enunciado, alternativaA, alternativaB, alternativaC, alternativaD, alternativaE, validadeA)";
                    query += "values ('" + questão.Area + "', '" + questão.Materia + "', '" + questão.Assunto + "', '" + questão.Banca + "', '" + questão.Enunciado + "' , '" + questão.AlternativaA + "' , '" + questão.AlternativaB + "' ,";
                    query += "'" + questão.AlternativaC + "' , '" + questão.AlternativaD + "' , '" + questão.AlternativaE + "' , '1')";
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
