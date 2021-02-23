using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerServices
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kullanıcı sisteme kayıt oldu ");
            }
            else 
            {
                Console.WriteLine("İslerm basarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı sistemden silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı guncellendi");
        }
    }
}
