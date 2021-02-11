A Stack is a data structure for storing a list of elements in a LIFO (last in, first out) fashion.</br>
Design a class called Stack with three methods:</br>
void Push(object obj)</br>
object Pop()</br>
void Clear()</br>
</br>
The Push() method stores the given object on top of the stack. We use the “object” type here so
we can store any objects inside the stack. Remember the “object” class is the base of all classes
in the .NET Framework. So any types can be automatically upcast to the object. Make sure to
take into account the scenario that null is passed to this object. We should not store null
references in the stack. So if null is passed to this method, you should throw an
InvalidOperationException.</br>
</br>
The Pop() method removes the object on top of the stack and returns it. Make sure to take into
account the scenario that we call the Pop() method on an empty stack. In this case, this method
should throw an InvalidOperationException. Remember, your classes should always be in a valid
state and used properly. When they are misused, they should throw exceptions.</br>
</br>
The Clear() method removes all objects from the stack.</br>
We should be able to use this stack class as follows:</br>
var stack = new Stack();</br>
stack.Push(1);</br>
stack.Push(2);</br>
stack.Push(3);</br>
Console.WriteLine(stack.Pop());</br>
Console.WriteLine(stack.Pop());</br>
Console.WriteLine(stack.Pop());</br>
The output of this program will be</br>
3</br>
2</br>
1</br>