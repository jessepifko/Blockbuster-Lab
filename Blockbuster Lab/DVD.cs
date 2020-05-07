using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class DVD : Movie
    {
        public DVD(string title, string category, int runtime, List<string> scenes) : base(title, category, runtime, scenes)
            {

            }

        public override void Play()
        {
            PrintScenes();
            Console.WriteLine();
            Console.WriteLine($"Which scene would you like to watch? (Select 0 to {Scenes.Count - 1})");
            string input = Console.ReadLine();
            int select = int.Parse(input);
            if (select > Scenes.Count - 1)
            {
                Console.WriteLine($"That is not an option. (Select 0 to {Scenes.Count - 1})");
                Play();
            }
            string scene = Scenes[select];
            Console.WriteLine($"\n{scene}");
            Console.WriteLine("Do you want to watch another scene? y/n");
            string confirm = Console.ReadLine().ToLower().Trim();
            if (confirm == "y")
            {
                Console.WriteLine();
                Play();
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
