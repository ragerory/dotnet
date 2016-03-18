#region Using Directives

using Brandstagram.DataContracts;

#endregion

namespace Brandstagram.ServiceContracts.Responses
{
    public class DeleteUserResponse
    {
        public User DeletedUser { get; set; }
    }
}
