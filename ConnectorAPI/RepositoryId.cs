// Ignore Spelling: Github

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories
{
    using System;

    /// <summary>
    /// Class that represents a full repository id.
    /// </summary>
    [Serializable]
    public class RepositoryId
    {
        /// <summary>
        /// Instantiate a new instance of the <see cref="RepositoryId"/> class.
        /// </summary>
        /// <param name="owner">The owner of the repository.</param>
        /// <param name="name">The name of the repository.</param>
        public RepositoryId(string owner, string name)
        {
            Owner = owner;
            Name = name;
        }


        /// <summary>
        /// The owner of the repository
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// The name of the repository
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the fullname of the repository.
        /// </summary>
        public string FullName => $"{Owner}/{Name}";
    }
}
