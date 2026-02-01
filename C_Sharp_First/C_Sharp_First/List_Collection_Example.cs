using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_First
{
    internal class List_Collection_Example
    {
        class Program
        {
            static void Main()
            {
                // ==========================================
                // 1. LIST<T> - ALL COMMON METHODS
                // ==========================================
                Console.WriteLine("--- LIST DEMO ---");
                List<string> tasks = new List<string> { "Code", "Sleep" };

                tasks.Add("Repeat");                // Adds to end
                tasks.Insert(1, "Eat");             // Inserts at index 1
                tasks.AddRange(new[] { "Gym", "Walk" }); // Adds multiple

                tasks.Remove("Walk");               // Removes specific item
                tasks.RemoveAt(0);                  // Removes item at index 0

                bool hasSleep = tasks.Contains("Sleep"); // Returns true
                int position = tasks.IndexOf("Eat");     // Returns index
                int count = tasks.Count;                 // Number of items

                tasks.Sort();                       // Alphabetical order

                foreach (var t in tasks) Console.WriteLine($"- {t}");


                // ==========================================
                // 2. DICTIONARY<K, V> - ALL COMMON METHODS
                // ==========================================
                Console.WriteLine("\n--- DICTIONARY DEMO ---");
                Dictionary<int, string> inventory = new Dictionary<int, string>();

                // Adding
                inventory.Add(1, "Laptop");
                inventory.Add(2, "Mouse");
                inventory[3] = "Keyboard";          // Direct assignment (Add or Update)

                // Updating
                inventory[2] = "Gaming Mouse";      // Updates value for key 2

                // Checking & Accessing
                if (inventory.ContainsKey(1))
                {
                    string item = inventory[1];
                    Console.WriteLine($"Key 1 exists: {item}");
                }

                // Safe Access (Best Practice)
                if (inventory.TryGetValue(2, out string val))
                {
                    Console.WriteLine($"Found Key 2: {val}");
                }

                // Removing
                inventory.Remove(3);                // Removes item with key 3

                // Properties
                int totalItems = inventory.Count;
                var allKeys = inventory.Keys;       // Collection of all keys
                var allValues = inventory.Values;   // Collection of all values

                // Iterating
                foreach (KeyValuePair<int, string> kvp in inventory)
                {
                    Console.WriteLine($"ID: {kvp.Key} | Product: {kvp.Value}");
                }

                // Clear everything
                tasks.Clear();
                inventory.Clear();

            }
        }
    }
}
