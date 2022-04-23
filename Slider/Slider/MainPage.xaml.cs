using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Slider
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            labelFrases.Text = frases[0];
            labelFrases.TextColor = Color.Black;
        }

        private Color[] cores = new Color[]
        {
            Color.Red,
            Color.Green,
            Color.Blue,
            Color.Yellow,
            Color.Orange,
            Color.AliceBlue,
            Color.Purple,
            Color.Orchid,
        };

        private string[] frases = new string[]
        {
            "Life is like a bicycle. To keep you balance, you must keep moving.",
            "Anything who has never made a mistake has never tried anything new.",
            "Try not to become a man of success. Rather become a man of value.",
            "Logic will get you from A to Z; imagination will get you everywhere.",
        };

        private int indice = 0;

        private void Button_Clicked(object sender, EventArgs e)
        {
            indice++;

            if (indice >= (frases.Length-1))
            {
                indice = 0;
            }
            labelFrases.Text = frases[indice];
        }

        private void sliderColor_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if ((int)(sliderColor.Value) > 0)
            {
                labelFrases.TextColor = cores[((int)sliderColor.Value)-1];
            }
            else labelFrases.TextColor = cores[0];


        }
    }
}
