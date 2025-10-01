<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelSidebar = New Panel()
        Me.btnSettings = New Button()
        Me.btnPerformance = New Button()
        Me.btnSalesReports = New Button()
        Me.btnSystemLogs = New Button()
        Me.btnActivityLogs = New Button()
        Me.btnMovieMgmt = New Button()
        Me.btnTellerMgmt = New Button()
        Me.btnDashboard = New Button()
        Me.lblTitle = New Label()

        Me.PanelMain = New Panel()
        Me.lblPageTitle = New Label()

        Me.pnlActivityTotal = New Panel()
        Me.lblActivityHeader = New Label()
        Me.lblActivityCount = New Label()

        Me.pnlTicketSales = New Panel()
        Me.lblTicketHeader = New Label()
        Me.lblTicketCount = New Label()

        Me.pnlLoginEvents = New Panel()
        Me.lblLoginHeader = New Label()
        Me.lblLoginCount = New Label()

        Me.pnlSystemChanges = New Panel()
        Me.lblSystemHeader = New Label()
        Me.lblSystemCount = New Label()

        Me.pnlFilters = New Panel()
        Me.lblFilterTitle = New Label()
        Me.dtpFrom = New DateTimePicker()
        Me.dtpTo = New DateTimePicker()
        Me.cmbUser = New ComboBox()
        Me.cmbActionType = New ComboBox()
        Me.btnApplyFilter = New Button()
        Me.txtSearch = New TextBox()

        Me.dgvActivityLogs = New DataGridView()
        Me.colTimestamp = New DataGridViewTextBoxColumn()
        Me.colUser = New DataGridViewTextBoxColumn()
        Me.colAction = New DataGridViewTextBoxColumn()
        Me.colDetails = New DataGridViewTextBoxColumn()
        Me.colIP = New DataGridViewTextBoxColumn()
        Me.colStatus = New DataGridViewTextBoxColumn()

        CType(Me.dgvActivityLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' Sidebar
        Me.PanelSidebar.BackColor = Color.FromArgb(20, 20, 20)
        Me.PanelSidebar.Dock = DockStyle.Left
        Me.PanelSidebar.Size = New Size(200, 700)
        Me.PanelSidebar.Controls.AddRange(New Control() {
            Me.btnSettings, Me.btnPerformance, Me.btnSalesReports,
            Me.btnSystemLogs, Me.btnActivityLogs, Me.btnMovieMgmt,
            Me.btnTellerMgmt, Me.btnDashboard, Me.lblTitle
        })

        Me.lblTitle.Text = "CinemaAdmin"
        Me.lblTitle.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.Red
        Me.lblTitle.Dock = DockStyle.Top
        Me.lblTitle.Height = 60
        Me.lblTitle.TextAlign = ContentAlignment.MiddleCenter

        ' Sidebar Buttons
        Dim sidebarBtns() As Button = {
            Me.btnDashboard, Me.btnTellerMgmt, Me.btnMovieMgmt,
            Me.btnActivityLogs, Me.btnSystemLogs, Me.btnSalesReports,
            Me.btnPerformance, Me.btnSettings
        }

        For Each b In sidebarBtns
            b.Dock = DockStyle.Top
            b.Height = 40
            b.FlatStyle = FlatStyle.Flat
            b.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            b.ForeColor = Color.White
            b.BackColor = Color.FromArgb(45, 45, 45)
        Next

        Me.btnActivityLogs.BackColor = Color.Red
        Me.btnDashboard.Text = "Dashboard"
        Me.btnTellerMgmt.Text = "Teller Management"
        Me.btnMovieMgmt.Text = "Movie Management"
        Me.btnActivityLogs.Text = "Activity Logs"
        Me.btnSystemLogs.Text = "System Logs"
        Me.btnSalesReports.Text = "Sales Reports"
        Me.btnPerformance.Text = "Performance Reports"
        Me.btnSettings.Text = "Settings"

        ' Main Panel
        Me.PanelMain.BackColor = Color.FromArgb(40, 40, 40)
        Me.PanelMain.Dock = DockStyle.Fill
        Me.PanelMain.Location = New Point(200, 0)
        Me.PanelMain.Size = New Size(1000, 700)
        Me.PanelMain.Controls.AddRange(New Control() {
            Me.lblPageTitle, Me.pnlActivityTotal, Me.pnlTicketSales,
            Me.pnlLoginEvents, Me.pnlSystemChanges, Me.pnlFilters,
            Me.dgvActivityLogs
        })

        ' Page Title
        Me.lblPageTitle.Text = "Activity Logs"
        Me.lblPageTitle.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        Me.lblPageTitle.ForeColor = Color.Red
        Me.lblPageTitle.Location = New Point(20, 20)

        ' Metric Panels
        Dim metricPanels() As Panel = {
            Me.pnlActivityTotal, Me.pnlTicketSales,
            Me.pnlLoginEvents, Me.pnlSystemChanges
        }
        Dim metricHeaders() As Label = {
            Me.lblActivityHeader, Me.lblTicketHeader,
            Me.lblLoginHeader, Me.lblSystemHeader
        }
        Dim metricCounts() As Label = {
            Me.lblActivityCount, Me.lblTicketCount,
            Me.lblLoginCount, Me.lblSystemCount
        }
        Dim metricTitles() As String = {
            "Total Activities Today", "Ticket Sales",
            "Login Events", "System Changes"
        }
        Dim metricValues() As String = {
            "2,341", "156", "23", "8"
        }

        For i = 0 To 3
            metricPanels(i).BackColor = Color.FromArgb(60, 60, 60)
            metricPanels(i).Size = New Size(200, 80)
            metricPanels(i).Location = New Point(20 + i * 220, 60)
            metricPanels(i).BorderStyle = BorderStyle.FixedSingle

            metricHeaders(i).Text = "   " & metricTitles(i)
            metricHeaders(i).BackColor = Color.Red
            metricHeaders(i).Dock = DockStyle.Top
            metricHeaders(i).Height = 20
            metricHeaders(i).ForeColor = Color.White
            metricHeaders(i).Font = New Font("Segoe UI", 10, FontStyle.Bold)

            metricCounts(i).Text = metricValues(i)
            metricCounts(i).ForeColor = Color.White
            metricCounts(i).Font = New Font("Segoe UI", 10, FontStyle.Bold)
            metricCounts(i).Location = New Point(15, 35)

            metricPanels(i).Controls.Add(metricCounts(i))
            metricPanels(i).Controls.Add(metricHeaders(i))
        Next

        ' Filter Panel
        Me.pnlFilters.BackColor = Color.FromArgb(50, 50, 50)
        Me.pnlFilters.Size = New Size(950, 100)
        Me.pnlFilters.Location = New Point(20, 160)
        Me.pnlFilters.BorderStyle = BorderStyle.FixedSingle
        Me.pnlFilters.Controls.AddRange(New Control() {
            Me.lblFilterTitle, Me.dtpFrom, Me.dtpTo,
            Me.cmbUser, Me.cmbActionType, Me.btnApplyFilter, Me.txtSearch
        })

        Me.lblFilterTitle.Text = "Filter Activity Logs"
        Me.lblFilterTitle.ForeColor = Color.White
        Me.lblFilterTitle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.lblFilterTitle.Location = New Point(10, 10)

        Me.dtpFrom.Location = New Point(10, 40)
        Me.dtpTo.Location = New Point(170, 40)
        Me.cmbUser.Location = New Point(330, 40)
        Me.cmbActionType.Location = New Point(490, 40)
        Me.btnApplyFilter.Location = New Point(650, 40)
        Me.btnApplyFilter.Text = "Apply Filter"
        Me.btnApplyFilter.BackColor = Color.Green
        Me.btnApplyFilter.ForeColor = Color.White

        Me.txtSearch.Location = New Point(10, 70)
        Me.txtSearch.Size = New Size(930, 25)
        Me.txtSearch.Text = "Search activity logs..."

        ' DataGridView
        Me.dgvActivityLogs.BackgroundColor = Color.FromArgb(30, 30, 30)
        Me.dgvActivityLogs.Location = New Point(20, 270)
        Me.dgvActivityLogs.Size = New Size(950, 400)
        Me.dgvActivityLogs.ColumnHeadersDefaultCellStyle.BackColor = Color.Red
        Me.dgvActivityLogs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvActivityLogs.EnableHeadersVisualStyles = False
        Me.dgvActivityLogs.RowHeadersVisible = False
        Me.dgvActivityLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvActivityLogs.Columns.AddRange(New DataGridViewColumn() {
            Me.colTimestamp, Me.colUser, Me.colAction,
            Me.colDetails, Me.colIP, Me.colStatus
        })

        ' Column Definitions
        Me.colTimestamp.HeaderText = "Timestamp"
        Me.colTimestamp.Name = "colTimestamp"
        Me.colTimestamp.Width = 150

        Me.colUser.HeaderText = "User"
        Me.colUser.Name = "colUser"
        Me.colUser.Width = 120

        Me.colAction.HeaderText = "Action"
        Me.colAction.Name = "colAction"
        Me.colAction.Width = 120

        Me.colDetails.HeaderText = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Width = 250

        Me.colIP.HeaderText = "IP Address"
        Me.colIP.Name = "colIP"
        Me.colIP.Width = 120

        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 100

        ' Final Form Setup
        Me.AutoScaleDimensions = New SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(40, 40, 40)
        Me.ClientSize = New Size(1200, 700)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelSidebar)
        Me.Name = "Form2"
        Me.Text = "CinemaAdmin - Activity Logs"

        CType(Me.dgvActivityLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSidebar As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnTellerMgmt As Button
    Friend WithEvents btnMovieMgmt As Button
    Friend WithEvents btnActivityLogs As Button
    Friend WithEvents btnSystemLogs As Button
    Friend WithEvents btnSalesReports As Button
    Friend WithEvents btnPerformance As Button
    Friend WithEvents btnSettings As Button

    Friend WithEvents PanelMain As Panel
    Friend WithEvents lblPageTitle As Label

    Friend WithEvents pnlActivityTotal As Panel
    Friend WithEvents lblActivityHeader As Label
    Friend WithEvents lblActivityCount As Label

    Friend WithEvents pnlTicketSales As Panel
    Friend WithEvents lblTicketHeader As Label
    Friend WithEvents lblTicketCount As Label

    Friend WithEvents pnlLoginEvents As Panel
    Friend WithEvents lblLoginHeader As Label
    Friend WithEvents lblLoginCount As Label

    Friend WithEvents pnlSystemChanges As Panel
    Friend WithEvents lblSystemHeader As Label
    Friend WithEvents lblSystemCount As Label

    Friend WithEvents pnlFilters As Panel
    Friend WithEvents lblFilterTitle As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents cmbUser As ComboBox
    Friend WithEvents cmbActionType As ComboBox
    Friend WithEvents btnApplyFilter As Button
    Friend WithEvents txtSearch As TextBox

    Friend WithEvents dgvActivityLogs As DataGridView
    Friend WithEvents colTimestamp As DataGridViewTextBoxColumn
    Friend WithEvents colUser As DataGridViewTextBoxColumn
    Friend WithEvents colAction As DataGridViewTextBoxColumn
    Friend WithEvents colDetails As DataGridViewTextBoxColumn
    Friend WithEvents colIP As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
End Class