using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JogoVelha
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        public void testarVitoria()
        {

            if (botao0.Text == vez && botao3.Text == vez && botao6.Text == vez)
            {
                vitoria = true;
            }
            else if (botao1.Text == vez && botao4.Text == vez && botao7.Text == vez)
            {
                vitoria = true;
            }
            else if (botao2.Text == vez && botao5.Text == vez && botao8.Text == vez)
            {
                vitoria = true;
            }
            else if (botao0.Text == vez && botao1.Text == vez && botao2.Text == vez)
            {
                vitoria = true;
            }
            else if (botao3.Text == vez && botao4.Text == vez && botao5.Text == vez)
            {
                vitoria = true;
            }
            else if (botao6.Text == vez && botao7.Text == vez && botao8.Text == vez)
            {
                vitoria = true;
            }
            else if (botao0.Text == vez && botao4.Text == vez && botao8.Text == vez)
            {
                vitoria = true;
            }
            else if (botao2.Text == vez && botao4.Text == vez && botao6.Text == vez)
            {
                vitoria = true;
            }
        }

        string vez = "X";
        bool vitoria;
        public void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (vez == "X")
            {
                button.IsEnabled = false;
                button.Text = "X";
                testarVitoria();
                vez = "O";
                label_vez.Text = "É a vez do " + vez;
                if (vitoria == true)
                {

                    DisplayAlert("Mensagem de vencedor", "X GANHOU!!!!!", "Fechar");
                }

            }
            else
            {
                button.IsEnabled = false;
                button.Text = "O";
                testarVitoria();
                vez = "X";
                label_vez.Text = "é a vez do " + vez;
                if (vitoria == true)
                {
                    vez = "O";
                    DisplayAlert("Mensagem de vencedor", "O GANHOU!!!!!", "Fechar");
                }
            }
        }
    }
}
