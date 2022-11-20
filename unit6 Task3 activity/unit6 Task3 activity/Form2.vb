
Public Class Customer_Bookings_Form

    'project by hanoz daruwalla


    'temporary variables
    Dim Double1 As Double = 0.00
    Dim Int1 As String = ""
    Dim String1 As String = ""
    Dim Temp_Convert As String = ""
    Dim Center_Output As Double = 0.00
    Dim Only_Check_Activities As Boolean = True


    Public Sub Reset() 'reset outputs

        Booking_Code_Output.Text = "."
        Cost_Output.Text = "£0.00"
        Price_activities_output.Text = "£0.00"
        MsgBox("Booking Code Removed till all data added.")

    End Sub
    Public Function Parse_To_String_Function(Double1) 'convert double to string

        Try
            Convert.ToString(Double1)
            String1 = Double1

        Catch ex As System.FormatException

            MsgBox("Parse String Error")
        End Try

        Return String1

    End Function

    Public Function Parse_To_Int_Function(Str1) 'convert string to int

        Try
            Convert.ToInt32(Str1)
            Int1 = Str1

        Catch ex As System.FormatException
            MsgBox("Parse int Error")
        End Try

        Return Int1

    End Function


    Public Sub Booking_Code_Generator() 'generate random code

        Dim Gen_Pool As String = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"

        Dim Counter As Integer = 0

        Booking_Code_Output.Text = "."

        Dim Generator As New Random

        Dim Value As String = ""

        While Counter < Int(7) '<7 chars

            Value = Generator.Next(0, Gen_Pool.Length)

            Counter = Counter + 1

            Booking_Code_Output.Text = Booking_Code_Output.Text & Gen_Pool(Value)

        End While
    End Sub


    Public Sub Reduce_Spin() 'reset if too young
        MsgBox("!! User is too young for Tree Top Adventure !!")
        Tta_Spin.Value = 0

    End Sub

    Public Sub all_Chosen()


        If Tta_Spin.Value = 0 And Fs_Spin.Value = 0 And Zw_Spin.Value = 0 And Ts_Spin.Value = 0 Then 'if no activities chosen
            MsgBox("No Activities Chosen")
            Reset()

        ElseIf Gp_Button.Checked = False And Barnet_Button.Checked = False And Southgate_Button.Checked = False Then 'if no center chosen
            MsgBox("Dont forget to choose what centre you would like to attend")
            Reset()

        Else
            If Only_Check_Activities = False Then 'if all data added
                MsgBox("All data has been included, the booking code will now be generated")
            Else
                MsgBox("All data has been included, Cost for Activities added.")
            End If
            Booking_Code_Generator()

        End If
    End Sub


    Public Sub Centre_Select()
        'prices
        Dim Gp_Price As Double = 250.0
        Dim Barnet_Price As Double = 350.0
        Dim Southgate_Price As Double = 275.0


        If Gp_Button.Checked Then 'sets price of center to the location (variables above)
            Center_Output = Gp_Price

        ElseIf Barnet_Button.Checked Then
            Center_Output = Barnet_Price

        ElseIf Southgate_Button.Checked Then
            Center_Output = Southgate_Price

        Else
            MsgBox("No Center Added.")
            Reset()


        End If
        'output
        Price_Centre_Output_label.Text = Center_Output
        Price_Centre_Output_label.Text = Format(Center_Output, "c")

        Center_Output = Format(Center_Output, "c")
        Price_Centre_Output_label.Text = Center_Output.ToString("£,###,###.00")

    End Sub



    Public Sub Final_Costs(Activity_Cost) 'These are all validation checks
        Dim Activities_Output As Double = 0.00

        Dim Cost_Before_discount As Double = 0.00
        Dim Amount_Discounted_Cost As Double = 0.00
        Dim Final_Cost As Double = 0.00
        Dim Age_For_Discount As Integer = 18

        Dim Customer_Age As Integer = 0

        Activities_Output = Activity_Cost

        Activities_Output = Activities_Output

        Cost_Before_discount = Activities_Output + Center_Output

        If Age_Textbox_Booking.Text <> "" Then 'If Age_For_Discount isnt blank convert to int
            Temp_Convert = Age_Textbox_Booking.Text
            Parse_To_Int_Function(Temp_Convert)
            Customer_Age = Int1
        End If

        Dim Customer_Name As String = Name_Textbox_Booking.Text

        Dim Old_enough_Tta As String = "No"

        If Customer_Age = Nothing Then 'NOTHING = NULL
            MsgBox("Please enter your age")

        ElseIf Customer_Age < 18 Or Customer_Age = 18 Then '10% DISCOUNT IF 18 OR YOUNGER 

            Amount_Discounted_Cost = (Cost_Before_discount / 100) * 10
            Final_Cost = Cost_Before_discount - Amount_Discounted_Cost
            Discount_Output.Text = "10%"

        ElseIf Customer_Age > 18 Then
            Final_Cost = Cost_Before_discount
            Discount_Output.Text = "No Discount"
        End If

        If Customer_Name = "" Then
            MsgBox("Please enter your name")
            Final_Cost = Cost_Before_discount

        End If

        If Price_activities_output.Text = "£0.00" Then
            MsgBox("You need to choose atleast 1 type of activity to go on, dont forget to check the price for your activities also.")
        End If


        Final_Cost = Format(Final_Cost, "c")
        Cost_Output.Text = Final_Cost.ToString("£,###,###.00")


    End Sub

    Public Sub addition_of_activities() 'setting + adding costs
        Dim Tta_Default_Price As Double = 32.0
        Dim Tta_Price As Double = 0.00
        Dim Tta_Qty As Integer = 0
        Dim Tta_Total_Price As Double = 0.00

        Dim Fs_Default_Price As Double = 35.0
        Dim Fs_Price As Double = 0.00
        Dim Fs_Qty As Integer = 0
        Dim Fs_Total_Price As Double = 0.00

        Dim Zw_Default_Price As Double = 17.0
        Dim Zw_Price As Double = 0.00
        Dim Zw_Qty As Integer = 0
        Dim Zw_Total_Price As Double = 0.00

        Dim Ts_Default_Price As Double = 12.5
        Dim Ts_Price As Double = 0.00
        Dim Ts_Qty As Integer = 0
        Dim Ts_Total_Price As Double = 0.00

        Dim Total_Activity_Price As Decimal = 0.00

        Total_Activity_Price += Center_Output
        If Tta_Spin.Value = 1 Then 'if tree top adventure activity chosen set qty @ price if not set to 0.00
            If_Old_Enough()
            Tta_Qty = Tta_Spin.Value
            Tta_Price = Tta_Default_Price
        Else
            Tta_Qty = Tta_Spin.Value
            Tta_Price = 0.00
        End If
        Tta_Total_Price = Tta_Price * Tta_Qty 'calculation


        If Fs_Spin.Value = 1 Then 'if Forest Segway activity chosen set qty @ price if not set to 0.00
            Fs_Qty = Fs_Spin.Value
            Fs_Price = Fs_Default_Price

        Else
            Fs_Qty = Fs_Spin.Value
            Fs_Price = 0.00
        End If
        Fs_Total_Price = Fs_Price * Fs_Qty 'calculation


        If Zw_Spin.Value = 1 Then 'if Zip Wiring activity chosen set qty @ price if not set to 0.00
            Zw_Qty = Zw_Spin.Value
            Zw_Price = Zw_Default_Price

        Else
            Zw_Qty = Zw_Spin.Value
            Zw_Price = 0.00
        End If
        Zw_Total_Price = Zw_Price * Zw_Qty 'calculation



        If Ts_Spin.Value = 1 Then 'if tarzan swing activity chosen set qty @ price if not set to 0.00
            Ts_Qty = Ts_Spin.Value
            Ts_Price = Ts_Default_Price

        Else
            Ts_Qty = Ts_Spin.Value
            Ts_Price = 0.00
        End If
        Ts_Total_Price = Ts_Price * Ts_Qty 'calculations


        Total_Activity_Price = Tta_Total_Price + Fs_Total_Price + Zw_Total_Price + Ts_Total_Price
        Parse_To_String_Function(Total_Activity_Price)

        Total_Activity_Price = Format(Total_Activity_Price, "c")
        Price_activities_output.Text = Total_Activity_Price.ToString("£,###,###.00")

        If Only_Check_Activities = False Then
            Final_Costs(Total_Activity_Price)
        End If

    End Sub

    Public Sub If_Old_Enough() 'check if user old enough

        Dim Age_restriction_Tta As String = 17
        Dim Customer_Age As String = Age_Textbox_Booking.Text

        Dim Old_enough_Tta As String = "No"

        If Name_Textbox_Booking.Text = "" Then 'chekc name entered

            MsgBox("!! No Name Has Been Entered !!")

        End If

        If Customer_Age < Age_restriction_Tta Then 'if too young

            Dim Old_Enough As String = "No"
            Reduce_Spin()

        ElseIf Customer_Age > Age_restriction_Tta Or Customer_Age = Age_restriction_Tta Then 'if old enough
            Dim Old_Enough As String = "Yes"
            MsgBox("User is above age recommendation.")
        Else
            MsgBox("Please make a booking")
        End If





    End Sub

    Public Sub First_Age_discount()


        addition_of_activities()


    End Sub




    Private Sub Tta_Spin_ValueChanged(sender As Object, e As EventArgs) Handles Tta_Spin.ValueChanged

    End Sub



    Private Sub Price_Centre_Output_label_Click(sender As Object, e As EventArgs) Handles Price_Centre_Output_label.Click

    End Sub

    Private Sub Gp_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Gp_Button.CheckedChanged

        Centre_Select()

    End Sub

    Private Sub Barnet_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Barnet_Button.CheckedChanged

        Centre_Select()

    End Sub

    Private Sub Southgate_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Southgate_Button.CheckedChanged

        Centre_Select()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Price_activities_output.Click

    End Sub

    Private Sub Age_Textbox_Booking_TextChanged(sender As Object, e As EventArgs) Handles Age_Textbox_Booking.TextChanged

    End Sub

    Private Sub Name_Textbox_Booking_TextChanged(sender As Object, e As EventArgs) Handles Name_Textbox_Booking.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Booking_code_button.Click
        Only_Check_Activities = False

        If_Old_Enough()
        Centre_Select()
        addition_of_activities()

        Booking_Code_Generator()
        all_Chosen()

    End Sub

    Private Sub Fs_Spin_ValueChanged(sender As Object, e As EventArgs) Handles Fs_Spin.ValueChanged



    End Sub

    Private Sub Zw_Spin_ValueChanged(sender As Object, e As EventArgs) Handles Zw_Spin.ValueChanged



    End Sub

    Private Sub Ts_Spin_ValueChanged(sender As Object, e As EventArgs) Handles Ts_Spin.ValueChanged



    End Sub

    Private Sub Gp_Label_Price_Click(sender As Object, e As EventArgs) Handles Gp_Label_Price.Click

    End Sub

    Private Sub Cost_Output_Click(sender As Object, e As EventArgs) Handles Cost_Output.Click

    End Sub

    Private Sub Discount_Output_Click(sender As Object, e As EventArgs) Handles Discount_Output.Click



    End Sub

    Private Sub Name_Age_Button_Click(sender As Object, e As EventArgs) Handles Name_Age_Button.Click
        If_Old_Enough()
    End Sub

    Private Sub Book_Activities_Button_Click(sender As Object, e As EventArgs) Handles Book_Activities_Button.Click
        Only_Check_Activities = True
        addition_of_activities()
        all_Chosen()
    End Sub

    Private Sub FlowLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles Dark_green_background_1.Paint

    End Sub
End Class