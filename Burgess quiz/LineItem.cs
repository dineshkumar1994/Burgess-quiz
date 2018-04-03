using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgess_quiz
{
    class LineItem
    {
        public int p1 { get; set; }
        public string p2 { get; set; }
        public string p3 { get; set; }
        public int p4 { get; set; }

        public LineItem(int p1, string p2, string p3, int p4)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }

        public int LineID { get; set; }
        public string Date { get; set; }
        public string ItemId { get; set; }
        public int Quantity { get; set; }

    }
}
