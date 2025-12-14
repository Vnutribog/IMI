namespace BookList;

public partial class BooksCatalog : Form
{
    private readonly MainMenu _menuInstance;
    public BooksCatalog(MainMenu menuInstance)
    {
        InitializeComponent();
        _menuInstance = menuInstance;
    }

    private void addBookBtn_Click(object sender, EventArgs e)
    {
        string bookName = bookNameTextBox.Text.Trim();
        if (bookName.Length == 0)
        {
            MessageBox.Show("Введите название книги!", "Ошибка", MessageBoxButtons.OK);
        }
        else
        {
            bookListBox.Items.Add(bookName);
        }
    }

    private void showMainMenuBtn_Click(object sender, EventArgs e)
    {
        Hide();
        _menuInstance.Show();
    }
}