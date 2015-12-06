using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNotes.Models
{
    class Item
    {
        private ObservableCollection<Content> _ItemDetail;
        public ObservableCollection<Content> ItemDetail
        {
            get
            {
                return _ItemDetail;
            }
            set
            {
                _ItemDetail = value as ObservableCollection<Content>;
            }
        }

        private string _Title;
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value.ToString();
            }
        }

      
    }
}
