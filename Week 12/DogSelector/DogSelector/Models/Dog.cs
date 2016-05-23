using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogSelector.Models
{
    public class Dog
    {
        // Dog properties
        public String BreedName { get; set; }
        public String DisplayName { get; set; }
        public EScale ActivityLevel { get; set; }
        public ELength Coatlength { get; set; }
        public EScale GroomingLevel { get; set; }
        public EScale IntelligenceLevel { get; set; }
        public EScale SheddingLevel { get; set; }
        public ESize Size { get; set; }
        public String ImageName { get; set; }
        public bool Drools { get; set; }
        public bool GoodWithChildren { get; set; }
    }
}