#Region "#usings"
Imports System.ComponentModel

#End Region  ' #usings
Namespace MVVMSchedulerApplication.ViewModel

#Region "#mybindinglist"
    Partial Class MainViewModel

        Public Property Doctors As BindingList(Of Doctor)

        Public Property Appointments As BindingList(Of HospitalAppointment)

        Public Sub New()
            Doctors = New BindingList(Of Doctor)()
            Appointments = New BindingList(Of HospitalAppointment)()
            FillEmployees()
            FillTasks()
        End Sub

        Public Class Doctor

            Public Property Id As Object

            Public Property Name As String
        End Class

        Public Class HospitalAppointment

            Public Property PatientName As String

            Public Property Location As String

            Public Property StartTime As Date

            Public Property EndTime As Date

            Public Property InsuranceNumber As String

            Public Property FirstVisit As Boolean

            Public Property DoctorId As Object

            Public Property Notes As String
        End Class
    End Class
#End Region  ' #mybindinglist
End Namespace
