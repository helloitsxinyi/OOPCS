using System;

{
    public class PersonProp
    {

        private string firstName, lastName;
        private int age;
        private float height;


        public PersonProp(string firstName, string lastName, int age, float height)
        {
            //updating an automatic property from within a class itself
            FirstName = firstName;
            LastName = lastName;
            this.age = age;
            this.height = height;
        }

        // C# properties
        // important to rename to FirstName and LastName: automatic properties help to automatically read & update.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age
        {
            get { return age; }

            set
            {
                if (value > 0 && value < 150)
                    age = value;
            }
        }
        public float Height
        {
            get { return height; }

            set
            {
                if (value > 0 && value < 3.0)
                    height = value;
            }
        }

    }

}

