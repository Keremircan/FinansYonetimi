namespace FinansYonetimi.Forms
{
    partial class ReceivableForm
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
            gbxUpdate = new GroupBox();
            cbxCurrency2 = new ComboBox();
            lblDescription2 = new Label();
            tbxDescription2 = new RichTextBox();
            lblDate2 = new Label();
            lblAmount2 = new Label();
            lblName2 = new Label();
            tbxDate2 = new TextBox();
            btnUpdate = new Button();
            tbxAmount2 = new TextBox();
            tbxName2 = new TextBox();
            gbxAdd = new GroupBox();
            cbxCurrency = new ComboBox();
            lblDescription = new Label();
            tbxDescription = new RichTextBox();
            tbxDate = new TextBox();
            lblDate = new Label();
            btnAdd = new Button();
            tbxAmount = new TextBox();
            lblName = new Label();
            lblAmount = new Label();
            tbxName = new TextBox();
            dgwReceivables = new DataGridView();
            btnRemove = new Button();
            tbxSearch = new TextBox();
            lblSearch = new Label();
            gbxUpdate.SuspendLayout();
            gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwReceivables).BeginInit();
            SuspendLayout();
            // 
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(cbxCurrency2);
            gbxUpdate.Controls.Add(lblDescription2);
            gbxUpdate.Controls.Add(tbxDescription2);
            gbxUpdate.Controls.Add(lblDate2);
            gbxUpdate.Controls.Add(lblAmount2);
            gbxUpdate.Controls.Add(lblName2);
            gbxUpdate.Controls.Add(tbxDate2);
            gbxUpdate.Controls.Add(btnUpdate);
            gbxUpdate.Controls.Add(tbxAmount2);
            gbxUpdate.Controls.Add(tbxName2);
            gbxUpdate.Location = new Point(490, 310);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(450, 252);
            gbxUpdate.TabIndex = 9;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "DÜZENLE";
            // 
            // cbxCurrency2
            // 
            cbxCurrency2.FormattingEnabled = true;
            cbxCurrency2.Items.AddRange(new object[] { "TL", "Dolar", "Euro" });
            cbxCurrency2.Location = new Point(277, 72);
            cbxCurrency2.Name = "cbxCurrency2";
            cbxCurrency2.Size = new Size(63, 28);
            cbxCurrency2.TabIndex = 12;
            // 
            // lblDescription2
            // 
            lblDescription2.AutoSize = true;
            lblDescription2.Location = new Point(56, 145);
            lblDescription2.Name = "lblDescription2";
            lblDescription2.Size = new Size(70, 20);
            lblDescription2.TabIndex = 13;
            lblDescription2.Text = "Açıklama";
            // 
            // tbxDescription2
            // 
            tbxDescription2.Location = new Point(144, 138);
            tbxDescription2.Name = "tbxDescription2";
            tbxDescription2.ScrollBars = RichTextBoxScrollBars.Vertical;
            tbxDescription2.Size = new Size(196, 60);
            tbxDescription2.TabIndex = 11;
            tbxDescription2.Text = "";
            // 
            // lblDate2
            // 
            lblDate2.AutoSize = true;
            lblDate2.Location = new Point(56, 108);
            lblDate2.Name = "lblDate2";
            lblDate2.Size = new Size(40, 20);
            lblDate2.TabIndex = 12;
            lblDate2.Text = "Tarih";
            // 
            // lblAmount2
            // 
            lblAmount2.AutoSize = true;
            lblAmount2.Location = new Point(56, 75);
            lblAmount2.Name = "lblAmount2";
            lblAmount2.Size = new Size(61, 20);
            lblAmount2.TabIndex = 11;
            lblAmount2.Text = "Miktar *";
            // 
            // lblName2
            // 
            lblName2.AutoSize = true;
            lblName2.Location = new Point(56, 39);
            lblName2.Name = "lblName2";
            lblName2.Size = new Size(46, 20);
            lblName2.TabIndex = 10;
            lblName2.Text = "İsim *";
            // 
            // tbxDate2
            // 
            tbxDate2.Location = new Point(144, 105);
            tbxDate2.Name = "tbxDate2";
            tbxDate2.Size = new Size(196, 27);
            tbxDate2.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(144, 208);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(196, 29);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxAmount2
            // 
            tbxAmount2.Location = new Point(144, 72);
            tbxAmount2.Name = "tbxAmount2";
            tbxAmount2.Size = new Size(127, 27);
            tbxAmount2.TabIndex = 5;
            // 
            // tbxName2
            // 
            tbxName2.Location = new Point(144, 39);
            tbxName2.Name = "tbxName2";
            tbxName2.Size = new Size(196, 27);
            tbxName2.TabIndex = 3;
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(cbxCurrency);
            gbxAdd.Controls.Add(lblDescription);
            gbxAdd.Controls.Add(tbxDescription);
            gbxAdd.Controls.Add(tbxDate);
            gbxAdd.Controls.Add(lblDate);
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(tbxAmount);
            gbxAdd.Controls.Add(lblName);
            gbxAdd.Controls.Add(lblAmount);
            gbxAdd.Controls.Add(tbxName);
            gbxAdd.Location = new Point(40, 310);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(450, 252);
            gbxAdd.TabIndex = 8;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "EKLE";
            // 
            // cbxCurrency
            // 
            cbxCurrency.FormattingEnabled = true;
            cbxCurrency.Items.AddRange(new object[] { "TL", "Dolar", "Euro" });
            cbxCurrency.Location = new Point(277, 72);
            cbxCurrency.Name = "cbxCurrency";
            cbxCurrency.Size = new Size(63, 28);
            cbxCurrency.TabIndex = 12;
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
            // tbxDescription
            // 
            tbxDescription.Location = new Point(144, 138);
            tbxDescription.Name = "tbxDescription";
            tbxDescription.ScrollBars = RichTextBoxScrollBars.Vertical;
            tbxDescription.Size = new Size(196, 60);
            tbxDescription.TabIndex = 11;
            tbxDescription.Text = "";
            // 
            // tbxDate
            // 
            tbxDate.Location = new Point(144, 105);
            tbxDate.Name = "tbxDate";
            tbxDate.Size = new Size(196, 27);
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
            // btnAdd
            // 
            btnAdd.Location = new Point(144, 208);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(196, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxAmount
            // 
            tbxAmount.Location = new Point(144, 72);
            tbxAmount.Name = "tbxAmount";
            tbxAmount.Size = new Size(127, 27);
            tbxAmount.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(56, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(46, 20);
            lblName.TabIndex = 2;
            lblName.Text = "İsim *";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(56, 72);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(61, 20);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Miktar *";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(144, 39);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(196, 27);
            tbxName.TabIndex = 3;
            // 
            // dgwReceivables
            // 
            dgwReceivables.AllowUserToAddRows = false;
            dgwReceivables.AllowUserToDeleteRows = false;
            dgwReceivables.AllowUserToResizeColumns = false;
            dgwReceivables.AllowUserToResizeRows = false;
            dgwReceivables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwReceivables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwReceivables.Location = new Point(40, 70);
            dgwReceivables.Name = "dgwReceivables";
            dgwReceivables.ReadOnly = true;
            dgwReceivables.RowHeadersWidth = 51;
            dgwReceivables.Size = new Size(900, 216);
            dgwReceivables.TabIndex = 7;
            dgwReceivables.CellClick += dgwReceivables_CellClick;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(60, 14);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(143, 40);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Kaldır";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(746, 27);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(174, 27);
            tbxSearch.TabIndex = 11;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(691, 30);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(39, 20);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Ara :";
            // 
            // ReceivableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 572);
            Controls.Add(lblSearch);
            Controls.Add(tbxSearch);
            Controls.Add(btnRemove);
            Controls.Add(gbxUpdate);
            Controls.Add(gbxAdd);
            Controls.Add(dgwReceivables);
            Name = "ReceivableForm";
            Text = "Alınacaklar";
            Load += ReceivableForm_Load_1;
            gbxUpdate.ResumeLayout(false);
            gbxUpdate.PerformLayout();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwReceivables).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxUpdate;
        private Label lblDescription2;
        private Label lblDate2;
        private Label lblAmount2;
        private Label lblName2;
        private TextBox tbxDate2;
        private Button btnUpdate;
        private TextBox tbxAmount2;
        private TextBox tbxName2;
        private GroupBox gbxAdd;
        private Label lblDescription;
        private TextBox tbxDate;
        private Label lblDate;
        private Button btnAdd;
        private TextBox tbxAmount;
        private Label lblName;
        private Label lblAmount;
        private TextBox tbxName;
        private DataGridView dgwReceivables;
        private Button btnRemove;
        private RichTextBox tbxDescription;
        private RichTextBox tbxDescription2;
        private TextBox tbxSearch;
        private Label lblSearch;
        private ComboBox cbxCurrency;
        private ComboBox cbxCurrency2;
    }
}