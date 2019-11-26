namespace Join.Domain
{
    public class User
    {
        public User(int id, string name, int departmentId)
        {
            Id = id;
            Name = name;
            DepartmentId = departmentId;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int DepartmentId { get; set; }
    }
}
