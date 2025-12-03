namespace Project2025
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MovieDetails), typeof(MovieDetails));
        }
    }
}
