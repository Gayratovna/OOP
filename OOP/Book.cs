using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Book
    {
            private string name;
            private string author;
            private decimal price;  

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;   
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }

        }

        public string Edition { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public Book()
        {

        }

        public Book(string name)
        {
            this.Name = name;
        }

        public void GetName()
        {
            Console.WriteLine($"Name: {this.Name}");
        }

        public void SetNewProper()
        {
            Console.WriteLine("Edition: ");
            Edition = Console.ReadLine();
            Console.WriteLine("Description: ");
            Description = Console.ReadLine();
            Console.WriteLine("Type");
            Type = Console.ReadLine();

        }
        public void GetAllInfo()
        {
            Console.WriteLine($"Name: {Name}\n" +
                $"Author: {Author}\n" +
                $"Price: {Price}\n" +
                $"Edition: {Edition}\n" +
                $"Description: {Description}\n" +
                $"Type: {Type}");
        }

    }
}
