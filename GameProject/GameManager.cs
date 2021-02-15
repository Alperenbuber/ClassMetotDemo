using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameServices
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyununuz başarıyla eklenmiştir:" + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyununuz başarıyla silinmiştir:" + game.GameName );
        }

        public void Uptaded(Game game)
        {
            Console.WriteLine("Oyununuz başarıyla güncellenmiştir.:" + game.GameName);
        }
    }
}
