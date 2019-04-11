using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App3.modelos;


namespace App3
{
	public partial class MainPage : ContentPage
	{
        // vetor de Professor
        Professor[] professores = new Professor[4]
        {
            new Professor("Maria",1),
            new Professor("José",2),
            new Professor("Gabriel",3),
            new Professor("Marcia",4)
        };
        // vetor de  Disciplinas 
        Disciplina[] disciplinas = new Disciplina[4]
        {
            new Disciplina("Calculo 1",1,1),
            new Disciplina("Física",2,2),
            new Disciplina("Programação",3,3),
            new Disciplina("Calculo 2",4,4)
        };

		public MainPage()
        {
            InitializeComponent();
            //para todos professores do vetor
            foreach (Professor professor in professores)
            {
                Picker2.Items.Add(professor.codigo + " - " + professor.nome);
            }

            foreach (Disciplina disciplina in disciplinas)
            {
                Picker.Items.Add(disciplina.professor + " - " + disciplina.nome);
            }
        }
        void OnButtonClicked(object sender, EventArgs args)
        {
            Label1.IsVisible = false;
            Label2.IsVisible = false;
            Label3.IsVisible = false;
            Label4.IsVisible = false;

            if (Entry1.Text != null &&
                Entry2.Text != null &&
                Entry1.Text.Length > 0 &&
                Entry2.Text.Length > 0 &&
                Picker.SelectedIndex >= 0 &&
                Picker2.SelectedIndex >= 0)
            {
                Disciplina disciplina = disciplinas[Picker.SelectedIndex];
                Professor professor = professores[Picker2.SelectedIndex];
                if (disciplina.Lecionar(professor))
                {
                    Aluno aluno = new Aluno();
                    aluno.matricula = Entry1.Text;
                    Nota nota = new Nota(disciplina.nome, aluno.matricula, int.Parse(Entry2.Text));
                    if (nota.Aprovar())
                    {
                        Label1.IsVisible = true;
                        Label3.IsVisible = true;
                    }
                    else
                    {
                        Label1.IsVisible = true;
                        Label4.IsVisible = true;

                    }
                }
                else {
                    Label2.IsVisible = true;
                }
            }else
            {
                Label2.IsVisible = true;
            }

        }
    }
}
