
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
            this.lblWhichAnimal = new System.Windows.Forms.Label();
            this.lblWhichDay = new System.Windows.Forms.Label();
            this.dgvAnimalTable = new System.Windows.Forms.DataGridView();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AnimalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalTable)).BeginInit();
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
            this.btnEnterAddConsumption.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterAddConsumption.Location = new System.Drawing.Point(12, 378);
            this.btnEnterAddConsumption.Name = "btnEnterAddConsumption";
            this.btnEnterAddConsumption.Size = new System.Drawing.Size(428, 60);
            this.btnEnterAddConsumption.TabIndex = 17;
            this.btnEnterAddConsumption.Text = "Enter";
            this.btnEnterAddConsumption.UseVisualStyleBackColor = false;
            // 
            // lblWhichAnimal
            // 
            this.lblWhichAnimal.AutoSize = true;
            this.lblWhichAnimal.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhichAnimal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblWhichAnimal.Location = new System.Drawing.Point(12, 42);
            this.lblWhichAnimal.Name = "lblWhichAnimal";
            this.lblWhichAnimal.Size = new System.Drawing.Size(112, 19);
            this.lblWhichAnimal.TabIndex = 18;
            this.lblWhichAnimal.Text = "Which Animal?";
            // 
            // lblWhichDay
            // 
            this.lblWhichDay.AutoSize = true;
            this.lblWhichDay.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhichDay.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblWhichDay.Location = new System.Drawing.Point(12, 165);
            this.lblWhichDay.Name = "lblWhichDay";
            this.lblWhichDay.Size = new System.Drawing.Size(90, 19);
            this.lblWhichDay.TabIndex = 19;
            this.lblWhichDay.Text = "Which Day?";
            // 
            // dgvAnimalTable
            // 
            this.dgvAnimalTable.AllowUserToOrderColumns = true;
            this.dgvAnimalTable.AutoGenerateColumns = false;
            this.dgvAnimalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimalTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnimalName,
            this.Species});
            this.dgvAnimalTable.DataSource = this.animalBindingSource;
            this.dgvAnimalTable.Location = new System.Drawing.Point(17, 66);
            this.dgvAnimalTable.Name = "dgvAnimalTable";
            this.dgvAnimalTable.Size = new System.Drawing.Size(261, 99);
            this.dgvAnimalTable.TabIndex = 20;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(SPCAAppGui.Animal);
            // 
            // animalBindingSource1
            // 
            this.animalBindingSource1.DataSource = typeof(SPCAAppGui.Animal);
            // 
            // AnimalName
            // 
            this.AnimalName.HeaderText = "Animal Name";
            this.AnimalName.Name = "AnimalName";
            // 
            // Species
            // 
            this.Species.HeaderText = "Species";
            this.Species.Name = "Species";
            // 
            // AddConsumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAnimalTable);
            this.Controls.Add(this.lblWhichDay);
            this.Controls.Add(this.lblWhichAnimal);
            this.Controls.Add(this.btnEnterAddConsumption);
            this.Controls.Add(this.rtbOutputAddConsumption);
            this.Controls.Add(this.lblAddConsumption);
            this.Controls.Add(this.btnBackAddConsumption);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddConsumption";
            this.Text = "AddConsumption";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalTable)).EndInit();
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
        private System.Windows.Forms.Label lblWhichAnimal;
        private System.Windows.Forms.Label lblWhichDay;
        private System.Windows.Forms.DataGridView dgvAnimalTable;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.BindingSource animalBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Species;
    }
}