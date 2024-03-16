using System;

public class PosisiKarakterGame
{
    public enum states{Jongkok, Berdiri, Terbang, Tengkurap};

    //When terbang ke jongkok, output pposisi landing
    //when berdiri ke terbang, output posisi take off

    states state = states.Berdiri;


    public void Run()
    {
        string command = " ";
        while (command != "EXIT")
        {
            Console.WriteLine("Current state: ");
            Console.WriteLine(state.ToString());
            Console.WriteLine("Masukan command");
            Console.WriteLine(" ");
            command = Console.ReadLine();

            switch(state)
            {
                case states.Jongkok:
                    if (command == "TombolW")
                    {
                        state = states.Berdiri;
                    
                    } else if (command == "TombolS")
                    {
                        state = states.Tengkurap;
                        
                    }
                    break;
                case states.Berdiri:
                    if (command == "TombolS")
                    {
                        state = states.Jongkok;
                    }
                    else if (command == "TombolW")
                    {
                        state = states.Terbang;
                        Console.WriteLine("posisi take off");

                    }
                    break;
                case states.Terbang:
                    if (command == "TombolS")
                    {
                        state = states.Berdiri;

                    }
                    else if (command == "TombolX")
                    {
                        state = states.Jongkok;
                        Console.WriteLine("posisi landing");

                    }
                    break;
                case states.Tengkurap:
                    if (command == "TombolW")
                    {
                        state = states.Jongkok;

                    }
                    break;



            }
        }

    }

}


