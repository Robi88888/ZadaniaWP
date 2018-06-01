using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartBankC
{
    abstract class PaymentFactory
    {
        public abstract IPayment Bank();
    }

    class BankAccountFactory : PaymentFactory
    {
        public override IPayment Bank()
        {
            return new BankAccount();
        }
    }
}
