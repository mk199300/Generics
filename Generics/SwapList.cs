using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class SwapList<T> : List<T>
    {
        public List<T> list { set; get; }
        public SwapList() { }
        public void  Swap ( int index1,int index2)
        {

            T help = this.list[index1];
            this.list[index1]= this.list[index2];
            this.list[index2] = help;

        }

    }

}
