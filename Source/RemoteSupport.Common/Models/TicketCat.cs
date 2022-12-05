// <copyright file="TicketCat.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.RemoteSupport.Common.Models
{
    /// <summary>
    /// Represents the current category of ticket.
    /// </summary>
    public enum TicketCat
    {
        /// <summary>
        /// Represents that ticket needs to be addressed on Problem priority.
        /// </summary>
        Problem = 0,

        /// <summary>
        /// Represents that ticket needs to be addressed on Enquiry priority.
        /// </summary>
        Enquiry = 1,

        /// <summary>
        /// Represents that ticket needs to be addressed on Request priority.
        /// </summary>
        Request = 2,
    }
}