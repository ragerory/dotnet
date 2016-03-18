#region Using Directives

using Brandstagram.DataContracts;

#endregion

namespace Brandstagram.ServiceContracts.Responses
{
    public class CreateUserResponse
    {
        public User CreatedUser { get; set; }
    }
}
