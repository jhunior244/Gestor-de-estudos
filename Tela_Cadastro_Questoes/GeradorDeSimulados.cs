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
        private List<Questao> listaRetornadaBD;
        public List<Questao> ListaRetornadaBD { get { return this.listaRetornadaBD; } }
        private Questao[] simulado;
        public Questao[] Simulado { get { return this.simulado; } }
        private int contQuest = -1;
        private bool iniciarSimul;
        public bool IniciarSimul { get { return this.iniciarSimul; } }
        public int indexQuestoes = -1;
        public void BuscarQuestoes(OleDbConnection objConection, string ban, string ar, string assun, string mat)
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
                
                if (dataReader.HasRows)
                {
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
                    this.iniciarSimul = true;
                    System.Windows.Forms.MessageBox.Show("Para iniciar o seu simulado clique no botão iniciar!");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Não foram encontradas questões com os parametros procurados.");
                }
                objConection.Close();                              
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show(erro.Message);
                objConection.Close();
            }
        }
        public void selectQuestoes(int numQuestoes)
        {
            simulado = new Questao[numQuestoes];
            if (simulado.Length < listaRetornadaBD.Count)
            {
                Random random = new Random();
                int aux = 0;
                while (aux < numQuestoes)
                {
                    int posQuestao = random.Next(listaRetornadaBD.Count);
                    if (!questaoJaAcicionada(listaRetornadaBD[posQuestao].IdQuest))//verifica se a questao sorteada ja foi adicionada
                    {
                        simulado[aux] = listaRetornadaBD[posQuestao];
                        aux++;
                    }
                }
            }
            else
            {
                for(int i = 0; i < simulado.Length; i++)
                {
                    simulado[i] = listaRetornadaBD[i];
                }
            }                      
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
        public void exibirQuestaoSemResposta(ControleExibeQuestao controle)
        {
            controle.ExibeQuestao(Simulado[indexQuestoes]);           
        }
    }
}

