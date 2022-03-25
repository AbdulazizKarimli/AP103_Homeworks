using System;
using System.Collections.Generic;
using System.Text;

namespace _19032022.Interfaces
{
    internal interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
