using System.Diagnostics.Eventing.Reader;
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
    using System.Windows.Threading;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int tenthsOfSecondsElapsed;
        int matchesFound;
        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;

            SetUpGame();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            tenthsOfSecondsElapsed++;
            TimeTextBlock.Text = (tenthsOfSecondsElapsed / 10F).ToString("0.0s");

            if (matchesFound == 8)
            {
                timer.Stop();
                TimeTextBlock.Text = TimeTextBlock.Text = " - Play Again?";
            }
        }

        private void SetUpGame()
        {
            List<string> AnimalEmoji = new()
            {
                "🐷","🐷",
                "🐻","🐻",
                "🐺","🐺",
                "🦁","🦁",
                "🐱","🐱",
                "🐵","🐵",
                "🐔","🐔",
                "🐸","🐸"
            };

            Random random = new();


            foreach (TextBlock textblock in mainGrid.Children.OfType<TextBlock>()) {

                if (textblock.Name != "TimeTextBlock")
                {
                    int index = random.Next(AnimalEmoji.Count);
                    string nextEmoji = AnimalEmoji[index];
                    textblock.Text = nextEmoji;
                    AnimalEmoji.RemoveAt(index);
                    textblock.Visibility = Visibility.Visible;
                }
            }

            tenthsOfSecondsElapsed = 0;
            matchesFound = 0;
           
            timer.Start();
        }

        TextBlock lastTextBlockClicked;
        bool findingMatch = false;


        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;

            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TimeTextBlock_MouseDown (object sender, MouseButtonEventArgs e)
        {
            if (matchesFound == 8)
            {
                SetUpGame();
            }
        }

    }
}