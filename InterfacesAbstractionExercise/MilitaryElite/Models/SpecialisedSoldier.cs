﻿using System;
using MilitaryElite.Contracts.NewFolder;
using MilitaryElite.Enums;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(
            string id,
            string firstName,
            string lastName,
            decimal salary,
            Corps corps )
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public Corps Corps { get; private set; }

        public override string ToString()
        {
            return base.ToString() +
                   Environment.NewLine +
                   $"Corps: {this.Corps}";
        }
    }
}
