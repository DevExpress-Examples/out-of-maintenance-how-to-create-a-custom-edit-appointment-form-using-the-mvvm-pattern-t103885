Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace MVVMSchedulerApplication.ViewModel
    Partial Friend Class MainViewModel
        Private Sub FillEmployees()
            Doctors.Add(New Doctor() With {.Id = 1, .Name = "Stomatologist"})
            Doctors.Add(New Doctor() With {.Id = 2, .Name = "Ophthalmologist"})
            Doctors.Add(New Doctor() With {.Id = 3, .Name = "Surgeon"})
        End Sub

        Private Sub FillTasks()
            Dim rand As New Random(Date.Now.Millisecond)
            Appointments.Add(New HospitalAppointment() With {.StartTime = Date.Now.Date.AddHours(10), .EndTime = Date.Now.Date.AddHours(11), .DoctorId = 1, .Notes = "", .Location = "101", .PatientName = "Dave Murrel", .InsuranceNumber = GenerateNineNumbers(rand), .FirstVisit = True})
            Appointments.Add(New HospitalAppointment() With {.StartTime = Date.Now.Date.AddDays(2).AddHours(15), .EndTime = Date.Now.Date.AddDays(2).AddHours(16), .DoctorId = 1, .Notes = "", .Location = "101", .PatientName = "Mike Roller", .InsuranceNumber = GenerateNineNumbers(rand), .FirstVisit = True})

            Appointments.Add(New HospitalAppointment() With {.StartTime = Date.Now.Date.AddDays(1).AddHours(11), .EndTime = Date.Now.Date.AddDays(1).AddHours(12), .DoctorId = 2, .Notes = "", .Location = "103", .PatientName = "Bert Parkins", .InsuranceNumber = GenerateNineNumbers(rand), .FirstVisit = True})
            Appointments.Add(New HospitalAppointment() With {.StartTime = Date.Now.Date.AddDays(2).AddHours(10), .EndTime = Date.Now.Date.AddDays(2).AddHours(12), .DoctorId = 2, .Notes = "", .Location = "103", .PatientName = "Carl Lucas", .InsuranceNumber = GenerateNineNumbers(rand), .FirstVisit = False})

            Appointments.Add(New HospitalAppointment() With {.StartTime = Date.Now.Date.AddHours(12), .EndTime = Date.Now.Date.AddHours(13), .DoctorId = 3, .Notes = "Blood test results are required", .Location = "104", .PatientName = "Brad Barnes", .InsuranceNumber = GenerateNineNumbers(rand), .FirstVisit = False})
            Appointments.Add(New HospitalAppointment() With {.StartTime = Date.Now.Date.AddDays(1).AddHours(14), .EndTime = Date.Now.Date.AddDays(1).AddHours(15), .DoctorId = 3, .Notes = "", .Location = "104", .PatientName = "Richard Fisher", .InsuranceNumber = GenerateNineNumbers(rand), .FirstVisit = True})
        End Sub

        Private Function GenerateNineNumbers(ByVal rand As Random) As String
            Dim result As String = ""
            For i As Integer = 0 To 8
                result &= rand.Next(9).ToString()
            Next i
            Return result
        End Function
    End Class
End Namespace
