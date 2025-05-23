﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class RailroadPropertySquare : PropertySquare
    {

        public RailroadPropertySquare(Property property, Panel infoPanel, PropertyVisualizer pvis) : base(property, infoPanel, pvis)
        {

        }

        public override void SquareEffect(Player player, Board board, Random rand)
        {
            if(property.owner == null)
            {
                base.SquareEffect(player, board, rand);
            }
            else
            {
                Player PropOwner = property.owner;
                int count = 0;
                foreach (var i in PropOwner.properties)
                {
                    if(i.color == BoardConstants.PropertyColors.Railroad)
                    {
                        count++;
                    }
                }
                int rentprice = (int)(property.rentCost * (Math.Pow(2,count-1)));

                player.money -= rentprice;
                property.owner.money += rentprice;
            }
           
        }

        public int GetRent(Player player)
        {
            Player PropOwner = property.owner;
            int count = 0;
            foreach (var i in PropOwner.properties)
            {
                if (i.color == BoardConstants.PropertyColors.Railroad)
                {
                    count++;
                }
            }
            return (int)(property.rentCost * (Math.Pow(2, count - 1)));
        }
    }
}
