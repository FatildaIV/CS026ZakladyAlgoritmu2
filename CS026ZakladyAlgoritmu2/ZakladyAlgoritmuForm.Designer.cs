
namespace CS025ZakladyAlgoritmu
{
    partial class ZakladyAlgoritmuForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.algoritmyComboBox = new System.Windows.Forms.ComboBox();
            this.pokynyTextBox = new System.Windows.Forms.TextBox();
            this.vstupTextBox = new System.Windows.Forms.TextBox();
            this.vystupLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // algoritmyComboBox
            // 
            this.algoritmyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.algoritmyComboBox.FormattingEnabled = true;
            this.algoritmyComboBox.Items.AddRange(new object[] {
            "1) Nerovnost součet, jinak trojnásobek",
            "2) Když n<51, potom 51-n, jinak trojnásobek",
            "3) Jedno z čísel je 30, nebo jejich součet je 30",
            "4) Číslo mezi 10 a 100, nebo číslo je 200"});
            this.algoritmyComboBox.Location = new System.Drawing.Point(31, 28);
            this.algoritmyComboBox.Name = "algoritmyComboBox";
            this.algoritmyComboBox.Size = new System.Drawing.Size(620, 32);
            this.algoritmyComboBox.TabIndex = 0;
            this.algoritmyComboBox.SelectedIndexChanged += new System.EventHandler(this.algoritmyComboBox_SelectedIndexChanged);
            this.algoritmyComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.algoritmyComboBox_KeyDown);
            // 
            // pokynyTextBox
            // 
            this.pokynyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.pokynyTextBox.Location = new System.Drawing.Point(31, 81);
            this.pokynyTextBox.Multiline = true;
            this.pokynyTextBox.Name = "pokynyTextBox";
            this.pokynyTextBox.Size = new System.Drawing.Size(619, 126);
            this.pokynyTextBox.TabIndex = 1;
            // 
            // vstupTextBox
            // 
            this.vstupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.vstupTextBox.Location = new System.Drawing.Point(31, 231);
            this.vstupTextBox.Name = "vstupTextBox";
            this.vstupTextBox.Size = new System.Drawing.Size(619, 29);
            this.vstupTextBox.TabIndex = 2;
            this.vstupTextBox.TextChanged += new System.EventHandler(this.vstupTextBox_TextChanged);
            // 
            // vystupLabel
            // 
            this.vystupLabel.AutoSize = true;
            this.vystupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.vystupLabel.Location = new System.Drawing.Point(26, 281);
            this.vystupLabel.Name = "vystupLabel";
            this.vystupLabel.Size = new System.Drawing.Size(43, 26);
            this.vystupLabel.TabIndex = 3;
            this.vystupLabel.Text = "= ?";
            // 
            // ZakladyAlgoritmuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 370);
            this.Controls.Add(this.vystupLabel);
            this.Controls.Add(this.vstupTextBox);
            this.Controls.Add(this.pokynyTextBox);
            this.Controls.Add(this.algoritmyComboBox);
            this.Name = "ZakladyAlgoritmuForm";
            this.Text = "CS026ZakladyAlgoritmu2 - Michael Krejbich";
            this.Load += new System.EventHandler(this.ZakladyAlgoritmuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox algoritmyComboBox;
        private System.Windows.Forms.TextBox pokynyTextBox;
        private System.Windows.Forms.TextBox vstupTextBox;
        private System.Windows.Forms.Label vystupLabel;
    }
}

