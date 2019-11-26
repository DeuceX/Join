using System;
using Join.BL;
using Join.Helpers;

namespace Join
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create data
            var amountOfData = 10;
            var users = DataGenerator.GetUsers(amountOfData);
            var departments = DataGenerator.GetDepartments(amountOfData);

            // Join
            var joiner = new Joiner();
            var result = joiner.Join(users, departments);

            // Display the result
            foreach (var userDepartment in result)
            {
                Console.WriteLine($"UserId: {userDepartment.UserId}, UserName: {userDepartment.UserName}. " +
                                  $"DepartmentId: {userDepartment.DepartmentId}, DepartmentName: {userDepartment.DepartmentName}");
            }

            Console.ReadKey();
        }
    }
}
