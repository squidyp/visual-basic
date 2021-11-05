<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.chkBlood = New System.Windows.Forms.CheckBox()
        Me.chkEval = New System.Windows.Forms.CheckBox()
        Me.chkJournals = New System.Windows.Forms.CheckBox()
        Me.grpBlood = New System.Windows.Forms.GroupBox()
        Me.radVitamin = New System.Windows.Forms.RadioButton()
        Me.radSugar = New System.Windows.Forms.RadioButton()
        Me.radAdvanced = New System.Windows.Forms.RadioButton()
        Me.radBasic = New System.Windows.Forms.RadioButton()
        Me.grpEvaluation = New System.Windows.Forms.GroupBox()
        Me.radGold = New System.Windows.Forms.RadioButton()
        Me.radSilver = New System.Windows.Forms.RadioButton()
        Me.radBronze = New System.Windows.Forms.RadioButton()
        Me.grpJournals = New System.Windows.Forms.GroupBox()
        Me.radActivity = New System.Windows.Forms.RadioButton()
        Me.radIntake = New System.Windows.Forms.RadioButton()
        Me.btnBill = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.grpBlood.SuspendLayout()
        Me.grpEvaluation.SuspendLayout()
        Me.grpJournals.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkBlood
        '
        Me.chkBlood.AutoSize = True
        Me.chkBlood.Location = New System.Drawing.Point(20, 157)
        Me.chkBlood.Name = "chkBlood"
        Me.chkBlood.Size = New System.Drawing.Size(150, 29)
        Me.chkBlood.TabIndex = 0
        Me.chkBlood.Text = "Blood work"
        Me.chkBlood.UseVisualStyleBackColor = True
        '
        'chkEval
        '
        Me.chkEval.AutoSize = True
        Me.chkEval.Location = New System.Drawing.Point(20, 442)
        Me.chkEval.Name = "chkEval"
        Me.chkEval.Size = New System.Drawing.Size(248, 29)
        Me.chkEval.TabIndex = 1
        Me.chkEval.Text = "Nutritional Evaluation"
        Me.chkEval.UseVisualStyleBackColor = True
        '
        'chkJournals
        '
        Me.chkJournals.AutoSize = True
        Me.chkJournals.Location = New System.Drawing.Point(20, 625)
        Me.chkJournals.Name = "chkJournals"
        Me.chkJournals.Size = New System.Drawing.Size(229, 29)
        Me.chkJournals.TabIndex = 2
        Me.chkJournals.Text = "Nutritional Journals"
        Me.chkJournals.UseVisualStyleBackColor = True
        '
        'grpBlood
        '
        Me.grpBlood.Controls.Add(Me.radVitamin)
        Me.grpBlood.Controls.Add(Me.radSugar)
        Me.grpBlood.Controls.Add(Me.radAdvanced)
        Me.grpBlood.Controls.Add(Me.radBasic)
        Me.grpBlood.Location = New System.Drawing.Point(331, 12)
        Me.grpBlood.Name = "grpBlood"
        Me.grpBlood.Size = New System.Drawing.Size(388, 346)
        Me.grpBlood.TabIndex = 3
        Me.grpBlood.TabStop = False
        Me.grpBlood.Text = "Types of Blood Work"
        '
        'radVitamin
        '
        Me.radVitamin.AutoSize = True
        Me.radVitamin.Location = New System.Drawing.Point(7, 233)
        Me.radVitamin.Name = "radVitamin"
        Me.radVitamin.Size = New System.Drawing.Size(336, 129)
        Me.radVitamin.TabIndex = 5
        Me.radVitamin.TabStop = True
        Me.radVitamin.Text = "Basic panel + advanced" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cholesterol testing + advanced" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sugar testing + vitamin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "absorption testing ($229.99)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.radVitamin.UseVisualStyleBackColor = True
        '
        'radSugar
        '
        Me.radSugar.AutoSize = True
        Me.radSugar.Location = New System.Drawing.Point(7, 145)
        Me.radSugar.Name = "radSugar"
        Me.radSugar.Size = New System.Drawing.Size(336, 79)
        Me.radSugar.TabIndex = 4
        Me.radSugar.TabStop = True
        Me.radSugar.Text = "Basic panel + advanced" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cholesterol testing + advanced" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sugar testing ($179.99)"
        Me.radSugar.UseVisualStyleBackColor = True
        '
        'radAdvanced
        '
        Me.radAdvanced.AutoSize = True
        Me.radAdvanced.Location = New System.Drawing.Point(7, 85)
        Me.radAdvanced.Name = "radAdvanced"
        Me.radAdvanced.Size = New System.Drawing.Size(316, 54)
        Me.radAdvanced.TabIndex = 1
        Me.radAdvanced.TabStop = True
        Me.radAdvanced.Text = "Basic panel + advanced" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cholesterol testing ($129.99)"
        Me.radAdvanced.UseVisualStyleBackColor = True
        '
        'radBasic
        '
        Me.radBasic.AutoSize = True
        Me.radBasic.Location = New System.Drawing.Point(7, 31)
        Me.radBasic.Name = "radBasic"
        Me.radBasic.Size = New System.Drawing.Size(241, 29)
        Me.radBasic.TabIndex = 0
        Me.radBasic.TabStop = True
        Me.radBasic.Text = "Basic panel ($79.99)"
        Me.radBasic.UseVisualStyleBackColor = True
        '
        'grpEvaluation
        '
        Me.grpEvaluation.Controls.Add(Me.radGold)
        Me.grpEvaluation.Controls.Add(Me.radSilver)
        Me.grpEvaluation.Controls.Add(Me.radBronze)
        Me.grpEvaluation.Location = New System.Drawing.Point(331, 393)
        Me.grpEvaluation.Name = "grpEvaluation"
        Me.grpEvaluation.Size = New System.Drawing.Size(388, 147)
        Me.grpEvaluation.TabIndex = 4
        Me.grpEvaluation.TabStop = False
        Me.grpEvaluation.Text = "Levels of Nutritional Evaluations"
        '
        'radGold
        '
        Me.radGold.AutoSize = True
        Me.radGold.Location = New System.Drawing.Point(7, 101)
        Me.radGold.Name = "radGold"
        Me.radGold.Size = New System.Drawing.Size(186, 29)
        Me.radGold.TabIndex = 2
        Me.radGold.TabStop = True
        Me.radGold.Text = "Gold ($399.99)"
        Me.radGold.UseVisualStyleBackColor = True
        '
        'radSilver
        '
        Me.radSilver.AutoSize = True
        Me.radSilver.Location = New System.Drawing.Point(7, 66)
        Me.radSilver.Name = "radSilver"
        Me.radSilver.Size = New System.Drawing.Size(195, 29)
        Me.radSilver.TabIndex = 1
        Me.radSilver.TabStop = True
        Me.radSilver.Text = "Silver ($299.99)"
        Me.radSilver.UseVisualStyleBackColor = True
        '
        'radBronze
        '
        Me.radBronze.AutoSize = True
        Me.radBronze.Location = New System.Drawing.Point(7, 31)
        Me.radBronze.Name = "radBronze"
        Me.radBronze.Size = New System.Drawing.Size(209, 29)
        Me.radBronze.TabIndex = 0
        Me.radBronze.TabStop = True
        Me.radBronze.Text = "Bronze ($199.99)"
        Me.radBronze.UseVisualStyleBackColor = True
        '
        'grpJournals
        '
        Me.grpJournals.Controls.Add(Me.radActivity)
        Me.grpJournals.Controls.Add(Me.radIntake)
        Me.grpJournals.Location = New System.Drawing.Point(338, 584)
        Me.grpJournals.Name = "grpJournals"
        Me.grpJournals.Size = New System.Drawing.Size(430, 121)
        Me.grpJournals.TabIndex = 5
        Me.grpJournals.TabStop = False
        Me.grpJournals.Text = "Types of Nutritional Journals"
        '
        'radActivity
        '
        Me.radActivity.AutoSize = True
        Me.radActivity.Location = New System.Drawing.Point(7, 67)
        Me.radActivity.Name = "radActivity"
        Me.radActivity.Size = New System.Drawing.Size(428, 29)
        Me.radActivity.TabIndex = 1
        Me.radActivity.TabStop = True
        Me.radActivity.Text = "Food intake and activity journal ($14.99)"
        Me.radActivity.UseVisualStyleBackColor = True
        '
        'radIntake
        '
        Me.radIntake.AutoSize = True
        Me.radIntake.Location = New System.Drawing.Point(7, 31)
        Me.radIntake.Name = "radIntake"
        Me.radIntake.Size = New System.Drawing.Size(301, 29)
        Me.radIntake.TabIndex = 0
        Me.radIntake.TabStop = True
        Me.radIntake.Text = "Food intake journal ($9.99)"
        Me.radIntake.UseVisualStyleBackColor = True
        '
        'btnBill
        '
        Me.btnBill.Location = New System.Drawing.Point(869, 524)
        Me.btnBill.Name = "btnBill"
        Me.btnBill.Size = New System.Drawing.Size(222, 57)
        Me.btnBill.TabIndex = 6
        Me.btnBill.Text = "Calculate Cost"
        Me.btnBill.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(991, 649)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 31)
        Me.txtTotal.TabIndex = 7
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(864, 652)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(116, 25)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "Total Cost:"
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 746)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnBill)
        Me.Controls.Add(Me.grpJournals)
        Me.Controls.Add(Me.grpEvaluation)
        Me.Controls.Add(Me.grpBlood)
        Me.Controls.Add(Me.chkJournals)
        Me.Controls.Add(Me.chkEval)
        Me.Controls.Add(Me.chkBlood)
        Me.Name = "frmReport"
        Me.Text = "Billing Report"
        Me.grpBlood.ResumeLayout(False)
        Me.grpBlood.PerformLayout()
        Me.grpEvaluation.ResumeLayout(False)
        Me.grpEvaluation.PerformLayout()
        Me.grpJournals.ResumeLayout(False)
        Me.grpJournals.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkBlood As CheckBox
    Friend WithEvents chkEval As CheckBox
    Friend WithEvents chkJournals As CheckBox
    Friend WithEvents grpBlood As GroupBox
    Friend WithEvents radVitamin As RadioButton
    Friend WithEvents radSugar As RadioButton
    Friend WithEvents radAdvanced As RadioButton
    Friend WithEvents radBasic As RadioButton
    Friend WithEvents grpEvaluation As GroupBox
    Friend WithEvents radGold As RadioButton
    Friend WithEvents radSilver As RadioButton
    Friend WithEvents radBronze As RadioButton
    Friend WithEvents grpJournals As GroupBox
    Friend WithEvents radActivity As RadioButton
    Friend WithEvents radIntake As RadioButton
    Friend WithEvents btnBill As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
End Class
