// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Reservations;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ReservationMergeProperties
    {
        /// <summary>
        /// Initializes a new instance of the ReservationMergeProperties class.
        /// </summary>
        public ReservationMergeProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReservationMergeProperties class.
        /// </summary>
        /// <param name="mergeDestination">Reservation Resource Id Created due
        /// to the merge. Format of the resource Id is
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</param>
        /// <param name="mergeSources">Resource Ids of the Source Reservation's
        /// merged to form this Reservation. Format of the resource Id is
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</param>
        public ReservationMergeProperties(string mergeDestination = default(string), IList<string> mergeSources = default(IList<string>))
        {
            MergeDestination = mergeDestination;
            MergeSources = mergeSources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reservation Resource Id Created due to the merge.
        /// Format of the resource Id is
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}
        /// </summary>
        [JsonProperty(PropertyName = "mergeDestination")]
        public string MergeDestination { get; set; }

        /// <summary>
        /// Gets or sets resource Ids of the Source Reservation's merged to
        /// form this Reservation. Format of the resource Id is
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}
        /// </summary>
        [JsonProperty(PropertyName = "mergeSources")]
        public IList<string> MergeSources { get; set; }

    }
}
