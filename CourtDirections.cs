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

        public CourtDirections() { 
            list_directions = new Dictionary<int, string>();} // default construtor
        
        public CourtDirections(ref CourtDirections rcourtDirections) {


            list_directions = rcourtDirections.list_directions
            
            ; } // Copy Constructor

        public void addDirection(int iDirNum, string direction) {; }

        public Dictionary<int,string> listDirections() { return null; }



        // private


        private Dictionary<int, string> list_directions;
    }
}
