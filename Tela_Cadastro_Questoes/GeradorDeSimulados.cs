using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_Cadastro_Questoes
{
    class GeradorDeSimulados
    {
        List<Questao> listaRetornadaBD;
        private Questao[] simulado;
        public Questao[] Simulado { get { return this.simulado; } }
        int contQuest = -1;
        public void BuscarQuestoes(OleDbConnection objConection, int num, string ban, string ar, string assun, string mat)
        {
            listaRetornadaBD = new List<Questao>();
            DataSet ds = new DataSet();
            if (ban == "")
            {
                ban = "Não tem";
            }
            if (mat == "")
            {
                mat = "Não tem";
            }
            if (assun == "")
            {
                assun = "Não tem";
            }
            if (ar == "")
            {
                ar = "Não tem";
            }
            try
            {
                objConection.Open();
                string query = "select enunciado, alternativaA, alternativaB, alternativaC, alternativaD, alternativaE, validadeA, validadeB, validadeC, validadeD, validadeE, idQuest from tb_questoes where banca = '" + ban + "' and area = '" + ar + "' and assunto = '" + assun + "' and materia = '" + mat + "' ";
                OleDbCommand cmm = new OleDbCommand();
                cmm.CommandText = query;
                cmm.CommandType = CommandType.Text;
                cmm.Connection = objConection;
                OleDbDataReader dataReader = cmm.ExecuteReader();
                while (dataReader.Read())
                {
                    string enun = dataReader.GetString(0);
                    string a = dataReader.GetString(1);
                    string b = dataReader.GetString(2);
                    string c = dataReader.GetString(3);
                    string d = dataReader.GetString(4);
                    string e = dataReader.GetString(5);
                    bool ra = dataReader.GetBoolean(6);
                    bool rb = dataReader.GetBoolean(7);
                    bool rc = dataReader.GetBoolean(8);
                    bool rd = dataReader.GetBoolean(9);
                    bool re = dataReader.GetBoolean(10);
                    int id = dataReader.GetInt32(11);
                    Questao questao = new Questao(id, enun, a, b, c, d, e, ra, rb, rc, rd, re);
                    listaRetornadaBD.Add(questao);
                }
                objConection.Close();
                selectQuestoes(listaRetornadaBD, num);               
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show(erro.Message);
            }
        }
        private Questao[] selectQuestoes(List<Questao> lista, int numQuestoes)
        {
            simulado = new Questao[numQuestoes];
            Random random = new Random();
            int aux = 0;
            while (aux < numQuestoes)
            {
                int posQuestao = random.Next(lista.Count);
                if (!questaoJaAcicionada(lista[posQuestao].IdQuest))//verifica se a questao sorteada ja foi adicionada
                {
                    simulado[aux] = lista[posQuestao];
                    aux++;
                }
            }
            return simulado;
        }
        private bool questaoJaAcicionada(int id)
        {
            for (int i = 0; i < simulado.Length; i++)
            {
                if(simulado[i] != null)
                {
                    if (id == simulado[i].IdQuest)
                    {
                        return true;
                    }
                }             
            }
            return false;
        }
        public Questao questAtual()
        {
            if(contQuest < simulado.Length -1)
            {
                contQuest++;
                return Simulado[contQuest];
                
            }
            else { return null; }
        }
    }
}
