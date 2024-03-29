﻿
namespace SPCAAppGui
{
    partial class Home
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
            this.lblHome = new System.Windows.Forms.Label();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnAddConsumption = new System.Windows.Forms.Button();
            this.btnViewStats = new System.Windows.Forms.Button();
            this.lblRequired = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(343, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 21);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "SPCA App";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(366, 39);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(39, 13);
            this.lblHome.TabIndex = 3;
            this.lblHome.Text = "Home";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAnimal.Location = new System.Drawing.Point(273, 55);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(231, 35);
            this.btnAddAnimal.TabIndex = 4;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnAddConsumption
            // 
            this.btnAddConsumption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddConsumption.Location = new System.Drawing.Point(273, 96);
            this.btnAddConsumption.Name = "btnAddConsumption";
            this.btnAddConsumption.Size = new System.Drawing.Size(231, 35);
            this.btnAddConsumption.TabIndex = 5;
            this.btnAddConsumption.Text = "Add Consumption";
            this.btnAddConsumption.UseVisualStyleBackColor = true;
            this.btnAddConsumption.Click += new System.EventHandler(this.btnAddConsumption_Click);
            // 
            // btnViewStats
            // 
            this.btnViewStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewStats.Location = new System.Drawing.Point(273, 137);
            this.btnViewStats.Name = "btnViewStats";
            this.btnViewStats.Size = new System.Drawing.Size(231, 35);
            this.btnViewStats.TabIndex = 6;
            this.btnViewStats.Text = "View Stats";
            this.btnViewStats.UseVisualStyleBackColor = true;
            this.btnViewStats.Click += new System.EventHandler(this.btnViewStats_Click);
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Location = new System.Drawing.Point(510, 55);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(181, 13);
            this.lblRequired.TabIndex = 7;
            this.lblRequired.Text = "*Required for Consumption and Stats";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.btnViewStats);
            this.Controls.Add(this.btnAddConsumption);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblTitle);
            this.Name = "Home";
            this.Text = "SPCA Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnAddConsumption;
        private System.Windows.Forms.Button btnViewStats;
        private System.Windows.Forms.Label lblRequired;
    }
}