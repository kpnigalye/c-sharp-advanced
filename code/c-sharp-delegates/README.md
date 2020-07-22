# Practicing Delegates in C-Sharp  

## What are Delegates?
- Delegates are reference types. They are function pointers in C# which are type safe.
- They allow methods or a block of methods to be passed as parameters.
- Signature of the delegate is same as the method you will be passing as a parameter. 


## Topics Covered
- Delegates
  - Delegates are function pointers in C# which are type safe.
  - It is a reference type who signature is same as the method you will be passing to it as a parameter. 
  - Delegates can be passed to methods as an argument and can be returned from methods as a return type.
````
delegate void SampleDelegate(string message)
// Traditional way of calling delegate using 'Invoke' function
ArithmaticDelegate operation1 = new ArithmaticDelegate(Add);
operation1.Invoke(5, 10);

// Assign method directly to delegate and pass arguments to delegate
ArithmaticDelegate operation2 = Substract;
operation2(15, 10);

// Using Lamda Expression
ArithmaticDelegate operation3 = (a, b) =>
{
    int c = a * b;
    Console.WriteLine($"Multiplication: {c}");
};
operation3(15, 10);
````

- Multicast Delegates
  - A delegate that can point to more than one method is a Multicast Delegate like this. 
  - You can add a function to the invocation list by using a ‘+’ sign.
  - You can remove a function to the invocation list by using a ‘-’ sign.

- Generic Delegates
````
delegate T SampleDelegate<T>(T a, T b)
````

- Anonymous Methods
  - As the name suggests, anonymous method is a method without a name. 
  - It can be defined using ‘delegate’ keyword and can be assigned to variable of delegate type.

- Func delegates
````
Func<int, bool> func = (numb) => numb % 2 != 0;
Console.WriteLine($"Is {n} an odd number? {func(n)}");
````

- Action delegates
````
Action<string> action = (msg) => Console.WriteLine(msg);
action("Printer output");
````

- Predicate delegates
````
Predicate<string> predicate = (string str) => str.Equals(str.ToUpper());
Console.WriteLine($"Is given string in capital letters? {predicate("Hello World")}");
````
