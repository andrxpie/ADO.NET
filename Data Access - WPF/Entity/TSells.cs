using System;

namespace Data_Access
{
    public class TSells
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SellerId { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Id} => {CustomerId}, {SellerId} ({Price}$ - {Date.ToString("yyyy-MM-dd")})";
        }
    }
}