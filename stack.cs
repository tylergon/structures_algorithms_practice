using System;


namespace DataStruct.Stack
{
    public class Stack<T> {
        Entry _top;

        public void push(T data) {
            _top = new Entry(_top, data);
        }

        public T pop() {
            if (_top == null) {
                throw new InvalidOperationException();
            }

            T ret = _top.data;
            _top = _top.next;

            return ret;
        }

        public void print() {
            Entry curr = _top;
            Console.Write("[ ");

            while (curr != null) {
                Console.Write($"{curr.data} --> ");
                curr = curr.next;
            }

            Console.Write("null ]\n");
        }

        class Entry {
            public T data {get; set;}
            public Entry next {get; set;}

            public Entry(Entry next, T data) {
                this.next = next;
                this.data = data;
            }
        }
    }

    public class InteractableStack {
        public void TestOutStack() {
        Stack<String> s = new Stack<String>();

            while (true){
                Console.WriteLine("1: Insert onto stack");
                Console.WriteLine("2: Pop and print the top value on the stack");
                Console.WriteLine("3: Print stack");
                Console.WriteLine("4: Exit");

                Console.Write(">>> ");
                System.ConsoleKey key = Console.ReadKey(false).Key;

                switch(key) {
                    case (ConsoleKey.D1):
                        Console.Write("\nData: ");
                        s.push(Console.ReadLine());
                        break;
                    case (ConsoleKey.D2):
                        try {
                            Console.WriteLine($"\n {s.pop()}");
                        } catch (Exception e) {
                            Console.WriteLine("\nInvalid operation, the stack is empty");
                        }
                        
                        break;
                    case ConsoleKey.D3:
                        s.print();
                        break;
                    case ConsoleKey.D4:
                        return;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.Write('\n');
            }
        }
    }
}