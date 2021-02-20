using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        ICampaignService campaignService;

        public GameManager(ICampaignService campaignService)
        {
            this.campaignService = campaignService;
        }
        public void GetGameSale(GamerManager gamerManager,Gamer gamer,Game game)
        {
            Console.WriteLine(gamer.FirstName + " isimli oyuncu " + game.GamePrice +" Tl'ye oyunu satın aldı");
        }

        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "eklendi"); 
        }

        public void Delete(Game game)
        {
           
            Console.WriteLine(game.GameName +"Guncellendi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "kaldırıldı");
        }
    }
}
