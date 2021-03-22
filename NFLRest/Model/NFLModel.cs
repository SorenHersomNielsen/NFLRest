using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFLRest.Model
{
    public class NFLModel
    {
        public NFLModel(int id,string name, string initials)
        {

            CheckInitials(initials);
            Name = name;
            Initials = initials;
            Id = id;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string initials;

        public string Initials
        {
            get { return initials; }
            set {initials = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        private static void CheckInitials(string initials)
        {
            if (initials.Length < 2 || initials.Length > 3)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

    }
}
