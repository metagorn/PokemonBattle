using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Goodra : MyPokemon
    {
        public Goodra()
        {
            Random random = new Random();
            Name = "Goodra";
            HP = random.Next(290, 384);
            _image = Properties.Resources._0bc264cfd7d9eee6a9a036537d0035f91a65d9fc;
            Atk = random.Next(184, 350);
            Defense = random.Next(130, 262);
        }
    }
}
