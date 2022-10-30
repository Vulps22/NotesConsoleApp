using System;

namespace Notes
{

    class NoteManager {

        private List<Note> notes;

        public NoteManager(){
            notes = new List<Note>();
        }

        public void list(){
            if(notes.Count == 0){
                Console.WriteLine("No Notes to show");
                return;
            }
            for (int i = 0; i < notes.Count(); i++)
            {
                Note note = notes.ElementAt(i);
                Console.WriteLine(" ");
                Console.WriteLine(i + ":   " + note.getTitle());
                Console.WriteLine("------");
                Console.WriteLine(" ");
                Console.WriteLine(note.getText());
                Console.WriteLine(" ");
                
            }
        }

        public void addNote(){
            Console.WriteLine("Title: ");
            string title = Console.ReadLine() ?? "";
            Console.WriteLine("Text: ");
            string text = Console.ReadLine() ?? "";
            this.notes.Add(new Note(title, text));
        }

        public void deleteNote(){
            Console.WriteLine(" ");
            for (int i = 0; i < notes.Count(); i++)
            {
                Note note = notes.ElementAt(i);
                Console.WriteLine(i + ": " + note.getTitle());
            }
            Console.WriteLine("Which note to delete?");
            string option = Console.ReadLine() ?? "-1";
            int index = int.Parse(option);
            if(index > -1 && index <= notes.Count()){
                notes.RemoveAt(index);
            }
        }
    }

}