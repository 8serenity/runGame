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
            int direction = random.Next(1, 8);
            var currentMargin = buttonGame.Margin;
            switch (direction)
            {
                case 1:
                    buttonGame.Margin = new System.Windows.Thickness { Left = currentMargin.Left + 55 };
                    break;
                case 2:
                    buttonGame.Margin = new System.Windows.Thickness { Left = currentMargin.Left + 55 };
                    buttonGame.Margin = new System.Windows.Thickness { Top = currentMargin.Top + 55 };
                    break;
                case 3:
                    buttonGame.Margin = new System.Windows.Thickness { Top = currentMargin.Top + 55 };
                    break;
                case 4:
                    buttonGame.Margin = new System.Windows.Thickness { Right = currentMargin.Right + 55 };
                    buttonGame.Margin = new System.Windows.Thickness { Top = currentMargin.Top + 55 };
                    break;
                case 5:
                    buttonGame.Margin = new System.Windows.Thickness { Right = currentMargin.Right + 55 };
                    break;
                case 6:
                    buttonGame.Margin = new System.Windows.Thickness { Right = currentMargin.Right + 55 };
                    buttonGame.Margin = new System.Windows.Thickness { Bottom = currentMargin.Bottom + 55 };
                    break;
                case 7:
                    buttonGame.Margin = new System.Windows.Thickness { Bottom = currentMargin.Bottom + 55 };
                    break;
                case 8:
                    buttonGame.Margin = new System.Windows.Thickness { Left = currentMargin.Left + 55 };
                    buttonGame.Margin = new System.Windows.Thickness { Bottom = currentMargin.Bottom + 55 };
                    break;
            }
        }

        
    }
}
