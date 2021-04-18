using System;
using System.Linq;

namespace Person
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "1.234.567-2");
            john.IntroduceYourself();
            Person jane = new Person("Jane Doe", "8.765.432-7");
            jane.IntroduceYourself();
            Person felipe = new Person("", "1.234.567-9");
            felipe.IntroduceYourself();
        }
    }
}
