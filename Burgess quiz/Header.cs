using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgess_quiz
{
   
    class Header
    {
        public string p1 { get; set; }
        public int p2 { get; set; }

        public Header(string p1, int p2)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
        }
        
        //public string HeaderId { get; set; }
        //public int ClientId { get; set; }
       
    }
}

    
