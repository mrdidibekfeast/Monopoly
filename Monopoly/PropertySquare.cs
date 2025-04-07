using System;
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
        private readonly Panel infoPanel;
        PropertyVisualizer textBoxes;

        public PropertySquare(Property property, Panel infoPanel, PropertyVisualizer textBoxes)
        {
            this.infoPanel = infoPanel;
            this.property = property;
            this.textBoxes = textBoxes;
        }
        
        public override void SquareEffect(Player player,Board board, Random rand)
        {
            if (property.owner == null || property.owner == player)
            {
                infoPanel.Visible = true;

                textBoxes.propertyName.Text = property.name;
                textBoxes.propertyColor.Text = property.color.ToString();
                textBoxes.propertyPrice.Text = property.price.ToString();

                textBoxes.propertyRentCost.Text = property.GetRent().ToString();
              
            }
            else
            {
                if(!player.properties.Contains(property))
                {
                    //charge
                    player.money -= property.GetRent();
                    property.owner.money += property.GetRent();
                }
            }
        }
    }
}
