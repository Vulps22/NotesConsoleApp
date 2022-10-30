using System;

namespace Notes
{
    class Note{
    
    private string title;
    private string text;
    

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

    public string getTitle(){
        return this.title;
    }

    public string getText(){
        return this.text;
    }

    public void setText(string text){
        this.text = text;
    }


    }

}