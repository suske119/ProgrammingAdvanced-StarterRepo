using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoorbeeldOrders.Models;

namespace VoorbeeldOrders.Data.Repository
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> OrdersOphalen();

        public IEnumerable<Order> OrdersOphalenVoorKlant(string bedrijfsnaam);
    }
}