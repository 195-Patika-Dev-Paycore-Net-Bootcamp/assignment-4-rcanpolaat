﻿using System;
namespace assignment_4_rcanpolaat.Models
{
    public class Container
    {
        public virtual long Id { get; set; }

        public virtual string ContainerName { get; set; }

        public virtual Double Latitude { get; set; }

        public virtual Double Longitude { get; set; }

        public virtual long VehicleId { get; set; }

    }

}
