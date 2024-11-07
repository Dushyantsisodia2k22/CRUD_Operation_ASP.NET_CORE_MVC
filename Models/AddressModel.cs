using System.ComponentModel.DataAnnotations;

namespace MNJ_CRUD_OPERATION_FINAL.Models
{
    public class AddressModel
    {
        [Key]
        public long Id { get; set; }
        public required long  employeeId { get; set; }
        public required string HouseNumber { get; set; }
        public required string LocalityCity { get; set; }
        public required string State { get; set; }

        public required string pincode { get; set; }
        public required string PeriodOfStay { get; set; }
        public required string? Telephone { get; set; }
        public required string MobileNumber { get; set; }
        public required string EmailId { get; set; }
        public required string? InstantMessagingSystemID { get; set; }
    }
}
