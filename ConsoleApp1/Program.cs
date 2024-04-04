using System;
using System.Collections.Generic;

class CSharpMasterClass
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        while (stack.Count > 0)
        {
            Console.WriteLine($"이번에 제거된 숫자는? {stack.Pop()}");
            Console.WriteLine($"스택안에 남은 숫자갯수는? {stack.Count}");
        }

        int[] numbers = { 8, 2, 3, 4, 7, 6, 2 };

        Stack<int> myStack = new Stack<int>();

        foreach (var num in numbers)
        {
            myStack.Push(num);
        }
        int[] reverseNum = new int[numbers.Length];
        
        for (int i = 0; i < reverseNum.Length; i++)
        {
            reverseNum[i] = myStack.Pop();
            Console.Write(" "+reverseNum[i]);
        }
    }
}
            
