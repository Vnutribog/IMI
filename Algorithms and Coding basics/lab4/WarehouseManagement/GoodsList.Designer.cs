namespace WarehouseManagement
{
    partial class GoodsList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddNewItem = new Button();
            listBoxItems = new ListBox();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            buttonDecreaseQuantity = new Button();
            buttonIncreaseQuantity = new Button();
            groupBox1 = new GroupBox();
            labelDetailsQuantity = new Label();
            labelDetailsCategory = new Label();
            labelDetailsName = new Label();
            checkBoxDeficitOnly = new CheckBox();
            labelItemsTotalAmount = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddNewItem
            // 
            buttonAddNewItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddNewItem.Location = new Point(411, 558);
            buttonAddNewItem.Name = "buttonAddNewItem";
            buttonAddNewItem.Size = new Size(187, 53);
            buttonAddNewItem.TabIndex = 0;
            buttonAddNewItem.Text = "Добавить товар";
            buttonAddNewItem.UseVisualStyleBackColor = true;
            buttonAddNewItem.Click += Button1_Click;
            // 
            // listBoxItems
            // 
            listBoxItems.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxItems.FormattingEnabled = true;
            listBoxItems.ItemHeight = 25;
            listBoxItems.Location = new Point(33, 87);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(565, 254);
            listBoxItems.TabIndex = 1;
            listBoxItems.SelectedIndexChanged += ListBoxItems_SelectedIndexChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(78, 32);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(55, 20);
            labelSearch.TabIndex = 2;
            labelSearch.Text = "Поиск:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearch.Location = new Point(174, 29);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(374, 31);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.TextChanged += TextBoxSearch_TextChanged;
            // 
            // buttonDecreaseQuantity
            // 
            buttonDecreaseQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDecreaseQuantity.Location = new Point(540, 361);
            buttonDecreaseQuantity.Name = "buttonDecreaseQuantity";
            buttonDecreaseQuantity.Size = new Size(58, 57);
            buttonDecreaseQuantity.TabIndex = 4;
            buttonDecreaseQuantity.Text = "-";
            buttonDecreaseQuantity.UseVisualStyleBackColor = true;
            buttonDecreaseQuantity.Click += ButtonDecreaseQuantity_Click;
            // 
            // buttonIncreaseQuantity
            // 
            buttonIncreaseQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonIncreaseQuantity.Location = new Point(451, 361);
            buttonIncreaseQuantity.Name = "buttonIncreaseQuantity";
            buttonIncreaseQuantity.Size = new Size(58, 57);
            buttonIncreaseQuantity.TabIndex = 5;
            buttonIncreaseQuantity.Text = "+";
            buttonIncreaseQuantity.UseVisualStyleBackColor = true;
            buttonIncreaseQuantity.Click += ButtonIncreaseQuantity_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelDetailsQuantity);
            groupBox1.Controls.Add(labelDetailsCategory);
            groupBox1.Controls.Add(labelDetailsName);
            groupBox1.Location = new Point(33, 358);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 151);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Подробно о товаре";
            // 
            // labelDetailsQuantity
            // 
            labelDetailsQuantity.AutoSize = true;
            labelDetailsQuantity.Location = new Point(14, 113);
            labelDetailsQuantity.Name = "labelDetailsQuantity";
            labelDetailsQuantity.Size = new Size(93, 20);
            labelDetailsQuantity.TabIndex = 2;
            labelDetailsQuantity.Text = "Количество:";
            // 
            // labelDetailsCategory
            // 
            labelDetailsCategory.AutoSize = true;
            labelDetailsCategory.Location = new Point(14, 76);
            labelDetailsCategory.Name = "labelDetailsCategory";
            labelDetailsCategory.Size = new Size(84, 20);
            labelDetailsCategory.TabIndex = 1;
            labelDetailsCategory.Text = "Категория:";
            // 
            // labelDetailsName
            // 
            labelDetailsName.AutoSize = true;
            labelDetailsName.Location = new Point(14, 40);
            labelDetailsName.Name = "labelDetailsName";
            labelDetailsName.Size = new Size(80, 20);
            labelDetailsName.TabIndex = 0;
            labelDetailsName.Text = "Название:";
            // 
            // checkBoxDeficitOnly
            // 
            checkBoxDeficitOnly.AutoSize = true;
            checkBoxDeficitOnly.Location = new Point(33, 536);
            checkBoxDeficitOnly.Name = "checkBoxDeficitOnly";
            checkBoxDeficitOnly.Size = new Size(209, 24);
            checkBoxDeficitOnly.TabIndex = 7;
            checkBoxDeficitOnly.Text = "Показать только дефицит";
            checkBoxDeficitOnly.UseVisualStyleBackColor = true;
            checkBoxDeficitOnly.CheckedChanged += CheckBoxDeficitOnly_CheckedChanged;
            // 
            // labelItemsTotalAmount
            // 
            labelItemsTotalAmount.AutoSize = true;
            labelItemsTotalAmount.Location = new Point(33, 591);
            labelItemsTotalAmount.Name = "labelItemsTotalAmount";
            labelItemsTotalAmount.Size = new Size(143, 20);
            labelItemsTotalAmount.TabIndex = 8;
            labelItemsTotalAmount.Text = "Общее количество:";
            // 
            // GoodsList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 666);
            Controls.Add(labelItemsTotalAmount);
            Controls.Add(checkBoxDeficitOnly);
            Controls.Add(groupBox1);
            Controls.Add(buttonIncreaseQuantity);
            Controls.Add(buttonDecreaseQuantity);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearch);
            Controls.Add(listBoxItems);
            Controls.Add(buttonAddNewItem);
            Name = "GoodsList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список товаров";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddNewItem;
        private ListBox listBoxItems;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private Button buttonDecreaseQuantity;
        private Button buttonIncreaseQuantity;
        private GroupBox groupBox1;
        private Label labelDetailsCategory;
        private Label labelDetailsName;
        private Label labelDetailsQuantity;
        private CheckBox checkBoxDeficitOnly;
        private Label labelItemsTotalAmount;
    }
}
