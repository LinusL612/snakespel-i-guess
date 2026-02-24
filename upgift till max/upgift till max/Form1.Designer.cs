namespace upgift_till_max
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
            this.components = new System.ComponentModel.Container();
            this.updbtn = new System.Windows.Forms.Button();
            this.Penistimer = new System.Windows.Forms.Timer(this.components);
            this.scorebord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updbtn
            // 
            this.updbtn.BackColor = System.Drawing.Color.Red;
            this.updbtn.Location = new System.Drawing.Point(-12, 402);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(827, 52);
            this.updbtn.TabIndex = 0;
            this.updbtn.Text = "KILL YOUR SELF";
            this.updbtn.UseVisualStyleBackColor = false;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // Penistimer
            // 
            this.Penistimer.Enabled = true;
            this.Penistimer.Interval = 75;
            this.Penistimer.Tick += new System.EventHandler(this.Penistimer_Tick);
            // 
            // scorebord
            // 
            this.scorebord.AutoSize = true;
            this.scorebord.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scorebord.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorebord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scorebord.Location = new System.Drawing.Point(690, 9);
            this.scorebord.Name = "scorebord";
            this.scorebord.Size = new System.Drawing.Size(102, 26);
            this.scorebord.TabIndex = 1;
            this.scorebord.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scorebord);
            this.Controls.Add(this.updbtn);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Timer Penistimer;
        private System.Windows.Forms.Label scorebord;
    }
}

