using ExercicioEscola;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVisual
{
    public partial class FormEscola : Form
    {
        private List<Aluno> alunos;
        private List<Disciplina> disciplinas;
        private List<Avaliacao> avaliacao;

        public FormEscola()
        {
            InitializeComponent();

            this.alunos = new List<Aluno>();
            this.disciplinas = new List<Disciplina>();
            this.avaliacao = new List<Avaliacao>();

            comboAvaAluno.DisplayMember = "Nome";
            comboAvaDisc.DisplayMember = "Nome";
        }

        private void buttonAlunoSalvar_Click(object sender, EventArgs e)
        {
            alunos.Add(new Aluno(alunos.Count +1, txtAlunoNome.Text));
            comboAvaAluno.DataSource = alunos.ToList();
            txtAlunoNome.Text = "";
        }

        private void buttonDiscSalvar_Click(object sender, EventArgs e)
        {
            disciplinas.Add(new Disciplina(disciplinas.Count + 1, txtDiscNome.Text, int.Parse(txtDiscMedia.Text)));
            comboAvaDisc.DataSource = disciplinas.ToList();
            txtDiscNome.Text = "";
            txtDiscMedia.Text = "";
        }

        private void buttonAvaSalvar_Click(object sender, EventArgs e)
        {
            Avaliacao a = new Avaliacao(avaliacao.Count + 1,
                                        (Aluno)comboAvaAluno.SelectedItem,
                                        (Disciplina)comboAvaDisc.SelectedItem,
                                        float.Parse(txtAvaNota.Text));

            avaliacao.Add(a);
            ListViewItem li = new ListViewItem(
                new string[] { a.Aluno.Nome, a.Disciplina.Nome, a.nota.ToString("0.00") }
                );

            listaNotas.Items.Add(li);

        }
    }
}
