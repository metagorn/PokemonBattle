using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Greninja : MyPokemon
    {
        public Greninja()
        {
            Random random = new Random();
            Name = "Greninja";
            HP = random.Next(254, 348);
            _image = Properties.Resources._13627ce66606dbdb41d6a11a0a48d3991a26858c;
            Atk = random.Next(175, 317);
            Defense = random.Next(125, 256);
        }
    }
}
