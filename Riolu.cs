using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Riolu : MyPokemon
    {
        public Riolu()
        {
            Random random = new Random();
            Name = "Riolu";
            HP = random.Next(190, 284);
            _image = Properties.Resources.aae700aa7bb29fae4a30b77c495b0b66406d74d6;
            Atk = random.Next(130, 262);
            Defense = random.Next(76, 196);
        }
    }
}
