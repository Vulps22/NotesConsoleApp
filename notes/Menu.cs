using System;

namespace Notes
{

    class Menu {

       
        private NoteManager manager;

        public Menu() {
            manager = new NoteManager();
        }

        public void show(){

            string option = "";

            while (option != "-1")
            {
                Console.WriteLine("Menu");
                Console.WriteLine("Choose a number to continue");
                Console.WriteLine("1: List Notes");
                Console.WriteLine("2: Create Note");
                Console.WriteLine("3: Delete Note");
                Console.WriteLine("-1: Exit");
                option = Console.ReadLine() ?? "";
                run(option);
            }
           

            
        }

        private void run(string option){
            switch (option)
            {
                case "1":
                    manager.list();
                    break;
                case "2":
                    manager.addNote();
                    break;
                case "3":
                    manager.deleteNote();
                    break;
                default:
                    return;
            }
        }
    }
}

