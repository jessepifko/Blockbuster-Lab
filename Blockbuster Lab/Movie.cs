using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
   abstract class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }
       
        public Movie(string title, string category, int runtime, List<string> scenes)
        {
            Title = title;
            Category = category;
            RunTime = runtime;
            Scenes = scenes;
        }

        //Up to the children to fill in
        public abstract void Play();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"RunTime: {RunTime}");
        }

        public void PrintScenes()
        {
            int i = 0; 
            foreach (string scene in Scenes)
            {
                i++;
                Console.WriteLine($"{i} : {scene}");
            }
        }
       


    }
}
