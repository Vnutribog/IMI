namespace RPGClicker
{
    partial class Form1
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
            labelStrength = new Label();
            labelAgility = new Label();
            labelGold = new Label();
            buttonTraining = new Button();
            buttonWorking = new Button();
            shopComboBox = new ComboBox();
            buttonBuyItem = new Button();
            CharGroupBox = new GroupBox();
            labelEnergy = new Label();
            energyProgressBar = new ProgressBar();
            ShopGroupBox = new GroupBox();
            labelShopItemDescription = new Label();
            labelShopItemCost = new Label();
            buttonOpenArena = new Button();
            CharGroupBox.SuspendLayout();
            ShopGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // labelStrength
            // 
            labelStrength.AutoSize = true;
            labelStrength.Location = new Point(51, 69);
            labelStrength.Name = "labelStrength";
            labelStrength.Size = new Size(106, 32);
            labelStrength.TabIndex = 0;
            labelStrength.Text = "Сила: 10";
            // 
            // labelAgility
            // 
            labelAgility.AutoSize = true;
            labelAgility.Location = new Point(51, 133);
            labelAgility.Name = "labelAgility";
            labelAgility.Size = new Size(141, 32);
            labelAgility.TabIndex = 1;
            labelAgility.Text = "Ловкость: 4";
            // 
            // labelGold
            // 
            labelGold.AutoSize = true;
            labelGold.Location = new Point(311, 69);
            labelGold.Name = "labelGold";
            labelGold.Size = new Size(117, 32);
            labelGold.TabIndex = 2;
            labelGold.Text = "Золото: 0";
            // 
            // buttonTraining
            // 
            buttonTraining.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTraining.Location = new Point(33, 196);
            buttonTraining.Margin = new Padding(3, 4, 3, 4);
            buttonTraining.Name = "buttonTraining";
            buttonTraining.Size = new Size(158, 60);
            buttonTraining.TabIndex = 3;
            buttonTraining.Text = "Тренироваться";
            buttonTraining.UseVisualStyleBackColor = true;
            buttonTraining.Click += buttonTraining_Click;
            // 
            // buttonWorking
            // 
            buttonWorking.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonWorking.Location = new Point(311, 197);
            buttonWorking.Margin = new Padding(3, 4, 3, 4);
            buttonWorking.Name = "buttonWorking";
            buttonWorking.Size = new Size(158, 59);
            buttonWorking.TabIndex = 4;
            buttonWorking.Text = "Работать";
            buttonWorking.UseVisualStyleBackColor = true;
            buttonWorking.Click += ButtonWorking_Click;
            // 
            // shopComboBox
            // 
            shopComboBox.FormattingEnabled = true;
            shopComboBox.Location = new Point(17, 65);
            shopComboBox.Margin = new Padding(3, 4, 3, 4);
            shopComboBox.Name = "shopComboBox";
            shopComboBox.Size = new Size(261, 40);
            shopComboBox.TabIndex = 5;
            // 
            // buttonBuyItem
            // 
            buttonBuyItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonBuyItem.Location = new Point(338, 168);
            buttonBuyItem.Margin = new Padding(3, 4, 3, 4);
            buttonBuyItem.Name = "buttonBuyItem";
            buttonBuyItem.Size = new Size(154, 44);
            buttonBuyItem.TabIndex = 6;
            buttonBuyItem.Text = "Купить";
            buttonBuyItem.UseVisualStyleBackColor = true;
            buttonBuyItem.Click += ButtonBuyItem_Click;
            // 
            // CharGroupBox
            // 
            CharGroupBox.Controls.Add(labelEnergy);
            CharGroupBox.Controls.Add(energyProgressBar);
            CharGroupBox.Controls.Add(buttonWorking);
            CharGroupBox.Controls.Add(labelStrength);
            CharGroupBox.Controls.Add(labelGold);
            CharGroupBox.Controls.Add(buttonTraining);
            CharGroupBox.Controls.Add(labelAgility);
            CharGroupBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CharGroupBox.Location = new Point(58, 24);
            CharGroupBox.Margin = new Padding(3, 4, 3, 4);
            CharGroupBox.Name = "CharGroupBox";
            CharGroupBox.Padding = new Padding(3, 4, 3, 4);
            CharGroupBox.Size = new Size(527, 423);
            CharGroupBox.TabIndex = 7;
            CharGroupBox.TabStop = false;
            CharGroupBox.Text = "Ваш персонаж";
            // 
            // labelEnergy
            // 
            labelEnergy.AutoSize = true;
            labelEnergy.Location = new Point(47, 320);
            labelEnergy.Name = "labelEnergy";
            labelEnergy.Size = new Size(110, 32);
            labelEnergy.TabIndex = 6;
            labelEnergy.Text = "Энергия:";
            // 
            // energyProgressBar
            // 
            energyProgressBar.Location = new Point(187, 306);
            energyProgressBar.Margin = new Padding(3, 4, 3, 4);
            energyProgressBar.Name = "energyProgressBar";
            energyProgressBar.Size = new Size(269, 57);
            energyProgressBar.TabIndex = 5;
            energyProgressBar.Value = 100;
            // 
            // ShopGroupBox
            // 
            ShopGroupBox.Controls.Add(labelShopItemDescription);
            ShopGroupBox.Controls.Add(labelShopItemCost);
            ShopGroupBox.Controls.Add(shopComboBox);
            ShopGroupBox.Controls.Add(buttonBuyItem);
            ShopGroupBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ShopGroupBox.Location = new Point(58, 482);
            ShopGroupBox.Margin = new Padding(3, 4, 3, 4);
            ShopGroupBox.Name = "ShopGroupBox";
            ShopGroupBox.Padding = new Padding(3, 4, 3, 4);
            ShopGroupBox.Size = new Size(527, 253);
            ShopGroupBox.TabIndex = 8;
            ShopGroupBox.TabStop = false;
            ShopGroupBox.Text = "Магазин";
            // 
            // labelShopItemDescription
            // 
            labelShopItemDescription.AutoSize = true;
            labelShopItemDescription.Location = new Point(33, 171);
            labelShopItemDescription.Name = "labelShopItemDescription";
            labelShopItemDescription.Size = new Size(237, 32);
            labelShopItemDescription.TabIndex = 8;
            labelShopItemDescription.Text = "Описание предмета";
            // 
            // labelShopItemCost
            // 
            labelShopItemCost.AutoSize = true;
            labelShopItemCost.Location = new Point(311, 69);
            labelShopItemCost.Name = "labelShopItemCost";
            labelShopItemCost.Size = new Size(96, 32);
            labelShopItemCost.TabIndex = 7;
            labelShopItemCost.Text = "Цена: 0";
            // 
            // buttonOpenArena
            // 
            buttonOpenArena.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOpenArena.Location = new Point(431, 755);
            buttonOpenArena.Margin = new Padding(3, 4, 3, 4);
            buttonOpenArena.Name = "buttonOpenArena";
            buttonOpenArena.Size = new Size(154, 60);
            buttonOpenArena.TabIndex = 9;
            buttonOpenArena.Text = "В бой!";
            buttonOpenArena.UseVisualStyleBackColor = true;
            buttonOpenArena.Click += ButtonOpenArena_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 843);
            Controls.Add(buttonOpenArena);
            Controls.Add(ShopGroupBox);
            Controls.Add(CharGroupBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RPGClicker";
            CharGroupBox.ResumeLayout(false);
            CharGroupBox.PerformLayout();
            ShopGroupBox.ResumeLayout(false);
            ShopGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelStrength;
        private Label labelAgility;
        private Label labelGold;
        private Button buttonTraining;
        private Button buttonWorking;
        private ComboBox shopComboBox;
        private Button buttonBuyItem;
        private GroupBox CharGroupBox;
        private GroupBox ShopGroupBox;
        private Button buttonOpenArena;
        private Label labelEnergy;
        private ProgressBar energyProgressBar;
        private Label labelShopItemCost;
        private Label labelShopItemDescription;
    }
}
