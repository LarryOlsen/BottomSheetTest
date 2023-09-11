namespace BottomSheetTest;

public partial class MainPage : ContentPage
{
	MySheet sheet;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnShowClicked(object sender, EventArgs e)
	{
		sheet ??= new MySheet();

		sheet.ShowAsync(Window);
	}

    private void OnHideClicked(object sender, EventArgs e)
    {
		sheet?.DismissAsync();
    }
}

