namespace Kartkowka2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {

            count++;
            if (count == 0)
                CounterPolubienia.Text = $"Polubienia: 0";
            else
                CounterPolubienia.Text = $"Polubienia {count}";

            SemanticScreenReader.Announce(CounterPolubienia.Text);
        }
        private void OnCounterClickedDislike(object? sender, EventArgs e)
        {
            if (count > 0)
            {
            count--;
            }
            if (count == 0)
                CounterPolubienia.Text = $"Polubienia: 0";
            else
                CounterPolubienia.Text = $"Polubienia {count}";

            SemanticScreenReader.Announce(CounterPolubienia.Text);
        }
    }
}
