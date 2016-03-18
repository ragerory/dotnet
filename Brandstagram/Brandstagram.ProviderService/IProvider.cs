#region Using Directives

using Brandstagram.ServiceContracts.Requests;
using Brandstagram.ServiceContracts.Responses;

using System.ServiceModel;
using System.ServiceModel.Web;

#endregion

namespace Brandstagram.ProviderService
{
    [ServiceContract]
    public interface IProvider
    {
        #region Images

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, UriTemplate = "images")]
        GetAllImagesResponse GetAllImages();

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, UriTemplate = "imagesbyuserid/{id}")]
        GetImagesByUserResponse GetImagesByUserId(GetImagesByUserRequest request);

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, UriTemplate = "imagesbytag/{tag}")]
        GetImagesByTagResponse GetImagesByTag(GetImagesByTagRequest request);

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, UriTemplate = "image/{id}")]
        GetImageResponse GetImage(GetImageRequest request);

        #endregion
        
        #region Users

        [OperationContract]
        GetAllUsersResponse GetAllUsers();

        [OperationContract]
        CreateUserResponse CreateUser(CreateUserRequest request);

        [OperationContract]
        DeleteUserResponse DeleteUser(DeleteUserRequest request);

        [OperationContract]
        UpdateUserResponse UpdateUser(UpdateUserRequest request);

        [OperationContract]
        GetUserResponse GetUser(GetUserRequest request);

        #endregion
    }
}
