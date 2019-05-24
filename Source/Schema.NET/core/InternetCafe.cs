﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An internet cafe.
    /// </summary>
    public partial interface IInternetCafe : ILocalBusiness
    {
    }

    /// <summary>
    /// An internet cafe.
    /// </summary>
    [DataContract]
    public partial class InternetCafe : LocalBusiness, IInternetCafe
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InternetCafe";
    }
}
