namespace TransparentWindow;

public partial class SingleTransparent : Window
{
    public SingleTransparent ()
    {
        this.InitializeComponent();
        this.Loaded += this.MainWindow_Loaded;
    }

    private async void MainWindow_Loaded ( object sender, RoutedEventArgs e )
    {
        this.Loaded -= this.MainWindow_Loaded;
        await Task.Delay( 250 );

        var winChrome = WindowChrome.GetWindowChrome( this );
        winChrome.GlassFrameThickness = new( 0 );
    }
}
