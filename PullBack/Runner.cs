using System;
using System.Collections.Generic;

namespace PullBack
{
    public class Runner
    {
        public static void Run()
        {
            var domX = new HashSet<string>() {"X1", "X2", "X3"};
            var domY = new HashSet<string>() {"Y1", "Y2", "Y3", "Y4"};
            var codom = new HashSet<string>() {"Z1", "Z2", "Z3", "Z4"};
            var f = new F();
            var g = new G();
            Func<String, String, Boolean> comp = (s, s1) => s == s1;
            var results = new global::PullBack.PullBack().getPullback(f, domX, g, domY, codom, comp);
            foreach (var triple in results)
            {
                Console.WriteLine(triple.ToString());
            }
        }

        public static void Ex2()
        {
            var productHash = new HashSet<Product>
            {
                new Product
                {
                    ProductId = 1,
                    Name = "Prod1",
                    Category = "Category1"
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Prod2",
                    Category = "Category2"
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Prod3",
                    Category = "Category3"
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Prod4",
                    Category = "Category4"
                },
            };
            var articleHash = new HashSet<Article>
            {
                new Article
                {
                    ArticleId = 1,
                    Name = "Article1",
                    Category = "Category1"
                },
                new Article
                {
                    ArticleId = 2,
                    Name = "Article2",
                    Category = "Category2"
                },
                new Article
                {
                    ArticleId = 3,
                    Name = "Article3",
                    Category = "Category3"
                },
                new Article
                {
                    ArticleId = 4,
                    Name = "Article4",
                    Category = "Category4"
                },
            };

            //var domX = new HashSet<string>();
            //var domY = new HashSet<string>();

            //foreach (var product in productHash)
            //{
            //    domX.Add(product.Category);
            //}

            //foreach (var article in articleHash)
            //{
            //    domY.Add(article.Category);
            //}

            //var domX = new HashSet<string>() { "X1", "X2", "X3" };
            //var domY = new HashSet<string>() { "Y1", "Y2", "Y3", "Y4" };
            var codom = new HashSet<string>() { "Z1", "Z2", "Z3", "Z4" };
            var f = new F();
            var g = new G();
            Func<String, String, Boolean> comp = (s, s1) => s == s1;
            var results = new global::PullBack.PullBack().getPullback(f, productHash, g, articleHash, codom, comp);
            foreach (var triple in results)
            {
                Console.WriteLine(triple.ToString());
            }
        }
    }
}
