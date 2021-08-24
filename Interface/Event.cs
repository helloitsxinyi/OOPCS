using System;
namespace Interface
{
    public class Event : Item, ISyncable
    {
        private string title;
        private DateTime date;

        public Event(string title, DateTime date) : base()
        {
            this.title = title;
            this.date = date;
        }

        public string GetSyncString()
        {
            return $"EV*{id}*{title}*{date.ToString()}";
        }
    }
}
