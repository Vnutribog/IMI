namespace RPGClicker
{
    partial class BattleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleForm));
            pictureBoxHero = new PictureBox();
            pictureBoxVillain = new PictureBox();
            progressBarVillainHP = new ProgressBar();
            buttonHitVillain = new Button();
            buttonRetire = new Button();
            labelHero = new Label();
            labelVillain = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVillain).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxHero
            // 
            pictureBoxHero.Image = (Image)resources.GetObject("pictureBoxHero.Image");
            pictureBoxHero.Location = new Point(34, 159);
            pictureBoxHero.Margin = new Padding(3, 4, 3, 4);
            pictureBoxHero.Name = "pictureBoxHero";
            pictureBoxHero.Size = new Size(251, 308);
            pictureBoxHero.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHero.TabIndex = 0;
            pictureBoxHero.TabStop = false;
            // 
            // pictureBoxVillain
            // 
            pictureBoxVillain.Image = (Image)resources.GetObject("pictureBoxVillain.Image");
            pictureBoxVillain.Location = new Point(370, 159);
            pictureBoxVillain.Margin = new Padding(3, 4, 3, 4);
            pictureBoxVillain.Name = "pictureBoxVillain";
            pictureBoxVillain.Size = new Size(251, 308);
            pictureBoxVillain.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxVillain.TabIndex = 1;
            pictureBoxVillain.TabStop = false;
            // 
            // progressBarVillainHP
            // 
            progressBarVillainHP.Location = new Point(370, 519);
            progressBarVillainHP.Margin = new Padding(3, 4, 3, 4);
            progressBarVillainHP.Name = "progressBarVillainHP";
            progressBarVillainHP.Size = new Size(251, 43);
            progressBarVillainHP.TabIndex = 3;
            progressBarVillainHP.Value = 100;
            // 
            // buttonHitVillain
            // 
            buttonHitVillain.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHitVillain.Location = new Point(370, 635);
            buttonHitVillain.Margin = new Padding(3, 4, 3, 4);
            buttonHitVillain.Name = "buttonHitVillain";
            buttonHitVillain.Size = new Size(251, 60);
            buttonHitVillain.TabIndex = 4;
            buttonHitVillain.Text = "Ударить!";
            buttonHitVillain.UseVisualStyleBackColor = true;
            buttonHitVillain.Click += ButtonHitVillain_Click;
            // 
            // buttonRetire
            // 
            buttonRetire.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRetire.Location = new Point(34, 635);
            buttonRetire.Margin = new Padding(3, 4, 3, 4);
            buttonRetire.Name = "buttonRetire";
            buttonRetire.Size = new Size(251, 60);
            buttonRetire.TabIndex = 5;
            buttonRetire.Text = "Отступить";
            buttonRetire.UseVisualStyleBackColor = true;
            buttonRetire.Click += ButtonRetire_Click;
            // 
            // labelHero
            // 
            labelHero.AutoSize = true;
            labelHero.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelHero.Location = new Point(122, 45);
            labelHero.Name = "labelHero";
            labelHero.Size = new Size(92, 37);
            labelHero.TabIndex = 6;
            labelHero.Text = "Герой";
            // 
            // labelVillain
            // 
            labelVillain.AutoSize = true;
            labelVillain.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelVillain.Location = new Point(459, 45);
            labelVillain.Name = "labelVillain";
            labelVillain.Size = new Size(107, 37);
            labelVillain.TabIndex = 7;
            labelVillain.Text = "Злодей";
            // 
            // BattleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 843);
            Controls.Add(labelVillain);
            Controls.Add(labelHero);
            Controls.Add(buttonRetire);
            Controls.Add(buttonHitVillain);
            Controls.Add(progressBarVillainHP);
            Controls.Add(pictureBoxVillain);
            Controls.Add(pictureBoxHero);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BattleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RPGClicker";
            ((System.ComponentModel.ISupportInitialize)pictureBoxHero).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVillain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxHero;
        private PictureBox pictureBoxVillain;
        private ProgressBar progressBarVillainHP;
        private Button buttonHitVillain;
        private Button buttonRetire;
        private Label labelHero;
        private Label labelVillain;
    }
}