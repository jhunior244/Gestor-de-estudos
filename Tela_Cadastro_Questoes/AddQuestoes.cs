﻿using System;
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
        public void addItem(string arquivo, string item, frmInicial obj)
        {
            try
            {
                StreamWriter writer = new StreamWriter(arquivo, true, Encoding.UTF8);
                writer.WriteLine(item);
                writer.Close();
                if (arquivo == "materia.gte")
                {
                    obj.tbNovaMateria.Text = "NOVA MATERIA";
                }
                else if (arquivo == "banca.gte")
                {
                    obj.tbNovaBanca.Text = "NOVA BANCA";
                }
                else if (arquivo == "area.gte")
                {
                    obj.tbNovaArea.Text = "NOVA AREA";
                }
                else if (arquivo == "assunto.gte")
                {
                    obj.tbNovoAssunto.Text = "NOVO ASSUNTO";
                }
                MessageBox.Show("Item gravado com sucesso!");
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
        public void AddQuestão(OleDbConnection objConection, Questao questão)
        {
            try
            {
                if(questão.Banca == "")
                {
                    questão.Banca = "Não tem";
                }
                if (questão.Materia == "")
                {
                    questão.Materia = "Não tem";
                }
                if (questão.Assunto == "")
                {
                    questão.Assunto = "Não tem";
                }
                if (questão.Area == "")
                {
                    questão.Area = "Não tem";
                }               
                if (questão.AlternativaA != "" && questão.AlternativaB != "" && questão.AlternativaC != "" && questão.AlternativaD != "" && questão.AlternativaE != "")
                {
                    if(questão.ValidadeA == true || questão.ValidadeB == true || questão.ValidadeC == true || questão.ValidadeD == true || questão.ValidadeE == true)
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
                    else
                    {
                        MessageBox.Show("Você nao indicou qual é a resposta da questão.");
                    }
                }
                else if (questão.AlternativaA != "" && questão.AlternativaB != "" && questão.AlternativaC != "" && questão.AlternativaD != "")
                {
                    if (questão.ValidadeA == true || questão.ValidadeB == true || questão.ValidadeC == true || questão.ValidadeD == true)
                    {
                        objConection.Open();
                        string query = "insert into tb_questoes(area, materia, assunto, banca, enunciado, alternativaA, alternativaB, alternativaC, alternativaD, alternativaE, validadeA, validadeB, validadeC, validadeD, validadeE)";
                        query += "values ('" + questão.Area + "', '" + questão.Materia + "', '" + questão.Assunto + "', '" + questão.Banca + "', '" + questão.Enunciado + "' , '" + questão.AlternativaA + "' , '" + questão.AlternativaB + "' ,";
                        query += "'" + questão.AlternativaC + "' , '" + questão.AlternativaD + "' , 'Nao se aplica' , '" + Convert.ToByte(questão.ValidadeA) + "' ,'" + Convert.ToByte(questão.ValidadeB) + "' ,'" + Convert.ToByte(questão.ValidadeC) + "' ,'" + Convert.ToByte(questão.ValidadeD) + "' ,'0')";
                        OleDbCommand cmd = new OleDbCommand(query, objConection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dado inserido");
                        objConection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Você nao indicou qual é a resposta da questão.");
                    }
                }
                else if (questão.AlternativaA != "" && questão.AlternativaB != "" && questão.AlternativaC != "")
                {
                    if (questão.ValidadeA == true || questão.ValidadeB == true || questão.ValidadeC == true)
                    {
                        objConection.Open();
                        string query = "insert into tb_questoes(area, materia, assunto, banca, enunciado, alternativaA, alternativaB, alternativaC, alternativaD, alternativaE, validadeA, validadeB, validadeC, validadeD, validadeE)";
                        query += "values ('" + questão.Area + "', '" + questão.Materia + "', '" + questão.Assunto + "', '" + questão.Banca + "', '" + questão.Enunciado + "' , '" + questão.AlternativaA + "' , '" + questão.AlternativaB + "' ,";
                        query += "'" + questão.AlternativaC + "' , 'Nao se aplica' , 'Nao se aplica' , '" + Convert.ToByte(questão.ValidadeA) + "' ,'" + Convert.ToByte(questão.ValidadeB) + "' ,'" + Convert.ToByte(questão.ValidadeC) + "' ,'0' ,'0')";
                        OleDbCommand cmd = new OleDbCommand(query, objConection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dado inserido");
                        objConection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Você nao indicou qual é a resposta da questão.");
                    }
                }
                else if (questão.AlternativaA != "" && questão.AlternativaB != "")
                {
                    if (questão.ValidadeA == true || questão.ValidadeB == true)
                    {
                        objConection.Open();
                        string query = "insert into tb_questoes(area, materia, assunto, banca, enunciado, alternativaA, alternativaB, alternativaC, alternativaD, alternativaE, validadeA, validadeB, validadeC, validadeD, validadeE)";
                        query += "values ('" + questão.Area + "', '" + questão.Materia + "', '" + questão.Assunto + "', '" + questão.Banca + "', '" + questão.Enunciado + "' , '" + questão.AlternativaA + "' , '" + questão.AlternativaB + "' ,";
                        query += "'Nao se aplica' , 'Nao se aplica' , 'Nao se aplica' , '" + Convert.ToByte(questão.ValidadeA) + "' ,'" + Convert.ToByte(questão.ValidadeB) + "' ,'0' ,'0' ,'0')";
                        OleDbCommand cmd = new OleDbCommand(query, objConection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dado inserido");
                        objConection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Você nao indicou qual é a resposta da questão.");
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possivel adicionar a questão.\nObserve se todos campos da questão estão preenchidos.");
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
