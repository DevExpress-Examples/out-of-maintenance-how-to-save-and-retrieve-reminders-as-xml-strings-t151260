using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            schedulerControl1.DayView.DayCount = 3;
            schedulerControl1.DayView.ShowWorkTimeOnly = true;
            
            Appointment apt = this.schedulerStorage1.CreateAppointment(AppointmentType.Normal, DateTime.Now, DateTime.Now.AddHours(1), "Reminder Test");
            Reminder aptreminder = apt.CreateNewReminder();
            apt.Reminders.Add(aptreminder);
            
            schedulerControl1.Storage.Appointments.Add(apt);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (schedulerControl1.SelectedAppointments.Count == 0) return;
            #region #remindertoxml
            Appointment apt = schedulerControl1.SelectedAppointments[0];
            ReminderCollectionXmlPersistenceHelper myHelper = ReminderCollectionXmlPersistenceHelper.CreateSaveInstance(apt);
            string reminderInfo = myHelper.ToXml();
            #endregion #remindertoxml
            reminderEdit.Text = reminderInfo;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if ((schedulerControl1.SelectedAppointments.Count == 0) || reminderEdit.Text == "") return;
            #region #xmltoreminder
            Appointment apt = schedulerControl1.SelectedAppointments[0];
            apt.Reminders.AddRange(ReminderCollectionXmlPersistenceHelper.ObjectFromXml(apt, reminderEdit.Text));
            #endregion #xmltoreminder
        }
    }
}
