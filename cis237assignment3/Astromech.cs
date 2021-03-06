﻿/*  Assignment: cis237assigment3
    File: Astromech.cs
    Author: Benjamin M. Campbell
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        private bool fireExtinguisher;
        private int numberShips;
        private const int COSTPERSHIP = 4000;

        public Astromech(string Model, string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberShips)
            : base(Model, Material, Color, Toolbox, ComputerConnection, Arm)
        {
            this.BaseCost += 10000;
            this.fireExtinguisher = FireExtinguisher;
            this.numberShips = NumberShips;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" | Fire Extinguisher: {0} | Ships: {1}", this.fireExtinguisher, this.numberShips);
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();

            if (this.fireExtinguisher)
            {
                this.TotalCost += 5000;
            }

            TotalCost += this.numberShips * COSTPERSHIP;
        }
    }
}
