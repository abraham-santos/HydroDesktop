﻿using System.Collections.Generic;

namespace Search3.Settings
{
    public class ArrayOfOntologyPath : List<OntologyPath>
    {
    }

    public class OntologyPath
    {
        public int? ConceptID { get; set; }
        public string SearchableKeyword { get; set; }
        public string ConceptName { get; set; }
        public string ConceptPath { get; set; }
    }
}
