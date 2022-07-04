
namespace SPCAAppGui
{
    partial class AddConsumption
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBackAddConsumption = new System.Windows.Forms.Button();
            this.lblAddConsumption = new System.Windows.Forms.Label();
            this.rtbOutputAddConsumption = new System.Windows.Forms.RichTextBox();
            this.btnEnterAddConsumption = new System.Windows.Forms.Button();
            this.lblAddConsumptionWhichAnimal = new System.Windows.Forms.Label();
            this.lblAddConsumptionWhichDay = new System.Windows.Forms.Label();
            this.dgvAnimalTable = new System.Windows.Forms.DataGridView();
            this.lblAddConsumptionHowMuchEaten = new System.Windows.Forms.Label();
            this.nudAddConsumptionHowMuchEaten = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddConsumptionHowMuchEaten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "SPCA App";
            // 
            // btnBackAddConsumption
            // 
            this.btnBackAddConsumption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackAddConsumption.Location = new System.Drawing.Point(365, 12);
            this.btnBackAddConsumption.Name = "btnBackAddConsumption";
            this.btnBackAddConsumption.Size = new System.Drawing.Size(75, 23);
            this.btnBackAddConsumption.TabIndex = 4;
            this.btnBackAddConsumption.Text = "Back";
            this.btnBackAddConsumption.UseVisualStyleBackColor = true;
            this.btnBackAddConsumption.Click += new System.EventHandler(this.btnBackAddConsumption_Click);
            // 
            // lblAddConsumption
            // 
            this.lblAddConsumption.AutoSize = true;
            this.lblAddConsumption.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAddConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddConsumption.Location = new System.Drawing.Point(105, 15);
            this.lblAddConsumption.Name = "lblAddConsumption";
            this.lblAddConsumption.Size = new System.Drawing.Size(105, 13);
            this.lblAddConsumption.TabIndex = 14;
            this.lblAddConsumption.Text = "Add Consumption";
            // 
            // rtbOutputAddConsumption
            // 
            this.rtbOutputAddConsumption.Location = new System.Drawing.Point(446, 12);
            this.rtbOutputAddConsumption.Name = "rtbOutputAddConsumption";
            this.rtbOutputAddConsumption.Size = new System.Drawing.Size(342, 426);
            this.rtbOutputAddConsumption.TabIndex = 15;
            this.rtbOutputAddConsumption.Text = "";
            // 
            // btnEnterAddConsumption
            // 
            this.btnEnterAddConsumption.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEnterAddConsumption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterAddConsumption.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterAddConsumption.Location = new System.Drawing.Point(12, 378);
            this.btnEnterAddConsumption.Name = "btnEnterAddConsumption";
            this.btnEnterAddConsumption.Size = new System.Drawing.Size(428, 60);
            this.btnEnterAddConsumption.TabIndex = 17;
            this.btnEnterAddConsumption.Text = "Enter";
            this.btnEnterAddConsumption.UseVisualStyleBackColor = false;
            // 
            // lblAddConsumptionWhichAnimal
            // 
            this.lblAddConsumptionWhichAnimal.AutoSize = true;
            this.lblAddConsumptionWhichAnimal.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddConsumptionWhichAnimal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAddConsumptionWhichAnimal.Location = new System.Drawing.Point(12, 42);
            this.lblAddConsumptionWhichAnimal.Name = "lblAddConsumptionWhichAnimal";
            this.lblAddConsumptionWhichAnimal.Size = new System.Drawing.Size(112, 19);
            this.lblAddConsumptionWhichAnimal.TabIndex = 18;
            this.lblAddConsumptionWhichAnimal.Text = "Which Animal?";
            // 
            // lblAddConsumptionWhichDay
            // 
            this.lblAddConsumptionWhichDay.AutoSize = true;
            this.lblAddConsumptionWhichDay.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddConsumptionWhichDay.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAddConsumptionWhichDay.Location = new System.Drawing.Point(12, 165);
            this.lblAddConsumptionWhichDay.Name = "lblAddConsumptionWhichDay";
            this.lblAddConsumptionWhichDay.Size = new System.Drawing.Size(90, 19);
            this.lblAddConsumptionWhichDay.TabIndex = 19;
            this.lblAddConsumptionWhichDay.Text = "Which Day?";
            // 
            // dgvAnimalTable
            // 
            this.dgvAnimalTable.AllowUserToOrderColumns = true;
            this.dgvAnimalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimalTable.Location = new System.Drawing.Point(12, 63);
            this.dgvAnimalTable.Name = "dgvAnimalTable";
            this.dgvAnimalTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimalTable.Size = new System.Drawing.Size(361, 99);
            this.dgvAnimalTable.TabIndex = 20;
            this.dgvAnimalTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimalTable_CellContentClick);
            // 
            // lblAddConsumptionHowMuchEaten
            // 
            this.lblAddConsumptionHowMuchEaten.AutoSize = true;
            this.lblAddConsumptionHowMuchEaten.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddConsumptionHowMuchEaten.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAddConsumptionHowMuchEaten.Location = new System.Drawing.Point(192, 165);
            this.lblAddConsumptionHowMuchEaten.Name = "lblAddConsumptionHowMuchEaten";
            this.lblAddConsumptionHowMuchEaten.Size = new System.Drawing.Size(158, 19);
            this.lblAddConsumptionHowMuchEaten.TabIndex = 21;
            this.lblAddConsumptionHowMuchEaten.Text = "How Much Eaten (g)?";
            // 
            // nudAddConsumptionHowMuchEaten
            // 
            this.nudAddConsumptionHowMuchEaten.Location = new System.Drawing.Point(196, 187);
            this.nudAddConsumptionHowMuchEaten.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudAddConsumptionHowMuchEaten.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAddConsumptionHowMuchEaten.Name = "nudAddConsumptionHowMuchEaten";
            this.nudAddConsumptionHowMuchEaten.Size = new System.Drawing.Size(177, 20);
            this.nudAddConsumptionHowMuchEaten.TabIndex = 22;
            this.nudAddConsumptionHowMuchEaten.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(SPCAAppGui.Animal);
            // 
            // animalBindingSource1
            // 
            this.animalBindingSource1.DataSource = typeof(SPCAAppGui.Animal);
            // 
            // AddConsumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nudAddConsumptionHowMuchEaten);
            this.Controls.Add(this.lblAddConsumptionHowMuchEaten);
            this.Controls.Add(this.dgvAnimalTable);
            this.Controls.Add(this.lblAddConsumptionWhichDay);
            this.Controls.Add(this.lblAddConsumptionWhichAnimal);
            this.Controls.Add(this.btnEnterAddConsumption);
            this.Controls.Add(this.rtbOutputAddConsumption);
            this.Controls.Add(this.lblAddConsumption);
            this.Controls.Add(this.btnBackAddConsumption);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddConsumption";
            this.Text = "AddConsumption";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddConsumptionHowMuchEaten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBackAddConsumption;
        private System.Windows.Forms.Label lblAddConsumption;
        private System.Windows.Forms.RichTextBox rtbOutputAddConsumption;
        private System.Windows.Forms.Button btnEnterAddConsumption;
        private System.Windows.Forms.Label lblAddConsumptionWhichAnimal;
        private System.Windows.Forms.Label lblAddConsumptionWhichDay;
        private System.Windows.Forms.DataGridView dgvAnimalTable;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.BindingSource animalBindingSource1;
        private System.Windows.Forms.Label lblAddConsumptionHowMuchEaten;
        private System.Windows.Forms.NumericUpDown nudAddConsumptionHowMuchEaten;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}