using Timer = System.Windows.Forms.Timer;

namespace RPGClicker
{
    public partial class Form1 : Form
    {

        private int strength = 1;
        private int agility = 1;
        private int gold = 50;
        private int energy = 100;

        private int agility_rune_cost = 10;
        private int strength_rune_cost = 20;
        private int energy_drink_cost = 30;
        private int bananas_cost = 5;

        private int trainingEnergyCost = 10;
        private int workingEnergyCost = 10;

        private Timer energyTimer;


        public Form1()
        {
            InitializeComponent();
            InitializeEnergyTimer();
            UpdateInterface();

            string[] shopItems = {
                "Руна ловкости",
                "Руна силы",
                "Энергетик",
                "Бананы"
            };

            shopComboBox.Items.AddRange(shopItems);
            shopComboBox.TextChanged += ShopComboBox_TextChanged;
        }

        private void UpdateInterface()
        {
            labelStrength.Text = $"Сила: {strength}";
            labelAgility.Text = $"Ловкость: {agility}";
            labelGold.Text = $"Золото: {gold}";
            energyProgressBar.Value = energy;

            buttonTraining.Enabled = energy > trainingEnergyCost;
            buttonWorking.Enabled = energy > workingEnergyCost;
            //buttonTraining.Enabled = energy > 0;
            //buttonWorking.Enabled = energy > 0;
        }

        private void ShopComboBox_TextChanged(object? sender, EventArgs e)
        {
            switch (shopComboBox.Text)
            {
                case "Руна ловкости":
                    labelShopItemCost.Text = $"Цена: {agility_rune_cost} золота";
                    labelShopItemDescription.Text = "Повышает ловкость";
                    break;

                case "Руна силы":
                    labelShopItemCost.Text = $"Цена: {strength_rune_cost} золота";
                    labelShopItemDescription.Text = "Повышает силу";
                    break;

                case "Энергетик":
                    labelShopItemCost.Text = $"Цена: {energy_drink_cost} золота";
                    labelShopItemDescription.Text = "100% энергии";
                    break;

                case "Бананы":
                    labelShopItemCost.Text = $"Цена: {bananas_cost} золота";
                    labelShopItemDescription.Text = "Немного энергии";
                    break;
            }
        }

        private void InitializeEnergyTimer()
        {
            energyTimer = new Timer();
            energyTimer.Interval = 1000;
            energyTimer.Tick += GameLoop;
            energyTimer.Start();
        }

        private void GameLoop(object? sender, EventArgs e)
        {
            energy = (energy > 0) ? energy - 1 : 0;
            UpdateInterface();
        }

        private void buttonTraining_Click(object sender, EventArgs e)
        {
            if (energy - trainingEnergyCost > 0)
            {
                energy -= trainingEnergyCost;
                strength++;
                UpdateInterface();
            }
        }

        private void ButtonWorking_Click(object sender, EventArgs e)
        {
            if (energy - workingEnergyCost > 0)
            {
                energy -= workingEnergyCost;
                gold += 10;
                UpdateInterface();
            }
        }

        private void ButtonOpenArena_Click(object sender, EventArgs e)
        {
            BattleForm battle = new(strength, agility);
            battle.onGoBack += () => Show();
            battle.Show();
            Hide();
        }

        private void ButtonBuyItem_Click(object sender, EventArgs e)
        {

            var price = shopComboBox.Text switch
            {
                "Руна ловкости" => agility_rune_cost,
                "Руна силы" => strength_rune_cost,
                "Энергетик" => energy_drink_cost,
                "Бананы" => bananas_cost,
                _ => 0
            };

            if (price <= gold) {
                switch (shopComboBox.Text)
                {
                    case "Руна ловкости": agility += 2; break;
                    case "Руна силы": strength++; break;
                    case "Энергетик": energy = 100; break;
                    case "Бананы": 
                        energy = Math.Clamp(energy + 20, 0, 100);
                        break;
                }
                gold -= price;
                UpdateInterface();
            }
            else
            {
                MessageBox.Show("Недостаточно золота", "Вы нищий", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
