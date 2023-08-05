using AccountBook.DataAccess;
using AccountBook.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Presenters
{
    public class BudgetSummaryPresenter
    {
        private readonly IBudgetSummartView _budgetSummartView;
        private readonly IAccountRepository _accountRepository;
        private readonly ICommonCodeRepository _commonCodeRepository;

        public BudgetSummaryPresenter(IBudgetSummartView budgetSummartView, IAccountRepository accountRepository, ICommonCodeRepository commonCodeRepository)
        {
            _budgetSummartView = budgetSummartView;
            _accountRepository = accountRepository;
            _commonCodeRepository = commonCodeRepository;
        }

        public void Initialize() 
        { 
        
        }
    }
}
