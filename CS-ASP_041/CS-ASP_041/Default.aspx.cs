using HeroMonster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_041
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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

            resultLabel.Text = String.Format("<hr>-Bonus Attack-<br/><Hero>{0} - {1} - {2} - {3}", Hero.Name, Hero.Health, Hero.DamageMaximum, Hero.AttackBonus)
                + String.Format("<br/><Monster>{0} - {1} - {2} - {3}", Monster.Name, Monster.Health, Monster.DamageMaximum, Monster.AttackBonus);

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

                resultLabel.Text += String.Format("<hr>-Round {0}-<br/><Hero>{1} - {2} - {3} - {4}", count, Hero.Name, Hero.Health, Hero.DamageMaximum, Hero.AttackBonus)
                + String.Format("<br/><Monster>{0} - {1} - {2} - {3}", Monster.Name, Monster.Health, Monster.DamageMaximum, Monster.AttackBonus);
            }
        }

        private void displayResult(Character opponent1, Character opponent2)
        {
            if (opponent1.Health <= 0 && opponent2.Health <= 0)
                resultLabel.Text += String.Format("<hr>They both {0} and {1} died...<hr>", opponent1.Name, opponent2.Name);
            else if (opponent2.Health <= 0)
                resultLabel.Text += String.Format("<hr>{0} wins!<hr>", opponent1.Name);
            else resultLabel.Text += String.Format("<hr>{0} wins!<hr>", opponent2.Name);
        }

        private void fighterStats(Character Hero, Character Monster)
        {
            statsLabel.Text = String.Format("***Hero's Status***<br/>Name: {0}<br/>Health: {1}<br/>Maximum Damage: {2}<br/>Bonus Attack: {3}<br/><br/>" +
                "***Monster's Status***<br/>Name: {4}<br/>Health: {5}<br/>Maximum Damage: {6}<br/>Bonus Attack: {7} ",
                Hero.Name, Hero.Health, Hero.DamageMaximum, Hero.AttackBonus, Monster.Name, Monster.Health, Monster.DamageMaximum, Monster.AttackBonus);
        }
        
    }
}