namespace Entities.BusinessEntities
{
    using Entities.Enums;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="Flight" />.
    /// </summary>
    public class Flight : EntityBase
    {
        /// <summary>
        /// Gets or sets the AirlineName.
        /// </summary>
        public string AirlineName { get; set; }

        /// <summary>
        /// Gets or sets the FlightNumber.
        /// </summary>
        public string FlightNumber { get; set; }

        /// <summary>
        /// Gets or sets the Destination.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Gets or sets the ScheduledDepartureTime.
        /// </summary>
        public DateTime? ScheduledDepartureTime { get; set; }

        /// <summary>
        /// Gets or sets the EstimatedDepartureTime.
        /// </summary>
        public DateTime? EstimatedDepartureTime { get; set; }

        /// <summary>
        /// Gets or sets the ActualDepartureTime.
        /// </summary>
        public DateTime? ActualDepartureTime { get; set; }

        /// <summary>
        /// Gets or sets the FlightStatusEnum.
        /// </summary>
        public string FlightStatus { get; set; }

        [NotMapped]
        public FlightStatusEnum StatusEnum
        {
            get
            {
                return (FlightStatusEnum)Enum.Parse(typeof(FlightStatusEnum), FlightStatus);
            }
            set
            {
                FlightStatus = value.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the DepartureGate.
        /// </summary>
        public string DepartureGate { get; set; }
    }
}
