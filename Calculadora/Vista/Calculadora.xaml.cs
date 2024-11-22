using System.Diagnostics;

namespace Calculadora.Vista;

public partial class Calculadora : ContentPage
{
	public Calculadora()
	{
		InitializeComponent();
	}

    private void OnCalcularClicked(object sender, EventArgs e)
    {
        float altura = float.Parse(Ealtura.Text);
        float peso = float.Parse(Epeso.Text);

        float alturaM = altura / 100;

        float total = peso / (alturaM * alturaM);

        if (total < 18.5)
        {
            indice.Text = "Tu IMC está inferior al normal: " + total.ToString("F2");
        }
        else if (total > 18.5 && total < 24.9)
        {
            indice.Text = "Tu IMC está normal: " + total.ToString("F2");
        }
        else if (total > 25 && total < 29.9)
        {
            indice.Text = "Tu IMC indica obesidad I: " + total.ToString("F2");
        }
        else if (total > 30 && total < 34.9)
        {
            indice.Text = "Tu IMC indica obesidad II: " + total.ToString("F2");
        }
        else if (total > 40)
        {
            indice.Text = "Tu IMC indica obesidad III: " + total.ToString("F2");
        }


    }

    private void OnSalirClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}