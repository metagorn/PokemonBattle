using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Rockruff : MyPokemon
    {
        public Rockruff()
        {
            Random random = new Random();
            Name = "Rockruff";
            HP = random.Next(200, 294);
            _image = Properties.Resources._2d759e6d2a7539d82730e0347f4bc8c85fafbb03;
            Atk = random.Next(121, 251);
            Defense = random.Next(76, 196);
        }
    }
}
