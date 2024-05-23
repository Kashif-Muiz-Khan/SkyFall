namespace SkyFall.Model
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<OrderItem> Items { get; set; } = [];
        public DateTime Created { get; set; }
        public int Total => Items.Sum(item => item.Habit.Point * item.Quantity);
    }
}
