using AppartmentDesigner.Enums;
using AppartmentDesigner.Models.Entries.Doors;
using AppartmentDesigner.Models.Entries.Windows;
using AppartmentDesigner.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppartmentDesigner.Models.Entries
{
    /// <summary>
    /// <c>EntryManager</c> keeps track of entries.
    /// </summary>
    internal class EntryManager
    {
        private List<IEntry> _entries;

        /// <summary>
        /// constructs an entry manager.
        /// </summary>
        public EntryManager()
        {
            _entries = new List<IEntry>();
        }

        internal List<IEntry> Entries
        {
            get
            {
                return _entries;
            }

            set
            {
                _entries = value;
            }
        }

        /// <summary>
        /// Add a door to the entry manager.
        /// </summary>
        /// <param name="doorType"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public IEntry AddDoor(DoorType doorType)
        {
            switch(doorType)
            {
                case DoorType.Room:
                    return new RoomDoor();
                case DoorType.Main:
                    return new FrontDoor();
                case DoorType.Back:
                    return new BackDoor(doorType);
                case DoorType.Fire40:
                    return new BackDoor(doorType);
                case DoorType.Fire60:
                    return new BackDoor(doorType);
                default: 
                    throw new ArgumentException();
            }
        }
        /// <summary>
        /// Add a bathroom window to the entry manager
        /// </summary>
        /// <returns></returns>
        public BathRoomWindow AddBathroomWindow()
        {
            return new BathRoomWindow();
        }
        /// <summary>
        /// Add a standard window to the entry manager.
        /// </summary>
        /// <param name="panes"></param>
        /// <returns></returns>
        public StandardWindow AddStandardWindow(Pane[] panes)
        {
            return new StandardWindow(panes);
        }
        
        /// <summary>
        /// return an entry from the entry manager.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Entry"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEntry GetEntry<T>(T Entry)
        {
            throw new NotImplementedException();
        }
    }
}
