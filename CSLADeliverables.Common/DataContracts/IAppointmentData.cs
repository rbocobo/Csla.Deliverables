using System;
namespace CSLADeliverables.Common.DataContracts
{
    public interface IAppointmentData
    {
        int Id { get; set; }
        int CustomerId { get; set; }
        int DesignerId { get; set; }
        int SpecialtyId { get; set; }
        DateTime DateTime { get; set; }
        decimal Fee { get; set; }
        decimal PartialFee { get; set; }
        int CancelWindow { get; set; }
        int Status { get; set; }
    }
}
