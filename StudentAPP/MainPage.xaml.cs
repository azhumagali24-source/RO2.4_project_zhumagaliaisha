namespace StudentAPP;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        CounterBtn.Text = $"Clicked {count} time(s)";
    }

    private async void OnOpenStudentsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(StudentsPage));
    }
}