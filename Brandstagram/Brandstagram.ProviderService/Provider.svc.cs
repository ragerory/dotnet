#region Using Directives

using Brandstagram.ServiceContracts.Requests;
using Brandstagram.ServiceContracts.Responses;
using Brandstagram.BusinessLogic;

#endregion

namespace Brandstagram.ProviderService
{
    public class Provider : IProvider, IRestProvider
    {
        #region Fields

        private readonly Driver _driver = new Driver();

        #endregion

        #region Images

        /// <summary>
        /// Gets all images.
        /// </summary>
        /// <returns></returns>
        public GetAllImagesResponse GetAllImages()
        {
            var result = new GetAllImagesResponse();
            var retVal = _driver.GetAllImages();

            result.Images = retVal;
            return result;
        }

        /// <summary>
        /// Gets the images by user identifier.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetImagesByUserResponse GetImagesByUserId(GetImagesByUserRequest request)
        {
            var result = new GetImagesByUserResponse();

            int id;

            if (!int.TryParse(request.UserId, out id)) return result;

            var retVal = _driver.GetImagesByUserId(id);
            result.Images = retVal;
            return result;
        }

        /// <summary>
        /// Gets the images by user identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public GetImagesByUserResponse GetImagesByUserId(string id)
        {
            var result = new GetImagesByUserResponse();

            int userId;

            if (!int.TryParse(id, out userId)) return result;

            var retVal = _driver.GetImagesByUserId(userId);
            result.Images = retVal;
            return result;
        }

        /// <summary>
        /// Gets the images by tag.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetImagesByTagResponse GetImagesByTag(GetImagesByTagRequest request)
        {
            var result = new GetImagesByTagResponse();
            var retVal = _driver.GetImagesByTag(request.Tag);

            result.Images = retVal;
            return result;
        }

        /// <summary>
        /// Gets the images by tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <returns></returns>
        public GetImagesByTagResponse GetImagesByTag(string tag)
        {
            var result = new GetImagesByTagResponse();
            var retVal = _driver.GetImagesByTag(tag);

            result.Images = retVal;
            return result;
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetImageResponse GetImage(GetImageRequest request)
        {
            var result = new GetImageResponse();

            int id;
            if (!int.TryParse(request.ImageId, out id)) return result;

            var retVal = _driver.GetImage(id);
            result.Image = retVal;
            return result;
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public GetImageResponse GetImage(string id)
        {
            var result = new GetImageResponse();

            int imageId;
            if (!int.TryParse(id, out imageId)) return result;

            var retVal = _driver.GetImage(imageId);
            result.Image = retVal;
            return result;
        }

        #endregion

        #region Users

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns></returns>
        public GetAllUsersResponse GetAllUsers()
        {
            var result = new GetAllUsersResponse();
            var retVal = _driver.GetAllUsers();

            result.Users = retVal;
            return result;
        }

        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var result = new CreateUserResponse();
            var retVal = _driver.CreateUser(request.UserName, request.FirstName, request.LastName);

            result.CreatedUser = retVal;
            return result;
        }

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var result = new DeleteUserResponse();
            var retVal = _driver.DeleteUser(request.UserId);

            result.DeletedUser = retVal;
            return result;
        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var result = new UpdateUserResponse();
            var retVal = _driver.UpdateUser(request.UserId, request.UserName, request.FirstName, request.LastName);

            result.UpdatedUser = retVal;
            return result;
        }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetUserResponse GetUser(GetUserRequest request)
        {
            var result = new GetUserResponse();
            var retVal = _driver.GetUser(request.UserId);

            result.User = retVal;
            return result;
        }

        #endregion
    }
}
