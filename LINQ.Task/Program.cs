namespace LINQ.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            var sortedByName = from x in phoneBook orderby x.Name select x;
            var sortedByLastName = phoneBook.OrderBy(y => y.LastName);
            var sortedByNameAdnSurname = phoneBook
                .OrderBy(x => x.Name)
                .ThenBy(y => y.LastName);

            Console.WriteLine("Сортировка по имени:");
            foreach (var contact in sortedByName) 
            {
                Console.WriteLine(contact.Name + " " + contact.LastName + ": " + contact.PhoneNumber + ", " + contact.Email);
            }

            Console.WriteLine("\nСортировка по фамилии:");
            foreach (var contact in sortedByLastName)
            {
                Console.WriteLine(contact.LastName + " " + contact.Name + ": " + contact.PhoneNumber + ", " + contact.Email);
            }

            Console.WriteLine("\nСортировка по имени и фамилии:");
            foreach (var contact in sortedByNameAdnSurname)
            {
                Console.WriteLine(contact.Name + " " + contact.LastName + ": " + contact.PhoneNumber + ", " + contact.Email);
            }
        }
    }
}