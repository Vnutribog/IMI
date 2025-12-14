namespace BookList;

public partial class MainMenu : Form
{
    
    private readonly BooksCatalog _catalog;
    public MainMenu()
    {
        InitializeComponent();
        _catalog = new BooksCatalog(this);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Hide();
        _catalog.Show();
    }
}