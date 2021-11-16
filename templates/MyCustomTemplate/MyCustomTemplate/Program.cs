using System;
    
@*#if (Framework == "net6.0")
namespace MyCustomTemplate;

class Program
{
    public static void Main()
    {
        
    }
}
@*#elif (Framework == "net5.0")
namespace MyCustomTemplate
{
    class Program
    {
        public static void Main()
        {
            
        }
    }
}
#endif*@