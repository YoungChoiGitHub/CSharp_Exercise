using System;


namespace StrucDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Name myName = new Name("Young", "Il", "Choi");
            Console.WriteLine("My name is {0}", myName.ToString());
            Console.WriteLine("My initial is {0}", myName.Initials());
        }
    }
    public struct Name
    {
        private string fname, mname, lname;

        public Name(string first, string middle, string last)
        {
            fname = first;
            mname = middle;
            lname = last;
        }

        public string FirstName
        {
            get { return fname; }    
            set { fname = FirstName; }
        }
        public string MiddleName
        {
            get { return mname; }
            set { mname = MiddleName; }
        }

        public string LastName
        {
            get { return lname; }
            set { lname = LastName; }
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", fname, mname, lname);
        }
        public string Initials()
        {
            return String.Format("{0}{1}{2}", 
                fname.Substring(0,1), mname.Substring(0,1), lname.Substring(0,1));
        }
    }
}