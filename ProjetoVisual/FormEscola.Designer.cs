namespace ProjetoVisual
{
    partial class FormEscola
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupAlunos = new System.Windows.Forms.GroupBox();
            this.buttonAlunoSalvar = new System.Windows.Forms.Button();
            this.txtAlunoNome = new System.Windows.Forms.TextBox();
            this.labelAlunoNome = new System.Windows.Forms.Label();
            this.groupDisciplinas = new System.Windows.Forms.GroupBox();
            this.buttonDiscSalvar = new System.Windows.Forms.Button();
            this.txtDiscMedia = new System.Windows.Forms.TextBox();
            this.labelDiscMedia = new System.Windows.Forms.Label();
            this.txtDiscNome = new System.Windows.Forms.TextBox();
            this.labelDiscNome = new System.Windows.Forms.Label();
            this.groupAvaliacoes = new System.Windows.Forms.GroupBox();
            this.listaNotas = new System.Windows.Forms.ListView();
            this.columnAvaAluno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAvaDisc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAvaNota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAvaSalvar = new System.Windows.Forms.Button();
            this.txtAvaNota = new System.Windows.Forms.TextBox();
            this.comboAvaDisc = new System.Windows.Forms.ComboBox();
            this.labelAvaNota = new System.Windows.Forms.Label();
            this.labelAvaDisc = new System.Windows.Forms.Label();
            this.labelAvaAluno = new System.Windows.Forms.Label();
            this.comboAvaAluno = new System.Windows.Forms.ComboBox();
            this.buttonFecharAno = new System.Windows.Forms.Button();
            this.groupAlunos.SuspendLayout();
            this.groupDisciplinas.SuspendLayout();
            this.groupAvaliacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupAlunos
            // 
            this.groupAlunos.Controls.Add(this.buttonAlunoSalvar);
            this.groupAlunos.Controls.Add(this.txtAlunoNome);
            this.groupAlunos.Controls.Add(this.labelAlunoNome);
            this.groupAlunos.Location = new System.Drawing.Point(12, 13);
            this.groupAlunos.Name = "groupAlunos";
            this.groupAlunos.Size = new System.Drawing.Size(383, 114);
            this.groupAlunos.TabIndex = 0;
            this.groupAlunos.TabStop = false;
            this.groupAlunos.Text = "Alunos";
            // 
            // buttonAlunoSalvar
            // 
            this.buttonAlunoSalvar.Location = new System.Drawing.Point(267, 62);
            this.buttonAlunoSalvar.Name = "buttonAlunoSalvar";
            this.buttonAlunoSalvar.Size = new System.Drawing.Size(110, 25);
            this.buttonAlunoSalvar.TabIndex = 2;
            this.buttonAlunoSalvar.Text = "Salvar";
            this.buttonAlunoSalvar.UseVisualStyleBackColor = true;
            this.buttonAlunoSalvar.Click += new System.EventHandler(this.buttonAlunoSalvar_Click);
            // 
            // txtAlunoNome
            // 
            this.txtAlunoNome.Location = new System.Drawing.Point(58, 34);
            this.txtAlunoNome.Name = "txtAlunoNome";
            this.txtAlunoNome.Size = new System.Drawing.Size(319, 22);
            this.txtAlunoNome.TabIndex = 1;
            // 
            // labelAlunoNome
            // 
            this.labelAlunoNome.AutoSize = true;
            this.labelAlunoNome.Location = new System.Drawing.Point(7, 37);
            this.labelAlunoNome.Name = "labelAlunoNome";
            this.labelAlunoNome.Size = new System.Drawing.Size(49, 17);
            this.labelAlunoNome.TabIndex = 0;
            this.labelAlunoNome.Text = "Nome:";
            // 
            // groupDisciplinas
            // 
            this.groupDisciplinas.Controls.Add(this.buttonDiscSalvar);
            this.groupDisciplinas.Controls.Add(this.txtDiscMedia);
            this.groupDisciplinas.Controls.Add(this.labelDiscMedia);
            this.groupDisciplinas.Controls.Add(this.txtDiscNome);
            this.groupDisciplinas.Controls.Add(this.labelDiscNome);
            this.groupDisciplinas.Location = new System.Drawing.Point(401, 14);
            this.groupDisciplinas.Name = "groupDisciplinas";
            this.groupDisciplinas.Size = new System.Drawing.Size(383, 114);
            this.groupDisciplinas.TabIndex = 1;
            this.groupDisciplinas.TabStop = false;
            this.groupDisciplinas.Text = "Disciplinas";
            // 
            // buttonDiscSalvar
            // 
            this.buttonDiscSalvar.Location = new System.Drawing.Point(267, 61);
            this.buttonDiscSalvar.Name = "buttonDiscSalvar";
            this.buttonDiscSalvar.Size = new System.Drawing.Size(110, 25);
            this.buttonDiscSalvar.TabIndex = 6;
            this.buttonDiscSalvar.Text = "Salvar";
            this.buttonDiscSalvar.UseVisualStyleBackColor = true;
            this.buttonDiscSalvar.Click += new System.EventHandler(this.buttonDiscSalvar_Click);
            // 
            // txtDiscMedia
            // 
            this.txtDiscMedia.Location = new System.Drawing.Point(58, 62);
            this.txtDiscMedia.Name = "txtDiscMedia";
            this.txtDiscMedia.Size = new System.Drawing.Size(159, 22);
            this.txtDiscMedia.TabIndex = 5;
            // 
            // labelDiscMedia
            // 
            this.labelDiscMedia.AutoSize = true;
            this.labelDiscMedia.Location = new System.Drawing.Point(7, 65);
            this.labelDiscMedia.Name = "labelDiscMedia";
            this.labelDiscMedia.Size = new System.Drawing.Size(50, 17);
            this.labelDiscMedia.TabIndex = 4;
            this.labelDiscMedia.Text = "Média:";
            // 
            // txtDiscNome
            // 
            this.txtDiscNome.Location = new System.Drawing.Point(58, 33);
            this.txtDiscNome.Name = "txtDiscNome";
            this.txtDiscNome.Size = new System.Drawing.Size(319, 22);
            this.txtDiscNome.TabIndex = 3;
            // 
            // labelDiscNome
            // 
            this.labelDiscNome.AutoSize = true;
            this.labelDiscNome.Location = new System.Drawing.Point(7, 36);
            this.labelDiscNome.Name = "labelDiscNome";
            this.labelDiscNome.Size = new System.Drawing.Size(49, 17);
            this.labelDiscNome.TabIndex = 2;
            this.labelDiscNome.Text = "Nome:";
            // 
            // groupAvaliacoes
            // 
            this.groupAvaliacoes.Controls.Add(this.listaNotas);
            this.groupAvaliacoes.Controls.Add(this.buttonAvaSalvar);
            this.groupAvaliacoes.Controls.Add(this.txtAvaNota);
            this.groupAvaliacoes.Controls.Add(this.comboAvaDisc);
            this.groupAvaliacoes.Controls.Add(this.labelAvaNota);
            this.groupAvaliacoes.Controls.Add(this.labelAvaDisc);
            this.groupAvaliacoes.Controls.Add(this.labelAvaAluno);
            this.groupAvaliacoes.Controls.Add(this.comboAvaAluno);
            this.groupAvaliacoes.Location = new System.Drawing.Point(13, 133);
            this.groupAvaliacoes.Name = "groupAvaliacoes";
            this.groupAvaliacoes.Size = new System.Drawing.Size(771, 211);
            this.groupAvaliacoes.TabIndex = 2;
            this.groupAvaliacoes.TabStop = false;
            this.groupAvaliacoes.Text = "Avalicações";
            // 
            // listaNotas
            // 
            this.listaNotas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAvaAluno,
            this.columnAvaDisc,
            this.columnAvaNota});
            this.listaNotas.Location = new System.Drawing.Point(388, 21);
            this.listaNotas.Name = "listaNotas";
            this.listaNotas.Size = new System.Drawing.Size(367, 171);
            this.listaNotas.TabIndex = 8;
            this.listaNotas.UseCompatibleStateImageBehavior = false;
            this.listaNotas.View = System.Windows.Forms.View.Details;
            // 
            // columnAvaAluno
            // 
            this.columnAvaAluno.Text = "Aluno";
            // 
            // columnAvaDisc
            // 
            this.columnAvaDisc.Text = "Disciplina";
            this.columnAvaDisc.Width = 84;
            // 
            // columnAvaNota
            // 
            this.columnAvaNota.Text = "Nota";
            this.columnAvaNota.Width = 82;
            // 
            // buttonAvaSalvar
            // 
            this.buttonAvaSalvar.Location = new System.Drawing.Point(266, 98);
            this.buttonAvaSalvar.Name = "buttonAvaSalvar";
            this.buttonAvaSalvar.Size = new System.Drawing.Size(110, 25);
            this.buttonAvaSalvar.TabIndex = 7;
            this.buttonAvaSalvar.Text = "Salvar";
            this.buttonAvaSalvar.UseVisualStyleBackColor = true;
            this.buttonAvaSalvar.Click += new System.EventHandler(this.buttonAvaSalvar_Click);
            // 
            // txtAvaNota
            // 
            this.txtAvaNota.Location = new System.Drawing.Point(92, 99);
            this.txtAvaNota.Name = "txtAvaNota";
            this.txtAvaNota.Size = new System.Drawing.Size(121, 22);
            this.txtAvaNota.TabIndex = 6;
            // 
            // comboAvaDisc
            // 
            this.comboAvaDisc.FormattingEnabled = true;
            this.comboAvaDisc.Location = new System.Drawing.Point(92, 69);
            this.comboAvaDisc.Name = "comboAvaDisc";
            this.comboAvaDisc.Size = new System.Drawing.Size(284, 24);
            this.comboAvaDisc.TabIndex = 4;
            // 
            // labelAvaNota
            // 
            this.labelAvaNota.AutoSize = true;
            this.labelAvaNota.Location = new System.Drawing.Point(44, 102);
            this.labelAvaNota.Name = "labelAvaNota";
            this.labelAvaNota.Size = new System.Drawing.Size(42, 17);
            this.labelAvaNota.TabIndex = 3;
            this.labelAvaNota.Text = "Nota:";
            // 
            // labelAvaDisc
            // 
            this.labelAvaDisc.AutoSize = true;
            this.labelAvaDisc.Location = new System.Drawing.Point(14, 72);
            this.labelAvaDisc.Name = "labelAvaDisc";
            this.labelAvaDisc.Size = new System.Drawing.Size(72, 17);
            this.labelAvaDisc.TabIndex = 2;
            this.labelAvaDisc.Text = "Disciplina:";
            // 
            // labelAvaAluno
            // 
            this.labelAvaAluno.AutoSize = true;
            this.labelAvaAluno.Location = new System.Drawing.Point(38, 42);
            this.labelAvaAluno.Name = "labelAvaAluno";
            this.labelAvaAluno.Size = new System.Drawing.Size(48, 17);
            this.labelAvaAluno.TabIndex = 1;
            this.labelAvaAluno.Text = "Aluno:";
            // 
            // comboAvaAluno
            // 
            this.comboAvaAluno.FormattingEnabled = true;
            this.comboAvaAluno.Location = new System.Drawing.Point(92, 39);
            this.comboAvaAluno.Name = "comboAvaAluno";
            this.comboAvaAluno.Size = new System.Drawing.Size(284, 24);
            this.comboAvaAluno.TabIndex = 0;
            // 
            // buttonFecharAno
            // 
            this.buttonFecharAno.Location = new System.Drawing.Point(632, 350);
            this.buttonFecharAno.Name = "buttonFecharAno";
            this.buttonFecharAno.Size = new System.Drawing.Size(152, 36);
            this.buttonFecharAno.TabIndex = 3;
            this.buttonFecharAno.Text = "Fechar ano";
            this.buttonFecharAno.UseVisualStyleBackColor = true;
            // 
            // FormEscola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 395);
            this.Controls.Add(this.buttonFecharAno);
            this.Controls.Add(this.groupAvaliacoes);
            this.Controls.Add(this.groupDisciplinas);
            this.Controls.Add(this.groupAlunos);
            this.MaximizeBox = false;
            this.Name = "FormEscola";
            this.Text = "M0001 - Fechamento de ano";
            this.groupAlunos.ResumeLayout(false);
            this.groupAlunos.PerformLayout();
            this.groupDisciplinas.ResumeLayout(false);
            this.groupDisciplinas.PerformLayout();
            this.groupAvaliacoes.ResumeLayout(false);
            this.groupAvaliacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAlunos;
        private System.Windows.Forms.GroupBox groupDisciplinas;
        private System.Windows.Forms.GroupBox groupAvaliacoes;
        private System.Windows.Forms.Label labelAlunoNome;
        private System.Windows.Forms.Button buttonAlunoSalvar;
        private System.Windows.Forms.TextBox txtAlunoNome;
        private System.Windows.Forms.Button buttonDiscSalvar;
        private System.Windows.Forms.TextBox txtDiscMedia;
        private System.Windows.Forms.Label labelDiscMedia;
        private System.Windows.Forms.TextBox txtDiscNome;
        private System.Windows.Forms.Label labelDiscNome;
        private System.Windows.Forms.TextBox txtAvaNota;
        private System.Windows.Forms.ComboBox comboAvaDisc;
        private System.Windows.Forms.Label labelAvaNota;
        private System.Windows.Forms.Label labelAvaDisc;
        private System.Windows.Forms.Label labelAvaAluno;
        private System.Windows.Forms.ComboBox comboAvaAluno;
        private System.Windows.Forms.Button buttonAvaSalvar;
        private System.Windows.Forms.ListView listaNotas;
        private System.Windows.Forms.ColumnHeader columnAvaAluno;
        private System.Windows.Forms.ColumnHeader columnAvaDisc;
        private System.Windows.Forms.ColumnHeader columnAvaNota;
        private System.Windows.Forms.Button buttonFecharAno;
    }
}