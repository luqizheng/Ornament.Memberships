﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Ornament.Entities;

namespace Ornament.Identity
{
    /// <summary>
    ///     Represents a role in the identity system
    /// </summary>
    /// <typeparam name="TKey">The type used for the primary key for the role.</typeparam>
    public class IdentityRole<TKey>
        : EntityWithTypedId<TKey>
        where TKey : IEquatable<TKey>


    {
        /// <summary>
        ///     Initializes a new instance of <see cref="IdentityRole{TKey}" />.
        /// </summary>
        public IdentityRole()
        {
        }

        /// <summary>
        ///     Initializes a new instance of <see cref="IdentityRole{TKey}" />.
        /// </summary>
        /// <param name="roleName">The role name.</param>
        public IdentityRole(string roleName) : this()
        {
            Name = roleName;
        }


        /// <summary>
        ///     Navigation property for claims in this role.
        /// </summary>
        public virtual ICollection<IdentityRoleClaim> Claims { get; } = new List<IdentityRoleClaim>();


        /// <summary>
        ///     Gets or sets the normalized name for this role.
        /// </summary>
        [Required]
        public virtual string Name { get; set; }

        /// <summary>
        ///     A random value that should change whenever a role is persisted to the store
        /// </summary>
        public virtual string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

        public virtual string Remark { get; set; }

        /// <summary>
        ///     Returns the name of the role.
        /// </summary>
        /// <returns>The name of the role.</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}