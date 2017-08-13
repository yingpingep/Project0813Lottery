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
        private List<string> Names { get; set; }
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

            Names = names;
            return true;
        }

        public string Choose()
        {
            int litmit = Names.Count;

            if (litmit == 0)
                throw new ArgumentNullException();

            int index = random.Next(litmit);
            string name = Names[index];
            Names.Remove(name);

            return name;
        }
    }
}
