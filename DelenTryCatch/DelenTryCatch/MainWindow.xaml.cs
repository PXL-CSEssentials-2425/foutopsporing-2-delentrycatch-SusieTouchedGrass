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

namespace DelenTryCatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double number = double.Parse(numberTextBox.Text);
                double divier = double.Parse(dividerTextBox.Text);
                double result = number / divier;
                resultTextBox.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Er is een fout opgetreden", "FOUT", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void errorButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double number = double.Parse(numberTextBox.Text);
                double divider = double.Parse(dividerTextBox.Text);
                double result = number / divider;
                if (divider >= 1000000)
                {
                    throw new Exception();
                }
                else
                {
                    resultTextBox.Text = result.ToString();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Je moet 2 gehele getallen ingeven.\nDe indeling van de invoertekenreeks is onjuis", "Conversiefout bij DELER/DEELTAL", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("De deler mag niet 0 zijn.", "FOUTE BIJ DELING", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
            catch (Exception)
            {
                MessageBox.Show("DEELTAL is te groot!", "Conversiefout", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}