
namespace SPCAAppGui
{
    partial class AnimalStats
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBackAnimalStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(120)))), ((int)(((byte)(198)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 21);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "SPCA App";
            // 
            // btnBackAnimalStats
            // 
            this.btnBackAnimalStats.Location = new System.Drawing.Point(708, 12);
            this.btnBackAnimalStats.Name = "btnBackAnimalStats";
            this.btnBackAnimalStats.Size = new System.Drawing.Size(80, 28);
            this.btnBackAnimalStats.TabIndex = 4;
            this.btnBackAnimalStats.Text = "Back";
            this.btnBackAnimalStats.UseVisualStyleBackColor = true;
            this.btnBackAnimalStats.Click += new System.EventHandler(this.btnBackAnimalStats_Click);
            // 
            // AnimalStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackAnimalStats);
            this.Controls.Add(this.lblTitle);
            this.Name = "AnimalStats";
            this.Text = "AnimalStats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBackAnimalStats;
    }
}