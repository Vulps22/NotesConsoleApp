using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Notes
{

    class NoteManager {

        private List<Note> notes;

        public NoteManager(){
            notes = new List<Note>();
            load();
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
                Console.WriteLine(i + ":   " + note.title);
                Console.WriteLine("------");
                Console.WriteLine(" ");
                Console.WriteLine(note.text);
                Console.WriteLine(" ");
                
            }
        }

        public void addNote(){
            Console.WriteLine("Title: ");
            string title = Console.ReadLine() ?? "";
            Console.WriteLine("Text: ");
            string text = Console.ReadLine() ?? "";
            this.notes.Add(new Note(title, text));
            save();
        }

        public void deleteNote(){
            Console.WriteLine(" ");
            for (int i = 0; i < notes.Count(); i++)
            {
                Note note = notes.ElementAt(i);
                Console.WriteLine(i + ": " + note.title);
            }
            Console.WriteLine("Which note to delete?");
            string option = Console.ReadLine() ?? "-1";
            int index = int.Parse(option);
            if(index > -1 && index <= notes.Count()){
                notes.RemoveAt(index);
            }

            save();
        }

        private void save(){
            string json = JsonSerializer.Serialize(notes.ToArray());
            File.WriteAllText(@"C:\Users\ajmca\OneDrive\Documents\notes.json", json) ;
        }

        private void load(){
        {
            string json = File.ReadAllText(@"C:\Users\ajmca\OneDrive\Documents\notes.json");

            notes = JsonSerializer.Deserialize<List<Note>>(json);
        }
        }
    }
}