using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Dratini : MyPokemon
    {
        public Dratini()
        {
            Random random = new Random();
            Name = "Dratini";
            HP = random.Next(192, 286);
            _image = Properties.Resources._27a6cc8fdc7abc93def1b061b582dac7a93430c1;
            Atk = random.Next(119, 249);
            Defense = random.Next(85, 207);
        }
    }
}
