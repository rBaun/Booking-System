using System;
using System.Collections.Generic;
using System.Text;
using Server.Entities.Enums;

namespace Server.Entities
{
    /**
     * A Store is used to uniquely identity a specific store and the ability
     * to map employees to the store.
     *
     * @Id is the store identifier
     * @Name is the name of the store, that the customer sees.
     * @StoreType is the category of the store, that tells what line of work they are in.
     *
     * For each store type there should be a folder in the 'Server.Entities' project.
     * Each of those folders should be of different types, that should be
     * specified in this enum.
     *
     * The StoreTypes enum should be implemented in the Store class and every employee type of class
     * should implement a store type of class.
     */
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public StoreTypes StoreType { get; set; }

        public Store(int id, string name, StoreTypes storeType)
        {
            Id = id;
            Name = name;
            StoreType = storeType;
        }
    }
}
