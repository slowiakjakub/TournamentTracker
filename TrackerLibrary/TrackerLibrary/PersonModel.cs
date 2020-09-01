using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// The First Name od the person.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The Last Name of the person.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The e-mail adress of the person.
        /// </summary>
        public string EmailAdress { get; set; }
        /// <summary>
        /// The phone number of the person.
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
