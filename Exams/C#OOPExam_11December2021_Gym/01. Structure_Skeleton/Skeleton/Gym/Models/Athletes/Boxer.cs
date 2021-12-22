﻿using System;
using Gym.Utilities.Messages;

namespace Gym.Models.Athletes
{
    //Can train only in a BoxingGym.
    public class Boxer : Athlete
    {
        public const int initialStamina = 60;

        public Boxer(string fullName, string motivation, int numberOfMedals) 
            : base(fullName, motivation, numberOfMedals, initialStamina)
        {
        }

        public override void Exercise()
        {
            this.Stamina += 15;

            if (this.Stamina > 100)
            {
                this.Stamina = 100;

                throw new ArgumentException(ExceptionMessages.InvalidStamina);
            }
        }
    }
}
