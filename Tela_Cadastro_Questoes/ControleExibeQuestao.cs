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
            label1.MaximumSize = new Size(580, 0);
            label1.AutoSize = true;
            label1.Location = new Point(5, 5);
            label1.Text = "A África Ocidental é conhecida pela dinâmica das suas mulheres comerciantes, caracterizadas pela perícia, autonomia e mobilidade. A sua presença, que fora atestada por viajantes e por missionários portugueses que visitaram a costa a partir do século XV, consta também na ampla documentação sobre a região. A literatura é rica em referências às grandes mulheres como as vendedoras ambulantes, cujo jeito para o negócio, bem como a autonomia e mobilidade, é tão típico da região. HAVIK, P.Dinâmicas e assimetrias afro-atlânticas: a agência feminina e representações em mudança na Guiné(séculos XIX e XX).In: PANTOJA, S. (Org.). Identidades, memórias e histórias em terras africanas. Brasília: LGE; Luanda: Nzila, 2006. A abordagem realizada pelo autor sobre a vida social da África Ocidental pode ser relacionada a uma característica marcante das cidades no Brasil escravista nos séculos XVIII e XIX, que se observa pela";

            label2.MaximumSize = new Size(580, 0);
            label2.AutoSize = true;
            radioButton1.Location = new Point(4, label1.Bottom + 10);
            label2.Text = "A) restrição à realização do comércio ambulante por africanos escravizados e seus descendentes.";
            label2.Location = new Point(radioButton1.Width + 5, label1.Bottom + 10);

            label3.MaximumSize = new Size(580, 0);
            label3.AutoSize = true;
            radioButton2.Location = new Point(4, label2.Bottom + 10);
            label3.Text = "B) convivência entre homens e mulheres livres, de diversas origens, no pequeno comércio.";
            label3.Location = new Point(radioButton2.Width + 5, label2.Bottom + 10);

            label4.MaximumSize = new Size(580, 0);
            label4.AutoSize = true;
            radioButton3.Location = new Point(4, label3.Bottom + 10);
            label4.Text = "C) presença de mulheres negras no comércio de rua de diversos produtos e alimentos.";
            label4.Location = new Point(radioButton3.Width + 5, label3.Bottom + 10);

            label5.MaximumSize = new Size(580, 0);
            label5.AutoSize = true;
            radioButton4.Location = new Point(4, label4.Bottom + 10);            
            label5.Text = "D) dissolução dos hábitos culturais trazidos do continente de origem dos escravizados.";
            label5.Location = new Point(radioButton4.Width + 5, label4.Bottom + 10);

            label6.MaximumSize = new Size(580, 0);
            label6.AutoSize = true;
            radioButton5.Location = new Point(4, label5.Bottom + 10);
            label6.Text = "entrada de imigrantes portugueses nas atividades ligadas ao pequeno comércio urbano.";
            label6.Text += "\n\n";
            label6.Location = new Point(radioButton5.Width + 5, label5.Bottom + 10);
        }
    }
}
