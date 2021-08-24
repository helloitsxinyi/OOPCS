using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISyncable> syncables = new List<ISyncable>();

            // simulate items fetched from user's calendar.
            syncables.Add(new Email("Hi", "jane@gmail.com", "Free for lunch?"));
            syncables.Add(new Contact("Mary", "90111111"));
            syncables.Add(new Contact("Harry", "90111112"));
            syncables.Add(new Event("Lunch with Jane", new DateTime(2021, 9, 15, 19, 0, 0)));

            String serializedSync = "";
            foreach (ISyncable item in syncables)
            {
                serializedSync += item.GetSyncString();
            }

            // send serialized string to server
            Console.WriteLine(serializedSync);          
        }
    }
}
