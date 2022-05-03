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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void QuitButtonClick(object sender, MouseButtonEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

        private void QuitTextClick(object sender, MouseButtonEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

        private void RulesButtonClick(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page2());
        }

        private void RulesTextClick(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page2());
        }

        private void PlayButtonClick(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page3());
        }

        private void PlayTextClick(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page3());
        }
    }
}
