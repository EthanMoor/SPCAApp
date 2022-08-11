
namespace SPCAAppGui
{
    partial class AddAnimal
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
            this.rtbOutputAddAnimal = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.cmbbSpecies = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnEnterAddAnimal = new System.Windows.Forms.Button();
            this.lblAddAnimal = new System.Windows.Forms.Label();
            this.btnBackAddAnimal = new System.Windows.Forms.Button();
            this.btnAddAnimalClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOutputAddAnimal
            // 
            this.rtbOutputAddAnimal.Location = new System.Drawing.Point(446, 12);
            this.rtbOutputAddAnimal.Name = "rtbOutputAddAnimal";
            this.rtbOutputAddAnimal.Size = new System.Drawing.Size(342, 426);
            this.rtbOutputAddAnimal.TabIndex = 0;
            this.rtbOutputAddAnimal.Text = "";
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
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SPCA App";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.ForeColor = System.Drawing.Color.Black;
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
            "Cat",
            "Dog",
            "Guinea Pig",
            "Horse",
            "Bunny",
            "Chicken",
            "Duck"});
            this.cmbbSpecies.Location = new System.Drawing.Point(16, 62);
            this.cmbbSpecies.Name = "cmbbSpecies";
            this.cmbbSpecies.Size = new System.Drawing.Size(146, 21);
            this.cmbbSpecies.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
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
            // btnEnterAddAnimal
            // 
            this.btnEnterAddAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.btnEnterAddAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterAddAnimal.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterAddAnimal.Location = new System.Drawing.Point(12, 378);
            this.btnEnterAddAnimal.Name = "btnEnterAddAnimal";
            this.btnEnterAddAnimal.Size = new System.Drawing.Size(428, 60);
            this.btnEnterAddAnimal.TabIndex = 12;
            this.btnEnterAddAnimal.Text = "Enter";
            this.btnEnterAddAnimal.UseVisualStyleBackColor = false;
            this.btnEnterAddAnimal.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblAddAnimal
            // 
            this.lblAddAnimal.AutoSize = true;
            this.lblAddAnimal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAnimal.Location = new System.Drawing.Point(105, 15);
            this.lblAddAnimal.Name = "lblAddAnimal";
            this.lblAddAnimal.Size = new System.Drawing.Size(89, 13);
            this.lblAddAnimal.TabIndex = 13;
            this.lblAddAnimal.Text = "Add An Animal";
            // 
            // btnBackAddAnimal
            // 
            this.btnBackAddAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackAddAnimal.Location = new System.Drawing.Point(365, 12);
            this.btnBackAddAnimal.Name = "btnBackAddAnimal";
            this.btnBackAddAnimal.Size = new System.Drawing.Size(75, 27);
            this.btnBackAddAnimal.TabIndex = 14;
            this.btnBackAddAnimal.Text = "Back";
            this.btnBackAddAnimal.UseVisualStyleBackColor = true;
            this.btnBackAddAnimal.Click += new System.EventHandler(this.btnBackAddAnimal_Click);
            // 
            // btnAddAnimalClear
            // 
            this.btnAddAnimalClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAnimalClear.Location = new System.Drawing.Point(365, 45);
            this.btnAddAnimalClear.Name = "btnAddAnimalClear";
            this.btnAddAnimalClear.Size = new System.Drawing.Size(75, 27);
            this.btnAddAnimalClear.TabIndex = 15;
            this.btnAddAnimalClear.Text = "Clear";
            this.btnAddAnimalClear.UseVisualStyleBackColor = true;
            this.btnAddAnimalClear.Click += new System.EventHandler(this.btnAddAnimalClear_Click);
            // 
            // AddAnimal
            // 
            this.AcceptButton = this.btnEnterAddAnimal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddAnimalClear);
            this.Controls.Add(this.btnBackAddAnimal);
            this.Controls.Add(this.lblAddAnimal);
            this.Controls.Add(this.btnEnterAddAnimal);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbbSpecies);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rtbOutputAddAnimal);
            this.Name = "AddAnimal";
            this.Text = "AddAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutputAddAnimal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.ComboBox cmbbSpecies;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnEnterAddAnimal;
        private System.Windows.Forms.Label lblAddAnimal;
        private System.Windows.Forms.Button btnBackAddAnimal;
        private System.Windows.Forms.Button btnAddAnimalClear;
    }
}

