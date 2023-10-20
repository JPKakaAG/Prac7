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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnExit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnInfo_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил лучший разработчик: Девяткин Вадим Евгеньевич\r\nПрактическая №6\r\nИспользовать класс Pair (пара четных чисел). Разработать операцию перемножения \r\nпар (а, b) * (с, d) = (а * c, b * d). Разработать операцию инкремента для удвоения \r\nпары чисел.");
        }

        private void btnDa_click(object sender, RoutedEventArgs e)
        {
            string result1 = tbA.Text.Replace(" ", "");
            string result2 = tbB.Text.Replace(" ", "");
            if (int.TryParse(result1, out int A) && int.TryParse(result2, out int B))
            {
                string userInput1 = tbA.Text;
                string userInput2 = tbB.Text;
                string[] numbersArray1 = userInput1.Split(' ');
                string[] numbersArray2 = userInput2.Split(' ');

                if (numbersArray1.Length == 2 && numbersArray2.Length == 2)
                {
                    int.TryParse(numbersArray1[0], out int a);
                    int.TryParse(numbersArray1[1], out int b);
                    int.TryParse(numbersArray2[0], out int c);
                    int.TryParse(numbersArray2[1], out int d);

                    Pair pair1 = new Pair(a, b);
                    Pair pair2 = new Pair(c, d);
                    Pair multiplicationResult = pair1 * pair2;
                    tbRes1.Text = ($"Перемножениe пар {a}*{c}, {b}*{d} = {multiplicationResult.First}, {multiplicationResult.Second}");

                    Pair incrementResult = ++pair1;
                    tbRes2.Text = ($"Результат инкремента ({incrementResult.First}, {incrementResult.Second})");
                }
                else
                {
                    MessageBox.Show("Введите по 2 числа через пробел например: 1 2");
                }
            }
            else
            {
                MessageBox.Show("Введите числа");
            }
        }

        private void btnMediana_clickB(object sender, RoutedEventArgs e)
        {
            gr2.Visibility = Visibility.Hidden;
            gr1.Visibility = Visibility.Visible;
        }
        private void btnMediana_click(object sender, RoutedEventArgs e)
        {
            gr1.Visibility = Visibility.Hidden;
            gr2.Visibility = Visibility.Visible;
        }

        private void btnDaB_click(object sender, RoutedEventArgs e)
        {
            string result1 = tbAB.Text.Replace(" ", "");
            if (int.TryParse(result1, out int A))
            {
                string userInput1 = tbAB.Text;
                string[] numbersArray1 = userInput1.Split(' ');

                if (numbersArray1.Length == 2)
                {
                    int.TryParse(numbersArray1[0], out int a);
                    int.TryParse(numbersArray1[1], out int b);

                    RightAngledTriangle triangle = new RightAngledTriangle(a, b);
                    double hypotenuse = triangle.CalculateHypotenuse();
                    double area = triangle.CalculateArea();
                    tbRes1B.Text = ($"Гипотенуза треугольника: {hypotenuse}");

                    tbRes2B.Text = ($"Площадь треугольника: {area}");
                }
                else
                {
                    MessageBox.Show("Введите по 2 числа через пробел например: 1 2");
                }
            }
            else
            {
                MessageBox.Show("Введите числа");
            }
        }
    }
}
