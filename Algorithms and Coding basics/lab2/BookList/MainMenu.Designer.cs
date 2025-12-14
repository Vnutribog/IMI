namespace BookList;

partial class MainMenu
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        showCatalogBtn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // showCatalogBtn
        // 
        showCatalogBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        showCatalogBtn.Location = new System.Drawing.Point(81, 170);
        showCatalogBtn.Name = "showCatalogBtn";
        showCatalogBtn.Size = new System.Drawing.Size(407, 68);
        showCatalogBtn.TabIndex = 0;
        showCatalogBtn.Text = "Перейти к каталогу книг";
        showCatalogBtn.UseVisualStyleBackColor = false;
        showCatalogBtn.Click += button1_Click;
        // 
        // MainMenu
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(582, 453);
        Controls.Add(showCatalogBtn);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Главное меню библиотеки";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button showCatalogBtn;

    #endregion
}