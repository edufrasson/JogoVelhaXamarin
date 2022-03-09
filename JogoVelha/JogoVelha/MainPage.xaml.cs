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

        public void resetarJogo()
        {
            botao0.Text = " ";
            botao0.IsEnabled = true;

            botao1.Text = " ";
            botao1.IsEnabled = true;

            botao2.Text = " ";
            botao2.IsEnabled = true;

            botao3.Text = " ";
            botao3.IsEnabled = true;

            botao4.Text = " ";
            botao4.IsEnabled = true;

            botao5.Text = " ";
            botao5.IsEnabled = true;

            botao6.Text = " ";
            botao6.IsEnabled = true;

            botao7.Text = " ";
            botao7.IsEnabled = true;

            botao8.Text = " ";
            botao8.IsEnabled = true;

            vez = "X";
        }

        string vez = "X";
        bool vitoria;
        public async void Button_Clicked(object sender, EventArgs e)
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
                    await DisplayAlert("Mensagem de vencedor", "X GANHOU!!!!!", "Fechar");
                    resetarJogo();
                    vitoria = false;
                    label_vez.Text = "É a vez do " + vez;
                }
                else if(botao0.IsEnabled == false && botao1.IsEnabled == false && botao2.IsEnabled == false && botao3.IsEnabled == false && botao4.IsEnabled == false && botao5.IsEnabled == false && botao6.IsEnabled == false && botao7.IsEnabled == false && botao8.IsEnabled == false)
                {
                    resetarJogo();
                    vitoria = false;
                    await DisplayAlert("Rodada acabou", "Deu velha!!", "Fechar");
                    label_vez.Text = "É a vez do " + vez;
                }
            }
            else
            {
                button.IsEnabled = false;
                button.Text = "O";
                testarVitoria();
                vez = "X";
                label_vez.Text = "É a vez do " + vez;
                if (vitoria == true)
                {                    
                    await DisplayAlert("Mensagem de vencedor", "O GANHOU!!!!!", "Fechar");
                    resetarJogo();
                    vitoria = false;
                    label_vez.Text = "É a vez do " + vez;
                }
                else if (botao0.IsEnabled == false && botao1.IsEnabled == false && botao2.IsEnabled == false && botao3.IsEnabled == false && botao4.IsEnabled == false && botao5.IsEnabled == false && botao6.IsEnabled == false && botao7.IsEnabled == false && botao8.IsEnabled == false)
                {
                    resetarJogo();
                    vitoria = false;
                    await DisplayAlert("Rodada acabou", "Deu velha!!", "Fechar");
                    label_vez.Text = "É a vez do " + vez;
                }
            }
        }

        Color fundo_claro = new Color(255, 250, 250);
        private void mudar_cor_Toggled(object sender, ToggledEventArgs e)
        {
            if(mudar_cor.IsToggled == false)
            {
                fundo.BackgroundColor = fundo_claro;
                label_titulo.TextColor = Color.Black;
                label_mudar_cor.TextColor = Color.Black;
            }
            else
            {
                fundo.BackgroundColor = Color.Black;
                label_titulo.TextColor = Color.White;
                label_mudar_cor.TextColor = Color.White;
            }
        }
    }
}
