namespace AutoClient
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
            panel1 = new Panel();
            buttonForFilterByIncome = new Button();
            buttonForAllDatas = new Button();
            buttonForSearch = new Button();
            buttonForUpdate = new Button();
            buttonForDelete = new Button();
            buttonForClear = new Button();
            buttonAdd = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxAddress = new TextBox();
            textBoxEligibleForLoan = new TextBox();
            textBoxMonthlyIncome = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxCustomerId = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(buttonForFilterByIncome);
            panel1.Controls.Add(buttonForAllDatas);
            panel1.Controls.Add(buttonForSearch);
            panel1.Controls.Add(buttonForUpdate);
            panel1.Controls.Add(buttonForDelete);
            panel1.Controls.Add(buttonForClear);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxAddress);
            panel1.Controls.Add(textBoxEligibleForLoan);
            panel1.Controls.Add(textBoxMonthlyIncome);
            panel1.Controls.Add(textBoxLastName);
            panel1.Controls.Add(textBoxFirstName);
            panel1.Controls.Add(textBoxCustomerId);
            panel1.Location = new Point(12, 407);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 178);
            panel1.TabIndex = 1;
            // 
            // buttonForFilterByIncome
            // 
            buttonForFilterByIncome.Location = new Point(752, 44);
            buttonForFilterByIncome.Name = "buttonForFilterByIncome";
            buttonForFilterByIncome.Size = new Size(153, 31);
            buttonForFilterByIncome.TabIndex = 18;
            buttonForFilterByIncome.Text = "Filter by monthly income";
            buttonForFilterByIncome.UseVisualStyleBackColor = true;
            buttonForFilterByIncome.Click += buttonForFilterByIncome_Click;
            // 
            // buttonForAllDatas
            // 
            buttonForAllDatas.Location = new Point(616, 139);
            buttonForAllDatas.Name = "buttonForAllDatas";
            buttonForAllDatas.Size = new Size(120, 31);
            buttonForAllDatas.TabIndex = 17;
            buttonForAllDatas.Text = "Show All Data";
            buttonForAllDatas.UseVisualStyleBackColor = true;
            buttonForAllDatas.Click += buttonForAllDatas_Click;
            // 
            // buttonForSearch
            // 
            buttonForSearch.Location = new Point(616, 92);
            buttonForSearch.Name = "buttonForSearch";
            buttonForSearch.Size = new Size(120, 31);
            buttonForSearch.TabIndex = 16;
            buttonForSearch.Text = "Search a data";
            buttonForSearch.UseVisualStyleBackColor = true;
            buttonForSearch.Click += buttonForSearch_Click;
            // 
            // buttonForUpdate
            // 
            buttonForUpdate.Location = new Point(616, 44);
            buttonForUpdate.Name = "buttonForUpdate";
            buttonForUpdate.Size = new Size(120, 31);
            buttonForUpdate.TabIndex = 15;
            buttonForUpdate.Text = "Update";
            buttonForUpdate.UseVisualStyleBackColor = true;
            buttonForUpdate.Click += buttonForUpdate_Click;
            // 
            // buttonForDelete
            // 
            buttonForDelete.Location = new Point(477, 139);
            buttonForDelete.Name = "buttonForDelete";
            buttonForDelete.Size = new Size(120, 36);
            buttonForDelete.TabIndex = 14;
            buttonForDelete.Text = "Delete a customer";
            buttonForDelete.UseVisualStyleBackColor = true;
            buttonForDelete.Click += buttonForDelete_Click;
            // 
            // buttonForClear
            // 
            buttonForClear.Location = new Point(477, 89);
            buttonForClear.Name = "buttonForClear";
            buttonForClear.Size = new Size(120, 36);
            buttonForClear.TabIndex = 13;
            buttonForClear.Text = "Clear all selection";
            buttonForClear.UseVisualStyleBackColor = true;
            buttonForClear.Click += buttonForClear_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(477, 44);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 31);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Add new data";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(282, 105);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 11;
            label6.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 76);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 10;
            label5.Text = "Eligible For Loan:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 47);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 9;
            label4.Text = "Monthly Income:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 105);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 8;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 76);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 7;
            label2.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(34, 47);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 6;
            label1.Text = "Customer Id:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(341, 102);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(100, 23);
            textBoxAddress.TabIndex = 5;
            // 
            // textBoxEligibleForLoan
            // 
            textBoxEligibleForLoan.Enabled = false;
            textBoxEligibleForLoan.Location = new Point(341, 73);
            textBoxEligibleForLoan.Name = "textBoxEligibleForLoan";
            textBoxEligibleForLoan.Size = new Size(100, 23);
            textBoxEligibleForLoan.TabIndex = 4;
            // 
            // textBoxMonthlyIncome
            // 
            textBoxMonthlyIncome.Location = new Point(341, 44);
            textBoxMonthlyIncome.Name = "textBoxMonthlyIncome";
            textBoxMonthlyIncome.Size = new Size(100, 23);
            textBoxMonthlyIncome.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(115, 102);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(100, 23);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(115, 73);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(100, 23);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxCustomerId
            // 
            textBoxCustomerId.Location = new Point(115, 44);
            textBoxCustomerId.Name = "textBoxCustomerId";
            textBoxCustomerId.Size = new Size(100, 23);
            textBoxCustomerId.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(917, 389);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(917, 389);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 597);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Customer Management System";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox textBoxAddress;
        private TextBox textBoxEligibleForLoan;
        private TextBox textBoxMonthlyIncome;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TextBox textBoxCustomerId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonAdd;
        private Button buttonForClear;
        private Button buttonForDelete;
        private Button buttonForUpdate;
        private Button buttonForSearch;
        private Button buttonForAllDatas;
        private Button buttonForFilterByIncome;
    }
}
