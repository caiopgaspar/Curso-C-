﻿using System;
using System.Collections.Generic;
using System.Globalization;
using ExerEnumComp3.Entities;
using ExerEnumComp3.Entities.Enum;

namespace ExerEnumComp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
           
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");           
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime dateTime = DateTime.Now;

            Client client = new Client(name, email, birthDate);
            Order order = new Order(dateTime, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
