namespace LeaveManagementWeb.Models
{
    public class LeaveAllocationEditVM : LeaveAllocaitonVM
    {
        public string EmployeeId { get; set; }

        public int leavaTypeId { get; set; }

        public EmployeeListVM? Employee { get; set; }
    }
}
