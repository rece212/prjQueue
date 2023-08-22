using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjLinkedListQueue
{
     class Qnode
    {
        public int key;
        public Qnode next;

        public Qnode(int key)
        { 
            this.key = key;
            this.next = null;
        }
    }
}
