using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            NewStateUserValidationManager newStateUserValidationManager = new NewStateUserValidationManager();
            GamerManager gamerManager = new GamerManager(newStateUserValidationManager);
            Gamer gamer = new Gamer{ NationalityId = "12345", FirstName = "Engin", LastName = "Demirog", DateOfBirth = 1985 };
            
            gamerManager.Add(gamer);

            GameManager gameManager = new GameManager(new CampaignManager());
            Game game = new Game { GamePrice = 180.99 };
            gameManager.GetGameSale(gamerManager,gamer,game);
        }
    }
}
