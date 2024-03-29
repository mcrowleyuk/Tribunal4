using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tribunal4
{
    internal class CourtDirections
    {
        // public methods

        public CourtDirections() 
        {
            strTribunalref = "";
            list_directions = new Dictionary<int, string>();
        } // default construtor
        
        public CourtDirections(ref CourtDirections rcourtDirections) //copy Constructor
        {    
            list_directions = rcourtDirections.list_directions;
            
        } // Copy Constructor

        public void setTribunalRef(ref string rstrTribunalref) { strTribunalref = rstrTribunalref; }
        public void addDirection(int iDirNum, string direction) {; }

        public ref string getTribunalRef() { return ref strTribunalref; }

        public Dictionary<int,string> getDirections() { return list_directions; }

        // private

        string strTribunalref;
        private Dictionary<int, string> list_directions;
    }
}
