namespace Join.Domain
{
    public class UserDepartment
    {
        public UserDepartment(int userId, string userName, int departmentId, string departmentName)
        {
            UserId = userId;
            UserName = userName;
            DepartmentId = departmentId;
            DepartmentName = departmentName;
        }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }
    }
}
