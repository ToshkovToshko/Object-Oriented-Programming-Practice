﻿namespace CreateCustomStackOfStrings
{
    public class CustomStack : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public Stack<string> AddRange(IEnumerable<string> range)
        {
            foreach (var item in range)
            {
                this.Push(item);
            }

            return this;
        }
    }
}
