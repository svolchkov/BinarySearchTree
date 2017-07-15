using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class DuplicateItemException : Exception
    {
        public DuplicateItemException(string message) :
            base(message)
        {
        }
    }
}
