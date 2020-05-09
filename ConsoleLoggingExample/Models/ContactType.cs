using System.Collections.Generic;

namespace ConsoleLoggingExample.Models
{
    public partial class ContactType
    {
        public ContactType()
        {
            Customers = new HashSet<Customers>();
        }

        public int ContactTypeIdentifier { get; set; }
        public string ContactTitle { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
    }
}