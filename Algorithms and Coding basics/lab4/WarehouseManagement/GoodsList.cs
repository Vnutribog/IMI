
namespace WarehouseManagement
{
    public partial class GoodsList : Form
    {

        private readonly List<StockItem> allItems = new();

        public GoodsList()
        {
            InitializeComponent();


            AddNewItemToList(new StockItem("Картофель", "Еда", 50));
            AddNewItemToList(new StockItem("Стиральная машина", "Техника", 2));
            AddNewItemToList(new StockItem("Пальто", "Одежда", 5));
            RecalculateTotalAmount();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NewItemForm addForm = new();
            addForm.onGoBack += () => Show();
            addForm.onItemAdd += AddNewItemToList;
            addForm.ShowDialog();

        }

        private void UpdateListBoxCollection(List<StockItem> items)
        {
            listBoxItems.Items.Clear();
            listBoxItems.Items.AddRange([.. items]);
        }

        public void AddNewItemToList(StockItem stockItem)
        {
            allItems.Add(stockItem);
            listBoxItems.Items.Add(stockItem);
            RecalculateTotalAmount();
        }

        private void RecalculateTotalAmount()
        {
            var amount = 0;
            foreach (StockItem stockItem in allItems)
            {
                amount += stockItem.Quantity;
            }
            labelItemsTotalAmount.Text = $"Общее количество: {amount}";
        }

        private void CheckBoxDeficitOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDeficitOnly.Checked)
            {
                List<StockItem> filtered = [.. allItems.Where(item => item.Quantity < 3)];
                UpdateListBoxCollection(filtered);
            }
            else
            {
                UpdateListBoxCollection(allItems);
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var query = textBoxSearch.Text.Trim();
            if (query.Length > 0)
            {
                List<StockItem> filtered = [];
                foreach (StockItem stockItem in allItems)
                {
                    if (stockItem.Name.Contains(query, StringComparison.CurrentCultureIgnoreCase))
                    {
                        filtered.Add(stockItem);
                    }
                }
                UpdateListBoxCollection(filtered);
            }
            else
            {
                UpdateListBoxCollection(allItems);
            }
        }

        private void UpdateDetailsLabels(StockItem item)
        {
            labelDetailsName.Text = $"Название: {item.Name}";
            labelDetailsCategory.Text = $"Категория: {item.Category}";

            if (item.Quantity >= 5)
            {
                labelDetailsQuantity.ForeColor = Color.Black;
                labelDetailsQuantity.Text = $"Количество: {item.Quantity}";
                
            }
            else
            {
                labelDetailsQuantity.ForeColor = Color.Red;
                labelDetailsQuantity.Text = $"Количество: СРОЧНО ТРЕБУЕТСЯ ЗАКУПКА!";
            }
        }

        private void ButtonIncreaseQuantity_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
            {
                StockItem selected = (StockItem)listBoxItems.SelectedItem;
                selected.Quantity++;

                UpdateListBoxCollection(allItems);
                listBoxItems.SelectedItem = selected;
                UpdateDetailsLabels(selected);
                RecalculateTotalAmount();
            }
        }

        private void ButtonDecreaseQuantity_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
            {
                StockItem selected = (StockItem)listBoxItems.SelectedItem;
                selected.Quantity = selected.Quantity > 0 ? selected.Quantity - 1 : 0;

                UpdateListBoxCollection(allItems);
                listBoxItems.SelectedItem = selected;
                UpdateDetailsLabels(selected);
                RecalculateTotalAmount();
            }
        }

        private void ListBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
            {
                StockItem selected = (StockItem)listBoxItems.SelectedItem;
                UpdateDetailsLabels(selected);
            }
        }
    }
}
