// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Store
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LocationsOperations.
    /// </summary>
    public static partial class LocationsOperationsExtensions
    {
            /// <summary>
            /// Gets subscription-level properties and limits for Data Lake Store specified
            /// by Resource location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The Resource location without whitespace.
            /// </param>
            public static CapabilityInformation GetCapability(this ILocationsOperations operations, string location)
            {
                return operations.GetCapabilityAsync(location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets subscription-level properties and limits for Data Lake Store specified
            /// by Resource location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The Resource location without whitespace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CapabilityInformation> GetCapabilityAsync(this ILocationsOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCapabilityWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
