
using System;
using BCrypt.Net;
using static BCrypt.Net.BCrypt;

namespace DunaPet.App.Utils
{
    public class Crypt
    {
        private const int WorkFactor = 12;
        public string HashPasswd(string passwd)
        {
            var hashedPassword = HashPassword(passwd, WorkFactor);
            return hashedPassword;
        }
    }

    public class Decrypt
    {
    }
}
