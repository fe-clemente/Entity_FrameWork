using Azure;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace Blog
{
    class Program
    {
        public void Main(string[] args)
        {
            using var context = new BlogDataContext();



            var posts = context.PostWithTagCount.ToList();
            foreach (var post in posts)
            {
                
            }

            Console.WriteLine("Teste");

        }

    }
}


