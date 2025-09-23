
--this query to get appointment information and you can customize it to get more or less infomration in the future 



Select Appointments.AppointmentID,
Patient= P1.FirstName+' '+P1.LastName,
P1.Gendor,
P1.Phone,
P1.DateOfBirth,
Appointments.Note,
Doctor=P2.FirstName+' '+P2.LastName,
Appointments.AppointmentDate,
Appointments.Note,Status.Status
  from Appointments
left join
AppointmentStatus on Appointments.AppointmentID=AppointmentStatus.AppointmentID
left join
Status on Status.StatusID=AppointmentStatus.StatusID
left join
Patients on Patients.PatientID =Appointments.PatientID
left join 
Persons P1 on P1.PersonID=Patients.PersonID
left join
Employees
on Employees.EmployeeID=Appointments.EmployeeID
left join
Persons P2 on P2.PersonID=Employees.PersonID

