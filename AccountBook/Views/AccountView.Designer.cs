
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountView));
            this.gbx_search = new System.Windows.Forms.GroupBox();
            this.txt_descriptionSearch = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.cbx_storeSearch = new System.Windows.Forms.ComboBox();
            this.cbx_expenseTypeSearch = new System.Windows.Forms.ComboBox();
            this.cbx_categorySearch = new System.Windows.Forms.ComboBox();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_budget = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_statistic = new System.Windows.Forms.ToolStripMenuItem();
            this.gbx_account = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tab_expense = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_saveExpense = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_saveExpenseAccount = new System.Windows.Forms.Button();
            this.cbx_expenseType = new System.Windows.Forms.ComboBox();
            this.txt_expenseAmount = new System.Windows.Forms.TextBox();
            this.cbx_expenseCategory = new System.Windows.Forms.ComboBox();
            this.cbx_store = new System.Windows.Forms.ComboBox();
            this.txt_expenseDescription = new System.Windows.Forms.TextBox();
            this.tab_income = new System.Windows.Forms.TabPage();
            this.dtp_saveIncome = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_saveIncomeAccount = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_incomeCategory = new System.Windows.Forms.ComboBox();
            this.txt_incomeAmount = new System.Windows.Forms.TextBox();
            this.txt_incomeDescription = new System.Windows.Forms.TextBox();
            this.gbx_category = new System.Windows.Forms.GroupBox();
            this.chk_showDeletedCategory = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_saveCategoryText = new System.Windows.Forms.TextBox();
            this.btn_saveCategory = new System.Windows.Forms.Button();
            this.txt_saveExpenseCategoryAmount = new System.Windows.Forms.TextBox();
            this.cbx_saveCategory = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_expenseCategory = new System.Windows.Forms.TabPage();
            this.dgv_expenseCategory = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btn_deleteExpenseCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_incomeCategory = new System.Windows.Forms.TabPage();
            this.dgv_incomeCategory = new System.Windows.Forms.DataGridView();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.btn_deleteIncomeCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_expenseType = new System.Windows.Forms.TabPage();
            this.dgv_expenseType = new System.Windows.Forms.DataGridView();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.btn_deleteExpenseType = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_store = new System.Windows.Forms.TabPage();
            this.dgv_store = new System.Windows.Forms.DataGridView();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.btn_deleteStore = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_account = new System.Windows.Forms.DataGridView();
            this.btn_deleteAccount = new System.Windows.Forms.Button();
            this.lbl_totalIncome = new System.Windows.Forms.Label();
            this.lbl_totalExpense = new System.Windows.Forms.Label();
            this.lbl_totalRemain = new System.Windows.Forms.Label();
            this.chk_income = new System.Windows.Forms.CheckBox();
            this.chk_expense = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_startDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_endDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbx_search.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbx_account.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tab_expense.SuspendLayout();
            this.tab_income.SuspendLayout();
            this.gbx_category.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab_expenseCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expenseCategory)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.tab_incomeCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incomeCategory)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.tab_expenseType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expenseType)).BeginInit();
            this.menuStrip4.SuspendLayout();
            this.tab_store.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_store)).BeginInit();
            this.menuStrip5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_search
            // 
            resources.ApplyResources(this.gbx_search, "gbx_search");
            this.gbx_search.Controls.Add(this.txt_descriptionSearch);
            this.gbx_search.Controls.Add(this.btn_search);
            this.gbx_search.Controls.Add(this.cbx_storeSearch);
            this.gbx_search.Controls.Add(this.cbx_expenseTypeSearch);
            this.gbx_search.Controls.Add(this.cbx_categorySearch);
            this.gbx_search.Controls.Add(this.dtp_to);
            this.gbx_search.Controls.Add(this.dtp_from);
            this.gbx_search.Name = "gbx_search";
            this.gbx_search.TabStop = false;
            // 
            // txt_descriptionSearch
            // 
            resources.ApplyResources(this.txt_descriptionSearch, "txt_descriptionSearch");
            this.txt_descriptionSearch.Name = "txt_descriptionSearch";
            // 
            // btn_search
            // 
            resources.ApplyResources(this.btn_search, "btn_search");
            this.btn_search.Name = "btn_search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cbx_storeSearch
            // 
            resources.ApplyResources(this.cbx_storeSearch, "cbx_storeSearch");
            this.cbx_storeSearch.FormattingEnabled = true;
            this.cbx_storeSearch.Name = "cbx_storeSearch";
            // 
            // cbx_expenseTypeSearch
            // 
            resources.ApplyResources(this.cbx_expenseTypeSearch, "cbx_expenseTypeSearch");
            this.cbx_expenseTypeSearch.FormattingEnabled = true;
            this.cbx_expenseTypeSearch.Name = "cbx_expenseTypeSearch";
            // 
            // cbx_categorySearch
            // 
            resources.ApplyResources(this.cbx_categorySearch, "cbx_categorySearch");
            this.cbx_categorySearch.FormattingEnabled = true;
            this.cbx_categorySearch.Name = "cbx_categorySearch";
            // 
            // dtp_to
            // 
            resources.ApplyResources(this.dtp_to, "dtp_to");
            this.dtp_to.Name = "dtp_to";
            // 
            // dtp_from
            // 
            resources.ApplyResources(this.dtp_from, "dtp_from");
            this.dtp_from.Name = "dtp_from";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_budget,
            this.btn_statistic});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // btn_budget
            // 
            resources.ApplyResources(this.btn_budget, "btn_budget");
            this.btn_budget.Name = "btn_budget";
            this.btn_budget.Click += new System.EventHandler(this.btn_budget_Click);
            // 
            // btn_statistic
            // 
            resources.ApplyResources(this.btn_statistic, "btn_statistic");
            this.btn_statistic.Name = "btn_statistic";
            // 
            // gbx_account
            // 
            resources.ApplyResources(this.gbx_account, "gbx_account");
            this.gbx_account.Controls.Add(this.tabControl2);
            this.gbx_account.Name = "gbx_account";
            this.gbx_account.TabStop = false;
            // 
            // tabControl2
            // 
            resources.ApplyResources(this.tabControl2, "tabControl2");
            this.tabControl2.Controls.Add(this.tab_expense);
            this.tabControl2.Controls.Add(this.tab_income);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            // 
            // tab_expense
            // 
            resources.ApplyResources(this.tab_expense, "tab_expense");
            this.tab_expense.Controls.Add(this.label9);
            this.tab_expense.Controls.Add(this.dtp_saveExpense);
            this.tab_expense.Controls.Add(this.label6);
            this.tab_expense.Controls.Add(this.label5);
            this.tab_expense.Controls.Add(this.label3);
            this.tab_expense.Controls.Add(this.label2);
            this.tab_expense.Controls.Add(this.label1);
            this.tab_expense.Controls.Add(this.btn_saveExpenseAccount);
            this.tab_expense.Controls.Add(this.cbx_expenseType);
            this.tab_expense.Controls.Add(this.txt_expenseAmount);
            this.tab_expense.Controls.Add(this.cbx_expenseCategory);
            this.tab_expense.Controls.Add(this.cbx_store);
            this.tab_expense.Controls.Add(this.txt_expenseDescription);
            this.tab_expense.Name = "tab_expense";
            this.tab_expense.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // dtp_saveExpense
            // 
            resources.ApplyResources(this.dtp_saveExpense, "dtp_saveExpense");
            this.dtp_saveExpense.Name = "dtp_saveExpense";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_saveExpenseAccount
            // 
            resources.ApplyResources(this.btn_saveExpenseAccount, "btn_saveExpenseAccount");
            this.btn_saveExpenseAccount.Name = "btn_saveExpenseAccount";
            this.btn_saveExpenseAccount.UseVisualStyleBackColor = true;
            this.btn_saveExpenseAccount.Click += new System.EventHandler(this.btn_saveExpenseAccount_Click);
            // 
            // cbx_expenseType
            // 
            resources.ApplyResources(this.cbx_expenseType, "cbx_expenseType");
            this.cbx_expenseType.FormattingEnabled = true;
            this.cbx_expenseType.Name = "cbx_expenseType";
            // 
            // txt_expenseAmount
            // 
            resources.ApplyResources(this.txt_expenseAmount, "txt_expenseAmount");
            this.txt_expenseAmount.Name = "txt_expenseAmount";
            this.txt_expenseAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_expenseAmount_KeyPress);
            // 
            // cbx_expenseCategory
            // 
            resources.ApplyResources(this.cbx_expenseCategory, "cbx_expenseCategory");
            this.cbx_expenseCategory.FormattingEnabled = true;
            this.cbx_expenseCategory.Name = "cbx_expenseCategory";
            // 
            // cbx_store
            // 
            resources.ApplyResources(this.cbx_store, "cbx_store");
            this.cbx_store.FormattingEnabled = true;
            this.cbx_store.Name = "cbx_store";
            // 
            // txt_expenseDescription
            // 
            resources.ApplyResources(this.txt_expenseDescription, "txt_expenseDescription");
            this.txt_expenseDescription.Name = "txt_expenseDescription";
            // 
            // tab_income
            // 
            resources.ApplyResources(this.tab_income, "tab_income");
            this.tab_income.Controls.Add(this.dtp_saveIncome);
            this.tab_income.Controls.Add(this.label10);
            this.tab_income.Controls.Add(this.btn_saveIncomeAccount);
            this.tab_income.Controls.Add(this.label8);
            this.tab_income.Controls.Add(this.label7);
            this.tab_income.Controls.Add(this.label4);
            this.tab_income.Controls.Add(this.cbx_incomeCategory);
            this.tab_income.Controls.Add(this.txt_incomeAmount);
            this.tab_income.Controls.Add(this.txt_incomeDescription);
            this.tab_income.Name = "tab_income";
            this.tab_income.UseVisualStyleBackColor = true;
            // 
            // dtp_saveIncome
            // 
            resources.ApplyResources(this.dtp_saveIncome, "dtp_saveIncome");
            this.dtp_saveIncome.Name = "dtp_saveIncome";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // btn_saveIncomeAccount
            // 
            resources.ApplyResources(this.btn_saveIncomeAccount, "btn_saveIncomeAccount");
            this.btn_saveIncomeAccount.Name = "btn_saveIncomeAccount";
            this.btn_saveIncomeAccount.UseVisualStyleBackColor = true;
            this.btn_saveIncomeAccount.Click += new System.EventHandler(this.btn_saveIncomeAccount_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cbx_incomeCategory
            // 
            resources.ApplyResources(this.cbx_incomeCategory, "cbx_incomeCategory");
            this.cbx_incomeCategory.DropDownWidth = 145;
            this.cbx_incomeCategory.FormattingEnabled = true;
            this.cbx_incomeCategory.Name = "cbx_incomeCategory";
            // 
            // txt_incomeAmount
            // 
            resources.ApplyResources(this.txt_incomeAmount, "txt_incomeAmount");
            this.txt_incomeAmount.Name = "txt_incomeAmount";
            this.txt_incomeAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_incomeAmount_KeyPress);
            // 
            // txt_incomeDescription
            // 
            resources.ApplyResources(this.txt_incomeDescription, "txt_incomeDescription");
            this.txt_incomeDescription.Name = "txt_incomeDescription";
            // 
            // gbx_category
            // 
            resources.ApplyResources(this.gbx_category, "gbx_category");
            this.gbx_category.Controls.Add(this.chk_showDeletedCategory);
            this.gbx_category.Controls.Add(this.label13);
            this.gbx_category.Controls.Add(this.label12);
            this.gbx_category.Controls.Add(this.label11);
            this.gbx_category.Controls.Add(this.txt_saveCategoryText);
            this.gbx_category.Controls.Add(this.btn_saveCategory);
            this.gbx_category.Controls.Add(this.txt_saveExpenseCategoryAmount);
            this.gbx_category.Controls.Add(this.cbx_saveCategory);
            this.gbx_category.Controls.Add(this.tabControl);
            this.gbx_category.Name = "gbx_category";
            this.gbx_category.TabStop = false;
            // 
            // chk_showDeletedCategory
            // 
            resources.ApplyResources(this.chk_showDeletedCategory, "chk_showDeletedCategory");
            this.chk_showDeletedCategory.Name = "chk_showDeletedCategory";
            this.chk_showDeletedCategory.UseVisualStyleBackColor = true;
            this.chk_showDeletedCategory.CheckedChanged += new System.EventHandler(this.chk_showDeletedCategory_CheckedChanged);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // txt_saveCategoryText
            // 
            resources.ApplyResources(this.txt_saveCategoryText, "txt_saveCategoryText");
            this.txt_saveCategoryText.Name = "txt_saveCategoryText";
            // 
            // btn_saveCategory
            // 
            resources.ApplyResources(this.btn_saveCategory, "btn_saveCategory");
            this.btn_saveCategory.Name = "btn_saveCategory";
            this.btn_saveCategory.UseVisualStyleBackColor = true;
            this.btn_saveCategory.Click += new System.EventHandler(this.btn_saveCategory_Click);
            // 
            // txt_saveExpenseCategoryAmount
            // 
            resources.ApplyResources(this.txt_saveExpenseCategoryAmount, "txt_saveExpenseCategoryAmount");
            this.txt_saveExpenseCategoryAmount.Name = "txt_saveExpenseCategoryAmount";
            this.txt_saveExpenseCategoryAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_saveExpenseCategoryAmount_KeyPress);
            // 
            // cbx_saveCategory
            // 
            resources.ApplyResources(this.cbx_saveCategory, "cbx_saveCategory");
            this.cbx_saveCategory.FormattingEnabled = true;
            this.cbx_saveCategory.Items.AddRange(new object[] {
            resources.GetString("cbx_saveCategory.Items"),
            resources.GetString("cbx_saveCategory.Items1"),
            resources.GetString("cbx_saveCategory.Items2"),
            resources.GetString("cbx_saveCategory.Items3")});
            this.cbx_saveCategory.Name = "cbx_saveCategory";
            this.cbx_saveCategory.SelectedIndexChanged += new System.EventHandler(this.cbx_saveCategory_SelectedIndexChanged);
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tab_expenseCategory);
            this.tabControl.Controls.Add(this.tab_incomeCategory);
            this.tabControl.Controls.Add(this.tab_expenseType);
            this.tabControl.Controls.Add(this.tab_store);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tab_expenseCategory
            // 
            resources.ApplyResources(this.tab_expenseCategory, "tab_expenseCategory");
            this.tab_expenseCategory.Controls.Add(this.dgv_expenseCategory);
            this.tab_expenseCategory.Controls.Add(this.menuStrip2);
            this.tab_expenseCategory.Name = "tab_expenseCategory";
            this.tab_expenseCategory.UseVisualStyleBackColor = true;
            // 
            // dgv_expenseCategory
            // 
            resources.ApplyResources(this.dgv_expenseCategory, "dgv_expenseCategory");
            this.dgv_expenseCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_expenseCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_expenseCategory.Name = "dgv_expenseCategory";
            this.dgv_expenseCategory.RowHeadersVisible = false;
            this.dgv_expenseCategory.RowTemplate.Height = 30;
            this.dgv_expenseCategory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_expenseCategory_CellFormatting);
            this.dgv_expenseCategory.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_expenseCategory_CellValueChanged);
            // 
            // menuStrip2
            // 
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_deleteExpenseCategory});
            this.menuStrip2.Name = "menuStrip2";
            // 
            // btn_deleteExpenseCategory
            // 
            resources.ApplyResources(this.btn_deleteExpenseCategory, "btn_deleteExpenseCategory");
            this.btn_deleteExpenseCategory.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_deleteExpenseCategory.BackColor = System.Drawing.SystemColors.Control;
            this.btn_deleteExpenseCategory.Name = "btn_deleteExpenseCategory";
            this.btn_deleteExpenseCategory.Click += new System.EventHandler(this.btn_deleteExpenseCategory_Click);
            // 
            // tab_incomeCategory
            // 
            resources.ApplyResources(this.tab_incomeCategory, "tab_incomeCategory");
            this.tab_incomeCategory.Controls.Add(this.dgv_incomeCategory);
            this.tab_incomeCategory.Controls.Add(this.menuStrip3);
            this.tab_incomeCategory.Name = "tab_incomeCategory";
            this.tab_incomeCategory.UseVisualStyleBackColor = true;
            // 
            // dgv_incomeCategory
            // 
            resources.ApplyResources(this.dgv_incomeCategory, "dgv_incomeCategory");
            this.dgv_incomeCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_incomeCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_incomeCategory.Name = "dgv_incomeCategory";
            this.dgv_incomeCategory.RowHeadersVisible = false;
            this.dgv_incomeCategory.RowTemplate.Height = 30;
            this.dgv_incomeCategory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_incomeCategory_CellFormatting);
            // 
            // menuStrip3
            // 
            resources.ApplyResources(this.menuStrip3, "menuStrip3");
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_deleteIncomeCategory});
            this.menuStrip3.Name = "menuStrip3";
            // 
            // btn_deleteIncomeCategory
            // 
            resources.ApplyResources(this.btn_deleteIncomeCategory, "btn_deleteIncomeCategory");
            this.btn_deleteIncomeCategory.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_deleteIncomeCategory.BackColor = System.Drawing.SystemColors.Control;
            this.btn_deleteIncomeCategory.Name = "btn_deleteIncomeCategory";
            this.btn_deleteIncomeCategory.Click += new System.EventHandler(this.btn_deleteIncomeCategory_Click);
            // 
            // tab_expenseType
            // 
            resources.ApplyResources(this.tab_expenseType, "tab_expenseType");
            this.tab_expenseType.Controls.Add(this.dgv_expenseType);
            this.tab_expenseType.Controls.Add(this.menuStrip4);
            this.tab_expenseType.Name = "tab_expenseType";
            this.tab_expenseType.UseVisualStyleBackColor = true;
            // 
            // dgv_expenseType
            // 
            resources.ApplyResources(this.dgv_expenseType, "dgv_expenseType");
            this.dgv_expenseType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_expenseType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_expenseType.Name = "dgv_expenseType";
            this.dgv_expenseType.RowHeadersVisible = false;
            this.dgv_expenseType.RowTemplate.Height = 30;
            this.dgv_expenseType.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_expenseType_CellFormatting);
            // 
            // menuStrip4
            // 
            resources.ApplyResources(this.menuStrip4, "menuStrip4");
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_deleteExpenseType});
            this.menuStrip4.Name = "menuStrip4";
            // 
            // btn_deleteExpenseType
            // 
            resources.ApplyResources(this.btn_deleteExpenseType, "btn_deleteExpenseType");
            this.btn_deleteExpenseType.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_deleteExpenseType.BackColor = System.Drawing.SystemColors.Control;
            this.btn_deleteExpenseType.Name = "btn_deleteExpenseType";
            this.btn_deleteExpenseType.Click += new System.EventHandler(this.btn_deleteExpenseType_Click);
            // 
            // tab_store
            // 
            resources.ApplyResources(this.tab_store, "tab_store");
            this.tab_store.Controls.Add(this.dgv_store);
            this.tab_store.Controls.Add(this.menuStrip5);
            this.tab_store.Name = "tab_store";
            this.tab_store.UseVisualStyleBackColor = true;
            // 
            // dgv_store
            // 
            resources.ApplyResources(this.dgv_store, "dgv_store");
            this.dgv_store.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_store.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_store.Name = "dgv_store";
            this.dgv_store.RowHeadersVisible = false;
            this.dgv_store.RowTemplate.Height = 30;
            this.dgv_store.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_store_CellFormatting);
            // 
            // menuStrip5
            // 
            resources.ApplyResources(this.menuStrip5, "menuStrip5");
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_deleteStore});
            this.menuStrip5.Name = "menuStrip5";
            // 
            // btn_deleteStore
            // 
            resources.ApplyResources(this.btn_deleteStore, "btn_deleteStore");
            this.btn_deleteStore.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_deleteStore.BackColor = System.Drawing.SystemColors.Control;
            this.btn_deleteStore.Name = "btn_deleteStore";
            this.btn_deleteStore.Click += new System.EventHandler(this.btn_deleteStore_Click);
            // 
            // dgv_account
            // 
            resources.ApplyResources(this.dgv_account, "dgv_account");
            this.dgv_account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.RowHeadersVisible = false;
            this.dgv_account.RowTemplate.Height = 23;
            this.dgv_account.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_account_CellFormatting);
            this.dgv_account.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_account_CellValidating);
            this.dgv_account.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_account_CellValueChanged);
            // 
            // btn_deleteAccount
            // 
            resources.ApplyResources(this.btn_deleteAccount, "btn_deleteAccount");
            this.btn_deleteAccount.Name = "btn_deleteAccount";
            this.btn_deleteAccount.UseVisualStyleBackColor = true;
            this.btn_deleteAccount.Click += new System.EventHandler(this.btn_deleteAccount_Click);
            // 
            // lbl_totalIncome
            // 
            resources.ApplyResources(this.lbl_totalIncome, "lbl_totalIncome");
            this.lbl_totalIncome.ForeColor = System.Drawing.Color.Green;
            this.lbl_totalIncome.Name = "lbl_totalIncome";
            // 
            // lbl_totalExpense
            // 
            resources.ApplyResources(this.lbl_totalExpense, "lbl_totalExpense");
            this.lbl_totalExpense.ForeColor = System.Drawing.Color.Red;
            this.lbl_totalExpense.Name = "lbl_totalExpense";
            // 
            // lbl_totalRemain
            // 
            resources.ApplyResources(this.lbl_totalRemain, "lbl_totalRemain");
            this.lbl_totalRemain.Name = "lbl_totalRemain";
            // 
            // chk_income
            // 
            resources.ApplyResources(this.chk_income, "chk_income");
            this.chk_income.Checked = true;
            this.chk_income.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_income.Name = "chk_income";
            this.chk_income.UseVisualStyleBackColor = true;
            this.chk_income.CheckedChanged += new System.EventHandler(this.chk_income_CheckedChanged);
            // 
            // chk_expense
            // 
            resources.ApplyResources(this.chk_expense, "chk_expense");
            this.chk_expense.Checked = true;
            this.chk_expense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_expense.Name = "chk_expense";
            this.chk_expense.UseVisualStyleBackColor = true;
            this.chk_expense.CheckedChanged += new System.EventHandler(this.chk_expense_CheckedChanged);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_startDate,
            this.lbl_endDate});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lbl_startDate
            // 
            resources.ApplyResources(this.lbl_startDate, "lbl_startDate");
            this.lbl_startDate.Name = "lbl_startDate";
            // 
            // lbl_endDate
            // 
            resources.ApplyResources(this.lbl_endDate, "lbl_endDate");
            this.lbl_endDate.Name = "lbl_endDate";
            // 
            // AccountView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chk_expense);
            this.Controls.Add(this.chk_income);
            this.Controls.Add(this.lbl_totalRemain);
            this.Controls.Add(this.lbl_totalExpense);
            this.Controls.Add(this.lbl_totalIncome);
            this.Controls.Add(this.btn_deleteAccount);
            this.Controls.Add(this.dgv_account);
            this.Controls.Add(this.gbx_category);
            this.Controls.Add(this.gbx_account);
            this.Controls.Add(this.gbx_search);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AccountView";
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
            this.tabControl.ResumeLayout(false);
            this.tab_expenseCategory.ResumeLayout(false);
            this.tab_expenseCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expenseCategory)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tab_incomeCategory.ResumeLayout(false);
            this.tab_incomeCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incomeCategory)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.tab_expenseType.ResumeLayout(false);
            this.tab_expenseType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expenseType)).EndInit();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.tab_store.ResumeLayout(false);
            this.tab_store.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_store)).EndInit();
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_budget;
        private System.Windows.Forms.ToolStripMenuItem btn_statistic;
        private System.Windows.Forms.GroupBox gbx_account;
        private System.Windows.Forms.Button btn_saveExpenseAccount;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tab_expense;
        private System.Windows.Forms.TabPage tab_income;
        private System.Windows.Forms.GroupBox gbx_category;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_expenseCategory;
        private System.Windows.Forms.TabPage tab_expenseType;
        private System.Windows.Forms.DataGridView dgv_account;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.TextBox txt_descriptionSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbx_storeSearch;
        private System.Windows.Forms.ComboBox cbx_expenseTypeSearch;
        private System.Windows.Forms.ComboBox cbx_categorySearch;
        private System.Windows.Forms.Button btn_deleteAccount;
        private System.Windows.Forms.TextBox txt_expenseAmount;
        private System.Windows.Forms.ComboBox cbx_expenseCategory;
        private System.Windows.Forms.ComboBox cbx_store;
        private System.Windows.Forms.TextBox txt_expenseDescription;
        private System.Windows.Forms.Label lbl_totalIncome;
        private System.Windows.Forms.Label lbl_totalExpense;
        private System.Windows.Forms.Label lbl_totalRemain;
        private System.Windows.Forms.ComboBox cbx_expenseType;
        private System.Windows.Forms.ComboBox cbx_incomeCategory;
        private System.Windows.Forms.TextBox txt_incomeAmount;
        private System.Windows.Forms.TextBox txt_incomeDescription;
        private System.Windows.Forms.TextBox txt_saveExpenseCategoryAmount;
        private System.Windows.Forms.ComboBox cbx_saveCategory;
        private System.Windows.Forms.CheckBox chk_income;
        private System.Windows.Forms.CheckBox chk_expense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_saveIncomeAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_startDate;
        private System.Windows.Forms.ToolStripStatusLabel lbl_endDate;
        private System.Windows.Forms.TabPage tab_incomeCategory;
        private System.Windows.Forms.TabPage tab_store;
        private System.Windows.Forms.DataGridView dgv_store;
        private System.Windows.Forms.DataGridView dgv_expenseCategory;
        private System.Windows.Forms.DataGridView dgv_incomeCategory;
        private System.Windows.Forms.DataGridView dgv_expenseType;
        private System.Windows.Forms.Button btn_saveCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_saveExpense;
        private System.Windows.Forms.DateTimePicker dtp_saveIncome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_saveCategoryText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem btn_deleteExpenseCategory;
        private System.Windows.Forms.ToolStripMenuItem btn_deleteIncomeCategory;
        private System.Windows.Forms.ToolStripMenuItem btn_deleteExpenseType;
        private System.Windows.Forms.ToolStripMenuItem btn_deleteStore;
        private System.Windows.Forms.CheckBox chk_showDeletedCategory;
    }
}

