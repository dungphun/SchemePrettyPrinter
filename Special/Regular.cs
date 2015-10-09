// Regular -- Parse tree node strategy for printing regular lists

using System;

namespace Tree
{
    public class Regular : Special
    {
        // TODO: Add any fields needed.
    
        // TODO: Add an appropriate constructor.
        public Regular() { }

        public override void print(Node t, int n, bool p)
        {
            if(!p)
            {
                Console.Write("(");
            } else
            {
                Console.Write(" ");
            }
            Node car = t.getCar();
            car.print(n, !car.isPair());
            t.getCdr().print(n, true);
        }
    }
}


