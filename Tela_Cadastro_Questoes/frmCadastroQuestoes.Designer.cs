namespace Gestor_de_estudos
{
    partial class frmAddQuestao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mstripArquivo = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarQuestãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancaExistenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaBancaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarQuestãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxBanca = new System.Windows.Forms.ComboBox();
            this.cbxAssunto = new System.Windows.Forms.ComboBox();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            this.chekLetraA = new System.Windows.Forms.CheckBox();
            this.chekLetraB = new System.Windows.Forms.CheckBox();
            this.chekLetraE = new System.Windows.Forms.CheckBox();
            this.chekLetraD = new System.Windows.Forms.CheckBox();
            this.chekLetraC = new System.Windows.Forms.CheckBox();
            this.lblLetraE = new System.Windows.Forms.Label();
            this.lblLetraD = new System.Windows.Forms.Label();
            this.lblLetraC = new System.Windows.Forms.Label();
            this.lblLetraB = new System.Windows.Forms.Label();
            this.lblLetraA = new System.Windows.Forms.Label();
            this.domainAlternativas = new System.Windows.Forms.DomainUpDown();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.btnAddQuestao = new System.Windows.Forms.Button();
            this.btnReeditarQuestao = new System.Windows.Forms.Button();
            this.btnCancelarAdicao = new System.Windows.Forms.Button();
            this.mstripArquivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstripArquivo
            // 
            this.mstripArquivo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mstripArquivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.ajudaToolStripMenuItem1});
            this.mstripArquivo.Location = new System.Drawing.Point(0, 0);
            this.mstripArquivo.Name = "mstripArquivo";
            this.mstripArquivo.Size = new System.Drawing.Size(629, 24);
            this.mstripArquivo.TabIndex = 0;
            this.mstripArquivo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mstripArquivo_ItemClicked);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarQuestãoToolStripMenuItem,
            this.editarQuestãoToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // adicionarQuestãoToolStripMenuItem
            // 
            this.adicionarQuestãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancaExistenteToolStripMenuItem,
            this.novaBancaToolStripMenuItem});
            this.adicionarQuestãoToolStripMenuItem.Name = "adicionarQuestãoToolStripMenuItem";
            this.adicionarQuestãoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.adicionarQuestãoToolStripMenuItem.Text = "Adicionar Questão";
            // 
            // bancaExistenteToolStripMenuItem
            // 
            this.bancaExistenteToolStripMenuItem.Name = "bancaExistenteToolStripMenuItem";
            this.bancaExistenteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.bancaExistenteToolStripMenuItem.Text = "Banca Existente";
            // 
            // novaBancaToolStripMenuItem
            // 
            this.novaBancaToolStripMenuItem.Name = "novaBancaToolStripMenuItem";
            this.novaBancaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.novaBancaToolStripMenuItem.Text = "Nova Banca";
            // 
            // editarQuestãoToolStripMenuItem
            // 
            this.editarQuestãoToolStripMenuItem.Name = "editarQuestãoToolStripMenuItem";
            this.editarQuestãoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.editarQuestãoToolStripMenuItem.Text = "Editar Questão";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.salvarToolStripMenuItem.Text = "Salvar ";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ajudaToolStripMenuItem.Text = "Formatar";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem1.Text = "Ajuda";
            // 
            // cbxBanca
            // 
            this.cbxBanca.FormattingEnabled = true;
            this.cbxBanca.Items.AddRange(new object[] {
            "CESPE"});
            this.cbxBanca.Location = new System.Drawing.Point(12, 27);
            this.cbxBanca.Name = "cbxBanca";
            this.cbxBanca.Size = new System.Drawing.Size(120, 21);
            this.cbxBanca.TabIndex = 2;
            this.cbxBanca.Text = "Selecione a Banca";
            // 
            // cbxAssunto
            // 
            this.cbxAssunto.FormattingEnabled = true;
            this.cbxAssunto.Items.AddRange(new object[] {
            "História do Brasil"});
            this.cbxAssunto.Location = new System.Drawing.Point(247, 29);
            this.cbxAssunto.Name = "cbxAssunto";
            this.cbxAssunto.Size = new System.Drawing.Size(153, 21);
            this.cbxAssunto.TabIndex = 3;
            this.cbxAssunto.Text = "Assunto";
            // 
            // cbxArea
            // 
            this.cbxArea.FormattingEnabled = true;
            this.cbxArea.Items.AddRange(new object[] {
            "Humanas"});
            this.cbxArea.Location = new System.Drawing.Point(138, 27);
            this.cbxArea.Name = "cbxArea";
            this.cbxArea.Size = new System.Drawing.Size(103, 21);
            this.cbxArea.TabIndex = 4;
            this.cbxArea.Text = "Area";
            // 
            // cbxMateria
            // 
            this.cbxMateria.AutoCompleteCustomSource.AddRange(new string[] {
            "História"});
            this.cbxMateria.FormattingEnabled = true;
            this.cbxMateria.Items.AddRange(new object[] {
            "História"});
            this.cbxMateria.Location = new System.Drawing.Point(406, 29);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(73, 21);
            this.cbxMateria.TabIndex = 5;
            this.cbxMateria.Text = "Matéria";
            // 
            // chekLetraA
            // 
            this.chekLetraA.AutoSize = true;
            this.chekLetraA.Location = new System.Drawing.Point(12, 141);
            this.chekLetraA.Name = "chekLetraA";
            this.chekLetraA.Size = new System.Drawing.Size(36, 17);
            this.chekLetraA.TabIndex = 6;
            this.chekLetraA.Text = "A)";
            this.chekLetraA.UseVisualStyleBackColor = true;
            // 
            // chekLetraB
            // 
            this.chekLetraB.AutoSize = true;
            this.chekLetraB.Location = new System.Drawing.Point(12, 166);
            this.chekLetraB.Name = "chekLetraB";
            this.chekLetraB.Size = new System.Drawing.Size(36, 17);
            this.chekLetraB.TabIndex = 7;
            this.chekLetraB.Text = "B)";
            this.chekLetraB.UseVisualStyleBackColor = true;
            // 
            // chekLetraE
            // 
            this.chekLetraE.AutoSize = true;
            this.chekLetraE.Location = new System.Drawing.Point(12, 235);
            this.chekLetraE.Name = "chekLetraE";
            this.chekLetraE.Size = new System.Drawing.Size(36, 17);
            this.chekLetraE.TabIndex = 8;
            this.chekLetraE.Text = "E)";
            this.chekLetraE.UseVisualStyleBackColor = true;
            // 
            // chekLetraD
            // 
            this.chekLetraD.AutoSize = true;
            this.chekLetraD.Location = new System.Drawing.Point(12, 212);
            this.chekLetraD.Name = "chekLetraD";
            this.chekLetraD.Size = new System.Drawing.Size(37, 17);
            this.chekLetraD.TabIndex = 9;
            this.chekLetraD.Text = "D)";
            this.chekLetraD.UseVisualStyleBackColor = true;
            // 
            // chekLetraC
            // 
            this.chekLetraC.AutoSize = true;
            this.chekLetraC.Location = new System.Drawing.Point(12, 189);
            this.chekLetraC.Name = "chekLetraC";
            this.chekLetraC.Size = new System.Drawing.Size(36, 17);
            this.chekLetraC.TabIndex = 10;
            this.chekLetraC.Text = "C)";
            this.chekLetraC.UseVisualStyleBackColor = true;
            // 
            // lblLetraE
            // 
            this.lblLetraE.AutoSize = true;
            this.lblLetraE.Location = new System.Drawing.Point(54, 238);
            this.lblLetraE.Name = "lblLetraE";
            this.lblLetraE.Size = new System.Drawing.Size(67, 13);
            this.lblLetraE.TabIndex = 14;
            this.lblLetraE.Text = "Alternativa E";
            // 
            // lblLetraD
            // 
            this.lblLetraD.AutoSize = true;
            this.lblLetraD.Location = new System.Drawing.Point(55, 215);
            this.lblLetraD.Name = "lblLetraD";
            this.lblLetraD.Size = new System.Drawing.Size(67, 13);
            this.lblLetraD.TabIndex = 15;
            this.lblLetraD.Text = "Alternativa E";
            // 
            // lblLetraC
            // 
            this.lblLetraC.AutoSize = true;
            this.lblLetraC.Location = new System.Drawing.Point(55, 192);
            this.lblLetraC.Name = "lblLetraC";
            this.lblLetraC.Size = new System.Drawing.Size(67, 13);
            this.lblLetraC.TabIndex = 16;
            this.lblLetraC.Text = "Alternativa C";
            // 
            // lblLetraB
            // 
            this.lblLetraB.AutoSize = true;
            this.lblLetraB.Location = new System.Drawing.Point(55, 169);
            this.lblLetraB.Name = "lblLetraB";
            this.lblLetraB.Size = new System.Drawing.Size(67, 13);
            this.lblLetraB.TabIndex = 17;
            this.lblLetraB.Text = "Alternativa B";
            // 
            // lblLetraA
            // 
            this.lblLetraA.AutoSize = true;
            this.lblLetraA.Location = new System.Drawing.Point(55, 142);
            this.lblLetraA.Name = "lblLetraA";
            this.lblLetraA.Size = new System.Drawing.Size(67, 13);
            this.lblLetraA.TabIndex = 18;
            this.lblLetraA.Text = "Alternativa A";
            // 
            // domainAlternativas
            // 
            this.domainAlternativas.Items.Add("Uma alternativa");
            this.domainAlternativas.Items.Add("Duas alternativas");
            this.domainAlternativas.Items.Add("Três alernativas");
            this.domainAlternativas.Items.Add("Quatro alternativas");
            this.domainAlternativas.Items.Add("Cinco alternativas");
            this.domainAlternativas.Location = new System.Drawing.Point(485, 29);
            this.domainAlternativas.Name = "domainAlternativas";
            this.domainAlternativas.Size = new System.Drawing.Size(132, 20);
            this.domainAlternativas.TabIndex = 19;
            this.domainAlternativas.Text = "Alternativas";
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Location = new System.Drawing.Point(14, 51);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(58, 13);
            this.lblEnunciado.TabIndex = 20;
            this.lblEnunciado.Text = "Enunciado";
            // 
            // btnAddQuestao
            // 
            this.btnAddQuestao.BackColor = System.Drawing.Color.Red;
            this.btnAddQuestao.Location = new System.Drawing.Point(330, 265);
            this.btnAddQuestao.Name = "btnAddQuestao";
            this.btnAddQuestao.Size = new System.Drawing.Size(75, 23);
            this.btnAddQuestao.TabIndex = 21;
            this.btnAddQuestao.Text = "ADICIONAR";
            this.btnAddQuestao.UseVisualStyleBackColor = false;
            this.btnAddQuestao.Click += new System.EventHandler(this.btnAddQuestao_Click);
            // 
            // btnReeditarQuestao
            // 
            this.btnReeditarQuestao.BackColor = System.Drawing.Color.Red;
            this.btnReeditarQuestao.Location = new System.Drawing.Point(249, 265);
            this.btnReeditarQuestao.Name = "btnReeditarQuestao";
            this.btnReeditarQuestao.Size = new System.Drawing.Size(75, 23);
            this.btnReeditarQuestao.TabIndex = 22;
            this.btnReeditarQuestao.Text = "REEDITAR";
            this.btnReeditarQuestao.UseVisualStyleBackColor = false;
            // 
            // btnCancelarAdicao
            // 
            this.btnCancelarAdicao.BackColor = System.Drawing.Color.Red;
            this.btnCancelarAdicao.Location = new System.Drawing.Point(168, 265);
            this.btnCancelarAdicao.Name = "btnCancelarAdicao";
            this.btnCancelarAdicao.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAdicao.TabIndex = 23;
            this.btnCancelarAdicao.Text = "CANCELAR";
            this.btnCancelarAdicao.UseVisualStyleBackColor = false;
            // 
            // frmAddQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(629, 300);
            this.Controls.Add(this.btnCancelarAdicao);
            this.Controls.Add(this.btnReeditarQuestao);
            this.Controls.Add(this.btnAddQuestao);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.domainAlternativas);
            this.Controls.Add(this.lblLetraA);
            this.Controls.Add(this.lblLetraB);
            this.Controls.Add(this.lblLetraC);
            this.Controls.Add(this.lblLetraD);
            this.Controls.Add(this.lblLetraE);
            this.Controls.Add(this.chekLetraC);
            this.Controls.Add(this.chekLetraD);
            this.Controls.Add(this.chekLetraE);
            this.Controls.Add(this.chekLetraB);
            this.Controls.Add(this.chekLetraA);
            this.Controls.Add(this.cbxMateria);
            this.Controls.Add(this.cbxArea);
            this.Controls.Add(this.cbxAssunto);
            this.Controls.Add(this.cbxBanca);
            this.Controls.Add(this.mstripArquivo);
            this.MainMenuStrip = this.mstripArquivo;
            this.Name = "frmAddQuestao";
            this.Text = "Adicionar questões ao banco";
            this.mstripArquivo.ResumeLayout(false);
            this.mstripArquivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstripArquivo;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarQuestãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarQuestãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancaExistenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaBancaToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxBanca;
        private System.Windows.Forms.ComboBox cbxAssunto;
        private System.Windows.Forms.ComboBox cbxArea;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.CheckBox chekLetraA;
        private System.Windows.Forms.CheckBox chekLetraB;
        private System.Windows.Forms.CheckBox chekLetraE;
        private System.Windows.Forms.CheckBox chekLetraD;
        private System.Windows.Forms.CheckBox chekLetraC;
        private System.Windows.Forms.Label lblLetraE;
        private System.Windows.Forms.Label lblLetraD;
        private System.Windows.Forms.Label lblLetraC;
        private System.Windows.Forms.Label lblLetraB;
        private System.Windows.Forms.Label lblLetraA;
        private System.Windows.Forms.DomainUpDown domainAlternativas;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Button btnAddQuestao;
        private System.Windows.Forms.Button btnReeditarQuestao;
        private System.Windows.Forms.Button btnCancelarAdicao;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
    }
}

