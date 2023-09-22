using AppartmentDesigner.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppartmentDesigner.Models.Entries.Doors
{
    /// <summary>
    /// <c>Backdoor</c> models a backdoor
    /// </summary>
    internal class BackDoor : Door
    {
        public BackDoor(DoorType doorType, double price, bool isEmergencyExit, int[] measurements) : base(price, isEmergencyExit, measurements)
        {
            DoorType = doorType;
        }

        /// <summary>
        /// The type of door. This is used for seeing fire resistnace.
        /// </summary>
        public DoorType DoorType { get; }
    }
}
