   M S B A M L   `   `   `  ���� M  IXamarin.Forms.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI7clr-namespace:Xamarin.Forms;assembly=Xamarin.Forms.CoreXamarin.Forms   	ManagerUI   Scheduleator.AddShift   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     &localusing:XAMLTimePicker     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     :xctk)http://schemas.xceed.com/wpf/xaml/toolkit     Iforms7clr-namespace:Xamarin.Forms;assembly=Xamarin.Forms.Core     $	��340��$	��400��  � 
ResizeMode$  NoResize=� � Title$ Add a Shift�� � WindowStartupLocation$ CenterScreen=�.���  � RowDefinitions �� $	��67* ��� $	��47* ��� $	��47* ��� $	��47* ��� $	��47* ��� $	��47* � � ColumnDefinitions �� $
��Auto �$	��136���� $
��Auto �$	��135���� $
��Auto �$��13��.+��� -   $��lblCompanyProductName��$��10q�$��0��$��0��$��Scheduleator��$��22(�
����  ��� -   $
��Date��$��0��$��1��$��Date ��$��15(�(  "System.Windows.Controls.DatePicker  -   $��
datePicker��$��25��$��Center=�$��2,10,0,0q�$	��Top=�$��1��$��1��$	��119��   SelectedDate �� *	ShiftDate+�� -   $��	StartTime��$��0��$��2��$��StartTime(hh:mm)��$��15(�$
��Left=�$	��132���� -   $��SHour��$��2��$��1��$��23,10,164,10q��� -   $��Colon��$��1��$��2��$��:��$��25(�$��
0,0,145,44q�$��Right=�$��19��$��2���� -   $��SMinute��$��1��$��2��$��76,10,111,10q��� -   $��SAMPM��$��1��$��2��$��126,10,60,10q��� -	   $��EndTime��$��0��$��3��$��EndTime(hh:mm)��$��15(��� -
   $��EHour��$��3��$��23,10,164,10q� J� RenderTransformOrigin$ 0.152,0.586&�$��1���� -   $��eColon��$��1��$��3��$��:��$��25(�$��
0,0,145,43q�$��Right=�$��19��$��2���� -   $��EMinute��$��1��$��3��$��76,10,111,10q��� -   $��EAMPM��$��1��$��3��$��126,10,60,10q��� -   $��RequiredPeople��$��4��$��0��$��Required People��$��15(��� -   $��	NumPeople��$��1��$��4��$��10q�����  �� Path$ 	NumPeople��� -   $
��Save��$
��Save��$��5��$��50,10,69,10q�$��1���� -   $��Cancel��$��Cancel��$��5��$��
46,10,0,10q�$
��Left=�$��86��