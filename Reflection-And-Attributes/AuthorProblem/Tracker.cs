using System.Reflection;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodByAuthor()
        {
            Type[] allTypes = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in allTypes)
            {
                PrintAllMethodAuthors(type);

                if (type.GetCustomAttributes().Any(t => t.GetType() == typeof(AuthorAttribute)))
                {
                    continue;
                }

                AuthorAttribute[] attributes = type.GetCustomAttributes()
                    .Where(t => t.GetType() == typeof(AuthorAttribute))
                    .Select(t => (AuthorAttribute)t)
                    .ToArray();

                foreach (var attr in attributes)
                {
                    Console.WriteLine($"{type.Name} created by {attr.Name}");
                }
            }
        }

        private void PrintAllMethodAuthors(Type type)
        {
            MethodInfo[] methods = type.GetMethods();

            foreach (var method in methods)
            {
                if (!method.GetCustomAttributes().Any(a => a.GetType() == typeof(AuthorAttribute)))
                {
                    continue;
                }

                Attribute[] attributes = method.GetCustomAttributes().ToArray();

                foreach (var attr in attributes)
                {
                    if (attr is AuthorAttribute)
                    {
                        AuthorAttribute author = (AuthorAttribute)attr;

                        Console.WriteLine($"{method.Name} is written by {author.Name}");
                    }
                }
            }
        }
    }
}
