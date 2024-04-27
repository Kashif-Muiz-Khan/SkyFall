namespace SkyFall.Model
{
    public class DailyTask
    {
        public int TaskID { get; set; }
        public int UserID { get; set; }
        public string Type { get; set; }
        public string TaskDescription { get; set; }
        public DateTime Created { get; set; }
        public bool Status { get; set; }
    }
}
