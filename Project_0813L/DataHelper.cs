using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_0813L
{
    public class DataHelper
    {
        private string[] Names { get; set; }
        private bool[] Check { get; set; }
        public int Limit { get; private set; }
        public int Times { get; set; }
        private Random random;

        public DataHelper()
        {
            random = new Random();
            Times = 0;
        }

        public bool LoadNames(StreamReader stream)
        {
            List<string> names = new List<string>();
            while (!stream.EndOfStream)
            {
                names.Add(stream.ReadLine());
            }
            
            Names = names.ToArray();
            Check = new bool[Names.Length];
            Limit = Names.Length;
            return true;
        }

        public string Choose()
        {            
            int index = random.Next(Limit);

            while (Check[index])
            {
                index = random.Next(Limit);                
            }

            Check[index] = true;
            return Names[index];
        }
    }
}
