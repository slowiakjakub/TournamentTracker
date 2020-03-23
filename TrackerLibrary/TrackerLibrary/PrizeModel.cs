using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class PrizeModel
    {
        /// <summary>
        /// Specifies for which place the prize is.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Name of that specific place for which the prize is.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// The amount of the prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Specifies how much percentage of {PrizeAmount} goes to the winner of this particular prize.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
