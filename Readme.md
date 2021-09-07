<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128656815/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T103885)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HospitalAppointmentForm.xaml](./CS/MVVMSchedulerApplication/HospitalAppointmentForm.xaml) (VB: [HospitalAppointmentForm.xaml](./VB/MVVMSchedulerApplication/HospitalAppointmentForm.xaml))
* [HospitalAppointmentForm.xaml.cs](./CS/MVVMSchedulerApplication/HospitalAppointmentForm.xaml.cs) (VB: [HospitalAppointmentForm.xaml.vb](./VB/MVVMSchedulerApplication/HospitalAppointmentForm.xaml.vb))
* [MainWindow.xaml](./CS/MVVMSchedulerApplication/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MVVMSchedulerApplication/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MVVMSchedulerApplication/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MVVMSchedulerApplication/MainWindow.xaml.vb))
* [MainViewModel.cs](./CS/MVVMSchedulerApplication/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/MVVMSchedulerApplication/ViewModel/MainViewModel.vb))
* [ModelHelper.cs](./CS/MVVMSchedulerApplication/ViewModel/ModelHelper.cs) (VB: [ModelHelper.vb](./VB/MVVMSchedulerApplication/ViewModel/ModelHelper.vb))
<!-- default file list end -->
# How to create a custom Edit Appointment form using the MVVM pattern


This example demonstrates how to substitute the standard <strong>Edit Appointment</strong> form with the custom one using the MVVM approach. The new technique is based on a service provided by a data template. This service allows displaying a form in a separate window. <br /><br />See also: <br /><a href="http://documentation.devexpress.com/#WPF/CustomDocument16994">How to: Create a Custom Edit Appointment Form Using the MVVM Pattern (step-by-step guide) </a><br /><br />


<h3>Description</h3>

<p>Starting with version 15.2, it is necessary to bind the "OK" button to the&nbsp;SaveAndCloseAppointmentCommand.<br>Using the old binding to the&nbsp;SaveAppointmentCommand only saves the changed appointment data, but doesn't close the form.</p>

<br/>


