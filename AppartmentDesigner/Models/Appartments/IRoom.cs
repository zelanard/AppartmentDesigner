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
    /// <c>IRoom</c> Contains the base for any room.
    /// </summary>
    internal interface IRoom
    {
        /// <summary>
        /// Inventory would include ktichen,
        ///bathroom, outlets
        ///lamps, furniture and other
        ///types of inventory in the room.
        /// </summary>
        List<IInventory> Inventories { get; set; }
        
        /// <summary>
        /// room entries
        /// </summary>
        List<IEntry> Entries { get; set; }

        /// <summary>
        /// floor type
        /// </summary>
        FloorType Floor { get; set; }

        /// <summary>
        /// suqare meteres of the room
        /// </summary>
        int[] SquareMetre { get; set; }

        /// <summary>
        /// whtehr or not hte room has water installed
        /// </summary>
        bool HasWater { get; set; }
    }
}
