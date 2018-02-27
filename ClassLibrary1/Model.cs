using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Model
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string ClusteredName { get; set; }
    }
}
