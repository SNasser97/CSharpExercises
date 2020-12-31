using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercises
{

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Select exercise to run (0=EXIST 1=stopwatch,2=stackoverpost..):");
                var input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        Console.WriteLine("exited");
                        break;
                    case 1:
                        Exercise1();
                        break;
                    case 2:
                        Exercise2();
                        break;
                    default:
                        Console.WriteLine("Option does not exist");
                        break;
                }
                break;
            } while (true);
        }

        static void Exercise1()
        {
            var stopwatch = new StopWatch(); // 00:00:00
            stopwatch.StartTimer();
            for (int i = 0; stopwatch.IsRunning; i++)
            {
                Console.WriteLine("Press Enter each time to get current duration");
                // Display every 1s
                Thread.Sleep(1_000);
                Console.Write("Type quit or q to exit:");
                var input = Console.ReadLine().ToLower().Trim();
                //getting stopwatch time here..
                stopwatch.Interval();

                if (String.Equals("quit", input) || input.Equals("q"))
                {
                    stopwatch.EndTimer();
                }

            }

            Console.WriteLine("Exited program");
            Console.WriteLine("Final duration: {0}", stopwatch.Duration);
        }
        static void Exercise2()
        {
            var post = new Post("Difference between Int.Parse vs Convert.Int ?");
            var post2 = new Post("How to use ternary condition in string literals?");
            var posts = new Posts().PostList;
            posts.Add(post.PostId, post);
            posts.Add(post2.PostId, post2);
            post.Upvote();
            post.Upvote();
            post.Upvote();
            post2.DownVote();
            post2.DownVote();
            post2.DownVote();
            post2.Upvote();
            post.DownVote();

            Console.Write("Search by id:");
            var input = Convert.ToInt32(Console.ReadLine().Trim());
            //Console.WriteLine(posts[input]);
            if (posts.ContainsKey(input))
            {
                posts[input].DisplayPost();
            }
            else
            {
                Console.WriteLine("Does not exist");
            }
        }
    }
}
