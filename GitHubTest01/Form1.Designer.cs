namespace GitHubTest01
{
    partial class Form1
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
            this.button1_Test1 = new System.Windows.Forms.Button();
            this.button2_Test2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_Test1
            // 
            this.button1_Test1.Location = new System.Drawing.Point(95, 89);
            this.button1_Test1.Name = "button1_Test1";
            this.button1_Test1.Size = new System.Drawing.Size(75, 23);
            this.button1_Test1.TabIndex = 0;
            this.button1_Test1.Text = "Test 1";
            this.button1_Test1.UseVisualStyleBackColor = true;
            this.button1_Test1.Click += new System.EventHandler(this.button1_Test1_Click);
            // 
            // button2_Test2
            // 
            this.button2_Test2.Location = new System.Drawing.Point(262, 89);
            this.button2_Test2.Name = "button2_Test2";
            this.button2_Test2.Size = new System.Drawing.Size(75, 23);
            this.button2_Test2.TabIndex = 1;
            this.button2_Test2.Text = "Test 2";
            this.button2_Test2.UseVisualStyleBackColor = true;
            this.button2_Test2.Click += new System.EventHandler(this.button2_Test2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2_Test2);
            this.Controls.Add(this.button1_Test1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_Test1;
        private System.Windows.Forms.Button button2_Test2;
    }
}

