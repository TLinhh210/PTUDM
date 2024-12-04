using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DammioCodeFirstNewDatabase
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext()) 
            {
                //Nhap ten 1 Blog moi can tao
                Console.Write("Tên của 1 Blog mới: ");
                var name = Console.ReadLine();

                //them 1 Blog moi
                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();

                //Hien thi cac Blog trong db, sap xep theo Name
                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                Console.WriteLine("Tất cả blog trong database: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.BlogID + " " + item.Name);
                }
                Console.WriteLine("Gõ bất kỳ phím nào để thoát... ");
                Console.ReadKey();
            }  
        }
    }

    public class User
    {
        [Key] // đây là chú thích dữ liệu có ý nghĩa thuộc tính Username là khóa chính của lớp
        public string Username { get; set; }
        public string DisplayName { get; set; }
    }
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }  // thêm mới DbSet User
    }


}
