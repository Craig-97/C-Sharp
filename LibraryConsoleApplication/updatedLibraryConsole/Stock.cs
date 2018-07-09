using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    [Serializable]
    public class Stock
    {
        private int libraryNum;
        private string title;
        private Member tmember = null;
        private DateTime returnDate;

        public int LibraryNum
        {
            get { return libraryNum; }
            set { libraryNum = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        public Member getMember
        {
            get { return tmember; }

            set { tmember = value;}
        }
        
        public Stock(int id, string strtitle)
        {
            tmember = new Member();
            LibraryNum = id;
            Title = strtitle;
        }

        public override string ToString()
        {
            string strout = LibraryNum + " " + Title;
            return strout;
        }
    }

    [Serializable]
    public class Journal : Stock
    {
        private int volume;

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public Journal(int vol, string strtitle, int id)
            : base(id, strtitle)
        {
            Volume = vol;
            Title = strtitle;
            LibraryNum = id;
        }

        public override string ToString()
        {
            string strout = LibraryNum + " " + Title + "\n" + Volume + "\n";
            return strout;
        }
    }

    [Serializable]
    public class Book : Stock
    {
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public Book(string strtitle, string strauthor, int intid)
            : base(intid, strtitle)
        {
            Title = strtitle;
            Author = strauthor;
            LibraryNum = intid;
        }

        public override string ToString()
        {
            string strout = LibraryNum + "  " + Title + " by " + Author + "\n";
            return strout;
        }
    }
}
