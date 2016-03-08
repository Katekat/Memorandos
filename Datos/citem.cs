using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class citem
    {
    public string Name {get; set;}
    
 
    public citem(string name)
    {
        Name = name; 
       
    }
    public override string ToString()
    {
        return Name;
    }
    }
}
