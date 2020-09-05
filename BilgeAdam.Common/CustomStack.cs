using System.Collections.Generic;

namespace BilgeAdam.Common
{
    public class CustomStack
    {
        Stack<string> stack = new Stack<string>();
        public int GetItemCount()
        {
            return stack.Count;
        }

        public void Add(string value)
        {
            stack.Push(value);
        }

        public string Call()
        {
            return stack.Pop();
        }

        public string Check()
        {
            return stack.Peek();
        }
    }
}


//TODO: Araştır => SortedSet, LinkedList, SortedDictionary, BlockingCollection