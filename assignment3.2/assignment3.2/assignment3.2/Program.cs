using System;
using System.Collections;
using System.IO;

namespace assignment3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            read_file obj = new read_file();
            int linesCount = obj.read();
            for(int i=0;i<linesCount;i++)
            {
                obj.getQA(i, out int answer);
                Console.WriteLine("enter the correct option number");
                int choice =Convert.ToInt32(Console.ReadLine());
                if(choice==answer)
                    Console.WriteLine("your answer is correct");
                else
                    Console.WriteLine("your answer is wrong");
            }
        }
    }
    class read_file
    {
        ArrayList arrlist = new ArrayList();
        public int read()
        {
            FileStream fs = new FileStream(@"C:\Users\Vybhav A\Downloads\sample-quiz-file.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            int count = 0;
            while (sw.Peek() >= 0)
            {
                arrlist.Add(sw.ReadLine());
                count++;
            }
            return count;
        }
        public void getQA(int i,out int answer)
        {
            string[] questAndAns = (arrlist[i].ToString()).Split('|');
            int count = 0;answer = 0;
            foreach (string iterrate in questAndAns)
            {

                if (count == 0)
                {
                    Console.WriteLine(iterrate);
                    count++;
                }
                else
                {   

                    Console.Write(count + ". ");
                    
                    foreach (char c in iterrate)
                    {
                        if (c == '*')
                        {
                            answer = count;
                            continue;
                            
                        }
                        else
                        {
                            Console.Write(c);
                        }

                    }
                    Console.WriteLine();
                    count++;
                }

            }
        }
    }
}
