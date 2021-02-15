using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthDay == "1985" && gamer.FirstName == "Alperen") 
            {
                return true;
            }

            else
            {
                return false;
            }
           
        }
    }
}
