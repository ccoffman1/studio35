using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studio35.Studio
{
    public class Comic
    {
        //public string title;  // if this was set to private string title then it couldn't be used in access stuff
        //public string Title  //<-- this is the verbose better way to do a getter / setter
        //                          this allows us to set exceptions in the get piece
        //{
        //    get { return this.title; }
        //    set { this.title = value; }
        //}

        // get rid of original public/private string title and do
        public string Title { get; set; }

        public string issue;
        public static List<string> grades = new List<string>() { "fine", "Poor", "mint" };
        // ^-- can also do this here as well as below.

        public Comic(string title, string issue) // this is the constructor
        {
            this.Title = title;
            this.issue = issue;
            
        }

        public string GetInfo()
        {
            return this.Title + " " + this.issue;
        }



    }

    

    //public string GetInfo() // when GetInfo() is called you get the title and issue.
    //{
    //    return this.title + " " + this.issue;  //in this instance "this" is optional
    //}

    

    public class AccessStuff
    {
        public Comic comic;

        // making a constructor
        public AccessStuff(Comic comic)
        {
            this.comic = comic;
        }
        
        public string GetInfo()
        {
            return this.comic.Title + " " + this.comic.issue;
        }
    }

    public class ComicCollection
    {
        private List<Comic> comics = null;

        public ComicCollection(List<Comic> comics)
        {
            this.comics = comics;
        }

        public static void DoThings()
        {
            var comics = new List<Comic>();
            comics.Add(new Comic("spider-man", "3"));
            var collection = new ComicCollection(comics);
        }
    }
    




}





// example of GetInfo()
// var text = comic.GetInfo();  <-- this will get that particular comic's get info.
//                                  the comic named "comic".
