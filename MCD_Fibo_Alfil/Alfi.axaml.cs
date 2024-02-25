using System;
using System.Text;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MCD_Fibo_Alfil
{
    public partial class Alfi : Window
    {
        private TextBlock Tablero;

        public int AlfiX;
        public int AlfiY;

        public Alfi()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            N1 = this.FindControl<TextBox>("N1");
            N2 = this.FindControl<TextBox>("N2");
            Board = this.FindControl<Label>("Board");
            Tablero = this.FindControl<TextBlock>("ChessboardText");
        }

        private void CalBtn(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (N1 != null && N2 != null && Board != null && Tablero != null)
            {
                if (int.TryParse(N1.Text, out int num1) && int.TryParse(N2.Text, out int num2))
                {
                    AlfiX = num1-1;
                    AlfiY = num2-1;
                    UpdateChessboard();
                }
            }
        }

        private void UpdateChessboard()
        {
            var gridBuilder = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == AlfiY && j == AlfiX)
                    {
                        gridBuilder.Append("[A]");
                    }
                    else if (IsBishopMove(i, j))
                    {
                        gridBuilder.Append("[*]");
                    }
                    else
                    {
                        gridBuilder.Append("[ ]");
                    }
                }
                gridBuilder.AppendLine();
            }

            Tablero.Text = gridBuilder.ToString();
        }

        private bool IsBishopMove(int x, int y)
        {
            return Math.Abs(x - AlfiY) == Math.Abs(y - AlfiX);
        }
    }
}
