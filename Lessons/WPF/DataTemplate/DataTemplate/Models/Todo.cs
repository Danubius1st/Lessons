namespace DataTemplate.Models
{
    public class Todo
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private string _description;

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        private int _priority;

        public int Priority
        {
            get => _priority;
            set => _priority = value;
        }

        public override string ToString()
        {
            return Name + ": " + Description + "(" + Priority.ToString() + ")";
        }
    }
}
