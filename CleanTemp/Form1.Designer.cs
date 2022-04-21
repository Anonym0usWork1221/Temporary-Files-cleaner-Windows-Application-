namespace CleanTemp
{
    partial class TempCleaner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TempCleaner));
            this.cleanBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.files_dump = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cleanBtn
            // 
            this.cleanBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cleanBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cleanBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cleanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cleanBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cleanBtn.FlatAppearance.BorderSize = 3;
            this.cleanBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.cleanBtn.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cleanBtn.Location = new System.Drawing.Point(12, 131);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(122, 44);
            this.cleanBtn.TabIndex = 0;
            this.cleanBtn.Text = "Clean";
            this.cleanBtn.UseVisualStyleBackColor = false;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // files_dump
            // 
            this.files_dump.BackColor = System.Drawing.Color.Gray;
            this.files_dump.Cursor = System.Windows.Forms.Cursors.Hand;
            this.files_dump.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.files_dump.Location = new System.Drawing.Point(830, 100);
            this.files_dump.Multiline = true;
            this.files_dump.Name = "files_dump";
            this.files_dump.ReadOnly = true;
            this.files_dump.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.files_dump.Size = new System.Drawing.Size(350, 746);
            this.files_dump.TabIndex = 4;
            // 
            // l1
            // 
            this.l1.BackColor = System.Drawing.Color.Gold;
            this.l1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l1.Font = new System.Drawing.Font("SimSun", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(830, 58);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(350, 39);
            this.l1.TabIndex = 5;
            this.l1.Text = "Remainings After Clean";
            this.l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(12, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1100, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 54);
            this.button3.TabIndex = 7;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TempCleaner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1180, 1044);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.files_dump);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cleanBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TempCleaner";
            this.Text = "Temp Cleaner";
            this.Load += new System.EventHandler(this.TempCleaner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox files_dump;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

