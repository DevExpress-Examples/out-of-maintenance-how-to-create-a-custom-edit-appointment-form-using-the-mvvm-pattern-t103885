# How to create a custom Edit Appointment form using the MVVM pattern


This example demonstrates how to substitute the standard <strong>Edit Appointment</strong> form with the custom one using the MVVM approach. The new technique is based on a service provided by a data template. This service allows displaying a form in a separate window. <br /><br />See also: <br /><a href="http://documentation.devexpress.com/#WPF/CustomDocument16994">How to: Create a Custom Edit Appointment Form Using the MVVM Pattern (step-by-step guide) </a><br /><br />


<h3>Description</h3>

<p>Starting with version 15.2, it is necessary to bind the "OK" button to the&nbsp;SaveAndCloseAppointmentCommand.<br>Using the old binding to the&nbsp;SaveAppointmentCommand only saves the changed appointment data, but doesn't close the form.</p>

<br/>


