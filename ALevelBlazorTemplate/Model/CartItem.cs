namespace SkyFall.Model
{
    public class CartItem
    {
        public Habit Habit { get; set; }
        public int Quantity { get; set; }
        public decimal Total => Habit.Point * Quantity;
    }
}
