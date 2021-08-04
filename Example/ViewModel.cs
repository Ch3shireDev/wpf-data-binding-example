using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class ViewModel
    {
        public int ParameterA { get; set; } = 123;
        public string ParameterB { get; set; } = "abc";
        public float ParameterC { get; set; } = 0.012f;
        public List<Element> Elements { get; set; }

        public void RefreshElements()
        {
            var names = new string[]
            {
                "Mike",
                "Joe",
                "Brett",
                "June",
                "Felix",
                "Werner",
                "Steve",
                "Kevin",
                "Jim",
                "Hank"
            };

            var r = new Random();
            Elements = new List<Element>();
            for (int i = 0; i < r.Next() % 10; i++)
            {
                var element = new Element
                {
                    Id = i,
                    Name = names[r.Next() % 10]
                };
                Elements.Add(element);
            }
        }
    }

  public  class Element
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
