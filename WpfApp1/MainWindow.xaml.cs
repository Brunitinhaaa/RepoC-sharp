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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> AnimalEmoji = new()
            {
                "🐷","🐷",
                "🐻", "🐻",
                "🐺","🐺",
                "🦁","🦁",
                "🐱","🐱",
                "🐵","🐵",
                "🐔","🐔",
                "🐸","🐸"
            };

            Random random = new();

            foreach (TextBlock textblock in mainGrid.Children.OfType<TextBlock>()) {

                int index = random.Next(AnimalEmoji.Count);
                string nextEmoji = AnimalEmoji[index];
                textblock.Text = nextEmoji;
                AnimalEmoji.RemoveAt(index);

            };
        }
    }
}