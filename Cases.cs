using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corona
{
    class Cases
    {
   
        public int cases { get; set; }
       
        public int deaths { get; set; }
  
        public int recovered { get; set; }
       
        public long updated { get; set; }
        
        public int active { get; set; }
       
        public int affectedCountries { get; set; }
    }
}
