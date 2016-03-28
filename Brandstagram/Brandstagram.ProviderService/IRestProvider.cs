#region Using Directives

using Brandstagram.ServiceContracts.Responses;

using System.ServiceModel;
using System.ServiceModel.Web;

#endregion

namespace Brandstagram.ProviderService
{
    [ServiceContract]
    public interface IRestProvider
    {
        #region Images

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, UriTemplate = "image/all")]
        GetAllImagesResponse GetAllImages();

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, UriTemplate = "image/user/{id}")]
        GetImagesByUserResponse GetImagesByUserId(string id);

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, UriTemplate = "image/tag/{tag}")]
        GetImagesByTagResponse GetImagesByTag(string tag);

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, UriTemplate = "image/{id}")]
        GetImageResponse GetImage(string id);

        #endregion

        #region Users

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, UriTemplate = "user/all")]
        GetAllUsersResponse GetAllUsers();

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, UriTemplate = "user/{userName}/{firstName}/{lastName}")]
        CreateUserResponse CreateUser(string userName, string firstName, string lastName);

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, UriTemplate = "user/delete/{id}")]
        DeleteUserResponse DeleteUser(string id);

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, UriTemplate = "user/update/{id}/{userName}/{firstName}/{lastName}")]
        UpdateUserResponse UpdateUser(string id, string userName, string firstName, string lastName);

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, UriTemplate = "user/{id}")]
        GetUserResponse GetUser(string id);

        #endregion
    }
}
