using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        // vetor de disciplinas
        Disciplina[] disciplinas = new Disciplina[4]
        {
            new Disciplina("Cálculo 1", 1),
            new Disciplina("Introdução a Engenharia", 2),
            new Disciplina("Cálculo 2", 3),
            new Disciplina("Projetos de Engenharia", 4)
        };

        public MainPage()
        {
            InitializeComponent();
            // para todos as disciplinas do vetor
            foreach (Disciplina disciplina in disciplinas)
            {
                // adicionar um elemento na caixa de seleção
                Picker.Items.Add(disciplina.semestre + " - " + disciplina.nome);
            }
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            // desabilitar mensagens
            Label1.IsVisible = false;
            Label2.IsVisible = false;
            // verificar se período e semestre foram selecionados
            if (Entry2.Text != null &&
                Entry2.Text.Length > 0 &&
                Picker.SelectedIndex >= 0)
            {
                // criar objeto aluno
                Aluno aluno = new Aluno();
                // modificar o período do aluno de acordo com o texto
                aluno.periodo = int.Parse(Entry2.Text);
                // verificar se os valores são iguais
                if (aluno.periodo == disciplinas[Picker.SelectedIndex].semestre)
                {
                    // habilitar mensagem de erro
                    Label1.IsVisible = true;
                }
                else
                {
                    // habilitar mensagem de erro
                    Label2.IsVisible = true;
                }
            }
            else
            {
                // habilitar mensagem de erro
                Label2.IsVisible = true;
            }

        }

    }
}
