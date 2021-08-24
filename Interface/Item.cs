using System;
namespace Interface
{
    public class Item
    {
        protected string id;

        public Item()
        {
            id = Guid.NewGuid().ToString();
        }
    }
}
