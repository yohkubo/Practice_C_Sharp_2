using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_030
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int heroHealth = 100;
            int monsterhealth = 100;

            displayBattleHeader();

            //Hero gets bonus first attack
            monsterhealth = performAttack(monsterhealth, 20, "Hero", "Monster");

            while (heroHealth > 0 && monsterhealth > 0)
            {
                displayRoundHeader();

                // Perform battle here!
                heroHealth = performAttack(heroHealth, 20, "Hero", "Monster");
                monsterhealth = performAttack(monsterhealth, 20, "Monster", "Hero");

                /*
                performAttack(heroHealth, 20, "Monster", "Hero", monsterArmorBonus: 10);

                performAttack(attackerDamageMax: 20,
                    defenderName: "Hero",
                    monsterArmorBonus: 10,
                    attackerName: "Monster",
                    defenderHealth: heroHealth);
                */

            }

            displayResult(heroHealth, monsterhealth);
                                                                                                                                                                                                                  

        }

        private void displayBattleHeader()
        {
            resultLabel.Text += "<h3>Battle Between the Hero (you) and the Monster (bad guy)</h3>";
        }

        private void displayRoundHeader()
        {
            resultLabel.Text += "<hr /><p>Round begins</p>";
        }

        private int performAttack(
            int defenderHealth, 
            int attackerDamageMax, 
            string attackerName, 
            string defenderName,
            double criticalHitChance = .1,
            double monsterArmorBonus = 5)
        {
            Random random = new Random();
            int damage = random.Next(1, attackerDamageMax);
            defenderHealth -= damage;

            describeRound(attackerName, defenderName, defenderHealth);

            return defenderHealth;
        }

        private void describeRound(string attackerName, string defenderName, int defenderHealth)
        {
            if (defenderHealth <= 0)
                resultLabel.Text += String.Format("<br />{0} attacks {1} and vanquishes the {2}.", attackerName, defenderName, defenderHealth);
            else
                resultLabel.Text += String.Format("<br />{0} attacks {1}, leaving {2} with {3} health.", attackerName, defenderName, defenderName, defenderHealth);
        }

        private void displayResult(int heroHealth, int monsterHealth)
        {
            if (heroHealth <= 0)
                resultLabel.Text += "<h3>Monster wins!</h3>";
            else if (monsterHealth <= 0)
                resultLabel.Text += "<h3>Hero wins!</h3>";
            else
                resultLabel.Text += "<h3>THey are both losers!</h3>";
        }

        public void displayMonsterStats(
            string monsterName,
            int health,
            int damageMaximum,
            double criticalHitChance)
        {
            resultLabel.Text += String.Format("<p>{0} Current Stats<br />Health: {1}<br /> Damage Max: {2}<br />Critical Hit Chance: {3}</p>",
                monsterName,
                health,
                damageMaximum,
                criticalHitChance);
        }

        public void displayMonsterStats(
            string monsterName,
            int health,
            int damageMaximum)
        {
            resultLabel.Text += String.Format("<p>{0} Current Stats<br />Health: {1}<br />Damage Max: {2}</p>",
                monsterName,
                health,
                damageMaximum);
        }

        public void displayMonsterStats(
            string monsterName,
            int health)
        {
            resultLabel.Text += String.Format("<p>{0} Current Stats<br />Health: {1}</p>",
                monsterName,
                health);
        }

        public void displayMonsterStats(
            string monsterName,
            string heroName)
        {
            resultLabel.Text += String.Format("<p>Name of Fighters:<br /> - {0}<br /> - {1}</p>",
                monsterName,
                heroName);
        }


    }
}