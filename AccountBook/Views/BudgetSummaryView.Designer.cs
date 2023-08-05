
namespace AccountBook.Views
{
    partial class BudgetSummaryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetSummaryView));
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dgv_budgetSummary = new System.Windows.Forms.DataGridView();
            this.dgv_expenseCategory = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_start = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_end = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_budgetSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expenseCategory)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_from
            // 
            resources.ApplyResources(this.dtp_from, "dtp_from");
            this.dtp_from.Name = "dtp_from";
            // 
            // dtp_to
            // 
            resources.ApplyResources(this.dtp_to, "dtp_to");
            this.dtp_to.Name = "dtp_to";
            // 
            // dgv_budgetSummary
            // 
            resources.ApplyResources(this.dgv_budgetSummary, "dgv_budgetSummary");
            this.dgv_budgetSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_budgetSummary.Name = "dgv_budgetSummary";
            this.dgv_budgetSummary.RowTemplate.Height = 23;
            this.dgv_budgetSummary.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_budgetSummary_CellFormatting);
            // 
            // dgv_expenseCategory
            // 
            resources.ApplyResources(this.dgv_expenseCategory, "dgv_expenseCategory");
            this.dgv_expenseCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_expenseCategory.Name = "dgv_expenseCategory";
            this.dgv_expenseCategory.RowTemplate.Height = 23;
            // 
            // btn_search
            // 
            resources.ApplyResources(this.btn_search, "btn_search");
            this.btn_search.Name = "btn_search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_start,
            this.lbl_end});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lbl_start
            // 
            resources.ApplyResources(this.lbl_start, "lbl_start");
            this.lbl_start.Name = "lbl_start";
            // 
            // lbl_end
            // 
            resources.ApplyResources(this.lbl_end, "lbl_end");
            this.lbl_end.Name = "lbl_end";
            // 
            // BudgetSummaryView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_expenseCategory);
            this.Controls.Add(this.dgv_budgetSummary);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.dtp_from);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "BudgetSummaryView";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_budgetSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expenseCategory)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DataGridView dgv_budgetSummary;
        private System.Windows.Forms.DataGridView dgv_expenseCategory;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_start;
        private System.Windows.Forms.ToolStripStatusLabel lbl_end;
    }
}