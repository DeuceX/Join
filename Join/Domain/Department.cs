namespace Join.Domain
{
    public class Department
    {
        public Department(int id, string name, int managerId)
        {
            Id = id;
            Name = name;
            ManagerId = managerId;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int ManagerId { get; set; }
    }
}
