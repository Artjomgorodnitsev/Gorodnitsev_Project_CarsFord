namespace gorodnitsevCarModelsProject
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.markText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modelText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bodyText = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fuelText = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.checkAvaraia = new System.Windows.Forms.CheckBox();
            this.carModelDbDataSet = new gorodnitsevCarModelsProject.CarModelDbDataSet();
            this.tblCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CarsTableAdapter = new gorodnitsevCarModelsProject.CarModelDbDataSetTableAdapters.tbl_CarsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.carModelDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(64, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Марка";
            // 
            // markText
            // 
            this.markText.BackColor = System.Drawing.Color.White;
            this.markText.Location = new System.Drawing.Point(182, 31);
            this.markText.Name = "markText";
            this.markText.Size = new System.Drawing.Size(175, 20);
            this.markText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Моедль";
            // 
            // modelText
            // 
            this.modelText.Location = new System.Drawing.Point(182, 84);
            this.modelText.Name = "modelText";
            this.modelText.Size = new System.Drawing.Size(175, 20);
            this.modelText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Была ли в аварии";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Год";
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(182, 174);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(175, 20);
            this.yearText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тип кузова";
            // 
            // bodyText
            // 
            this.bodyText.FormattingEnabled = true;
            this.bodyText.Items.AddRange(new object[] {
            "Универсал",
            "Хэтчбек",
            "Седан"});
            this.bodyText.Location = new System.Drawing.Point(182, 217);
            this.bodyText.Name = "bodyText";
            this.bodyText.Size = new System.Drawing.Size(175, 21);
            this.bodyText.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Тип топлива";
            // 
            // fuelText
            // 
            this.fuelText.FormattingEnabled = true;
            this.fuelText.Items.AddRange(new object[] {
            "Дизель",
            "Бензин",
            "Электричество",
            "Газ"});
            this.fuelText.Location = new System.Drawing.Point(182, 258);
            this.fuelText.Name = "fuelText";
            this.fuelText.Size = new System.Drawing.Size(175, 21);
            this.fuelText.TabIndex = 13;
            this.fuelText.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Цена";
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(182, 300);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(175, 20);
            this.priceText.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(282, 362);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Location = new System.Drawing.Point(1089, 362);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Location = new System.Drawing.Point(196, 362);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "Сбросить";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // checkAvaraia
            // 
            this.checkAvaraia.AutoSize = true;
            this.checkAvaraia.Location = new System.Drawing.Point(240, 129);
            this.checkAvaraia.Name = "checkAvaraia";
            this.checkAvaraia.Size = new System.Drawing.Size(41, 17);
            this.checkAvaraia.TabIndex = 21;
            this.checkAvaraia.Text = "Да";
            this.checkAvaraia.UseVisualStyleBackColor = true;
            // 
            // carModelDbDataSet
            // 
            this.carModelDbDataSet.DataSetName = "CarModelDbDataSet";
            this.carModelDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCarsBindingSource
            // 
            this.tblCarsBindingSource.DataMember = "tbl_Cars";
            this.tblCarsBindingSource.DataSource = this.carModelDbDataSet;
            // 
            // tbl_CarsTableAdapter
            // 
            this.tbl_CarsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(428, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(736, 289);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1183, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkAvaraia);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fuelText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bodyText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modelText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.markText);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Auto25";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carModelDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox markText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modelText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox bodyText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fuelText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.CheckBox checkAvaraia;
        private CarModelDbDataSet carModelDbDataSet;
        private System.Windows.Forms.BindingSource tblCarsBindingSource;
        private CarModelDbDataSetTableAdapters.tbl_CarsTableAdapter tbl_CarsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

