using System.Reflection;
using log4net;
using log4net.Config;
using log4net.Repository.Hierarchy;

namespace Main;

public class TestClass
{
    public void ComplexMethod()
    {
        var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
        XmlConfigurator.Configure(logRepository, new FileInfo("log4netconfig.config"));

        if (5 == 5)
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