using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Entities.HairSalon
{
    /**
     * An employee who cuts the hair on the customers.
     *
     * @Id specifies a specific HairDresser and is unique across ALL Hair Salons.
     * @Name is the name of the employee and can be nickname, first name, full name, etc.
     * @Information is an optional field to add information, that the customers can see.
     */
    public class HairDresser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }

        public HairDresser(string name, string information, int id = 0)
        {
            Name = name;
            Information = information;
            Id = id;
        }
    }
}
