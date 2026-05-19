namespace WarehouseManagement
{
    partial class NewItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelItemName = new Label();
            labelItemCategory = new Label();
            labelItemQuantity = new Label();
            textBoxItemName = new TextBox();
            textBoxItemQuantity = new TextBox();
            button1 = new Button();
            buttonAddItem = new Button();
            comboBoxItemCategory = new ComboBox();
            SuspendLayout();
            // 
            // labelItemName
            // 
            labelItemName.AutoSize = true;
            labelItemName.Location = new Point(63, 62);
            labelItemName.Name = "labelItemName";
            labelItemName.Size = new Size(80, 20);
            labelItemName.TabIndex = 0;
            labelItemName.Text = "Название:";
            // 
            // labelItemCategory
            // 
            labelItemCategory.AutoSize = true;
            labelItemCategory.Location = new Point(63, 193);
            labelItemCategory.Name = "labelItemCategory";
            labelItemCategory.Size = new Size(84, 20);
            labelItemCategory.TabIndex = 1;
            labelItemCategory.Text = "Категория:";
            // 
            // labelItemQuantity
            // 
            labelItemQuantity.AutoSize = true;
            labelItemQuantity.Location = new Point(63, 130);
            labelItemQuantity.Name = "labelItemQuantity";
            labelItemQuantity.Size = new Size(93, 20);
            labelItemQuantity.TabIndex = 2;
            labelItemQuantity.Text = "Количество:";
            // 
            // textBoxItemName
            // 
            textBoxItemName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxItemName.Location = new Point(194, 55);
            textBoxItemName.Name = "textBoxItemName";
            textBoxItemName.Size = new Size(342, 31);
            textBoxItemName.TabIndex = 3;
            // 
            // textBoxItemQuantity
            // 
            textBoxItemQuantity.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxItemQuantity.Location = new Point(194, 123);
            textBoxItemQuantity.Name = "textBoxItemQuantity";
            textBoxItemQuantity.Size = new Size(342, 31);
            textBoxItemQuantity.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(63, 282);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // buttonAddItem
            // 
            buttonAddItem.Location = new Point(442, 282);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(94, 29);
            buttonAddItem.TabIndex = 7;
            buttonAddItem.Text = "Добавить";
            buttonAddItem.UseVisualStyleBackColor = true;
            buttonAddItem.Click += ButtonAddItem_Click;
            // 
            // comboBoxItemCategory
            // 
            comboBoxItemCategory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxItemCategory.FormattingEnabled = true;
            comboBoxItemCategory.Location = new Point(194, 190);
            comboBoxItemCategory.Name = "comboBoxItemCategory";
            comboBoxItemCategory.Size = new Size(342, 33);
            comboBoxItemCategory.TabIndex = 8;
            // 
            // NewItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 362);
            Controls.Add(comboBoxItemCategory);
            Controls.Add(buttonAddItem);
            Controls.Add(button1);
            Controls.Add(textBoxItemQuantity);
            Controls.Add(textBoxItemName);
            Controls.Add(labelItemQuantity);
            Controls.Add(labelItemCategory);
            Controls.Add(labelItemName);
            Name = "NewItemForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление товара";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelItemName;
        private Label labelItemCategory;
        private Label labelItemQuantity;
        private TextBox textBoxItemName;
        private TextBox textBoxItemQuantity;
        private Button button1;
        private Button buttonAddItem;
        private ComboBox comboBoxItemCategory;
    }
}