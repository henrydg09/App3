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
		public MainPage()
        {
            InitializeComponent();
            
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
                if (Picker.SelectedIndex == Picker2.SelectedIndex)
                {
                    int Matricula = int.Parse(Entry1.Text);
                    int Nota = int.Parse(Entry2.Text);
                    if (Nota >= 6)
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



            }
            else
            {

                Label2.IsVisible = true;

            }





        }
    }
}
