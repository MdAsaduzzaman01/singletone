using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
   public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object instancelock=new object(); 
        public static Singleton GetInstance
        {
            get
            {
                //Double Check for time safety
                if (instance == null)
                {
                    //Lock for Multi-threading
                    lock (instancelock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();

                        }
                       
                    }
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Instance Created " + counter + " times");
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
