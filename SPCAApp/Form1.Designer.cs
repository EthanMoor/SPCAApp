
namespace SPCAApp
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
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.cmbbSpecies = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.lblFood = new System.Windows.Forms.Label();
            this.nudFood = new System.Windows.Forms.NumericUpDown();
            this.btnEnter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFood)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(446, 12);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(342, 426);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SPCA App";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSpecies.Location = new System.Drawing.Point(12, 40);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(66, 19);
            this.lblSpecies.TabIndex = 2;
            this.lblSpecies.Text = "Species?";
            // 
            // cmbbSpecies
            // 
            this.cmbbSpecies.FormattingEnabled = true;
            this.cmbbSpecies.Items.AddRange(new object[] {
            "Bird",
            "Cat",
            "Dog",
            "Guinea Pig",
            "Lizard"});
            this.cmbbSpecies.Location = new System.Drawing.Point(16, 62);
            this.cmbbSpecies.Name = "cmbbSpecies";
            this.cmbbSpecies.Size = new System.Drawing.Size(146, 21);
            this.cmbbSpecies.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblName.Location = new System.Drawing.Point(12, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 19);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name?";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(16, 108);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(146, 20);
            this.txbName.TabIndex = 7;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDay.Location = new System.Drawing.Point(12, 131);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(82, 19);
            this.lblDay.TabIndex = 8;
            this.lblDay.Text = "What day?";
            // 
            // nudDay
            // 
            this.nudDay.Location = new System.Drawing.Point(16, 153);
            this.nudDay.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(146, 20);
            this.nudDay.TabIndex = 9;
            this.nudDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFood.Location = new System.Drawing.Point(182, 131);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(180, 19);
            this.lblFood.TabIndex = 10;
            this.lblFood.Text = "How much did it eat? (g)";
            // 
            // nudFood
            // 
            this.nudFood.Location = new System.Drawing.Point(186, 153);
            this.nudFood.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudFood.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFood.Name = "nudFood";
            this.nudFood.Size = new System.Drawing.Size(146, 20);
            this.nudFood.TabIndex = 11;
            this.nudFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(12, 378);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(428, 60);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.nudFood);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.nudDay);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbbSpecies);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rtbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.ComboBox cmbbSpecies;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.NumericUpDown nudFood;
        private System.Windows.Forms.Button btnEnter;
    }
}

