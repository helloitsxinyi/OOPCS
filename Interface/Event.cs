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
            //system autosimplifies to: *{date:dd/mm/yy,HH:MM}*;
            return $"EV*{id}*{title}*{date.ToString("dd/MM/yy,HH:MM")}*";
        }
    }
}
