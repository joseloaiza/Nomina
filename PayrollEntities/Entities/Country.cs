namespace Payroll.Models.Entities
{
    using Payroll.Models.Common;
    public partial class Country : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }         
        public bool IsActive { get; set; } 
    }
}
