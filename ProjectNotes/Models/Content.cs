using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Note >> NoteItem >> Item >> Content
/// </summary>


namespace ProjectNotes.Models
{
    class Content
    {
        private string _ContentDetail;
        public string ContentDetail
        {
            get
            {
                return _ContentDetail;
            }
            set
            {
                _ContentDetail = value.ToString();
            }
        }
    }
}
