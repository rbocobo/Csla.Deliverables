using System;
namespace CSLADeliverables.Common.DataContracts
{
    public interface IDesignerData
    {
        int Id { get; set; }
        string Name { get; set; }
        bool IsFull { get; set; }
    }
}
