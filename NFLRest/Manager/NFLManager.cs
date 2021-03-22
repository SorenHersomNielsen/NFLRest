using NFLRest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFLRest.Manager
{
    public class NFLManager
    {
        private static int nextId = 1;

        public static readonly List<NFLModel> NFLList = new List<NFLModel>()
        {
            new NFLModel( nextId++, "New england", "NE"),
            new NFLModel(nextId++, "new york giants", "NYG")
        };

        public List<NFLModel> GetAll()
        {
            return new List<NFLModel>(NFLList);
        }

        public NFLModel Add(NFLModel NewNFLTeam)
        {
            NewNFLTeam.Id = nextId++;
            NFLList.Add(NewNFLTeam);
            return NewNFLTeam;
        }

        public NFLModel GetByID(int id)
        {
            return NFLList.Find(NFLList => NFLList.Id == id);
        }

        public NFLModel Update(int id, NFLModel update)
        {
            NFLModel Nfl = NFLList.Find(nfl1 => nfl1.Id == id);
            if (Nfl == null)
            {
                return null;
            }

            Nfl.Id = update.Id;
            Nfl.Initials = update.Initials;
            Nfl.Name = update.Name;
            return Nfl;
        }

        public NFLModel Delete(int id)
        {
            NFLModel nfl = NFLList.Find(nfl1 => nfl1.Id == id);
            if (nfl == null)
            {
                return null;
            }

            NFLList.Remove(nfl);
            return nfl;
        }

    }
}
