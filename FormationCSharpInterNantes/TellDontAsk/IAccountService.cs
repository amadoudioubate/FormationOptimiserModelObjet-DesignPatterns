﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.TellDontAsk
{
    internal interface IAccountService
    {
        void Withdraw(int accountId, double amount);
    }
}
