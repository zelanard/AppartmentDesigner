using AppartmentDesigner.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppartmentDesigner.Models.Entries.Windows
{
    /// <summary>
    /// <c>Window</c> is the base for modeling a window.
    /// </summary>
    internal abstract class Window : IEntry
    {
        private double _price;
        private bool _isEmergencyExit;
        private int[] _dimensions;
        private List<Pane> _panes;
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
        
        /// <summary>
        /// list of panes in the window.
        /// </summary>
        public List<Pane> Panes
        {
            get
            {
                return _panes;
            }

            set
            {
                _panes = value;
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

    }
}
