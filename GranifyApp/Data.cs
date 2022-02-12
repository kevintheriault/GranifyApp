using System;
using System.Collections.Generic;

namespace GranifyApp
{
    public class Data
    {
        private Dictionary<string, List<Pet>> mockDatabase = new Dictionary<string, List<Pet>>();

        // The assignment shows to have it print string but in assignment output example this is missing.
        public Data(string database)
        {
            Console.WriteLine("Connecting to database");
        }

        public Dictionary<string, List<Pet>> MockDatabase { get => mockDatabase; set => mockDatabase = value; }

        public void beginTran()
        {
            Console.WriteLine("Beginning transaction");
        }

        public void commit()
        {
            Console.WriteLine("Committing transaction");
        }

        public void rollback()
        {
            Console.WriteLine("Rolling back transaction");
        }

        public void insert(string table, Pet pet)
        {
            if (MockDatabase.ContainsKey(table))
            {
                MockDatabase[table].Add(pet);
            }
            else
            {
                MockDatabase.Add(table, new List<Pet>());
                MockDatabase[table].Add(pet);
            }
            Console.WriteLine("Inserting " + pet.Name + " into table " + table);
        }
    }
}
