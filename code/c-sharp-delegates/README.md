# Practicing Delegates in C-Sharp  

## What are Delegates?
- Delegates are reference types. They are function pointers in C# which are type safe.
- They allow methods or a block of methods to be passed as parameters.
- Signature of the delegate is same as the method you will be passing as a parameter. 


## Topics Covered
- Delegates
````
delegate void SampleDelegate(string message)
````
- Func delegates

````
Func<int, int, int> add_nums = (int t1, int t2) => t1 + t2;
add_nums.Invoke(3, 5)
````
- Action delegates
````
Action<string> act = msg => Console.Write("\n  {0}", msg);
act.Invoke("LINQ action's message");
````
