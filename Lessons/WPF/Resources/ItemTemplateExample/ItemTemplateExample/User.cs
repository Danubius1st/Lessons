namespace ItemTemplateExample
{

    internal class User
    {
        public int Age { get; internal set; }
        public string Name { get; internal set; }
        public string Mail { get; internal set; }

        public override string ToString()
        {
            return string.Format($"{Name}, {Age} years old");
        }
    }
}
