   M S B A M L   `   `   `  ����   	ManagerUI    Scheduleator.EditShift   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $	��600��$	��800��  � Title$  	EditShift�� � WindowStartupLocation$ CenterScreen=�.���  � RowDefinitions �� $	��61* ��� $	��46* ��� $	��77* ��� $	��63* ��� $	��58* ��� $	��62* ��� $	��57* ��� $	��80* � � ColumnDefinitions �� $
��Auto �$	��162���� $
��Auto �$	��241���� $
��Auto �$	��179���� $
��Auto �$	��479��.+��� -   $��lblCompanyProductName��$��10q�$��0��$��0��$��Scheduleator��$��22(�
����  ��� -   $��ShiftId��$��0��$��1��$	��Id:��$��25(�$��26,0,0,0q��� -   $��id��$��1��$��1��$��
28,10,33,0q����� *Id+�� -   $��	ShiftDate��$��0��$��2��$��Date:��$��25(�$��26,0,0,0q�(  "System.Windows.Controls.DatePicker  -   $
��Date��$��41��$��Center=�$��
28,10,34,0q�$	��Top=�$��1��$��2��$	��179��   SelectedDate �� *Date+�� -   $��	StartTime��$��0��$��3��$��
StartTime:��$��25(�$��26,0,0,0q��� -   $��	StartHour��$��1��$��3��$��28,10,164,22q��� -   $��Colon��$��1��$��3��$��:��$��20(�$��
0,10,139,5q�$��Right=�$��19�� J� RenderTransformOrigin$ -2.593,0.635&��� -	   $��StartMin��$��1��$��3��$��107,10,85,22q��� -
   $
��AMPM��$��1��$��3��$��182,10,10,22q��� -   $��EndTime��$��0��$��4��$��EndTime:��$��25(�$��26,0,0,0q��� -   $��EndHour��$��1��$��4��$��28,10,164,22q��� -   $��EColon��$��1��$��4��$��:��$��20(�$��
0,10,144,5q�$��Right=�$��19��$ -2.593,0.635&��� -   $��EndMin��$��1��$��4��$��107,10,85,22q��� -   $��EAMPM��$��1��$��4��$��182,10,10,22q��� -   $��	NumPeople��$��	Coverage:��$��5��$��0��$��26,0,0,0q�$��25(��� -   $��Coverage��$��1��$��5��$��28,10,33,10q����� *
Coverage+�� -   $
��Save��$��7��$��1��$
��Save��$��15(�$��
29,15,0,10q�$
��Left=�$	��177���� -   $��Discard��$��7��$��2��$��Discard��$��15(�$��0,16,0,9q�$��Right=�$	��155���� -   $��Deleteshift��$��0��$��7��$��Delete Shift��$��15(�$��26,16,10,10q��� -   $��	ListAvail��$��Available Employees��$��1��$��2��$��15(��� -   $��AvailableEmp��$��2��$��2��$��5������ *AvailableEmployee+���� .R��� 
�������.+�� .+��� ���� *
EmployeeID+� .+��� ���� *
UserName+�� -   $��ListWorking��$��Scheduled Employees��$��1��$��3��$��15(��� -   $��ScheduledEmp��$��3��$��2��$��5��$��	0,0,279,0q����� *WorkingEmployees+���� .R��� 
�������.+�� .+��� ���� *
EmployeeID+� .+��� ���� *
UserName+