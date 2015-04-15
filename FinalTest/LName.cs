using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public class LName
    {
        
        private string _lastName;
     


         public string  lastname{
            get
            {
                return this._lastName; // Read-Only
            }
        }
       

         public LName(string lastname)
        {
            //Assign values to instance variables
            this._lastName = lastname;
            
            
        }

        

    }
    }

