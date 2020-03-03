<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frrmMobiles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstNumbers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dlgBrowseFiles = New System.Windows.Forms.OpenFileDialog()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstNumbers
        '
        Me.lstNumbers.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstNumbers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstNumbers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstNumbers.GridLines = True
        Me.lstNumbers.HideSelection = False
        Me.lstNumbers.Location = New System.Drawing.Point(0, 0)
        Me.lstNumbers.Name = "lstNumbers"
        Me.lstNumbers.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstNumbers.Size = New System.Drawing.Size(936, 550)
        Me.lstNumbers.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstNumbers.TabIndex = 0
        Me.lstNumbers.UseCompatibleStateImageBehavior = False
        Me.lstNumbers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 421
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mobile Number"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 472
        '
        'dlgBrowseFiles
        '
        Me.dlgBrowseFiles.FileName = "OpenFileDialog1"
        '
        'btnLoad
        '
        Me.btnLoad.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLoad.Location = New System.Drawing.Point(0, 475)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(936, 75)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'frrmMobiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 550)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lstNumbers)
        Me.Name = "frrmMobiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mobiles"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstNumbers As ListView
    Friend WithEvents dlgBrowseFiles As OpenFileDialog
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnLoad As Button
End Class
