using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Direction
    {
        public virtual int dx
        {
            get { return 0; }
        }

        public virtual int dy
        {
            get { return 0; }
        }
    }

    public class Up : Direction
    {
        public override int dx
        {
            get { return -1; }
        }
    }
    public class Down : Direction
    {
        public override int dx
        {
            get { return 1; }
        }

    }
    public class Left : Direction
    {
        public override int dy
        {
            get { return -1; }
        }
    }
    public class Right : Direction
    {
        public override int dy
        {
            get { return 1; }
        }
    }
}
