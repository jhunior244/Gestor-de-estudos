using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_Cadastro_Questoes
{
    public partial class ControleExibeQuestao : UserControl
    {
        public ControleExibeQuestao()
        {
            InitializeComponent();
            label1.MaximumSize = new Size(510, 0);
            label1.AutoSize = true;
            this.Visible = false;          
            label2.MaximumSize = new Size(500, 0);
            label2.AutoSize = true;           
            label3.MaximumSize = new Size(500, 0);
            label3.AutoSize = true;            
            label4.MaximumSize = new Size(500, 0);
            label4.AutoSize = true;            
            label5.MaximumSize = new Size(500, 0);
            label5.AutoSize = true;          
            label6.MaximumSize = new Size(500, 0);
            label6.AutoSize = true;
            
        }
        public void ExibeQuestao(Questao questao)
        {
            this.Visible = true;
            label1.Location = new Point(0, 5);
            label1.Text = questao.Enunciado;

            rdbA.Location = new Point(4, label1.Bottom + 14);
            label2.Text = "A) " + questao.AlternativaA;
            label2.Location = new Point(rdbA.Width + 5, label1.Bottom + 10);

            rdbB.Location = new Point(4, label2.Bottom + 14);
            label3.Text = "B) " + questao.AlternativaB;
            label3.Location = new Point(rdbB.Width + 5, label2.Bottom + 10);

            if (questao.AlternativaC != "Nao se aplica")
            {
                rdbC.Location = new Point(4, label3.Bottom + 14);
                label4.Text = "C) " + questao.AlternativaC;
                label4.Location = new Point(rdbC.Width + 5, label3.Bottom + 10);
                label4.Visible = true;
                rdbC.Visible = true;
            }

            if (questao.AlternativaD != "Nao se aplica")
            {
                rdbD.Location = new Point(4, label4.Bottom + 14);
                label5.Text = "D) " + questao.AlternativaD;
                label5.Location = new Point(rdbD.Width + 5, label4.Bottom + 10);
                label5.Visible = true;
                rdbD.Visible = true;
            }

            if (questao.AlternativaE != "Nao se aplica")
            {
                rdbE.Location = new Point(4, label5.Bottom + 14);
                label6.Text = "E) " + questao.AlternativaE;
                label6.Text += "\n\n";
                label6.Location = new Point(rdbE.Width + 5, label5.Bottom + 10);
                label6.Visible = true;
                rdbE.Visible = true;
            }                       
        }
    }
}
