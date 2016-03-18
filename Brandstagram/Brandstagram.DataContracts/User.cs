#region Using Directives

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace Brandstagram.DataContracts
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public IEnumerable<Image> Images { get; set; }
    }
}
