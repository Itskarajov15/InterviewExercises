using QueueImplementations.Implementations;

var arrayQueue = new ArrayQueue<int>(3);

//Throws error because the queue is empty
arrayQueue.Dequeue();

arrayQueue.Enqueue(2);
arrayQueue.Enqueue(3);
arrayQueue.Enqueue(6);
//Throws error because the queue is full
arrayQueue.Enqueue(7);

//Output: 2
Console.WriteLine(arrayQueue.Dequeue());
//Output: 3
Console.WriteLine(arrayQueue.Dequeue());
//Output: 6
Console.WriteLine(arrayQueue.Dequeue());

var linkedListQueue = new LinkedListQueue<int>();

//Throws error because the queue is empty
linkedListQueue.Dequeue();

linkedListQueue.Enqueue(5);
linkedListQueue.Enqueue(57);
linkedListQueue.Enqueue(10);

//Output: 5
Console.WriteLine(linkedListQueue.Dequeue());
//Output: 57
Console.WriteLine(linkedListQueue.Dequeue());
//Output: 10
Console.WriteLine(linkedListQueue.Dequeue());