using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Blockbuster_Lab
{
    /* Next Create a child class of Movie called VHS and code the following:
A property called CurrentTime 
A method called Play() that plays the scene at the current time and then increments CurrentTime. 
A method called Rewind() that returns nothing and sets CurrentTime to 0. 
*/
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;
        public VHS(string title, string category, int runtime, List<string> scenes) : base(title, category, runtime, scenes)
        {

        }
        

        public override void Play()
        {
            string scene = Scenes[CurrentTime];
            Console.WriteLine();
            Console.WriteLine(scene);
            Console.WriteLine();
            CurrentTime++;
            if (CurrentTime > Scenes.Count - 1)
            {
                Rewind();
            }
            Console.WriteLine("Do you want to watch another scene? y/n");
            string confirm = Console.ReadLine().ToLower().Trim();
            if (confirm == "y")
            {
                Play();
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
