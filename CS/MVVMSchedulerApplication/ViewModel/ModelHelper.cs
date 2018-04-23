using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSchedulerApplication.ViewModel
{
    partial class MainViewModel
    {
        private void FillEmployees()
        {
            Doctors.Add(new Doctor() { Id = 1, Name = "Stomatologist" });
            Doctors.Add(new Doctor() { Id = 2, Name = "Ophthalmologist" });
            Doctors.Add(new Doctor() { Id = 3, Name = "Surgeon" });
        }

        private void FillTasks()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            Appointments.Add(new HospitalAppointment() { StartTime = DateTime.Now.Date.AddHours(10), EndTime = DateTime.Now.Date.AddHours(11), DoctorId = 1, Notes = "", Location = "101", PatientName = "Dave Murrel", InsuranceNumber = GenerateNineNumbers(rand), FirstVisit = true });
            Appointments.Add(new HospitalAppointment() { StartTime = DateTime.Now.Date.AddDays(2).AddHours(15), EndTime = DateTime.Now.Date.AddDays(2).AddHours(16), DoctorId = 1, Notes = "", Location = "101", PatientName = "Mike Roller", InsuranceNumber = GenerateNineNumbers(rand), FirstVisit = true });

            Appointments.Add(new HospitalAppointment() { StartTime = DateTime.Now.Date.AddDays(1).AddHours(11), EndTime = DateTime.Now.Date.AddDays(1).AddHours(12), DoctorId = 2, Notes = "", Location = "103", PatientName = "Bert Parkins", InsuranceNumber = GenerateNineNumbers(rand), FirstVisit = true });
            Appointments.Add(new HospitalAppointment() { StartTime = DateTime.Now.Date.AddDays(2).AddHours(10), EndTime = DateTime.Now.Date.AddDays(2).AddHours(12), DoctorId = 2, Notes = "", Location = "103", PatientName = "Carl Lucas", InsuranceNumber = GenerateNineNumbers(rand), FirstVisit = false });

            Appointments.Add(new HospitalAppointment() { StartTime = DateTime.Now.Date.AddHours(12), EndTime = DateTime.Now.Date.AddHours(13), DoctorId = 3, Notes = "Blood test results are required", Location = "104", PatientName = "Brad Barnes", InsuranceNumber = GenerateNineNumbers(rand), FirstVisit = false });
            Appointments.Add(new HospitalAppointment() { StartTime = DateTime.Now.Date.AddDays(1).AddHours(14), EndTime = DateTime.Now.Date.AddDays(1).AddHours(15), DoctorId = 3, Notes = "", Location = "104", PatientName = "Richard Fisher", InsuranceNumber = GenerateNineNumbers(rand), FirstVisit = true });
        }

        private string GenerateNineNumbers(Random rand)
        {
            string result = "";
            for (int i = 0; i < 9; i++)
            {
                result += rand.Next(9).ToString();
            }
            return result;
        }
    }
}
