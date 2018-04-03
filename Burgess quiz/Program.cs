using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgess_quiz
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Header> HeaderList = new List<Header>();
            HeaderList.Add(new Header("249e1bd0-0b6c-4dce-8d72-e16f20b1b49c", 1));
            HeaderList.Add(new Header("ea9560cc-e38b-481e-9630-3ca03e5b46a2", 2));
            HeaderList.Add(new Header("afaf2070-8fb7-492d-b7c2-b2ca7ed80844", 3));
            List<LineItem> LineItemList = new List<LineItem>();
            LineItemList.Add(new LineItem(1, "2/21/2017 12:00:00 AM", "Item 1", 100));
            LineItemList.Add(new LineItem(2, "2/22/2017 12:00:00 AM", "Item 2", 200));
            LineItemList.Add(new LineItem(3, "2/23/2017 12:00:00 AM", "Item 3", 300));
            List<LineItem> LineItemList1 = new List<LineItem>();
            LineItemList.Add(new LineItem(1, "2/23/2017 12:00:00 AM", "Item 3", 300));
            LineItemList.Add(new LineItem(2, "2/24/2017 12:00:00 AM", "Item 4", 400));
            LineItemList.Add(new LineItem(3, "2/25/2017 12:00:00 AM", "Item 5", 500));
            List<LineItem> LineItemList2 = new List<LineItem>();
            LineItemList.Add(new LineItem(1, "2/22/2017 12:00:00 AM", "Item 2", 200));
            LineItemList.Add(new LineItem(2, "2/24/2017 12:00:00 AM", "Item 4", 400));
            Program p1 = new Program();
            p1.task();
        }

        public void task()
        {
            foreach (var x in HeaderList)
            {
                Console.WriteLine("*** Task 1: Print orders");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Header ID = " + x.p1);
                Console.WriteLine("Client ID = " + x.p2);
                foreach (var z in LineItemList)
                {
                    Console.WriteLine(z.p1 + " | " + z.p2 + " | " + z.p3 + " | " + z.p4 + " | ");
                }
                Console.WriteLine("--------------------------------------------------------------------");
            }


        }
    } 
}
