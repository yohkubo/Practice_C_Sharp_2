﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonster
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice dice)
        {
            dice.Sides = this.DamageMaximum;

            int damage = dice.Roll();
            return damage;
        }

        public void defend(int damage)
        {
            this.Health -= damage;
        }

    }

    public class Dice
    {
        public int Sides { get; set; }

        Random random = new Random();

        public int Roll()
        {
            return random.Next(1, Sides);
        }
    }
}
