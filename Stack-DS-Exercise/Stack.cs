namespace Stack_DS_Exercise
{
    class Stack 
    {
        object[] Arr = new object[1];
        public void Push(object obj) 
        {
            Arr[Arr.Length - 1] = obj;
            
        }
        public object Pop() 
        { 
            object obj = Arr[Arr.Length - 1];
            Arr[Arr.Length - 1] = null;
            return obj;
        }
        public void Clear() 
        {
            Arr = new object[1];
        }
    }
}
