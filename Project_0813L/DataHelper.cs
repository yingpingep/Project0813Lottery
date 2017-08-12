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
        private Random random;

        public DataHelper()
        {
            random = new Random();
        }

        public bool LoadNames(StreamReader stream)
        {
            List<string> names = new List<string>();
            while (!stream.EndOfStream)
            {
                names.Add(stream.ReadLine());
            }
            
            Names = names.ToArray();
            return true;
        }

        public string Choose()
        {            
            int limit = Names.Length;
            int index = random.Next(limit);

            while (Check[index])
            {
                index = random.Next(limit);
            }

            return Names[index];
        }
    }
}
