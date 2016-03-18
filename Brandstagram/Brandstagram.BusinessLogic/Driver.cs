#region Using Directives

using Brandstagram.DataContracts;

using System.Collections.Generic;

#endregion

namespace Brandstagram.BusinessLogic
{
    public class Driver
    {
        #region Images

        /// <summary>
        /// Gets all images.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Image> GetAllImages()
        {
            return new List<Image>();
        }

        /// <summary>
        /// Gets the images by user identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public IEnumerable<Image> GetImagesByUserId(int id)
        {
            return new List<Image>();
        }

        /// <summary>
        /// Gets the images by tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <returns></returns>
        public IEnumerable<Image> GetImagesByTag(string tag)
        {
            return new List<Image>();
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Image GetImage(int id)
        {
            return new Image();
        }

        #endregion

        #region Users

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAllUsers()
        {
            return new List<User>();
        }

        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <returns></returns>
        public User CreateUser(string userName, string firstName, string lastName)
        {
            return new User();
        }

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public User DeleteUser(int id)
        {
            return new User();
        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="userName">Name of the user.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <returns></returns>
        public User UpdateUser(int id, string userName, string firstName, string lastName)
        {
            return new User();
        }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public User GetUser(int id)
        {
            return new User();
        }

        #endregion
    }
}
