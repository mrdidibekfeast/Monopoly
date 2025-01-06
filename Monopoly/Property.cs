﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Property
    {
        public string name;
        public int price;
        public int rentCost;
        public int houseFactor;
        public BoardConstants.PropertyColors color;
        public Player owner; 

        public Property(string name, int price, int rentCost, int houseFactor, BoardConstants.PropertyColors color)
        {
            this.name = name;
            this.price = price;
            this.rentCost = rentCost;
            this.houseFactor = houseFactor;
            this.color = color;

            owner = null;
        }


    }
}
