using System;
using System.Collections.Generic;

class CSharpMasterClass
{
    static void Main()
    {
        Queue<Order> ordersQueue = new Queue<Order>();

        foreach (var order in RecieveOrdersFromBranch1())
        {
            ordersQueue.Enqueue(order);
        }

        foreach (var order in RecieveOrdersFromBranch2())
        {
            ordersQueue.Enqueue(order);
        }

        while (ordersQueue.Count > 0)
        {
            Order currentOrder = ordersQueue.Dequeue();
            currentOrder.ProcessOrder();
        }
    }

    static Order[] RecieveOrdersFromBranch1()
    {
        Order[] orders = new Order[]
        {
            new Order(1,5),
            new Order(2,4),
            new Order(6,10),
        };
        return orders;
    }

    static Order[] RecieveOrdersFromBranch2()
    {
        Order[] orders = new Order[]
        {
            new Order(3,5),
            new Order(4,4),
            new Order(5,10),
        };
        return orders;
    }
}
            
