
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
            this.btn_saveCategory = new System.Windows.Forms.Button();
            this.txt_saveExpenseCategoryAmount = new System.Windows.Forms.TextBox();
            this.cbx_saveCategory = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_expenseCategory = new System.Windows.Forms.TabPage();
            this.dgv_expenseCategory = new System.Windows.Forms.DataGridView();
            this.tab_incomeCategory = new System.Windows.Forms.TabPage();
            this.dgv_incomeCategory = new System.Windows.Forms.DataGridView();
            this.tab_expenseType = new System.Windows.Forms.TabPage();
            this.dgv_expenseType = new System.Windows.Forms.DataGridView();
            this.tab_store = new System.Windows.Forms.TabPage();
            this.dgv_store = new System.Windows.Forms.DataGridView();
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
            this.txt_saveCategoryText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.tab_incomeCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incomeCategory)).BeginInit();
            this.tab_expenseType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expenseType)).BeginInit();
            this.tab_store.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_store)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            // txt_descriptionSearch
            // 
            this.txt_descriptionSearch.Location = new System.Drawing.Point(260, 46);
            this.txt_descriptionSearch.Name = "txt_descriptionSearch";
            this.txt_descriptionSearch.Size = new System.Drawing.Size(249, 21);
            this.txt_descriptionSearch.TabIndex = 6;
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
            // cbx_storeSearch
            // 
            this.cbx_storeSearch.FormattingEnabled = true;
            this.cbx_storeSearch.Location = new System.Drawing.Point(133, 47);
            this.cbx_storeSearch.Name = "cbx_storeSearch";
            this.cbx_storeSearch.Size = new System.Drawing.Size(121, 20);
            this.cbx_storeSearch.TabIndex = 4;
            // 
            // cbx_expenseTypeSearch
            // 
            this.cbx_expenseTypeSearch.FormattingEnabled = true;
            this.cbx_expenseTypeSearch.Location = new System.Drawing.Point(6, 47);
            this.cbx_expenseTypeSearch.Name = "cbx_expenseTypeSearch";
            this.cbx_expenseTypeSearch.Size = new System.Drawing.Size(121, 20);
            this.cbx_expenseTypeSearch.TabIndex = 3;
            // 
            // cbx_categorySearch
            // 
            this.cbx_categorySearch.FormattingEnabled = true;
            this.cbx_categorySearch.Location = new System.Drawing.Point(388, 20);
            this.cbx_categorySearch.Name = "cbx_categorySearch";
            this.cbx_categorySearch.Size = new System.Drawing.Size(121, 20);
            this.cbx_categorySearch.TabIndex = 2;
            // 
            // dtp_to
            // 
            this.dtp_to.CustomFormat = "";
            this.dtp_to.Location = new System.Drawing.Point(182, 20);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(200, 21);
            this.dtp_to.TabIndex = 1;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_budget,
            this.btn_statistic});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_budget
            // 
            this.btn_budget.Name = "btn_budget";
            this.btn_budget.Size = new System.Drawing.Size(67, 22);
            this.btn_budget.Text = "예산현황";
            this.btn_budget.Click += new System.EventHandler(this.btn_budget_Click);
            // 
            // btn_statistic
            // 
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.Size = new System.Drawing.Size(43, 22);
            this.btn_statistic.Text = "통계";
            // 
            // gbx_account
            // 
            this.gbx_account.Controls.Add(this.tabControl2);
            this.gbx_account.Location = new System.Drawing.Point(680, 45);
            this.gbx_account.Name = "gbx_account";
            this.gbx_account.Size = new System.Drawing.Size(281, 256);
            this.gbx_account.TabIndex = 2;
            this.gbx_account.TabStop = false;
            this.gbx_account.Text = "입력하기";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tab_expense);
            this.tabControl2.Controls.Add(this.tab_income);
            this.tabControl2.Location = new System.Drawing.Point(6, 20);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(269, 231);
            this.tabControl2.TabIndex = 0;
            // 
            // tab_expense
            // 
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
            this.tab_expense.Location = new System.Drawing.Point(4, 22);
            this.tab_expense.Name = "tab_expense";
            this.tab_expense.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_expense.Size = new System.Drawing.Size(261, 205);
            this.tab_expense.TabIndex = 0;
            this.tab_expense.Text = "지출";
            this.tab_expense.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 147);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "일자";
            // 
            // dtp_saveExpense
            // 
            this.dtp_saveExpense.Location = new System.Drawing.Point(106, 143);
            this.dtp_saveExpense.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_saveExpense.Name = "dtp_saveExpense";
            this.dtp_saveExpense.Size = new System.Drawing.Size(145, 21);
            this.dtp_saveExpense.TabIndex = 12;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "구매처";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "내용";
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
            // btn_saveExpenseAccount
            // 
            this.btn_saveExpenseAccount.Location = new System.Drawing.Point(96, 181);
            this.btn_saveExpenseAccount.Name = "btn_saveExpenseAccount";
            this.btn_saveExpenseAccount.Size = new System.Drawing.Size(75, 23);
            this.btn_saveExpenseAccount.TabIndex = 1;
            this.btn_saveExpenseAccount.Text = "저장";
            this.btn_saveExpenseAccount.UseVisualStyleBackColor = true;
            this.btn_saveExpenseAccount.Click += new System.EventHandler(this.btn_saveExpenseAccount_Click);
            // 
            // cbx_expenseType
            // 
            this.cbx_expenseType.FormattingEnabled = true;
            this.cbx_expenseType.Location = new System.Drawing.Point(106, 116);
            this.cbx_expenseType.Name = "cbx_expenseType";
            this.cbx_expenseType.Size = new System.Drawing.Size(145, 20);
            this.cbx_expenseType.TabIndex = 5;
            // 
            // txt_expenseAmount
            // 
            this.txt_expenseAmount.Location = new System.Drawing.Point(106, 60);
            this.txt_expenseAmount.Name = "txt_expenseAmount";
            this.txt_expenseAmount.Size = new System.Drawing.Size(145, 21);
            this.txt_expenseAmount.TabIndex = 4;
            this.txt_expenseAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_expenseAmount_KeyPress);
            // 
            // cbx_expenseCategory
            // 
            this.cbx_expenseCategory.FormattingEnabled = true;
            this.cbx_expenseCategory.Location = new System.Drawing.Point(106, 7);
            this.cbx_expenseCategory.Name = "cbx_expenseCategory";
            this.cbx_expenseCategory.Size = new System.Drawing.Size(145, 20);
            this.cbx_expenseCategory.TabIndex = 3;
            // 
            // cbx_store
            // 
            this.cbx_store.FormattingEnabled = true;
            this.cbx_store.Location = new System.Drawing.Point(106, 89);
            this.cbx_store.Name = "cbx_store";
            this.cbx_store.Size = new System.Drawing.Size(145, 20);
            this.cbx_store.TabIndex = 2;
            // 
            // txt_expenseDescription
            // 
            this.txt_expenseDescription.Location = new System.Drawing.Point(106, 33);
            this.txt_expenseDescription.Name = "txt_expenseDescription";
            this.txt_expenseDescription.Size = new System.Drawing.Size(145, 21);
            this.txt_expenseDescription.TabIndex = 1;
            // 
            // tab_income
            // 
            this.tab_income.Controls.Add(this.dtp_saveIncome);
            this.tab_income.Controls.Add(this.label10);
            this.tab_income.Controls.Add(this.btn_saveIncomeAccount);
            this.tab_income.Controls.Add(this.label8);
            this.tab_income.Controls.Add(this.label7);
            this.tab_income.Controls.Add(this.label4);
            this.tab_income.Controls.Add(this.cbx_incomeCategory);
            this.tab_income.Controls.Add(this.txt_incomeAmount);
            this.tab_income.Controls.Add(this.txt_incomeDescription);
            this.tab_income.Location = new System.Drawing.Point(4, 22);
            this.tab_income.Name = "tab_income";
            this.tab_income.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_income.Size = new System.Drawing.Size(261, 205);
            this.tab_income.TabIndex = 1;
            this.tab_income.Text = "수입";
            this.tab_income.UseVisualStyleBackColor = true;
            // 
            // dtp_saveIncome
            // 
            this.dtp_saveIncome.Location = new System.Drawing.Point(106, 89);
            this.dtp_saveIncome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_saveIncome.Name = "dtp_saveIncome";
            this.dtp_saveIncome.Size = new System.Drawing.Size(145, 21);
            this.dtp_saveIncome.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 93);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "일자";
            // 
            // btn_saveIncomeAccount
            // 
            this.btn_saveIncomeAccount.Location = new System.Drawing.Point(96, 181);
            this.btn_saveIncomeAccount.Name = "btn_saveIncomeAccount";
            this.btn_saveIncomeAccount.Size = new System.Drawing.Size(75, 23);
            this.btn_saveIncomeAccount.TabIndex = 8;
            this.btn_saveIncomeAccount.Text = "저장";
            this.btn_saveIncomeAccount.UseVisualStyleBackColor = true;
            this.btn_saveIncomeAccount.Click += new System.EventHandler(this.btn_saveIncomeAccount_Click);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "내용";
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
            // cbx_incomeCategory
            // 
            this.cbx_incomeCategory.DropDownWidth = 145;
            this.cbx_incomeCategory.FormattingEnabled = true;
            this.cbx_incomeCategory.Location = new System.Drawing.Point(106, 7);
            this.cbx_incomeCategory.Name = "cbx_incomeCategory";
            this.cbx_incomeCategory.Size = new System.Drawing.Size(145, 20);
            this.cbx_incomeCategory.TabIndex = 3;
            // 
            // txt_incomeAmount
            // 
            this.txt_incomeAmount.Location = new System.Drawing.Point(106, 60);
            this.txt_incomeAmount.Name = "txt_incomeAmount";
            this.txt_incomeAmount.Size = new System.Drawing.Size(145, 21);
            this.txt_incomeAmount.TabIndex = 2;
            this.txt_incomeAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_incomeAmount_KeyPress);
            // 
            // txt_incomeDescription
            // 
            this.txt_incomeDescription.Location = new System.Drawing.Point(106, 33);
            this.txt_incomeDescription.Name = "txt_incomeDescription";
            this.txt_incomeDescription.Size = new System.Drawing.Size(145, 21);
            this.txt_incomeDescription.TabIndex = 1;
            // 
            // gbx_category
            // 
            this.gbx_category.Controls.Add(this.label13);
            this.gbx_category.Controls.Add(this.label12);
            this.gbx_category.Controls.Add(this.label11);
            this.gbx_category.Controls.Add(this.txt_saveCategoryText);
            this.gbx_category.Controls.Add(this.btn_saveCategory);
            this.gbx_category.Controls.Add(this.txt_saveExpenseCategoryAmount);
            this.gbx_category.Controls.Add(this.cbx_saveCategory);
            this.gbx_category.Controls.Add(this.tabControl);
            this.gbx_category.Location = new System.Drawing.Point(680, 316);
            this.gbx_category.Name = "gbx_category";
            this.gbx_category.Size = new System.Drawing.Size(281, 276);
            this.gbx_category.TabIndex = 3;
            this.gbx_category.TabStop = false;
            this.gbx_category.Text = "분류 생성하기";
            // 
            // btn_saveCategory
            // 
            this.btn_saveCategory.Location = new System.Drawing.Point(196, 245);
            this.btn_saveCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_saveCategory.Name = "btn_saveCategory";
            this.btn_saveCategory.Size = new System.Drawing.Size(75, 23);
            this.btn_saveCategory.TabIndex = 3;
            this.btn_saveCategory.Text = "항목추가";
            this.btn_saveCategory.UseVisualStyleBackColor = true;
            this.btn_saveCategory.Click += new System.EventHandler(this.btn_saveCategory_Click);
            // 
            // txt_saveExpenseCategoryAmount
            // 
            this.txt_saveExpenseCategoryAmount.Location = new System.Drawing.Point(134, 206);
            this.txt_saveExpenseCategoryAmount.Name = "txt_saveExpenseCategoryAmount";
            this.txt_saveExpenseCategoryAmount.Size = new System.Drawing.Size(137, 21);
            this.txt_saveExpenseCategoryAmount.TabIndex = 2;
            this.txt_saveExpenseCategoryAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_saveExpenseCategoryAmount_KeyPress);
            // 
            // cbx_saveCategory
            // 
            this.cbx_saveCategory.FormattingEnabled = true;
            this.cbx_saveCategory.Items.AddRange(new object[] {
            "지출항목",
            "수입항목",
            "지출종류",
            "구매처"});
            this.cbx_saveCategory.Location = new System.Drawing.Point(6, 207);
            this.cbx_saveCategory.Name = "cbx_saveCategory";
            this.cbx_saveCategory.Size = new System.Drawing.Size(122, 20);
            this.cbx_saveCategory.TabIndex = 1;
            this.cbx_saveCategory.SelectedIndexChanged += new System.EventHandler(this.cbx_saveCategory_SelectedIndexChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_expenseCategory);
            this.tabControl.Controls.Add(this.tab_incomeCategory);
            this.tabControl.Controls.Add(this.tab_expenseType);
            this.tabControl.Controls.Add(this.tab_store);
            this.tabControl.Location = new System.Drawing.Point(6, 19);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(269, 169);
            this.tabControl.TabIndex = 0;
            // 
            // tab_expenseCategory
            // 
            this.tab_expenseCategory.Controls.Add(this.dgv_expenseCategory);
            this.tab_expenseCategory.Location = new System.Drawing.Point(4, 22);
            this.tab_expenseCategory.Name = "tab_expenseCategory";
            this.tab_expenseCategory.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_expenseCategory.Size = new System.Drawing.Size(261, 143);
            this.tab_expenseCategory.TabIndex = 0;
            this.tab_expenseCategory.Text = "지출 항목";
            this.tab_expenseCategory.UseVisualStyleBackColor = true;
            // 
            // dgv_expenseCategory
            // 
            this.dgv_expenseCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_expenseCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_expenseCategory.Location = new System.Drawing.Point(3, 3);
            this.dgv_expenseCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_expenseCategory.Name = "dgv_expenseCategory";
            this.dgv_expenseCategory.RowHeadersWidth = 62;
            this.dgv_expenseCategory.RowTemplate.Height = 30;
            this.dgv_expenseCategory.Size = new System.Drawing.Size(255, 137);
            this.dgv_expenseCategory.TabIndex = 0;
            // 
            // tab_incomeCategory
            // 
            this.tab_incomeCategory.Controls.Add(this.dgv_incomeCategory);
            this.tab_incomeCategory.Location = new System.Drawing.Point(4, 22);
            this.tab_incomeCategory.Name = "tab_incomeCategory";
            this.tab_incomeCategory.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_incomeCategory.Size = new System.Drawing.Size(261, 143);
            this.tab_incomeCategory.TabIndex = 3;
            this.tab_incomeCategory.Text = "수입 항목";
            this.tab_incomeCategory.UseVisualStyleBackColor = true;
            // 
            // dgv_incomeCategory
            // 
            this.dgv_incomeCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_incomeCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_incomeCategory.Location = new System.Drawing.Point(3, 3);
            this.dgv_incomeCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_incomeCategory.Name = "dgv_incomeCategory";
            this.dgv_incomeCategory.RowHeadersWidth = 62;
            this.dgv_incomeCategory.RowTemplate.Height = 30;
            this.dgv_incomeCategory.Size = new System.Drawing.Size(255, 137);
            this.dgv_incomeCategory.TabIndex = 0;
            // 
            // tab_expenseType
            // 
            this.tab_expenseType.Controls.Add(this.dgv_expenseType);
            this.tab_expenseType.Location = new System.Drawing.Point(4, 22);
            this.tab_expenseType.Name = "tab_expenseType";
            this.tab_expenseType.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_expenseType.Size = new System.Drawing.Size(261, 143);
            this.tab_expenseType.TabIndex = 1;
            this.tab_expenseType.Text = "지출종류";
            this.tab_expenseType.UseVisualStyleBackColor = true;
            // 
            // dgv_expenseType
            // 
            this.dgv_expenseType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_expenseType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_expenseType.Location = new System.Drawing.Point(3, 3);
            this.dgv_expenseType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_expenseType.Name = "dgv_expenseType";
            this.dgv_expenseType.RowHeadersWidth = 62;
            this.dgv_expenseType.RowTemplate.Height = 30;
            this.dgv_expenseType.Size = new System.Drawing.Size(255, 137);
            this.dgv_expenseType.TabIndex = 0;
            // 
            // tab_store
            // 
            this.tab_store.Controls.Add(this.dgv_store);
            this.tab_store.Location = new System.Drawing.Point(4, 22);
            this.tab_store.Name = "tab_store";
            this.tab_store.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_store.Size = new System.Drawing.Size(261, 143);
            this.tab_store.TabIndex = 2;
            this.tab_store.Text = "구매처";
            this.tab_store.UseVisualStyleBackColor = true;
            // 
            // dgv_store
            // 
            this.dgv_store.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_store.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_store.Location = new System.Drawing.Point(3, 3);
            this.dgv_store.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_store.Name = "dgv_store";
            this.dgv_store.RowHeadersWidth = 62;
            this.dgv_store.RowTemplate.Height = 30;
            this.dgv_store.Size = new System.Drawing.Size(255, 137);
            this.dgv_store.TabIndex = 0;
            // 
            // dgv_account
            // 
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Location = new System.Drawing.Point(12, 152);
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.RowHeadersWidth = 62;
            this.dgv_account.RowTemplate.Height = 23;
            this.dgv_account.Size = new System.Drawing.Size(598, 292);
            this.dgv_account.TabIndex = 4;
            this.dgv_account.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_account_CellValueChanged);
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
            // chk_income
            // 
            this.chk_income.AutoSize = true;
            this.chk_income.Checked = true;
            this.chk_income.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_income.Location = new System.Drawing.Point(12, 130);
            this.chk_income.Name = "chk_income";
            this.chk_income.Size = new System.Drawing.Size(48, 16);
            this.chk_income.TabIndex = 10;
            this.chk_income.Text = "수입";
            this.chk_income.UseVisualStyleBackColor = true;
            this.chk_income.CheckedChanged += new System.EventHandler(this.chk_income_CheckedChanged);
            // 
            // chk_expense
            // 
            this.chk_expense.AutoSize = true;
            this.chk_expense.Checked = true;
            this.chk_expense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_expense.Location = new System.Drawing.Point(66, 130);
            this.chk_expense.Name = "chk_expense";
            this.chk_expense.Size = new System.Drawing.Size(48, 16);
            this.chk_expense.TabIndex = 11;
            this.chk_expense.Text = "지출";
            this.chk_expense.UseVisualStyleBackColor = true;
            this.chk_expense.CheckedChanged += new System.EventHandler(this.chk_expense_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_startDate,
            this.lbl_endDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 596);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1020, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(73, 17);
            this.lbl_startDate.Text = "lbl_startDate";
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(121, 17);
            this.lbl_endDate.Text = "toolStripStatusLabel2";
            // 
            // txt_saveCategoryText
            // 
            this.txt_saveCategoryText.Location = new System.Drawing.Point(6, 245);
            this.txt_saveCategoryText.Name = "txt_saveCategoryText";
            this.txt_saveCategoryText.Size = new System.Drawing.Size(185, 21);
            this.txt_saveCategoryText.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "분류 선택";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "한도금액";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 12);
            this.label13.TabIndex = 7;
            this.label13.Text = "항목 이름";
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 618);
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
            this.tabControl.ResumeLayout(false);
            this.tab_expenseCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expenseCategory)).EndInit();
            this.tab_incomeCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incomeCategory)).EndInit();
            this.tab_expenseType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expenseType)).EndInit();
            this.tab_store.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_store)).EndInit();
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
    }
}

