using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalDisasters_API
{
    public class DataRecord
    {

        public string disasterNumber { get; set; }
        public string state { get; set; }
        public string incidentType { get; set; }

        public DateTime declarationDate { get; set; }



    }
}
