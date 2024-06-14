using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Manufacturer() { }

        public Manufacturer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static List<Manufacturer> GetFromTXT(string filename) 
        {
            List<Manufacturer> list = new List<Manufacturer>();
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Manufacturer m = new Manufacturer();
                    string[] tok = line.Split(',');
                    m.Id = int.Parse(tok[0]);
                    m.Name = tok[1];
                    list.Add(m);
                }
            }
            return list;
        }
    }
}
