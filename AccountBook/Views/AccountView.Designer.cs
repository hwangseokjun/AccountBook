
namespace AccountBook.Views
{
    partial class AccountView
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbx_search = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.금전출납부ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예산현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbx_account = new System.Windows.Forms.GroupBox();
            this.btn_saveExpenseAccount = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tab_expense = new System.Windows.Forms.TabPage();
            this.tab_income = new System.Windows.Forms.TabPage();
            this.gbx_category = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_category = new System.Windows.Forms.TabPage();
            this.tab_expenseType = new System.Windows.Forms.TabPage();
            this.tab_store = new System.Windows.Forms.TabPage();
            this.dgv_account = new System.Windows.Forms.DataGridView();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.cbx_categorySearch = new System.Windows.Forms.ComboBox();
            this.cbx_expenseTypeSearch = new System.Windows.Forms.ComboBox();
            this.cbx_storeSearch = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_descriptionSearch = new System.Windows.Forms.TextBox();
            this.btn_deleteAccount = new System.Windows.Forms.Button();
            this.lbl_totalIncome = new System.Windows.Forms.Label();
            this.lbl_totalExpense = new System.Windows.Forms.Label();
            this.lbl_totalRemain = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cbx_income = new System.Windows.Forms.CheckBox();
            this.cbx_expense = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_saveIncomeAccount = new System.Windows.Forms.Button();
            this.gbx_search.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbx_account.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tab_expense.SuspendLayout();
            this.tab_income.SuspendLayout();
            this.gbx_category.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_search
            // 
            this.gbx_search.Controls.Add(this.txt_descriptionSearch);
            this.gbx_search.Controls.Add(this.btn_search);
            this.gbx_search.Controls.Add(this.cbx_storeSearch);
            this.gbx_search.Controls.Add(this.cbx_expenseTypeSearch);
            this.gbx_search.Controls.Add(this.cbx_categorySearch);
            this.gbx_search.Controls.Add(this.dtp_to);
            this.gbx_search.Controls.Add(this.dtp_from);
            this.gbx_search.Location = new System.Drawing.Point(12, 45);
            this.gbx_search.Name = "gbx_search";
            this.gbx_search.Size = new System.Drawing.Size(598, 79);
            this.gbx_search.TabIndex = 0;
            this.gbx_search.TabStop = false;
            this.gbx_search.Text = "검색조건";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.금전출납부ToolStripMenuItem,
            this.예산현황ToolStripMenuItem,
            this.통계ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 금전출납부ToolStripMenuItem
            // 
            this.금전출납부ToolStripMenuItem.Name = "금전출납부ToolStripMenuItem";
            this.금전출납부ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.금전출납부ToolStripMenuItem.Text = "금전출납부";
            // 
            // 예산현황ToolStripMenuItem
            // 
            this.예산현황ToolStripMenuItem.Name = "예산현황ToolStripMenuItem";
            this.예산현황ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.예산현황ToolStripMenuItem.Text = "예산현황";
            // 
            // 통계ToolStripMenuItem
            // 
            this.통계ToolStripMenuItem.Name = "통계ToolStripMenuItem";
            this.통계ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.통계ToolStripMenuItem.Text = "통계";
            // 
            // gbx_account
            // 
            this.gbx_account.Controls.Add(this.tabControl2);
            this.gbx_account.Location = new System.Drawing.Point(680, 45);
            this.gbx_account.Name = "gbx_account";
            this.gbx_account.Size = new System.Drawing.Size(281, 224);
            this.gbx_account.TabIndex = 2;
            this.gbx_account.TabStop = false;
            this.gbx_account.Text = "입력하기";
            // 
            // btn_saveExpenseAccount
            // 
            this.btn_saveExpenseAccount.Location = new System.Drawing.Point(97, 142);
            this.btn_saveExpenseAccount.Name = "btn_saveExpenseAccount";
            this.btn_saveExpenseAccount.Size = new System.Drawing.Size(75, 23);
            this.btn_saveExpenseAccount.TabIndex = 1;
            this.btn_saveExpenseAccount.Text = "저장";
            this.btn_saveExpenseAccount.UseVisualStyleBackColor = true;
            this.btn_saveExpenseAccount.Click += new System.EventHandler(this.btn_saveExpenseAccount_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tab_expense);
            this.tabControl2.Controls.Add(this.tab_income);
            this.tabControl2.Location = new System.Drawing.Point(6, 20);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(269, 199);
            this.tabControl2.TabIndex = 0;
            // 
            // tab_expense
            // 
            this.tab_expense.Controls.Add(this.label6);
            this.tab_expense.Controls.Add(this.label5);
            this.tab_expense.Controls.Add(this.label3);
            this.tab_expense.Controls.Add(this.label2);
            this.tab_expense.Controls.Add(this.label1);
            this.tab_expense.Controls.Add(this.btn_saveExpenseAccount);
            this.tab_expense.Controls.Add(this.comboBox3);
            this.tab_expense.Controls.Add(this.textBox3);
            this.tab_expense.Controls.Add(this.comboBox2);
            this.tab_expense.Controls.Add(this.comboBox1);
            this.tab_expense.Controls.Add(this.textBox2);
            this.tab_expense.Location = new System.Drawing.Point(4, 22);
            this.tab_expense.Name = "tab_expense";
            this.tab_expense.Padding = new System.Windows.Forms.Padding(3);
            this.tab_expense.Size = new System.Drawing.Size(261, 173);
            this.tab_expense.TabIndex = 0;
            this.tab_expense.Text = "지출";
            this.tab_expense.UseVisualStyleBackColor = true;
            // 
            // tab_income
            // 
            this.tab_income.Controls.Add(this.btn_saveIncomeAccount);
            this.tab_income.Controls.Add(this.label8);
            this.tab_income.Controls.Add(this.label7);
            this.tab_income.Controls.Add(this.label4);
            this.tab_income.Controls.Add(this.comboBox4);
            this.tab_income.Controls.Add(this.textBox5);
            this.tab_income.Controls.Add(this.textBox4);
            this.tab_income.Location = new System.Drawing.Point(4, 22);
            this.tab_income.Name = "tab_income";
            this.tab_income.Padding = new System.Windows.Forms.Padding(3);
            this.tab_income.Size = new System.Drawing.Size(261, 173);
            this.tab_income.TabIndex = 1;
            this.tab_income.Text = "수입";
            this.tab_income.UseVisualStyleBackColor = true;
            // 
            // gbx_category
            // 
            this.gbx_category.Controls.Add(this.textBox6);
            this.gbx_category.Controls.Add(this.comboBox6);
            this.gbx_category.Controls.Add(this.tabControl1);
            this.gbx_category.Location = new System.Drawing.Point(680, 275);
            this.gbx_category.Name = "gbx_category";
            this.gbx_category.Size = new System.Drawing.Size(281, 269);
            this.gbx_category.TabIndex = 3;
            this.gbx_category.TabStop = false;
            this.gbx_category.Text = "분류 생성하기";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_category);
            this.tabControl1.Controls.Add(this.tab_expenseType);
            this.tabControl1.Controls.Add(this.tab_store);
            this.tabControl1.Location = new System.Drawing.Point(6, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(269, 169);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_category
            // 
            this.tab_category.Location = new System.Drawing.Point(4, 22);
            this.tab_category.Name = "tab_category";
            this.tab_category.Padding = new System.Windows.Forms.Padding(3);
            this.tab_category.Size = new System.Drawing.Size(261, 143);
            this.tab_category.TabIndex = 0;
            this.tab_category.Text = "카테고리";
            this.tab_category.UseVisualStyleBackColor = true;
            // 
            // tab_expenseType
            // 
            this.tab_expenseType.Location = new System.Drawing.Point(4, 22);
            this.tab_expenseType.Name = "tab_expenseType";
            this.tab_expenseType.Padding = new System.Windows.Forms.Padding(3);
            this.tab_expenseType.Size = new System.Drawing.Size(261, 143);
            this.tab_expenseType.TabIndex = 1;
            this.tab_expenseType.Text = "지출종류";
            this.tab_expenseType.UseVisualStyleBackColor = true;
            // 
            // tab_store
            // 
            this.tab_store.Location = new System.Drawing.Point(4, 22);
            this.tab_store.Name = "tab_store";
            this.tab_store.Size = new System.Drawing.Size(308, 126);
            this.tab_store.TabIndex = 2;
            this.tab_store.Text = "구매처";
            this.tab_store.UseVisualStyleBackColor = true;
            // 
            // dgv_account
            // 
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Location = new System.Drawing.Point(12, 152);
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.RowTemplate.Height = 23;
            this.dgv_account.Size = new System.Drawing.Size(598, 292);
            this.dgv_account.TabIndex = 4;
            this.dgv_account.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_account_CellValueChanged);
            // 
            // dtp_from
            // 
            this.dtp_from.CustomFormat = "";
            this.dtp_from.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_from.Location = new System.Drawing.Point(6, 20);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(170, 21);
            this.dtp_from.TabIndex = 0;
            // 
            // dtp_to
            // 
            this.dtp_to.CustomFormat = "";
            this.dtp_to.Location = new System.Drawing.Point(182, 20);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(200, 21);
            this.dtp_to.TabIndex = 1;
            // 
            // cbx_categorySearch
            // 
            this.cbx_categorySearch.FormattingEnabled = true;
            this.cbx_categorySearch.Location = new System.Drawing.Point(388, 20);
            this.cbx_categorySearch.Name = "cbx_categorySearch";
            this.cbx_categorySearch.Size = new System.Drawing.Size(121, 20);
            this.cbx_categorySearch.TabIndex = 2;
            // 
            // cbx_expenseTypeSearch
            // 
            this.cbx_expenseTypeSearch.FormattingEnabled = true;
            this.cbx_expenseTypeSearch.Location = new System.Drawing.Point(6, 47);
            this.cbx_expenseTypeSearch.Name = "cbx_expenseTypeSearch";
            this.cbx_expenseTypeSearch.Size = new System.Drawing.Size(121, 20);
            this.cbx_expenseTypeSearch.TabIndex = 3;
            // 
            // cbx_storeSearch
            // 
            this.cbx_storeSearch.FormattingEnabled = true;
            this.cbx_storeSearch.Location = new System.Drawing.Point(133, 47);
            this.cbx_storeSearch.Name = "cbx_storeSearch";
            this.cbx_storeSearch.Size = new System.Drawing.Size(121, 20);
            this.cbx_storeSearch.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(515, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(73, 49);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_descriptionSearch
            // 
            this.txt_descriptionSearch.Location = new System.Drawing.Point(260, 46);
            this.txt_descriptionSearch.Name = "txt_descriptionSearch";
            this.txt_descriptionSearch.Size = new System.Drawing.Size(249, 21);
            this.txt_descriptionSearch.TabIndex = 6;
            // 
            // btn_deleteAccount
            // 
            this.btn_deleteAccount.Location = new System.Drawing.Point(535, 456);
            this.btn_deleteAccount.Name = "btn_deleteAccount";
            this.btn_deleteAccount.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteAccount.TabIndex = 5;
            this.btn_deleteAccount.Text = "삭제";
            this.btn_deleteAccount.UseVisualStyleBackColor = true;
            this.btn_deleteAccount.Click += new System.EventHandler(this.btn_deleteAccount_Click);
            // 
            // lbl_totalIncome
            // 
            this.lbl_totalIncome.AutoSize = true;
            this.lbl_totalIncome.Location = new System.Drawing.Point(16, 461);
            this.lbl_totalIncome.Name = "lbl_totalIncome";
            this.lbl_totalIncome.Size = new System.Drawing.Size(38, 12);
            this.lbl_totalIncome.TabIndex = 6;
            this.lbl_totalIncome.Text = "label1";
            // 
            // lbl_totalExpense
            // 
            this.lbl_totalExpense.AutoSize = true;
            this.lbl_totalExpense.Location = new System.Drawing.Point(192, 461);
            this.lbl_totalExpense.Name = "lbl_totalExpense";
            this.lbl_totalExpense.Size = new System.Drawing.Size(38, 12);
            this.lbl_totalExpense.TabIndex = 8;
            this.lbl_totalExpense.Text = "label3";
            // 
            // lbl_totalRemain
            // 
            this.lbl_totalRemain.AutoSize = true;
            this.lbl_totalRemain.Location = new System.Drawing.Point(356, 461);
            this.lbl_totalRemain.Name = "lbl_totalRemain";
            this.lbl_totalRemain.Size = new System.Drawing.Size(38, 12);
            this.lbl_totalRemain.TabIndex = 9;
            this.lbl_totalRemain.Text = "label4";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 21);
            this.textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(106, 7);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 20);
            this.comboBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 21);
            this.textBox3.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(106, 116);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(145, 20);
            this.comboBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 33);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 21);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(106, 60);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(145, 21);
            this.textBox5.TabIndex = 2;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownWidth = 145;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(106, 7);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(145, 20);
            this.comboBox4.TabIndex = 3;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(6, 243);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(94, 20);
            this.comboBox6.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(106, 242);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(129, 21);
            this.textBox6.TabIndex = 2;
            // 
            // cbx_income
            // 
            this.cbx_income.AutoSize = true;
            this.cbx_income.Checked = true;
            this.cbx_income.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_income.Location = new System.Drawing.Point(12, 130);
            this.cbx_income.Name = "cbx_income";
            this.cbx_income.Size = new System.Drawing.Size(48, 16);
            this.cbx_income.TabIndex = 10;
            this.cbx_income.Text = "수입";
            this.cbx_income.UseVisualStyleBackColor = true;
            this.cbx_income.CheckedChanged += new System.EventHandler(this.cbx_income_CheckedChanged);
            // 
            // cbx_expense
            // 
            this.cbx_expense.AutoSize = true;
            this.cbx_expense.Checked = true;
            this.cbx_expense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_expense.Location = new System.Drawing.Point(66, 130);
            this.cbx_expense.Name = "cbx_expense";
            this.cbx_expense.Size = new System.Drawing.Size(48, 16);
            this.cbx_expense.TabIndex = 11;
            this.cbx_expense.Text = "지출";
            this.cbx_expense.UseVisualStyleBackColor = true;
            this.cbx_expense.CheckedChanged += new System.EventHandler(this.cbx_expense_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "카테고리";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "내용";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "금액";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "구매처";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "지출분류";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "카테고리";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "내용";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "금액";
            // 
            // btn_saveIncomeAccount
            // 
            this.btn_saveIncomeAccount.Location = new System.Drawing.Point(97, 142);
            this.btn_saveIncomeAccount.Name = "btn_saveIncomeAccount";
            this.btn_saveIncomeAccount.Size = new System.Drawing.Size(75, 23);
            this.btn_saveIncomeAccount.TabIndex = 8;
            this.btn_saveIncomeAccount.Text = "저장";
            this.btn_saveIncomeAccount.UseVisualStyleBackColor = true;
            this.btn_saveIncomeAccount.Click += new System.EventHandler(this.btn_saveIncomeAccount_Click);
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 585);
            this.Controls.Add(this.cbx_expense);
            this.Controls.Add(this.cbx_income);
            this.Controls.Add(this.lbl_totalRemain);
            this.Controls.Add(this.lbl_totalExpense);
            this.Controls.Add(this.lbl_totalIncome);
            this.Controls.Add(this.btn_deleteAccount);
            this.Controls.Add(this.dgv_account);
            this.Controls.Add(this.gbx_category);
            this.Controls.Add(this.gbx_account);
            this.Controls.Add(this.gbx_search);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AccountView";
            this.Text = "AccountView";
            this.gbx_search.ResumeLayout(false);
            this.gbx_search.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbx_account.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tab_expense.ResumeLayout(false);
            this.tab_expense.PerformLayout();
            this.tab_income.ResumeLayout(false);
            this.tab_income.PerformLayout();
            this.gbx_category.ResumeLayout(false);
            this.gbx_category.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 금전출납부ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예산현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 통계ToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbx_account;
        private System.Windows.Forms.Button btn_saveExpenseAccount;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tab_expense;
        private System.Windows.Forms.TabPage tab_income;
        private System.Windows.Forms.GroupBox gbx_category;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_category;
        private System.Windows.Forms.TabPage tab_expenseType;
        private System.Windows.Forms.TabPage tab_store;
        private System.Windows.Forms.DataGridView dgv_account;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.TextBox txt_descriptionSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbx_storeSearch;
        private System.Windows.Forms.ComboBox cbx_expenseTypeSearch;
        private System.Windows.Forms.ComboBox cbx_categorySearch;
        private System.Windows.Forms.Button btn_deleteAccount;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_totalIncome;
        private System.Windows.Forms.Label lbl_totalExpense;
        private System.Windows.Forms.Label lbl_totalRemain;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.CheckBox cbx_income;
        private System.Windows.Forms.CheckBox cbx_expense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_saveIncomeAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}

