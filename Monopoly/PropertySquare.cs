﻿using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class PropertySquare : Square
    {
        public Property property;

        public PropertySquare(Property property)
        {
            this.property = property;
        }
        public override void SquareEffect(Player player, Random rand)
        {
            if (property.owner == null)
            {
                //buy
            }
            else
            {
                if(!player.properties.Contains(property))
                {
                    //charge
                    player.money -= property.rentCost;
                    property.owner.money += property.rentCost;
                }
            }
        }
    }
}
