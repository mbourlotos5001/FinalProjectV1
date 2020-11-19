using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Tenant : Person
    {
        public Tenant(int tenId, string nm, int pn, bool tenPaid, string roomType, double rent) : base(tenId, nm, pn, tenPaid)
        {
            RoomType = roomType;
            RentAmount = rent;
        }
        public string RoomType { get; set; }
        public double RentAmount { get; set; }
    }
}
