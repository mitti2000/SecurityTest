using System.Reflection;
using log4net;
using log4net.Config;
using log4net.Repository.Hierarchy;

namespace Main;

public class TestClass
{
    public void ComplexMethod()
    {
        string password = "password1234";
        var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
        XmlConfigurator.Configure(logRepository, new FileInfo("log4netconfig.config"));

        if (password == "password1234")
        {
            Console.WriteLine("password is correct");
        }

        if (5 == password.Length)
        {
            List<Char> charArray = "this is a test".ToList();
            foreach (Char c in charArray)
            {
                if (c != null)
                {
                    if (c == 'b')
                    {
                        Console.WriteLine("this is a b");
                    }
                }
            }
        }
    }
}