using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace AIFit.Controllers
{
    public class HelperMethods
    {

        public bool ValidatePassword(string hashedpassword, string password)
        {
            var isValid = Crypto.VerifyHashedPassword(hashedpassword, password);
            return isValid;
        }

        public bool ValidateEmail(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

       

    }
}
