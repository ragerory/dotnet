#region Using Directives

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace Brandstagram.DataContracts
{
    [DataContract]
    public class Image
    {
        [DataMember]
        public int ImageId { get; set; }

        [DataMember]
        public string ImageName { get; set; }

        [DataMember]
        public User ImageAuthor { get; set; } 

        [DataMember]
        public IEnumerable<string> Tags { get; set; }
    }
}
