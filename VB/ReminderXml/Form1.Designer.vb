Namespace ReminderXml
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.btnLoad = New DevExpress.XtraEditors.SimpleButton()
            Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
            Me.reminderEdit = New DevExpress.XtraEditors.MemoEdit()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            DirectCast(Me.reminderEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 136)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(784, 425)
            Me.schedulerControl1.Start = New Date(2014, 9, 16, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Controls.Add(Me.btnLoad)
            Me.panelControl1.Controls.Add(Me.btnSave)
            Me.panelControl1.Controls.Add(Me.reminderEdit)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(784, 136)
            Me.panelControl1.TabIndex = 1
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Appearance.BackColor = System.Drawing.SystemColors.Info
            Me.labelControl1.LineVisible = True
            Me.labelControl1.Location = New System.Drawing.Point(13, 6)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(239, 13)
            Me.labelControl1.TabIndex = 3
            Me.labelControl1.Text = "Select an appointment and click the button below."
            ' 
            ' btnLoad
            ' 
            Me.btnLoad.Location = New System.Drawing.Point(13, 89)
            Me.btnLoad.Name = "btnLoad"
            Me.btnLoad.Size = New System.Drawing.Size(113, 23)
            Me.btnLoad.TabIndex = 1
            Me.btnLoad.Text = "Text -> Reminders"
            ' 
            ' btnSave
            ' 
            Me.btnSave.Location = New System.Drawing.Point(12, 28)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(113, 23)
            Me.btnSave.TabIndex = 0
            Me.btnSave.Text = "Reminders -> Text"
            ' 
            ' reminderEdit
            ' 
            Me.reminderEdit.Location = New System.Drawing.Point(144, 26)
            Me.reminderEdit.Name = "reminderEdit"
            Me.reminderEdit.Size = New System.Drawing.Size(628, 86)
            Me.reminderEdit.TabIndex = 2
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            DirectCast(Me.reminderEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents btnLoad As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
        Private reminderEdit As DevExpress.XtraEditors.MemoEdit
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace

