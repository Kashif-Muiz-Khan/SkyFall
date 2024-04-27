namespace SkyFall.Model
{
    public class ToDoList
    {
        public int ToDoListID { get; set; }
        public User UserID { get; set; }
        public DateTime Created { get; set; }
        public bool Status { get; set; }
        public string ToDoListText { get; set; }
    }

    public enum ToDoListStatus
    {
        None,
        Started,
        Halfway,
        Finished,
    }

    public enum ToDoListPriority
    {
        None,
        Low,
        High,
        Urgent,
    }
}
