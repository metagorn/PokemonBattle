using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Froakie : MyPokemon
    {
        public Froakie()
        {
            Random random = new Random();
            Name = "Froakie";
            HP = random.Next(192, 286);
            _image = Properties.Resources.cd2282e3ecef2ea7889594f954f7f04865bc48e4;
            Atk = random.Next(105, 232);
            Defense = random.Next(76, 196);
        }
    }
}
