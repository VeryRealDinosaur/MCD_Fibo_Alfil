using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MCD_Fibo_Alfil
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            // Attach the event handlers to the buttons
            var mcdButton = this.FindControl<Button>("Mcd");
            mcdButton.Click += OnMcdClick;

            var fiboButton = this.FindControl<Button>("Fibo");
            fiboButton.Click += OnFiboClick;

            var alfiButton = this.FindControl<Button>("Alfi");
            alfiButton.Click += OnAlfiClick;
        }

        private void OnMcdClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var secondWindow = new Mcd();
            secondWindow.Show();
        }

        private void OnFiboClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var thirdWindow = new Fibo();
            thirdWindow.Show();
        }

        private void OnAlfiClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var fourthWindow = new Alfi();
            fourthWindow.Show();
        }
    }
}