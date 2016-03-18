#region Using Directives

using Brandstagram.DataContracts;

using System.Collections.Generic;

#endregion

namespace Brandstagram.ServiceContracts.Responses
{
    public class GetAllUsersResponse
    {
        public IEnumerable<User> Users { get; set; } 
    }
}
