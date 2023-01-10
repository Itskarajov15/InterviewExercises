using StackImplementations.Contracts;
using StackImplementations.Implementations;

IStack<int> arrayStack = new ArrayStack<int>(3);
IStack<int> linkedListStack = new LinkedListStack<int>();

//Throws error because the stack is empty
arrayStack.Pop();
linkedListStack.Pop();

arrayStack.Push(5);
arrayStack.Push(6);
arrayStack.Push(5);
//Throws error because the stack has fixed size because of the array
arrayStack.Push(5);

linkedListStack.Push(21);
linkedListStack.Push(10);

//Output: 5
Console.WriteLine(arrayStack.Pop());
//Output: 10
Console.WriteLine(linkedListStack.Pop());
//Output: 21
Console.WriteLine(linkedListStack.Pop());