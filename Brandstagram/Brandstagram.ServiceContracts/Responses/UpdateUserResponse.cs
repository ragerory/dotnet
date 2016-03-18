#region Using Directives

using Brandstagram.DataContracts;

#endregion

namespace Brandstagram.ServiceContracts.Responses
{
    public class UpdateUserResponse
    {
        public User UpdatedUser { get; set; }
    }
}
