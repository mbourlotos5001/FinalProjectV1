using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Person
    {
        public Person(int id, string name, int phoneNumber, bool paid )
        {
            PersonId = id;
            PersonName = name;
            PersonPhone = phoneNumber;
            PersonPaid = paid;
        }
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public int PersonPhone { get; set; }
        public bool PersonPaid { get; set; }
    }
}
