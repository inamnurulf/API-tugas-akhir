namespace DidAPI.Models
{
    public class Mission
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
        public bool Checkbox { get; set; } = false;

        public Mission()
        {
        }

        public Mission(int Id, string Title, DateTime Deadline, string Description,bool Checkbox)
        {
            this.Id = Id;
            this.Title = Title;
            this.Deadline = Deadline;
            this.Description = Description;
        }
    }
}