using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class AccountViewModel : BaseViewModel
    {
        public Account CurrentAccount { set; get; }

        public List<Account> AccountList { set; get; }
        public AccountViewModel()
        {
            AccountList = new List<Account>()            //initiates test account list
            {
                {new Account(1, 100) },
                {new Account(2, 300) },
                {new Account(3, 700) },
            };
            this.CurrentAccount = AccountList[0];

        }

        public void WriteList()
        {
            foreach(Account account in AccountList )
            {
                Console.WriteLine("Account number {0} has a value of {1}", account.ID, account.Value);
            }

        }

        public void Remove()
        {   
            AccountList.Remove(AccountList.Find(item=>item.ID==CurrentAccount.ID));
        }

        public void Add()
        { int LastID = AccountList.Last().ID;
            AccountList.Add(new Account(LastID+1, 0));
        }

    }
}
