using AppartmentDesigner.Models.Appartments.Rooms;
using AppartmentDesigner.Models.Entries;
using AppartmentDesigner.Models.Inventories;
using AppartmentDesigner.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppartmentDesigner.Models.Appartments
{
    /// <summary>
    /// <c>Appartment</c> models an appartment
    /// </summary>
    internal class Appartment
    {
        private List<IRoom> _rooms;
        Appartment()
        {
            Rooms = new List<IRoom>();
        }

        internal List<IRoom> Rooms
        {
            get
            {
                return _rooms;
            }

            private set
            {
                _rooms = value;
            }
        }
    }
}
