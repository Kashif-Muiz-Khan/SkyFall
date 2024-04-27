namespace SkyFall.Model
{
    public class DailyTask
    {
        public int DailyTaskID { get; set; }
        public User User { get; set; }
        public string Type { get; set; }
        public string TaskDescription { get; set; }
        public DateTime Created { get; set; }
        public bool Status { get; set; }
    }
}
