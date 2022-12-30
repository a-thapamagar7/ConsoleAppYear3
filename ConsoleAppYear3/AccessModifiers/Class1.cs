using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppYear3.AccessModifiers
{
    class Class1
    {
        public void ForPublic()
        {
            Console.WriteLine("Public");
        }
        private void ForPrivate()
        {
            Console.WriteLine("Private");
        }

        private void UsePrivate()
        {
            ForPrivate();
        }

        protected void ForProtected()
        {
            Console.WriteLine("Protected");
        }

        internal void ForInternal()
        {
            Console.WriteLine("Internal");
        }

    }

    class Class2
    {
        Class1 c = new Class1();
        public void UsePublic()
        {
            c.ForPublic();
        }
    }

    class Class3 : Class1
    {
        private void UseProtected()
        {
            ForProtected();
        }
        private void UseInternal()
        {
            ForInternal();
        }
    }
}
