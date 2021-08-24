using System;
namespace Interface
{
    public class Contact : Item, ISyncable
    {
        private string name, mobile;
        public Contact(string name, string mobile) : base()
        {
            this.name = name;
            this.mobile = mobile;
        }

        public string GetSyncString()
        {
            return $"CO*{id}*{name}*{mobile}*";
        }
    }
}
