namespace WarehouseManagement
{
    public partial class NewItemForm : Form
    {

        public Action onGoBack;
        public Action<StockItem> onItemAdd;

        public NewItemForm()
        {
            InitializeComponent();

            comboBoxItemCategory.Items.AddRange([
                "Еда", "Техника", "Одежда"
            ]);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            onGoBack.Invoke();
            Close();
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {

            if (textBoxItemName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите название товара", "Название", MessageBoxButtons.OK);
                return;
            }
            if (textBoxItemQuantity.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите количество", "Количество", MessageBoxButtons.OK);
                return;
            }
            if (comboBoxItemCategory.SelectedItem == null)
            {
                MessageBox.Show("Выберите категорию", "Категория", MessageBoxButtons.OK);
                return;
            }

            var name = textBoxItemName.Text.Trim();
            var category = comboBoxItemCategory.SelectedText.Trim();
            var quantity = int.Parse(textBoxItemQuantity.Text.Trim());
            onItemAdd.Invoke(new StockItem(name, category, quantity));
        }
    }
}
