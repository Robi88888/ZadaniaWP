using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartBankC
{
    interface IPayment
    {
        double CheckStateAccount();
        void PayOutMoneyFromAccount(double AmountPayedOutMoney);
    }
}
