using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoralesAApuntes.Models;
    internal class Allnotes
    {
    public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();

    public Allnotes() =>
        LoadNotes();

    public void LoadNotes()
    {
        Notes.Clear();

        string appDataPath = FileSystem.AppDataDirectory;

        IEnumerable<Note> notes = Directory
            .EnumerateFiles(appDataPath, "*.notes.txt")
            .Select(filename => new Note()
            {
                Filename = filename,
                Text = File.ReadAllText(filename),
                Date = File.GetLastWriteTime(filename)
            })
            .OrderByDescending(note => note.Date);

        foreach (Note note in notes)
            Notes.Add(note);
    }
}
