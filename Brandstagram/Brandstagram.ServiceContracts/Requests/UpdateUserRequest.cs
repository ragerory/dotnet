namespace Brandstagram.ServiceContracts.Requests
{
    public class UpdateUserRequest
    {
        public int UserId { get; set; }

        public string UserName { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
