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
            label1.MaximumSize = new Size(300, 0);
            label1.AutoSize = true;
            label1.Location = new Point(16, 5);
            label1.Text = "Complete  frase com uma das alternativas abaixo. Quem descobriu o Brasil: Pedro alvares Ca";

            label2.MaximumSize = new Size(100, 0);
            label2.AutoSize = true;

            radioButton1.Location = new Point(4, label1.Bottom + 10);
            label2.Text = "A) Bral vamos ver se isso tambem vai funcionar";
            label2.Location = new Point(radioButton1.Width + 5, label1.Bottom + 10);

            radioButton2.Location = new Point(4, label2.Bottom + 10);
            label3.Text = "B) Brel";
            label3.Location = new Point(radioButton2.Width + 5, label2.Bottom + 10);

            radioButton3.Location = new Point(4, label3.Bottom + 10);
            label4.Text = "C) Bril";
            label4.Location = new Point(radioButton3.Width + 5, label3.Bottom + 10);

            radioButton4.Location = new Point(4, label4.Bottom + 10);
            label5.MaximumSize = new Size(160, 0);
            label5.AutoSize = true;
            label5.Text = "D) Brol esse negocio ainda vai ser muito foda e eu vou ter ogulho de ter gastado tanto tempo nesse prototipo. Deus me abençoe nesse programa que está ficando lindo";
            label5.Location = new Point(radioButton4.Width + 5, label4.Bottom + 10);

            radioButton5.Location = new Point(4, label5.Bottom + 10);
            label6.MaximumSize = new Size(50, 0);
            label6.AutoSize = true;
            label6.Text = "E) Brul label para teste das barras de rolagem para acabar de vez com essa treta que esta me matando                    dddddddddddddddsaffsdfsdfsdfsdfsfsadfsadfsdfsdfwe rwerw trter tret gdsfgdsf gdsf grtr e tert ewrt wert ewrt rewt wret rewtregrevrtgrtgrtgrevgrweqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqrtegvfdgretgfgvgfdgertv tr tfffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffdddddd";
            label6.Text += "\n\n";
            label6.Location = new Point(radioButton5.Width + 5, label5.Bottom + 10);
        }
    }
}
