using System.Collections.Generic;
using Join.Domain;

namespace Join.Helpers
{
    public static class DataGenerator
    {
        public static List<User> GetUsers(int amountOfUsers)
        {
            var list = new List<User>();

            for (var i = 0; i < amountOfUsers; i++)
            {
                list.Add(new User(i, $"User #{i}", i));
            }

            return list;
        }

        public static List<Department> GetDepartments(int amountOfDepartments)
        {
            var list = new List<Department>();

            for (var i = 0; i < amountOfDepartments; i++)
            {
                list.Add(new Department(i, $"Department #{i}", i));
            }

            return list;
        }
    }
}
