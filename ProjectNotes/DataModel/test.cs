using ProjectNotes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNotes.DataModel
{
    static class test
    {
        public static Item createModel()
        {
            Item a = new Item();
            a.Title = "asssss";
            a.ItemDetail = new ObservableCollection<Content>();

            for (int i = 0; i < 9; i++)
            {
                Content tmp = new Content()
                {
                    ContentDetail = "Content " + i
                };
                a.ItemDetail.Add(tmp);
            }
            return a;

        }
        
        
    }
}
