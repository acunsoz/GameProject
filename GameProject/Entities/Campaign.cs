using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Campaign:IEntity
    {
        public int Discount { get; set; }
        public string DiscountName { get; set; }

    }
}
