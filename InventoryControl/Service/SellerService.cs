﻿using InventoryControl.BdWork;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControl.Service
{
    class SellerService
    {
        public static ObservableCollection<Seller> GetSellerInfo()
        {
            InventoryСontrolEntities context = new InventoryСontrolEntities();
            var Collection = new ObservableCollection<Seller>();
            var items = context.Seller.ToList();
            foreach (var item in items)
            {
       
                Collection.Add(item);
            }
            return Collection;
        }
    }
}
