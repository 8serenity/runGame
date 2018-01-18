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

namespace RunGame
{
    //Создайте приложение, состоящее из окна с одной кнопкой,
    //за которой бы пользователь «гонялся» по всему окну с помощью мыши, но не мог щелкнуть ее.


    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mouseMoved(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            IsOkDirection(buttonGame, random);
        }

        private void pressedButton(object sender, RoutedEventArgs e)
        {
            buttonGame.Background = Brushes.Red;
            buttonGame.Content = "YOU WIN";
        }

        private bool IsOkDirection(Button buttonGame, Random rnd)
        {
            int direction = rnd.Next(1,8);
            var currentMargin = buttonGame.Margin;
            switch (direction)
            {
                case 1:
                    if (buttonGame.Margin.Left + 55 >= 425)
                    {
                        return false;
                    }
                    buttonGame.Margin = new System.Windows.Thickness { Left = currentMargin.Left + 55 };
                    break;
                case 2:
                    if (buttonGame.Margin.Left + 55 >= 425 || buttonGame.Margin.Top + 55 >= 290)
                    {
                        return false;
                    }
                    buttonGame.Margin = new System.Windows.Thickness { Left = currentMargin.Left + 55, Top = currentMargin.Top + 55 };
                    break;
                case 3:
                    if (buttonGame.Margin.Top + 55 >= 290)
                    {
                        return false;
                    }
                    buttonGame.Margin = new System.Windows.Thickness { Top = currentMargin.Top + 55 };
                    break;
                case 4:
                    if (buttonGame.Margin.Right + 55 >= 425 || buttonGame.Margin.Top + 55 >= 290)
                    {
                        return false;
                    }
                    buttonGame.Margin = new System.Windows.Thickness { Right = currentMargin.Right + 55, Top = currentMargin.Top + 55 };
                    break;
                case 5:
                    if (buttonGame.Margin.Right + 55 >= 425)
                    {
                        return false;
                    }
                    buttonGame.Margin = new System.Windows.Thickness { Right = currentMargin.Right + 55 };
                    break;
                case 6:
                    if (buttonGame.Margin.Right + 55 >= 425 || buttonGame.Margin.Bottom + 55 >= 290)
                    {
                        return false;
                    }
                    buttonGame.Margin = new System.Windows.Thickness { Right = currentMargin.Right + 55, Bottom = currentMargin.Bottom + 55 };
                    break;
                case 7:
                    if (buttonGame.Margin.Bottom + 55 >= 290)
                    {
                        return false;
                    }
                    buttonGame.Margin = new System.Windows.Thickness { Bottom = currentMargin.Bottom + 55 };
                    break;
                case 8:
                    if (buttonGame.Margin.Left + 55 >= 425 || buttonGame.Margin.Bottom + 55 >= 290)
                    {
                        return false;
                    }
                    buttonGame.Margin = new System.Windows.Thickness { Left = currentMargin.Left + 55, Bottom = currentMargin.Bottom + 55 };
                    break;
            }
            return true;
        }

    }
}
