#region Using Directives

using Brandstagram.DataContracts;

using System.Collections.Generic;

#endregion

namespace Brandstagram.ServiceContracts.Responses
{
    public class GetImagesByTagResponse
    {
        public IEnumerable<Image> Images { get; set; }
    }
}
