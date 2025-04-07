using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class PropertyVisualizer
    {
        public TextBox propertyName;
        public TextBox propertyColor;
        public TextBox propertyPrice;
        public TextBox propertyRentCost;

        public PropertyVisualizer(TextBox propertyName, TextBox propertyColor, TextBox propertyPrice, TextBox propertyRentCost)
        {
            this.propertyName = propertyName;
            this.propertyColor = propertyColor;
            this.propertyPrice = propertyPrice;
            this.propertyRentCost = propertyRentCost;
        }
    }
}
