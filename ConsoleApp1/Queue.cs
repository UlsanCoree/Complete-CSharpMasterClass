using System;
using System.Collections.Generic;

class PractiseQueue
{
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        while (queue.Count > 0)
        {
            Console.WriteLine($"이번에 {queue.Dequeue()}가 제거됨");
            Console.WriteLine($"제거되고 남은 갯수는 : {queue.Count}");
        }
    }
}
