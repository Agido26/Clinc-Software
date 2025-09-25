using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presintion_Layer
{
    public class clsValidation
    {

        public static bool UserValidation(string User)
        { 
            bool result = false;

            if(!string.IsNullOrWhiteSpace(User))
            {
                result =true;
            }
            return result;
        }
        public static bool PasswordValidation(string Password)
        {
            bool result = false;

            if (!string.IsNullOrWhiteSpace(Password))
            {
                result = true;
            }
            return result;
        }



    }
}
