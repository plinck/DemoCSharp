namespace ClassDemo1
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }
    }
}