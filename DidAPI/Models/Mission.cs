namespace DidAPI.Models
{
    public class Mission
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }

        public Mission()
        {
        }

        public Mission(int Id, string Title, DateTime Deadline, string Description)
        {
            this.Id = Id;
            this.Title = Title;
            this.Deadline = Deadline;
            this.Description = Description;
        }
    }
}