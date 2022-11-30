using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.TellDontAsk
{
    internal class AccountService : IAccountService
    {
        // Une agrégation ou injection (private readonly IAccountRepository _accountRepository)
        // readonly => c'est à la création on va lui passé une instance après oon ne peut plus l'initialisé (que le constructeur qui a le droit d'initialisé)
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public void  Withdraw(int accountId, double amount)
        {
            Account c = _accountRepository.FindById(accountId); 
            c.Withdraw(amount);
            _accountRepository.Save(c);
        }
    }
}
