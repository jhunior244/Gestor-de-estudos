using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_Cadastro_Questoes
{
    class Questoes
    {
        private int idQuest;
        private string area;
        public string Area { get { return (this.area); } }

        private string materia;
        public string Materia { get { return (this.materia); } }

        private string assunto;
        public string Assunto { get { return (this.assunto); } }

        private string banca;
        public string Banca { get { return (this.banca); } }

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

        public Questoes(string ar, string mat, string assun, string banc, string enun, string A, string B, string C, string D, string E, bool valA, bool valB, bool valC, bool valD, bool valE)
        {
            this.area = ar;
            this.materia = mat;
            this.assunto = assun;
            this.banca = banc;
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
    }
}
