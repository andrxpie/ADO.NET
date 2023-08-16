﻿namespace Entity_Framework_Intro.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public float Weight { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}