using hello_world.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hello_world.Services
{
    public class MockBookRepository : IRepository<Book>
    {

        List<Book> books;

        public MockBookRepository()
        {
            books = new List<Book>()
            {
                new Book()
                {
                    Title = "Learning ASP",
                    Description = "Sam's attempt to learn this stuff",
                    Author = "Andrew Anders",
                    PublishDate = "July, 2021",
                    Price = 35,
                    Image = ""
                },
                new Book()
                {
                    Title = "Learning Java Spring",
                    Description = "Sam's attempt build better knowledge of this stuff",
                    Author = "Berty Boblin",
                    PublishDate = "November, 2018",
                    Price = 5,
                    Image = ""
                }
            };
        }

        public bool Add(Book item)
        {
            try
            {
                Book book = item;
                book.Id = books.Max(x => x.Id) + 1;
                books.Add(item);
                return true;
            } catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Book item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Book item)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return books.ToList();
        }
    }
}
