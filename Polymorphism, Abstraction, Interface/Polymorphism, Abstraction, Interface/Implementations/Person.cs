using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstraction__Interface
{
    public class Person : ISpeak, IEating
    {
        public void Eating(DateTime time)
        {
            Console.WriteLine("Person eating - " + time);
        }
        
        public void Speak()
        {
            Console.WriteLine("Person speaking");
        }
    }
}
