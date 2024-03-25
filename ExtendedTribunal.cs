using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tribunal4;

namespace TribunalApp
{
    internal class ExtendedTribunal : Tribunal
    {
        public ExtendedTribunal() 
        { 
            bHealthElement = false;
            bSocialCareElement = false;
        }

        // needs copy constructor


        //

        private bool bHealthElement;
        private bool bSocialCareElement;
    }
}
