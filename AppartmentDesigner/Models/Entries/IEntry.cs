using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppartmentDesigner.Models.Entries
{
    /// <summary>
    /// <c>IEntry</c> Contains the base for any entry.
    /// </summary>
    internal interface IEntry
    {
        /// <summary>
        /// the price of the entry
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Whther or not this entry is an emergency exit
        /// </summary>
        bool IsEmergecyExit { get; set; }
        
        /// <summary>
        /// modifies the price using a % value
        /// </summary>
        /// <returns></returns>
        double PriceModifier(double modifier);
        
        /// <summary>
        /// adds moms to the price
        /// </summary>
        /// <returns></returns>
        double WithMoms(double modifier);
        int[] Dimensions { get; set; }
    }
}
