using System.Text.Json.Serialization;

namespace Notes
{
    class Note{
    
        [JsonInclude]
        public string title;
        [JsonInclude]
        public string text;
        
        public Note(string title, string text){
            if(title == ""){
                while(title == " "){
                    Console.WriteLine("     You must enter a title: ");
                    title = Console.ReadLine() ?? " ";
                    return;
                }
            }else{
                this.title = title ?? " ";
                this.text = text ?? " ";
                return;
            }

            if(this.title == null || this.text == null) throw new NullReferenceException();

            this.title = "Error";
            this.text = "An Error has occured";

        }
    }
}