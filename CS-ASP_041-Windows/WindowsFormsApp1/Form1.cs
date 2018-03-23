using HeroMonster;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
                Character Hero = new Character();
                Hero.Name = "Ray";
                Hero.Health = 40;
                Hero.DamageMaximum = 20;
                Hero.AttackBonus = true;

                Character Monster = new Character();
                Monster.Name = "Kylo";
                Monster.Health = 50;
                Monster.DamageMaximum = 25;
                Monster.AttackBonus = false;

                //Dice dice = new Dice();

                bonusAttack(Hero, Monster);

                roundAttack(Hero, Monster);

                displayResult(Hero, Monster);

                fighterStats(Hero, Monster);

        }

            private void bonusAttack(Character Hero, Character Monster)
            {
                Dice dice = new Dice();

                if (Hero.AttackBonus)
                    Monster.defend(Hero.Attack(dice));

                if (Monster.AttackBonus)
                    Hero.Health -= Monster.Attack(dice);

                resultLabel.Text = String.Format("\r\n-Bonus Attack-\r\n<Hero>{0} - {1} - {2} - {3}", Hero.Name, Hero.Health, Hero.DamageMaximum, Hero.AttackBonus)
                    + String.Format("\r\n<Monster>{0} - {1} - {2} - {3}", Monster.Name, Monster.Health, Monster.DamageMaximum, Monster.AttackBonus);

            }



            private void roundAttack(Character Hero, Character Monster)
            {
                Dice dice = new Dice();
                int count = 0;

                while (Hero.Health > 0 && Monster.Health > 0)
                {
                    count++;  // Count round
                    Monster.defend(Hero.Attack(dice));
                    Hero.defend(Monster.Attack(dice));

                    resultLabel.Text += String.Format("\r\n-Round {0}-\r\n<Hero>{1} - {2} - {3} - {4}", count, Hero.Name, Hero.Health, Hero.DamageMaximum, Hero.AttackBonus)
                    + String.Format("\r\n<Monster>{0} - {1} - {2} - {3}", Monster.Name, Monster.Health, Monster.DamageMaximum, Monster.AttackBonus);
                }
            }

            private void displayResult(Character opponent1, Character opponent2)
            {
                if (opponent1.Health <= 0 && opponent2.Health <= 0)
                    resultLabel.Text += String.Format("\r\nThey both {0} and {1} died...\r\n", opponent1.Name, opponent2.Name);
                else if (opponent2.Health <= 0)
                    resultLabel.Text += String.Format("\r\n{0} wins!\r\n", opponent1.Name);
                else resultLabel.Text += String.Format("\r\n{0} wins!\r\n", opponent2.Name);
            }

            private void fighterStats(Character Hero, Character Monster)
            {
                statsLabel.Text = String.Format("***Hero's Status***\r\nName: {0}\r\nHealth: {1}\r\nMaximum Damage: {2}\r\nBonus Attack: {3}\r\n\r\n" +
                    "***Monster's Status***\r\nName: {4}\r\nHealth: {5}\r\nMaximum Damage: {6}\r\nBonus Attack: {7} ",
                    Hero.Name, Hero.Health, Hero.DamageMaximum, Hero.AttackBonus, Monster.Name, Monster.Health, Monster.DamageMaximum, Monster.AttackBonus);
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
