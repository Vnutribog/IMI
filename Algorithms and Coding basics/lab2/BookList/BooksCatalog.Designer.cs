using System.ComponentModel;

namespace BookList;

partial class BooksCatalog
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        bookNameLabel = new System.Windows.Forms.Label();
        bookNameTextBox = new System.Windows.Forms.TextBox();
        bookListBox = new System.Windows.Forms.ListBox();
        showMainMenuBtn = new System.Windows.Forms.Button();
        addBookBtn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // bookNameLabel
        // 
        bookNameLabel.Location = new System.Drawing.Point(32, 37);
        bookNameLabel.Name = "bookNameLabel";
        bookNameLabel.Size = new System.Drawing.Size(134, 25);
        bookNameLabel.TabIndex = 0;
        bookNameLabel.Text = "Название книги:";
        // 
        // bookNameTextBox
        // 
        bookNameTextBox.Location = new System.Drawing.Point(182, 35);
        bookNameTextBox.Name = "bookNameTextBox";
        bookNameTextBox.Size = new System.Drawing.Size(357, 27);
        bookNameTextBox.TabIndex = 1;
        // 
        // bookListBox
        // 
        bookListBox.FormattingEnabled = true;
        bookListBox.Location = new System.Drawing.Point(32, 156);
        bookListBox.Name = "bookListBox";
        bookListBox.Size = new System.Drawing.Size(507, 384);
        bookListBox.TabIndex = 2;
        // 
        // showMainMenuBtn
        // 
        showMainMenuBtn.Location = new System.Drawing.Point(392, 561);
        showMainMenuBtn.Name = "showMainMenuBtn";
        showMainMenuBtn.Size = new System.Drawing.Size(147, 37);
        showMainMenuBtn.TabIndex = 3;
        showMainMenuBtn.Text = "Вернуться";
        showMainMenuBtn.UseVisualStyleBackColor = true;
        showMainMenuBtn.Click += showMainMenuBtn_Click;
        // 
        // addBookBtn
        // 
        addBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)((byte)221)), ((int)((byte)228)), ((int)((byte)255)));
        addBookBtn.Location = new System.Drawing.Point(392, 80);
        addBookBtn.Name = "addBookBtn";
        addBookBtn.Size = new System.Drawing.Size(147, 37);
        addBookBtn.TabIndex = 4;
        addBookBtn.Text = "Добавить";
        addBookBtn.UseVisualStyleBackColor = false;
        addBookBtn.Click += addBookBtn_Click;
        // 
        // BooksCatalog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(582, 653);
        Controls.Add(addBookBtn);
        Controls.Add(showMainMenuBtn);
        Controls.Add(bookListBox);
        Controls.Add(bookNameTextBox);
        Controls.Add(bookNameLabel);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "BooksCatalog";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button addBookBtn;

    private System.Windows.Forms.Button showMainMenuBtn;

    private System.Windows.Forms.ListBox bookListBox;

    private System.Windows.Forms.Label bookNameLabel;
    private System.Windows.Forms.TextBox bookNameTextBox;

    #endregion
}