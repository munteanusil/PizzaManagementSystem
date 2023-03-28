using Bogus.DataSets;
using CapricciosaPizza.Data;
using CapricciosaPizza.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using Microsoft.Graph.Models;

using CappricciosaPizzaContext context = new CappricciosaPizzaContext();

Product veggieSpecial = new Product()
{
    Name = "Veggie Special Pizza",
    Price = 9.99M
};
context.Products.Add(veggieSpecial);


Product deluxeMeat = new Product()
{
    Name = "Deluxe Meat pizza",
    Price = 12.99M,
};


context.Add(deluxeMeat);

//var veggieSpecial = context.Products
//                        .Where(p => p.Name == "Veggie Special Pizza")
//                        .FirstOrDefault();

//remove multiple id

var productsToRemove = context.Products.Where(p => p.Id == 6 || p.Id == 4);
if (productsToRemove.Any())
{
    context.RemoveRange(productsToRemove);
    context.SaveChanges();
}


//  update an entity ,change a price
if (veggieSpecial is Product)
{
    veggieSpecial.Price = 10.99M;
}


// to delete an entity from the database

if (veggieSpecial is Product)
{
    context.Remove(veggieSpecial);
}


context.SaveChanges();

var products = context.Products
    .Where(p => p.Price > 10.00M)
    .OrderBy(p => p.Name);

foreach (Product p in products)
{
    Console.WriteLine($"Id : {p.Id}");
    Console.WriteLine($"Name: {p.Name}");
    Console.WriteLine($"Price: {p.Price}");
    Console.WriteLine(new string('-', 20));
}

using LoyalCustomersContext Contextlol = new LoyalCustomersContext();

////reverse engineering in action

foreach (TblLoyalCustomer c in Contextlol.TblLoyalCustomers)
{
    Console.WriteLine($"Name:{c.FirstName}");
}

