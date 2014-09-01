﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MadsKristensen.EditorExtensions
{
    class ExtensionInformation : IEquatable<ExtensionInformation>
    {
        public string Name { get; set; }
        public string Identifier { get; set; }
        [XmlIgnore]
        public Version Version { get; set; }

        public bool Equals(ExtensionInformation other)
        {
            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Name.Equals(other.Name) && Identifier.Equals(other.Identifier);
        }

        public override int GetHashCode()
        {
            var hashProductName = Name == null ? 0 : Name.GetHashCode();
            var hashIdentifier = Identifier.GetHashCode();
            return hashProductName ^ hashIdentifier;
        }
    }
}
