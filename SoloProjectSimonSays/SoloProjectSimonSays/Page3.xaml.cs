using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SoloProjectSimonSays
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    /// https://www.youtube.com/watch?v=lYzeCSWLEDo
    public partial class Page3 : Page
    {
    
        public Page3()
        {
            InitializeComponent();

            SimonGame Game = new SimonGame();

            while(!Game.GameOver)
            {
                DisplayCurrentRound(Game);

                
            }

        }

        private void DisplayCurrentRound(SimonGame Game)
        {
            foreach (Colors Color in Game.Colors)
            {
                RoundText.Text = "Round" + Game.Colors.Count;

                System.Threading.Thread.Sleep(1000);

                switch (Color)
                {
                    case Colors.Green:
                        GreenBox.Fill = new BrushConverter().ConvertFromString("#FF45FF45") as SolidColorBrush;
                        break;
                    case Colors.Red:
                        RedBox.Fill = new BrushConverter().ConvertFromString("##FFF87777") as SolidColorBrush;
                        break;
                    case Colors.Blue:
                        BlueBox.Fill = new BrushConverter().ConvertFromString("##FF7777FB") as SolidColorBrush;
                        break;
                    case Colors.Yellow:
                        YellowBox.Fill = new BrushConverter().ConvertFromString("##FFEEEE69") as SolidColorBrush;
                        break;
                }
                System.Threading.Thread.Sleep(1000);
            }
            RoundText.Text = "Round" + Game.Colors.Count;
        }

        private void RedClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void BlueClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void YellowClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void GreenClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
