﻿namespace DropShipping.Domain.Models
{
    public class Product : BaseEntity
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public int UserId { get; set; }

        //public virtual User User { get; set; }

        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
