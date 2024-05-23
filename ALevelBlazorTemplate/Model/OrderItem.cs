namespace SkyFall.Model
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Habit Habit { get; set; }
        public int Quantity { get; set; }
        public decimal Total => Habit.Point * Quantity;
    }
}
