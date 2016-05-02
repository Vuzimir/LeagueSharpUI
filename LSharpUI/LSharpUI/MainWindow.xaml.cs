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
    // ********************************INFO ABOUT USING**********************************************
    //---------------------------style change on inject----------------------------------
    //injected.Text = "Injected";
    //Visual style = this.FindResource("appbar_connect") as Visual;
    //iconinjected.Visual = style;
    //--------------------------------------------------------------------------------
    // **********************************************************************************************
    public partial class MainWindow : MetroWindow
    {
        int GenralC = 0;
        int GenralH = 0;
        int GenralL = 0;
        public MainWindow()
        {
            InitializeComponent();
            this.Title += "Vuzimir/Normal - 0/2 - 2.0.14.15";
            /*BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FFFFFF");
            brush.Freeze();
            ButtonG.Background = brush;*/

        }
        private async void News_OnClick(object sender, RoutedEventArgs e)
        {
            MainTab.SelectedIndex = 0;
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
            MainTab.SelectedIndex = 1;
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
            MainTab.SelectedIndex = 2;
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
            MainTab.SelectedIndex = 3;
        }
        public void EnableSettings(string select) 
        {
            BrushConverter bc1 = new BrushConverter();
            Brush White = (Brush)bc1.ConvertFrom("#FFFFFFFF");
            White.Freeze();
            BrushConverter bc2 = new BrushConverter();
            Brush Black = (Brush)bc2.ConvertFrom("#FF000000");
            Black.Freeze();
            BrushConverter bc3 = new BrushConverter();
            Brush Blue = (Brush)bc3.ConvertFrom("#FF93D9F7");
            BrushConverter bc4 = new BrushConverter();
            Brush BlueClick = (Brush)bc4.ConvertFrom("#FF63BDE4");
            Blue.Freeze();
            if (select == "GeneralClick")
            {
                if (GenralC == 0)
                {
                    GenralC = 1;
                    GenralH = 0;
                    GenralL = 0;
                    ButtonG.Foreground = White;
                    ButtonG.Background = BlueClick;
                    ButtonG.BorderBrush = BlueClick;
                    TextBox1.Text = "Dilej";
                    //------disable hotkeys--------------
                    ButtonH.Foreground = Black;
                    ButtonH.Background = White;
                    ButtonH.BorderBrush = White;
                    //------disable Log----------
                    ButtonL.Foreground = Black;
                    ButtonL.Background = White;
                    ButtonL.BorderBrush = White;
                }
            }
            if (select == "GeneralEnter")
            {
                TextBox1.Text = "Enter";
                if (GenralC == 0)
                {
                    ButtonG.Background = Blue;
                    ButtonG.BorderBrush = Blue;
                }
            }
            if (select == "GeneralLeave")
            {
                TextBox1.Text = "Leave";
                if (GenralC == 0)
                {
                    ButtonG.Background = White;
                    ButtonG.BorderBrush = White;
                }
            }
            //----------------Hotkeys---------------------------------------
            if (select == "HotkeyClick")
            {
                if (GenralH == 0)
                {
                    GenralC = 0;
                    GenralH = 1;
                    GenralL = 0;
                    ButtonH.Foreground = White;
                    ButtonH.Background = BlueClick;
                    ButtonH.BorderBrush = BlueClick;
                    //------disable Genral----------
                    ButtonG.Foreground = Black;
                    ButtonG.Background = White;
                    ButtonG.BorderBrush = White;
                    //------disable Log----------
                    ButtonL.Foreground = Black;
                    ButtonL.Background = White;
                    ButtonL.BorderBrush = White;
                    TextBox1.Text = "Dilej";
                }
            }
            if (select == "HotkeyEnter")
            {
                TextBox1.Text = "Enter H";
                if (GenralH == 0)
                {
                    ButtonH.Background = Blue;
                    ButtonH.BorderBrush = Blue;
                }
            }
            if (select == "HotkeyLeave")
            {
                TextBox1.Text = "Leave H";
                if (GenralH == 0)
                {
                    ButtonH.Background = White;
                    ButtonH.BorderBrush = White;
                }
            }
            //----------------Log---------------------------------------
            if (select == "LogClick")
            {
                if (GenralL == 0)
                {
                    GenralC = 0;
                    GenralH = 0;
                    GenralL = 1;
                    ButtonL.Foreground = White;
                    ButtonL.Background = BlueClick;
                    ButtonL.BorderBrush = BlueClick;
                    //------disable Genral----------
                    ButtonG.Foreground = Black;
                    ButtonG.Background = White;
                    ButtonG.BorderBrush = White;
                    //------disable hotkeys--------------
                    ButtonH.Foreground = Black;
                    ButtonH.Background = White;
                    ButtonH.BorderBrush = White;
                    TextBox1.Text = "Dilej L";
                }
            }
            if (select == "LogEnter")
            {
                TextBox1.Text = "Enter L";
                if (GenralL == 0)
                {
                    ButtonL.Background = Blue;
                    ButtonL.BorderBrush = Blue;
                }
            }
            if (select == "LogLeave")
            {
                TextBox1.Text = "Leave L";
                if (GenralL == 0)
                {
                    ButtonL.Background = White;
                    ButtonL.BorderBrush = White;
                }
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EnableSettings("GeneralClick");
        }
        private void ButtonG_MouseEnter(object sender, MouseEventArgs e)
        {
            EnableSettings("GeneralEnter");
        }

        private void ButtonG_MouseLeave(object sender, MouseEventArgs e)
        {
            EnableSettings("GeneralLeave");
        }

        private void ButtonH_Click(object sender, RoutedEventArgs e)
        {
            EnableSettings("HotkeyClick");
        }

        private void ButtonH_MouseEnter(object sender, MouseEventArgs e)
        {
            EnableSettings("HotkeyEnter");
        }

        private void ButtonH_MouseLeave(object sender, MouseEventArgs e)
        {
            EnableSettings("HotkeyLeave");
        }

        private void ButtonL_Click(object sender, RoutedEventArgs e)
        {
            EnableSettings("LogClick");
        }

        private void ButtonL_MouseEnter(object sender, MouseEventArgs e)
        {
            EnableSettings("LogEnter");
        }

        private void ButtonL_MouseLeave(object sender, MouseEventArgs e)
        {
            EnableSettings("LogLeave");
        }

    }
}
