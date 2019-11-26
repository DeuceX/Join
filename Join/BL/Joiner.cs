using System.Collections.Generic;
using System.Linq;
using Join.Domain;

namespace Join.BL
{
    public class Joiner
    {
        public List<UserDepartment> Join(List<User> users, List<Department> departments)
        {
            return (users.Join(departments,
                    user => user.DepartmentId, department => department.Id,
                    (user, department) => new UserDepartment(
                        user.Id, user.Name, 
                        department.Id, department.Name)))
                .ToList();
        }
    }
}
