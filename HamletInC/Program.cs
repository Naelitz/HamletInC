// Created by David Naelitz. This is a newer version of a java homework assignment redone in C#.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HamletInC
{
    class Program
    {
        // Used to easily direct to new file
        static String FILE_NAME = "C:/Users/Naelitz/Documents/HamletInC/HamletInC/Hamlet.txt";  
        static StreamReader reader = new StreamReader(FILE_NAME);
        static System.Diagnostics.Stopwatch timer; // Will be used to measure eficiency of different sorts.
        static UnsortedList chaosList = new UnsortedList();
        static SelfSorting selfSortingList = new SelfSorting();
        static SearchTree tree = new SearchTree();
        static long overheadTime;
        static long chaosTime;
        static long selfSortTime;
        static long treeTime;
        static void Main(string[] args)
        {
            // Creates a line to send to linked list.
            String lineString = null;
            StartTimer(); // Starts the stop watch to measure following code.
        
           
            CalcOverhead();
            Console.WriteLine("\nCalculated over head time: " + overheadTime + " ms");
            CreateUnsorted();
            Console.WriteLine("Calculated time to make unsorted list: " + chaosTime + " ms");
            CreateAlphabetical();
            Console.WriteLine("Calculated time to make self sorting list: " + selfSortTime + " ms");
            CreateSearchTree();
            Console.WriteLine("\nCalculated time to make search tree: " + treeTime + " ms");
            tree.stat();
           
            
            Console.Read();
        }

        static void CalcOverhead()
        {
            reader = new StreamReader(FILE_NAME);
            StartTimer();
            while (reader.Peek() != -1)
            {
                String line = reader.ReadLine();
                if (line != null)
                {
                    // This will remove all the common punctuation from the String.
                    var charsToRemove = new string[] { "@", ",", ".", ";", "'", "?", ":", "'", "!", "[", "]", "&"};
                    foreach (var c in charsToRemove)
                    {
                        line = line.Replace(c, string.Empty);
                    }
                    // Takes the string of words and seperates it using spaces as delimiters.
                    String[] words = line.Split(' ');
                    foreach (var element in words)
                    {

                    }
                }
            }
            overheadTime = timer.ElapsedMilliseconds;
            
            
        }

        static void CreateUnsorted()
        {
            reader = new StreamReader(FILE_NAME);
            StartTimer();
            while (reader.Peek() != -1)
            {
                String line = reader.ReadLine();
                if (line != null)
                {
                    var charsToRemove = new string[] { "@", ",", ".", ";", "'", "?", ":", "'", "!", "[", "]", "&" };
                    foreach (var c in charsToRemove)
                    {
                        line = line.Replace(c, string.Empty);
                    }

                    String[] words = line.Split(' ');
                    foreach (var element in words)
                    {
                        chaosList.AddNode(new Node (element.ToLower()));
                    }
                }
            }
            chaosTime = EndTimer();

        }

        static void CreateAlphabetical()
        {
            reader = new StreamReader(FILE_NAME);
            StartTimer();
            while (reader.Peek() != -1)
            {
                String line = reader.ReadLine();
                if (line != null)
                {
                    var charsToRemove = new string[] { "@", ",", ".", ";", "'", "?", ":", "'", "!", "[", "]", "&" };
                    foreach (var c in charsToRemove)
                    {
                        line = line.Replace(c, string.Empty);
                    }

                    String[] words = line.Split(' ');
                    foreach (var element in words)
                    {
                        selfSortingList.AddNode(new Node (element.ToLower()));
                    }
                }
            }
            selfSortTime = EndTimer();

        }

        static void CreateSearchTree()
        {
            reader = new StreamReader(FILE_NAME);
            StartTimer();
            while (reader.Peek() != -1)
            {
                String line = reader.ReadLine();
                if (line != null)
                {
                    var charsToRemove = new string[] { "@", ",", ".", ";", "'", "?", ":", "'", "!", "[", "]", "&" };
                    foreach (var c in charsToRemove)
                    {
                        line = line.Replace(c, string.Empty);
                    }

                    String[] words = line.Split(' ');
                    foreach (var element in words)
                    {
                        tree.Add(new TreeNode(element.ToLower()));
                    }
                }
            }
            treeTime = EndTimer();

        }

        static void StartTimer()
        {
            timer = System.Diagnostics.Stopwatch.StartNew();
        }

        static long EndTimer()
        {
            return timer.ElapsedMilliseconds;
        }

    }
}
