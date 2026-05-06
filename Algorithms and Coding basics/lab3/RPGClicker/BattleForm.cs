namespace RPGClicker
{
    public partial class BattleForm : Form
    {
        private Random rng = new Random();
        private int villainHP = 100;
        private int heroDamage;
        private int critChance;
        public Action onGoBack;

        public BattleForm(int heroStrength, int heroAgility)
        {
            InitializeComponent();
            progressBarVillainHP.Value = villainHP;
            heroDamage = heroStrength * 2;
            critChance = heroAgility;
        }

        private void ButtonRetire_Click(object sender, EventArgs e)
        {
            onGoBack?.Invoke();
            this.Close();
        }

        private void ButtonHitVillain_Click(object sender, EventArgs e)
        {
            if (rng.Next(1, 100) < critChance) {
                villainHP -= heroDamage * 2;
            }
            else
            {
                villainHP -= heroDamage;
            }

            villainHP = Math.Clamp(villainHP, 0, 100);
            progressBarVillainHP.Value = villainHP;

            if (villainHP <= 0) 
            {
                MessageBox.Show("Победа", "Что может быть лучше", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonHitVillain.Enabled = false;
            }
        }
    }
}
