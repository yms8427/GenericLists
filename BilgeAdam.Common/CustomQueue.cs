using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Common
{
    public class CustomQueue
    {
        Queue<string> queue = new Queue<string>();
        public int GetItemCount()
        {
            return queue.Count;
        }

        public void Add(string value)
        {
            queue.Enqueue(value);
        }

        public string Call()
        {
            return queue.Dequeue();
        }

        public string Check()
        {
            return queue.Peek();
        }
    }
}
