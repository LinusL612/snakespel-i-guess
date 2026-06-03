namespace Texas_älskar_saker_upp_i_röven__sorterings_algoritmer_
{
    partial class Form1
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
            this.ItemBox = new System.Windows.Forms.ListBox();
            this.SortBtn = new System.Windows.Forms.Button();
            this.SortingButton = new System.Windows.Forms.Button();
            this.CountingSortBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemBox
            // 
            this.ItemBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.ItemBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ItemBox.FormattingEnabled = true;
            this.ItemBox.ItemHeight = 16;
            this.ItemBox.Location = new System.Drawing.Point(563, 12);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(112, 420);
            this.ItemBox.TabIndex = 0;
            // 
            // SortBtn
            // 
            this.SortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortBtn.Location = new System.Drawing.Point(12, 12);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(545, 175);
            this.SortBtn.TabIndex = 1;
            this.SortBtn.Text = "Bubblesort";
            this.SortBtn.UseVisualStyleBackColor = false;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // SortingButton
            // 
            this.SortingButton.BackColor = System.Drawing.Color.Red;
            this.SortingButton.Font = new System.Drawing.Font("Poor Richard", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortingButton.Location = new System.Drawing.Point(12, 185);
            this.SortingButton.Name = "SortingButton";
            this.SortingButton.Size = new System.Drawing.Size(545, 132);
            this.SortingButton.TabIndex = 2;
            this.SortingButton.Text = "Quicksort";
            this.SortingButton.UseVisualStyleBackColor = false;
            this.SortingButton.Click += new System.EventHandler(this.SortingButton_Click);
            // 
            // CountingSortBtn
            // 
            this.CountingSortBtn.BackColor = System.Drawing.Color.Cyan;
            this.CountingSortBtn.Font = new System.Drawing.Font("Mistral", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountingSortBtn.Location = new System.Drawing.Point(12, 314);
            this.CountingSortBtn.Name = "CountingSortBtn";
            this.CountingSortBtn.Size = new System.Drawing.Size(545, 124);
            this.CountingSortBtn.TabIndex = 3;
            this.CountingSortBtn.Text = "countingsort";
            this.CountingSortBtn.UseVisualStyleBackColor = false;
            this.CountingSortBtn.Click += new System.EventHandler(this.CountingSortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CountingSortBtn);
            this.Controls.Add(this.SortingButton);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.ItemBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ItemBox;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Button SortingButton;
        private System.Windows.Forms.Button CountingSortBtn;
    }
}

