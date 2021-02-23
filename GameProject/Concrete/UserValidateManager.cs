using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidateManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="ALIHAN" && gamer.LastName=="ACUNSOZ" && gamer.TcNo=="12345" && gamer.DateOfBirth==1998)
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
