using System;
using System.Collections.Generic;
using System.Text;

namespace Class_and_constructor
{
    public class person
    {
        public string SekondName { get; set; }

        public string Name { get; set; }
        
        
        public person(string sekondName, string name)
        {
           
            SekondName = sekondName;
            Name = name;
        }
        
        
          
        
    }

}
