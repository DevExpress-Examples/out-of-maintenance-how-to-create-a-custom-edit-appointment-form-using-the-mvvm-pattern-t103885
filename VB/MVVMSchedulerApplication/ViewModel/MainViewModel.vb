Imports Microsoft.VisualBasic
#Region "#usings"
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
#End Region ' #usings

Namespace MVVMSchedulerApplication.ViewModel
	#Region "#mybindinglist"
	Partial Friend Class MainViewModel
		Private privateDoctors As BindingList(Of Doctor)
		Public Property Doctors() As BindingList(Of Doctor)
			Get
				Return privateDoctors
			End Get
			Set(ByVal value As BindingList(Of Doctor))
				privateDoctors = value
			End Set
		End Property
		Private privateAppointments As BindingList(Of HospitalAppointment)
		Public Property Appointments() As BindingList(Of HospitalAppointment)
			Get
				Return privateAppointments
			End Get
			Set(ByVal value As BindingList(Of HospitalAppointment))
				privateAppointments = value
			End Set
		End Property
		Public Sub New()
			Doctors = New BindingList(Of Doctor)()
			Appointments = New BindingList(Of HospitalAppointment)()
			FillEmployees()
			FillTasks()
		End Sub

		Public Class Doctor
			Private privateId As Object
			Public Property Id() As Object
				Get
					Return privateId
				End Get
				Set(ByVal value As Object)
					privateId = value
				End Set
			End Property
			Private privateName As String
			Public Property Name() As String
				Get
					Return privateName
				End Get
				Set(ByVal value As String)
					privateName = value
				End Set
			End Property
		End Class

		Public Class HospitalAppointment
			Private privatePatientName As String
			Public Property PatientName() As String
				Get
					Return privatePatientName
				End Get
				Set(ByVal value As String)
					privatePatientName = value
				End Set
			End Property
			Private privateLocation As String
			Public Property Location() As String
				Get
					Return privateLocation
				End Get
				Set(ByVal value As String)
					privateLocation = value
				End Set
			End Property
			Private privateStartTime As DateTime
			Public Property StartTime() As DateTime
				Get
					Return privateStartTime
				End Get
				Set(ByVal value As DateTime)
					privateStartTime = value
				End Set
			End Property
			Private privateEndTime As DateTime
			Public Property EndTime() As DateTime
				Get
					Return privateEndTime
				End Get
				Set(ByVal value As DateTime)
					privateEndTime = value
				End Set
			End Property
			Private privateInsuranceNumber As String
			Public Property InsuranceNumber() As String
				Get
					Return privateInsuranceNumber
				End Get
				Set(ByVal value As String)
					privateInsuranceNumber = value
				End Set
			End Property
			Private privateFirstVisit As Boolean
			Public Property FirstVisit() As Boolean
				Get
					Return privateFirstVisit
				End Get
				Set(ByVal value As Boolean)
					privateFirstVisit = value
				End Set
			End Property
			Private privateDoctorId As Object
			Public Property DoctorId() As Object
				Get
					Return privateDoctorId
				End Get
				Set(ByVal value As Object)
					privateDoctorId = value
				End Set
			End Property
			Private privateNotes As String
			Public Property Notes() As String
				Get
					Return privateNotes
				End Get
				Set(ByVal value As String)
					privateNotes = value
				End Set
			End Property
		End Class
	End Class
	#End Region ' #mybindinglist
End Namespace
