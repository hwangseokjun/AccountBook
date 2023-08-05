using AccountBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBook.Views
{
    public partial class BudgetSummaryView : Form, IBudgetSummartView
    {
        public List<BudgetSummary> BudgetSummaries 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        
        public BudgetSummaryView()
        {
            InitializeComponent();
        }
    }
}
