using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GridViewCollectionOfObject;
using GridViewCollectionOfObject.Models;

namespace GridViewCollectionOfObject.ViewModels
{
    class VMNote : Notifications
    {
        private ObservableCollection<Note> _noteList;

        public ObservableCollection<Note> NoteList
        {
            get { return _noteList; }
            set { _noteList = value; OnPropertyChanged("NoteList"); }
        }

        public VMNote()
        {
            NoteList = new ObservableCollection<Note>
            {
                new Note() {CreationDate = DateTime.Now, NoteText = "Remember to buy milk", Subject = "Reminder"},
                new Note() {CreationDate = DateTime.Now, NoteText = "Read about it on MSDN", Subject = "Learn XAML"},
                new Note() {CreationDate = DateTime.Now, NoteText = "Make exercise 1 to 5", Subject = "School assignments"},
                new Note() {CreationDate = DateTime.Now, NoteText = "Link: 'https://channel9.msdn.com/Series/Windows-10-development-for-absolute-beginners'", Subject = "Check out Tutorial on Channel9"},
                new Note() {CreationDate = DateTime.Now, NoteText = "Starts April 24th, http://hbowatch.com/silicon-valley-season-3-is-confirmed/", Subject = "Silicon Valley season 3"},
                new Note() {CreationDate = DateTime.Now, NoteText = "App for creating notes", Subject = "Innovative app idea"}
            };
        }

        private Note CreateNote(string subject, string noteText, DateTime dateTime)
        {
            Note newNote = new Note
            {
                Subject = subject,
                NoteText = noteText,
                CreationDate = dateTime
            };
            return newNote;
        }

    }
}
