using System;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            string frame = "";
            int idk = 0;

            foreach (string smth in strings)
            {
                if (idk < smth.Length)
                    idk = smth.Length;
            }

            for (int i = 0; i < idk + 4; i++)
            {
                frame += "*";
            }

            Console.WriteLine(frame);

            foreach (string smth in strings)
            {
                if (smth.Length < idk)
                {
                    string str = "";
                    for (int i = 0; i < idk - smth.Length; i++)
                    {
                        str += " ";
                    }
                    Console.WriteLine("* " + smth + str + " *");
                }
                else
                    Console.WriteLine("* " + smth + " *");
            }

            Console.WriteLine(frame);
        }
    }
}