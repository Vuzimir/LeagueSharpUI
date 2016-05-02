using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows.Media.Animation;

namespace LSharpUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title += "Vuzimir/Normal - 0/2 - 2.0.14.15";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            injected.Text = "Injected";
            Visual style = this.FindResource("appbar_connect") as Visual;
            iconinjected.Visual = style;

        }
        private async void News_OnClick(object sender, RoutedEventArgs e)
        {
            var mySettings = new MetroDialogSettings()
            {
                AffirmativeButtonText = "OK",
                ColorScheme = MetroDialogColorScheme.Theme
            };

            await this.ShowMessageAsync("News_OnClick", "News_OnClick",
                MessageDialogStyle.Affirmative, mySettings);
        }
        private async void Assemblies_OnClick(object sender, RoutedEventArgs e)
        {
            var mySettings = new MetroDialogSettings()
            {
                AffirmativeButtonText = "OK",
                ColorScheme = MetroDialogColorScheme.Theme
            };

            await this.ShowMessageAsync("Assemblies_OnClick", "Assemblies_OnClick",
                MessageDialogStyle.Affirmative, mySettings);
        }
        private async void AssemblyDB_OnClick(object sender, RoutedEventArgs e)
        {
            var mySettings = new MetroDialogSettings()
            {
                AffirmativeButtonText = "OK",
                ColorScheme = MetroDialogColorScheme.Theme
            };

            await this.ShowMessageAsync("AssemblyDB_OnClick", "AssemblyDB_OnClick",
                MessageDialogStyle.Affirmative, mySettings);
        }
        private async void Unknown_OnClick(object sender, RoutedEventArgs e)
        {
            var mySettings = new MetroDialogSettings()
            {
                AffirmativeButtonText = "OK",
                ColorScheme = MetroDialogColorScheme.Theme
            };

            await this.ShowMessageAsync("Unknown_OnClick", "Unknown_OnClick",
                MessageDialogStyle.Affirmative, mySettings);
        }
        private async void Settings_OnClick(object sender, RoutedEventArgs e)
        {
            var mySettings = new MetroDialogSettings()
            {
                AffirmativeButtonText = "OK",
                ColorScheme = MetroDialogColorScheme.Theme
            };

            await this.ShowMessageAsync("Settings", "Settings",
                MessageDialogStyle.Affirmative, mySettings);
        }


    }
}
