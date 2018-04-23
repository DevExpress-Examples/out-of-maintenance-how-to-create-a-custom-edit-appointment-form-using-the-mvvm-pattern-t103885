#region #usings
using System;
using System.Collections.Generic;
using System.ComponentModel;
#endregion #usings

namespace MVVMSchedulerApplication.ViewModel
{
    #region #mybindinglist
    partial class MainViewModel
    {
        public BindingList<Doctor> Doctors { get; set; }
        public BindingList<HospitalAppointment> Appointments { get; set; }
        public MainViewModel() 
        {
            Doctors = new BindingList<Doctor>();
            Appointments = new BindingList<HospitalAppointment>();
            FillEmployees();
            FillTasks();
        }

        public class Doctor
        {
            public object Id { get; set; }
            public string Name { get; set; }
        }

        public class HospitalAppointment
        {
            public string PatientName { get; set; }
            public string Location { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public string InsuranceNumber { get; set; }
            public bool FirstVisit { get; set; }
            public object DoctorId { get; set; }
            public string Notes { get; set; }
        }
    }
    #endregion #mybindinglist
}
