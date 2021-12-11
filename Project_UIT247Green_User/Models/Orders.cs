﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_UIT247Green_User.Models
{
    public class Orders
    {
        public int id_ord { set; get; }
        public int id_customer { set; get; }
        public int id_promotion { set; get; }
        public double ship { set; get; }
        public int shipmethod { set; get; }
        public int paymethod { set; get; }
        public int status { set; get; }
        public string note { set; get; }
        public double price_sum { set; get; }
        public static int Insert(int id_cus, int id_promotion,int shipmethod, int paymethod, double ship, string note, double pricesum)
        {
            using (var context = new DataContext())
            {
                context.Orders.Add(new Orders
                {
                    id_customer = id_cus,
                    id_promotion = id_promotion,
                    shipmethod = shipmethod,
                    paymethod = paymethod,
                    ship = ship,
                    status = 0,
                    note = note,
                    price_sum = pricesum + ship
                });
                return context.SaveChanges();
            }
        }
        public static Orders SelectNew()
        {
            using (var context = new DataContext())
            {
                Orders ord = context.Orders.Last();
                return ord;
            }
        }
    }
}
