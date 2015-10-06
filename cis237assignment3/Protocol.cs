﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        private int numberLanguages;
        private const int costPerLanguage = 5000;

        public Protocol(string Model, string Material, string Color, int NumberLanguages)
            : base(Model, Material, Color)
        {

        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" | Languages: {0}", this.numberLanguages);
        }

        public override void CalculateTotalCost()
        {
            double languagesCost = this.numberLanguages * costPerLanguage;
        }

        public override double CalculateBaseCost()
        {
            return this.BaseCost;
        }
    }
}
