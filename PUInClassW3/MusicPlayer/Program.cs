using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play some music?");
            string answer = Console.ReadLine();
            
            if (answer == "yes")
            {
                Console.WriteLine("Playing music...!!");
                
                    using (SoundPlayer player = new SoundPlayer(@"C:\Users\Joana\Desktop\weeks\PU_IntroCSharp_InClass_1801681062\music\Official_Video_Clip-oal-MQkUoy8.wav"))
                    {
                        player.PlaySync();
                    }
            }
            else if (answer == "no")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Wrong Input.");
            }
            //Console.WriteLine("My answer is:{answer}"); 
        }
    }
}
