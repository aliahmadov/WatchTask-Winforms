namespace Task1_WinForms
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
            this.londonBtn = new System.Windows.Forms.Button();
            this.bakuBtn = new System.Windows.Forms.Button();
            this.headLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // londonBtn
            // 
            this.londonBtn.BackColor = System.Drawing.Color.Blue;
            this.londonBtn.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.londonBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.londonBtn.Location = new System.Drawing.Point(558, 467);
            this.londonBtn.Name = "londonBtn";
            this.londonBtn.Size = new System.Drawing.Size(280, 74);
            this.londonBtn.TabIndex = 0;
            this.londonBtn.Text = "London";
            this.londonBtn.UseVisualStyleBackColor = false;
            this.londonBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // bakuBtn
            // 
            this.bakuBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.bakuBtn.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakuBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.bakuBtn.Location = new System.Drawing.Point(140, 467);
            this.bakuBtn.Name = "bakuBtn";
            this.bakuBtn.Size = new System.Drawing.Size(280, 74);
            this.bakuBtn.TabIndex = 1;
            this.bakuBtn.Text = "Baku";
            this.bakuBtn.UseVisualStyleBackColor = false;
            this.bakuBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // headLbl
            // 
            this.headLbl.AutoSize = true;
            this.headLbl.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLbl.Location = new System.Drawing.Point(353, 108);
            this.headLbl.Name = "headLbl";
            this.headLbl.Size = new System.Drawing.Size(282, 62);
            this.headLbl.TabIndex = 2;
            this.headLbl.Text = "Time Info";
            this.headLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.headLbl);
            this.Controls.Add(this.bakuBtn);
            this.Controls.Add(this.londonBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button londonBtn;
        private System.Windows.Forms.Button bakuBtn;
        private System.Windows.Forms.Label headLbl;
    }
}

