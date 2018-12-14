using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_estudos
{
    public partial class frmAddQuestao : Form
    {
        public frmAddQuestao()
        {
            InitializeComponent();
            lblEnunciado.Text = "Quem descobriu o Brasil? Pedro alvares Ca...";
            lblLetraA.Text = "bral";
            lblLetraB.Text = "brel";
            lblLetraC.Text = "bril";
            lblLetraD.Text = "brol";
            lblLetraE.Text = "brul";
        }

        private void mstripArquivo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddQuestao_Click(object sender, EventArgs e)
        {
            frmInicial frm = new frmInicial();
            frm.Show();

        }
    }
}
