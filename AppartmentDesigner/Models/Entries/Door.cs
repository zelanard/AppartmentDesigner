using AppartmentDesigner.Enums;
using AppartmentDesigner.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppartmentDesigner.Models.Entries.Doors
{
    /// <summary>
    /// <c>Door</c> is the base for modeling a door.
    /// </summary>
    public abstract class Door : IEntry
    {
        private double _price;
        private bool _isEmergencyExit;
        private int[] _dimensions;

        /// <summary>
        /// base Constructor for a door
        /// </summary>
        /// <param name="price"></param>
        /// <param name="isEmergencyExit"></param>
        /// <param name="dimensions"></param>
        protected Door(int price, bool isEmergencyExit, int[] dimensions)
        {
            Price = price;
            _isEmergencyExit = isEmergencyExit;
            _dimensions = dimensions;
        }

        //summary in IEntry
        public int Price
        {
            get
            {
                return _price;
            }
            private set
            {
                _price = value;
            }
        }

        //summary in IEntry
        public bool IsEmergecyExit
        {
            get
            {
                return _isEmergencyExit;
            }

            set
            {
                _isEmergencyExit = value;
            }
        }

        //summary in IEntry
        public int[] Dimensions
        {
            get
            {
                return _dimensions;
            }

            set
            {
                _dimensions = value;
            }
        }

        //summary in IEntry
        public double PriceModifier(double modifier)
        {
            //change the modifier to % and make sure we're adding the 100% to it.
            return Price * ((modifier + 100) / 100);
        }

        //summary in IEntry
        public double WithMoms(int modifier)
        {
            if (modifier == 0)
            {
                return PriceModifier(25);
            }
            else
            {
                return PriceModifier(modifier * 1.25);
            }
        }

        /// <summary>
        /// get fire resistance
        /// </summary>
        /// <param name="door"></param>
        /// <returns></returns>
        public string GetFireResistance(DoorType door)
        {
            switch (door)
            {
                case DoorType.Fire40:
                    return "FireDoor40";
                case DoorType.Fire60:
                    return "FireDoor60";
                default:
                    return "This door have no fire resistance";
            }
        }
    }
}
