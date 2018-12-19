using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_Cadastro_Questoes
{
    public class Questao
    {
        private int idQuest;
        public int IdQuest { get { return this.idQuest; } }
        private string area;
        private string materia;
        private string assunto;
        private string banca;
        public string Area { get => area; set => area = value; }
        public string Materia { get => materia; set => materia = value; }
        public string Assunto { get => assunto; set => assunto = value; }
        public string Banca { get => banca; set => banca = value; }

        private string enunciado;
        public string Enunciado { get { return (this.enunciado); } }

        private string alternativaA;
        public string AlternativaA { get { return (this.alternativaA); } }

        private string alternativaB;
        public string AlternativaB { get { return (this.alternativaB); } }

        private string alternativaC;
        public string AlternativaC { get { return (this.alternativaC); } }

        private string alternativaD;
        public string AlternativaD { get { return (this.alternativaD); } }

        private string alternativaE;
        public string AlternativaE { get { return (this.alternativaE); } }

        private bool validadeA;
        public bool ValidadeA { get { return (this.validadeA); } }

        private bool validadeB;
        public bool ValidadeB { get { return (this.validadeB); } }

        private bool validadeC;
        public bool ValidadeC { get { return (this.validadeC); } }

        private bool validadeD;
        public bool ValidadeD { get { return (this.validadeD); } }

        private bool validadeE;
        public bool ValidadeE { get { return (this.validadeE); } }

        public Questao(string ar, string mat, string assun, string banc, string enun, string A, string B, string C, string D, string E, bool valA, bool valB, bool valC, bool valD, bool valE)
        {
            this.Area = ar;
            this.Materia = mat;
            this.Assunto = assun;
            this.Banca = banc;
            this.enunciado = enun;
            this.alternativaA = A;
            this.alternativaB = B;
            this.alternativaC = C;
            this.alternativaD = D;
            this.alternativaE = E;
            this.validadeA = valA;
            this.validadeB = valB;
            this.validadeC = valC;
            this.validadeD = valD;
            this.validadeE = valE;
        }
        public Questao(int id, string enun, string letraA, string letraB, string letraC, string letraD, string letraE, bool valA, bool valB,bool valC, bool valD, bool valE)
        {
            this.idQuest = id;
            this.enunciado = enun;
            this.alternativaA = letraA;
            this.alternativaB = letraB;
            this.alternativaC = letraC;
            this.alternativaD = letraD;
            this.alternativaE = letraE;
            this.validadeA = valA;
            this.validadeB = valB;
            this.validadeC = valC;
            this.validadeD = valD;
            this.validadeE = valE;
        }
        public Questao(bool c)
        {

        }
    }
}
