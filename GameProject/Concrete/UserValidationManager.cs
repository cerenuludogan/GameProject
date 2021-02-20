using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.NationalityId == "12345" && gamer.FirstName == "Engin" && gamer.LastName == "Demirog" && gamer.DateOfBirth == 1985) 
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
