using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridViewCollectionOfObject.Models
{
    class Note
    {
        private string _noteText;
        private string _subject;
        private DateTime _creationDate;

        public string NoteText { get { return _noteText; } set { _noteText = value; } }

        public string Subject { get { return _subject; } set { _subject = value; } }

        public DateTime CreationDate { get { return _creationDate; } set { _creationDate = value; } }
    }
}
