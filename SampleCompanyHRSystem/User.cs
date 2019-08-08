using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCompanyHRSystem
{
    class User
    {
        int userID;
        string username;
        string firstname;
        string surname;
        string hash;
        string salt;
        DateTime lastPasswordChange;
        int permissions;

        //00000 - support worker

        //first digit - HR permission level
        //second digit - Finance permission level
        //third digit - Learning and Development permission level
        //fourth digit - IT permission level
        //fifth digit - Roaming profile - 0/1

        /*
         * 0 - can view own records - support worker
         * 1 - can view basic records of service - senior
         * 2 - can view service records - team lead
         * 3 - can view all service records - house manager
         * 4 - can view area records - area manager
         * 5 - can view all records - Office officer
         * 6 - can view all detailed records - Officer manager
         * 7 - can see all detailed records - Director
        */
    }
}
