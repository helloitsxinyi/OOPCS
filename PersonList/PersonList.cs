using System;
using System.Collections.Generic;


namespace PersonList
{
    public class PersonList
    {
        List<PersonProp> persons;

        public PersonList()
        {
            persons = new List<PersonProp>();
                
        }

        public bool AddUniqueNamedPerson(PersonProp person)
        {
            //foreach (PersonProp p in persons)
            // {
            // contains could be useful, but for now we only take in 4 arguments, not 2, need to overload PersonProp class if needed
            //if persons.Contains(new PersonProp(person.FirstName.ToLower(), person.LastName.ToLower()))
            // another method
            //if (p.FirstName.ToLower() == person.FirstName.ToLower())

            if (persons.Find(p => p.FirstName.ToLower() == person.FirstName.ToLower() && p.LastName.ToLower() == person.LastName.ToLower()) == null)
            {
                persons.Add(person);
                return true;
            }
            return false;    
        }

        public


    }
}
