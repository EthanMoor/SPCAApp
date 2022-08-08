
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
            this.btnEnterAnimalStats = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.listviewStats = new System.Windows.Forms.ListView();
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
            this.btnBackAnimalStats.Location = new System.Drawing.Point(372, 12);
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
            this.lblSearchBy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSearchBy.Location = new System.Drawing.Point(12, 42);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(233, 19);
            this.lblSearchBy.TabIndex = 16;
            this.lblSearchBy.Text = "What do you want to search by?";
            // 
            // btnEnterAnimalStats
            // 
            this.btnEnterAnimalStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.btnEnterAnimalStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterAnimalStats.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterAnimalStats.Location = new System.Drawing.Point(12, 378);
            this.btnEnterAnimalStats.Name = "btnEnterAnimalStats";
            this.btnEnterAnimalStats.Size = new System.Drawing.Size(428, 60);
            this.btnEnterAnimalStats.TabIndex = 18;
            this.btnEnterAnimalStats.Text = "Enter";
            this.btnEnterAnimalStats.UseVisualStyleBackColor = false;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(16, 64);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(229, 20);
            this.txbSearch.TabIndex = 19;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // listviewStats
            // 
            this.listviewStats.HideSelection = false;
            this.listviewStats.Location = new System.Drawing.Point(458, 9);
            this.listviewStats.Name = "listviewStats";
            this.listviewStats.Size = new System.Drawing.Size(328, 428);
            this.listviewStats.TabIndex = 20;
            this.listviewStats.UseCompatibleStateImageBehavior = false;
            // 
            // AnimalStats
            // 
            this.AcceptButton = this.btnEnterAnimalStats;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listviewStats);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnEnterAnimalStats);
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
        private System.Windows.Forms.Button btnEnterAnimalStats;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.ListView listviewStats;
    }
}