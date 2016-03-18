#region Using Directives

using Brandstagram.DataContracts;

using System.Collections.Generic;

#endregion

namespace Brandstagram.ServiceContracts.Responses
{
    public class GetImagesByUserResponse
    {
        public IEnumerable<Image> Images { get; set; } 
    }
}
