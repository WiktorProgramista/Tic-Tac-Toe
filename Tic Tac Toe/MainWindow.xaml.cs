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

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Win = false;
        int count = 0;
        bool Player = false;
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        public void NewGame()
        {
            count = 0;
            Win = false;
            Player = false;
            Button_0_0.Content = string.Empty;
            Button__0_1.Content = string.Empty;
            Button__0_2.Content = string.Empty;
            Button__1_0.Content = string.Empty;
            Button__1_1.Content = string.Empty;
            Button__1_2.Content = string.Empty;
            Button__2_0.Content = string.Empty;
            Button__2_1.Content = string.Empty;
            Button__2_2.Content = string.Empty;
            Button_0_0.Background = Brushes.White;
            Button__0_1.Background = Brushes.White;
            Button__0_2.Background = Brushes.White;
            Button__1_0.Background = Brushes.White;
            Button__1_1.Background = Brushes.White;
            Button__1_2.Background = Brushes.White;
            Button__2_0.Background = Brushes.White;
            Button__2_1.Background = Brushes.White;
            Button__2_2.Background = Brushes.White;

        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            count++;
            if (Win==false)
            {
                if (Player == false)
                {
                    button.Content = "O";
                    Player = true;
                }
                else
                {
                    button.Content = "X";
                    Player = false;
                }

                if(Button_0_0.Content != string.Empty & Button_0_0.Content == Button__1_0.Content && Button__1_0.Content == Button__2_0.Content)
                {
                    Button_0_0.Background = Brushes.Green;
                    Button__1_0.Background = Brushes.Green;
                    Button__2_0.Background = Brushes.Green;
                    Win = true;
                }
                if (Button__0_1.Content != string.Empty & Button__0_1.Content == Button__1_1.Content && Button__1_1.Content == Button__2_1.Content)
                {
                    Button__0_1.Background = Brushes.Green;
                    Button__1_1.Background = Brushes.Green;
                    Button__2_1.Background = Brushes.Green;
                    Win = true;
                }
                if (Button__0_2.Content != string.Empty & Button__0_2.Content == Button__1_2.Content && Button__1_2.Content == Button__2_2.Content)
                {
                    Button__0_2.Background = Brushes.Green;
                    Button__1_2.Background = Brushes.Green;
                    Button__2_2.Background = Brushes.Green;
                    Win = true;
                }
                if (Button_0_0.Content != string.Empty & Button_0_0.Content == Button__0_1.Content && Button__0_1.Content == Button__0_2.Content)
                {
                    Button_0_0.Background = Brushes.Green;
                    Button__0_1.Background = Brushes.Green;
                    Button__0_2.Background = Brushes.Green;
                    Win = true;
                }
                if (Button__1_0.Content != string.Empty & Button__1_0.Content == Button__1_1.Content && Button__1_1.Content == Button__1_2.Content)
                {
                    Button__1_0.Background = Brushes.Green;
                    Button__1_1.Background = Brushes.Green;
                    Button__1_2.Background = Brushes.Green;
                    Win = true;
                }
                if (Button__2_0.Content != string.Empty & Button__2_0.Content == Button__2_1.Content & Button__2_1.Content == Button__2_2.Content)
                {
                    Button__2_0.Background = Brushes.Green;
                    Button__2_1.Background = Brushes.Green;
                    Button__2_2.Background = Brushes.Green;
                    Win = true;
                }
                if (Button__1_1.Content != string.Empty & Button__2_0.Content == Button__2_0.Content && Button__1_1.Content == Button__0_2.Content)
                {
                    Button__2_0.Background = Brushes.Green;
                    Button__1_1.Background = Brushes.Green;
                    Button__0_2.Background = Brushes.Green;
                    Win = true;
                }
                if (Button_0_0.Content != string.Empty & Button_0_0.Content == Button__1_1.Content && Button__1_1.Content == Button__2_2.Content)
                {
                    Button_0_0.Background = Brushes.Green;
                    Button__1_1.Background = Brushes.Green;
                    Button__2_2.Background = Brushes.Green;
                    Win = true;
                }
               

            }
            else
            {
                NewGame();
            }
        }
    }
}
