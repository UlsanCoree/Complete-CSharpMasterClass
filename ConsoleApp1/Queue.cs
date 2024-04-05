using System;
using System.Collections.Generic;

class Order
{
    public int OrderID { get; set; }
    public int OrderQuantity { get; set; }

    public Order(int id, int orderQuantity)
    {
        this.OrderID = id;
        this.OrderQuantity = orderQuantity;
    }
}