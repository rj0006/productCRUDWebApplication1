//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductCRUDWebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CL_Flight_Schedule_Detail
    {
        public short FlightId { get; set; }
        public short TransitId { get; set; }
        public System.TimeSpan DepartureTime { get; set; }
        public System.TimeSpan ArrivalTime { get; set; }
        public short TransitDays { get; set; }
    
        public virtual CL_Flight_Schedule_Header CL_Flight_Schedule_Header { get; set; }
    }
}
