using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SampleCompanyHRSystem
{
    static class UserHandler
    {
        static User currentUser;
        static DateTime logInTime;

        public static void LoadUser()
        {

        }

        public static void UnloadUser()
        {


        }

        public static void SaveUser()
        {

        }


        public static List<User> Users()
        {
            return new List<User>();
        }


        public static void Login()
        {

        }

        public static void Logout()
        {

        }

        public static string GenerateHash(String password, String salt)
        {
            return "";
        }

        public static byte[] GenerateSalt()
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            return salt;
        }

        
        //Methods


        //Load a user
        //Unload a user

        //Find a list of users


        //Login to a user
        //Log out of a user
    }
}
