using CSharpSQLiteCryptExample;
using CSharpSQLiteCryptExample.domain;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using (var db = new AppDbContext())
        {
            Console.WriteLine("Before Insert ----------------------------");

            var persons1 = db.Persons.ToList();
            foreach (var person in persons1)
            {
                Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
            }

            db.Persons.Add(new Person { Id = 3, Name = "Alice" });
            db.Persons.Add(new Person { Id = 4, Name = "Bob" });
            db.SaveChanges();

            Console.WriteLine("After Insert ----------------------------");

            var persons2 = db.Persons.ToList();
            foreach (var person in persons2)
            {
                Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
            }
        }
    }
}
