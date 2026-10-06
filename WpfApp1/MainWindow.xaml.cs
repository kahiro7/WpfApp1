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
using System.Data;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _resultatAffiche = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += "0";
        }

        private void BTN_Dot_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += ".";
        }

        private void BTN_Equal_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = EvaluateExpression(TB_Display.Text);
            _resultatAffiche = true;
        }
        private string EvaluateExpression(string expression)

        {
            try
            {
                string expressionCorrigee = expression.Replace(",", ".");
                var resultat = new DataTable().Compute(expressionCorrigee, null);
                return resultat.ToString();
            }
            catch
            {
                return "Erreur";
            }
        }

        private void BTN_Add_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += "+";
        }

        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += "1";
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += "2";
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += "3";
        }

        private void BTN_Sub_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += "-";
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += "4";
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += "5";
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += "6";
        }

        private void BTN_Mult_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += "*";
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += "7";
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += "8";
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += "9";
        }

        private void BTN_Div_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += "/";
        }

        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "";
            _resultatAffiche = false;
        }

        private void BTN_virgul_Click(object sender, RoutedEventArgs e)
        {
            if (_resultatAffiche)
            {
                TB_Display.Text = "";
                _resultatAffiche = false;
            }
            TB_Display.Text += ",";
        }
    }
}