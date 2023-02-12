using System.Threading;

namespace PokemonBattle
{
    public partial class Form1 : Form
    {
        List<MyPokemon> pokemons;
        MyPokemon selectedPokemon;
        MyPokemon monster;
        public Form1()
        {
            InitializeComponent();
            pokemons = new List<MyPokemon>();
            pokemons.Add(new Dratini());
            pokemons.Add(new Greninja());
            pokemons.Add(new Rockruff());
            pokemons.Add(new Goodra());

            monster = new Riolu();
            pictureBox2.Image = monster.getImage();
            tbHP2.Text = monster.getHP().ToString();
            tbName2.Text = monster.getName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("Dead");
            }
            else
            {
                pictureBox1.Image = selectedPokemon.getImage();
                tbName1.Text = selectedPokemon.getName();
                tbHP1.Text = selectedPokemon.getHP().ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (selectedPokemon.getHP() >= 0)
            {

                int damage = (selectedPokemon.getAtk() - monster.getDefense());
                monster.takeDamage(damage);
                tbHP2.Text = monster.getHP().ToString();

                if (monster.getHP() <= 0)
                {
                    tbHP2.Text = "0";
                    MessageBox.Show("Monster Defeated!!");
                }
                else
                {
                    int enemyDamage = (monster.getAtk() - selectedPokemon.getDefense());
                    selectedPokemon.takeDamage(enemyDamage);
                    tbHP1.Text = selectedPokemon.getHP().ToString();
                }
            }
            else
            {
                MessageBox.Show("Pokemon has no HP left.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("He's Dead.");
            }
            else
            {
                pictureBox1.Image = selectedPokemon.getImage();
                tbName1.Text = selectedPokemon.getName();
                tbHP1.Text = selectedPokemon.getHP().ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("He's Dead.");
            }
            else
            {
                pictureBox1.Image = selectedPokemon.getImage();
                tbName1.Text = selectedPokemon.getName();
                tbHP1.Text = selectedPokemon.getHP().ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("He's Dead.");
            }
            else
            {
                pictureBox1.Image = selectedPokemon.getImage();
                tbName1.Text = selectedPokemon.getName();
                tbHP1.Text = selectedPokemon.getHP().ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (selectedPokemon != null)
            {
                selectedPokemon.IncreaseDef(50);
            }
            else
            {
                MessageBox.Show("doesn't Pokemon");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(selectedPokemon != null)
            {
                selectedPokemon.IncreaseHP(50);
                tbHP1.Text = selectedPokemon.getHP().ToString();
            }
            else
            {
                MessageBox.Show("doesn't Pokemon");
            }
        }
    }
}