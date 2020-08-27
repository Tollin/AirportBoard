namespace Entities
{
    using System;

    /// <summary>
    /// Defines the <see cref="EntityBase" />.
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public virtual Int64 Id { get; set; }

        /// <summary>
        /// Gets or sets the CreatorId.
        /// </summary>
        public virtual string CreatorId { get; set; }

        /// <summary>
        /// Gets or sets the CreateTime.
        /// </summary>
        public virtual DateTime CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the UpdatorId.
        /// </summary>
        public virtual string UpdatorId { get; set; }

        /// <summary>
        /// Gets or sets the UpdateTime.
        /// </summary>
        public virtual DateTime UpdateTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsValid.
        /// </summary>
        public virtual bool IsValid { get; set; }
    }
}
