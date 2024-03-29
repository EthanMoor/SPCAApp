﻿
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
            this.lblAnimalStats = new System.Windows.Forms.Label();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.listviewStats = new System.Windows.Forms.ListView();
            this.rtbOutputAnimalStats = new System.Windows.Forms.RichTextBox();
            this.btnEnterAddConsumption = new System.Windows.Forms.Button();
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
            this.btnBackAnimalStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackAnimalStats.Location = new System.Drawing.Point(360, 12);
            this.btnBackAnimalStats.Name = "btnBackAnimalStats";
            this.btnBackAnimalStats.Size = new System.Drawing.Size(80, 28);
            this.btnBackAnimalStats.TabIndex = 4;
            this.btnBackAnimalStats.Text = "Back";
            this.btnBackAnimalStats.UseVisualStyleBackColor = true;
            this.btnBackAnimalStats.Click += new System.EventHandler(this.btnBackAnimalStats_Click);
            // 
            // lblAnimalStats
            // 
            this.lblAnimalStats.AutoSize = true;
            this.lblAnimalStats.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAnimalStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimalStats.Location = new System.Drawing.Point(105, 15);
            this.lblAnimalStats.Name = "lblAnimalStats";
            this.lblAnimalStats.Size = new System.Drawing.Size(77, 13);
            this.lblAnimalStats.TabIndex = 14;
            this.lblAnimalStats.Text = "Animal Stats";
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.ForeColor = System.Drawing.Color.Black;
            this.lblSearchBy.Location = new System.Drawing.Point(12, 42);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(233, 19);
            this.lblSearchBy.TabIndex = 16;
            this.lblSearchBy.Text = "What do you want to search by?";
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(12, 64);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(424, 20);
            this.txbSearch.TabIndex = 19;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // listviewStats
            // 
            this.listviewStats.FullRowSelect = true;
            this.listviewStats.HideSelection = false;
            this.listviewStats.Location = new System.Drawing.Point(12, 90);
            this.listviewStats.Name = "listviewStats";
            this.listviewStats.Size = new System.Drawing.Size(424, 282);
            this.listviewStats.TabIndex = 20;
            this.listviewStats.UseCompatibleStateImageBehavior = false;
            this.listviewStats.SelectedIndexChanged += new System.EventHandler(this.listviewStats_SelectedIndexChanged);
            // 
            // rtbOutputAnimalStats
            // 
            this.rtbOutputAnimalStats.Location = new System.Drawing.Point(446, 12);
            this.rtbOutputAnimalStats.Name = "rtbOutputAnimalStats";
            this.rtbOutputAnimalStats.Size = new System.Drawing.Size(342, 426);
            this.rtbOutputAnimalStats.TabIndex = 21;
            this.rtbOutputAnimalStats.Text = "";
            // 
            // btnEnterAddConsumption
            // 
            this.btnEnterAddConsumption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.btnEnterAddConsumption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterAddConsumption.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterAddConsumption.Location = new System.Drawing.Point(12, 378);
            this.btnEnterAddConsumption.Name = "btnEnterAddConsumption";
            this.btnEnterAddConsumption.Size = new System.Drawing.Size(424, 60);
            this.btnEnterAddConsumption.TabIndex = 22;
            this.btnEnterAddConsumption.Text = "Enter";
            this.btnEnterAddConsumption.UseVisualStyleBackColor = false;
            this.btnEnterAddConsumption.Click += new System.EventHandler(this.btnEnterAddConsumption_Click);
            // 
            // AnimalStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnterAddConsumption);
            this.Controls.Add(this.rtbOutputAnimalStats);
            this.Controls.Add(this.listviewStats);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.lblAnimalStats);
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
        private System.Windows.Forms.Label lblAnimalStats;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.ListView listviewStats;
        private System.Windows.Forms.RichTextBox rtbOutputAnimalStats;
        private System.Windows.Forms.Button btnEnterAddConsumption;
    }
}