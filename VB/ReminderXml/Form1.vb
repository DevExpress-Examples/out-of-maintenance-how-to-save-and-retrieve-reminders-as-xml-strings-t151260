Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Xml
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace ReminderXml
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            schedulerControl1.DayView.DayCount = 3
            schedulerControl1.DayView.ShowWorkTimeOnly = True

            Dim apt As Appointment = Me.schedulerStorage1.CreateAppointment(AppointmentType.Normal, Date.Now, Date.Now.AddHours(1), "Reminder Test")
            Dim aptreminder As Reminder = apt.CreateNewReminder()
            apt.Reminders.Add(aptreminder)

            schedulerControl1.Storage.Appointments.Add(apt)
        End Sub

        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
            If schedulerControl1.SelectedAppointments.Count = 0 Then
                Return
            End If
'            #Region "#remindertoxml"
            Dim apt As Appointment = schedulerControl1.SelectedAppointments(0)
            Dim myHelper As ReminderCollectionXmlPersistenceHelper = ReminderCollectionXmlPersistenceHelper.CreateSaveInstance(apt)
            Dim reminderInfo As String = myHelper.ToXml()
'            #End Region ' #remindertoxml
            reminderEdit.Text = reminderInfo
        End Sub

        Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
            If (schedulerControl1.SelectedAppointments.Count = 0) OrElse reminderEdit.Text = "" Then
                Return
            End If
'            #Region "#xmltoreminder"
            Dim apt As Appointment = schedulerControl1.SelectedAppointments(0)
            apt.Reminders.AddRange(ReminderCollectionXmlPersistenceHelper.ObjectFromXml(apt, reminderEdit.Text))
'            #End Region ' #xmltoreminder
        End Sub
    End Class
End Namespace
