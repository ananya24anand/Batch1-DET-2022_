using Batch1_DET_2022_.Data;
using Batch1_DET_2022_.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022_
{
    internal class CodeFirstEF
    {
        private static void Main()
        {
            //AddNewBook();
            //DeleteBook();
            //UpdateBook();
            //GetAllBookAvailable();
            //GetAllBook();
            //AddNewCustomerAndOrder();
            //AddNewOrder();
            //GetAllCustomersWithOrder_EagerLoading();
            //GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();
            Console.ReadLine();
        }

        private static void Disconnectedarchitecture()
        {
            var ctx = new BookContext();

            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

            ctx.Dispose();

            UpdateCustomerName(customer);

        }

        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Mike";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR

            //  ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");

        }

        private static void AddNewCustomerAndOrder()
        {
            var ctx = new BookContext();

            Customer customer = new Customer();
            customer.ID = 1;
            customer.Name = "Emma";
            customer.Age = 20;

            Order order = new Order();
            order.Order_ID = 100;
            order.Amount = 2000;
            order.OrderDate = DateTime.Now;

            order.cust = customer;
            try
            {
                //ctx.Orders.Add(order);
                //ctx.SaveChanges();
                //Console.WriteLine("Customer and order created");

                //Customer c = ctx.Orders.Where(c => c.cu == 2).SingleOrDefault();
            //    ctx.Orders.Where(C => C.cust == 1).SingleOrDefault();
            //    ctx.Orders.Add(order);
            //    ctx.SaveChanges();
            //    Console.WriteLine("order created");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private static void GetAllCustomersWithOrder_EagerLoading()
        {
            //Eager loading means that the related data is loaded 
            //from the database as part of the initial query.
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers.Include("Orders");

                //var customers = ctx.Customers.Include(o => o.Orders);                   

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");


                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
                    }
                    Console.WriteLine("-----");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void GetAllCustomersWithOrder_ExplicitLoading()
        {
            //Explicit loading means that the related data is
            //explicitly loaded from the database at a later time.
            //Needs MARS to be set to TRUE in connection string
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers;

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");

                    ctx.Entry(customer).Collection(o => o.Orders).Load();

                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());

                    }
                    Console.WriteLine("-----");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //private static void AddNewOrder()
        //{
        //    var ctx = new BookContext();

        //    ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();
        //    Order order = new Order();
        //    order.Order_ID = 300;
        //    order.Amount = 2000;
        //    order.OrderDate = DateTime.Now;


        //    try
        //    {
        //        /*ctx.Customers.Where(c => c.ID == 1).SingleOrDefault()*/;
        //        //ctx.Orders.Where(C => C.cust == 1).SingleOrDefault();
        //        ctx.Orders.Add(order);
        //        ctx.SaveChanges();
        //        Console.WriteLine("order created");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 9;
        //    book.BookName = "JQuery";
        //    book.author = "Liam";
        //    book.price = 800;

        //    try
        //    {
        //        ctx.Books.Add(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("new book added");
        //    }

        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.InnerException.Message);
        //    }
        //}

        //private static void DeleteBook()

        //{
        //    var ctx = new BookContext();
        //    try
        //    {

        //        Book book = ctx.Books.Where(b => b.BookID == 2).SingleOrDefault();
        //        ctx.Remove(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Book deleted");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void UpdateBook()

        //{
        //    var ctx = new BookContext();
        //    try
        //    {


        //        Book book = ctx.Books.Where(b => b.BookID == 3).SingleOrDefault();
        //        book.BookName = "LinQ";
        //        book.price = 1000;
        //        ctx.Update(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Updated book");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void GetAllBook()
        //{
        //    var ctx = new BookContext();
        //    var book = ctx.Books.Where(b => b.BookID == 5).SingleOrDefault();
        //    Console.WriteLine("Book Name        Book Price");
        //    Console.WriteLine(book.BookName + "                 " + book.price);
        //}

        //private static void GetAllBookAvailable()
        //{
        //    var ctx = new BookContext();
        //    var book = ctx.Books.ToList();
        //    Console.WriteLine("Id\tName\t\tPrice");
        //    foreach (var b in book)
        //        Console.WriteLine(b.BookID+"\t"+b.BookName+"\t\t"+b.price);
        //}

    }
}
