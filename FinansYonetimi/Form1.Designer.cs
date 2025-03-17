namespace FinansYonetimi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            dgwReceivables = new DataGridView();
            lblName = new Label();
            tbxName = new TextBox();
            tbxAmount = new TextBox();
            lblAmount = new Label();
            gbxAdd = new GroupBox();
            tbxDescription = new TextBox();
            lblDescription = new Label();
            tbxDate = new TextBox();
            lblDate = new Label();
            gbxUpdate = new GroupBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            textBox7 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox8 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgwReceivables).BeginInit();
            gbxAdd.SuspendLayout();
            gbxUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(144, 187);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgwReceivables
            // 
            dgwReceivables.AllowUserToAddRows = false;
            dgwReceivables.AllowUserToDeleteRows = false;
            dgwReceivables.AllowUserToResizeColumns = false;
            dgwReceivables.AllowUserToResizeRows = false;
            dgwReceivables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwReceivables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwReceivables.Location = new Point(252, 24);
            dgwReceivables.Name = "dgwReceivables";
            dgwReceivables.ReadOnly = true;
            dgwReceivables.RowHeadersWidth = 51;
            dgwReceivables.Size = new Size(674, 251);
            dgwReceivables.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(56, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(36, 20);
            lblName.TabIndex = 2;
            lblName.Text = "İsim";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(144, 39);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(149, 27);
            tbxName.TabIndex = 3;
            // 
            // tbxAmount
            // 
            tbxAmount.Location = new Point(144, 72);
            tbxAmount.Name = "tbxAmount";
            tbxAmount.Size = new Size(149, 27);
            tbxAmount.TabIndex = 5;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(56, 72);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 20);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Miktar";
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(tbxDescription);
            gbxAdd.Controls.Add(lblDescription);
            gbxAdd.Controls.Add(tbxDate);
            gbxAdd.Controls.Add(lblDate);
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(tbxAmount);
            gbxAdd.Controls.Add(lblName);
            gbxAdd.Controls.Add(lblAmount);
            gbxAdd.Controls.Add(tbxName);
            gbxAdd.Location = new Point(252, 281);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(310, 252);
            gbxAdd.TabIndex = 6;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Bir alacak ekle";
            // 
            // tbxDescription
            // 
            tbxDescription.Location = new Point(144, 138);
            tbxDescription.Name = "tbxDescription";
            tbxDescription.Size = new Size(149, 27);
            tbxDescription.TabIndex = 9;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(56, 138);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 20);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Açıklama";
            // 
            // tbxDate
            // 
            tbxDate.Location = new Point(144, 105);
            tbxDate.Name = "tbxDate";
            tbxDate.Size = new Size(149, 27);
            tbxDate.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(56, 105);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(40, 20);
            lblDate.TabIndex = 6;
            lblDate.Text = "Tarih";
            // 
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(textBox3);
            gbxUpdate.Controls.Add(label3);
            gbxUpdate.Controls.Add(textBox4);
            gbxUpdate.Controls.Add(label4);
            gbxUpdate.Controls.Add(button2);
            gbxUpdate.Controls.Add(textBox7);
            gbxUpdate.Controls.Add(label7);
            gbxUpdate.Controls.Add(label8);
            gbxUpdate.Controls.Add(textBox8);
            gbxUpdate.Location = new Point(616, 281);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(310, 252);
            gbxUpdate.TabIndex = 6;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "Bir alacağı düzenle";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(144, 138);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 27);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 138);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "label6";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(144, 105);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(149, 27);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 105);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "label5";
            // 
            // button2
            // 
            button2.Location = new Point(144, 187);
            button2.Name = "button2";
            button2.Size = new Size(149, 29);
            button2.TabIndex = 0;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(144, 72);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(149, 27);
            textBox7.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 39);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 2;
            label7.Text = "label1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 72);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 4;
            label8.Text = "label2";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(144, 39);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(149, 27);
            textBox8.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 545);
            Controls.Add(gbxUpdate);
            Controls.Add(gbxAdd);
            Controls.Add(dgwReceivables);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwReceivables).EndInit();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            gbxUpdate.ResumeLayout(false);
            gbxUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private DataGridView dgwReceivables;
        private Label lblName;
        private TextBox tbxName;
        private TextBox tbxAmount;
        private Label lblAmount;
        private GroupBox gbxAdd;
        private TextBox tbxDescription;
        private Label lblDescription;
        private TextBox tbxDate;
        private Label lblDate;
        private GroupBox gbxUpdate;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Button button2;
        private TextBox textBox7;
        private Label label7;
        private Label label8;
        private TextBox textBox8;
    }
}
