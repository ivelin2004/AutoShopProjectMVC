using AutoShop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoShop1.Controller
{
    public class CarController
    {
        private Auto_ShopContext auto_ShopContext;

        public List<AutoShop> GetAll()
        {

            using (auto_ShopContext = new Auto_ShopContext())
            {
                return auto_ShopContext.AutoShop.ToList();
            }
        }

        public AutoShop Get(int id)
        {
            using (auto_ShopContext = new Auto_ShopContext())
            {
                return auto_ShopContext.AutoShop.Find(id);

            }
        }
        public void Add(AutoShop autoshop)
        {
            using (auto_ShopContext = new Auto_ShopContext())
            {
                auto_ShopContext.AutoShop.Add(autoshop);
                auto_ShopContext.SaveChanges();

            }
        }

        public void Update(AutoShop autoshop)
        {
            using (auto_ShopContext = new Auto_ShopContext())
            {
                var item = auto_ShopContext.AutoShop.Find(autoshop.IdCar);
                if (item != null)
                {
                    auto_ShopContext.Entry(item).CurrentValues.SetValues(autoshop);
                    auto_ShopContext.SaveChanges();
                }

            }
        }
        public void Delete(int id)
        {
            
            using (auto_ShopContext = new Auto_ShopContext())
            {
                var autoshop = auto_ShopContext.AutoShop.Find(id);
                if (autoshop != null)
                {
                    auto_ShopContext.AutoShop.Remove(autoshop);
                    auto_ShopContext.SaveChanges();
                }
            }
        }

    }
}

