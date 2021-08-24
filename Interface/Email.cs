using System;
namespace Interface
{
    public class Email : Item, ISyncable
    {
        private string title, from, content;

        public Email(string title, string from, string content) : base()
        {
            this.title = title;
            this.from = from;
            this.content = content;           
        }

        public string GetSyncString()
        {
            return $"EM*{id}*{title}*{from}*{content}*";
        }
    }
}
