   M S B A M L   `   `   `  ���� M  IXamarin.Forms.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI7clr-namespace:Xamarin.Forms;assembly=Xamarin.Forms.CoreXamarin.Forms   	ManagerUI   Scheduleator.ManageShifts   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     &localusing:XAMLTimePicker     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     :xctk)http://schemas.xceed.com/wpf/xaml/toolkit     Iforms7clr-namespace:Xamarin.Forms;assembly=Xamarin.Forms.Core     $	��340��$	��400��  � 
ResizeMode$  NoResize=� � Title$ Add a Shift�� � WindowStartupLocation$ CenterScreen=�.���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* ��� $
��Auto � � ColumnDefinitions �� $��* ��� $��* �.+��� -   $��lblCurrentUserName��$��0��$��1��$��5q�$
��Left=�$	��Top=�$��12(�����  �� Path$ NameOfCurrentUser� �� UpdateSourceTrigger$ PropertyChanged=��� -   $��lblDateOfShift��$��1��$��1��$��5q�$
��Left=�$	��Top=�$��12(����� $ DateOfShift�$ PropertyChanged=��� -   $��lblStartTimeOfShift��$��2��$��1��$��5q�$
��Left=�$	��Top=�$��12(����� $ StartTimeShift�$ PropertyChanged=��� -   $��lblEndTimeOfShift��$��3��$��1��$��5q�$
��Left=�$	��Top=�$��12(����� $ EndTimeShift�$ PropertyChanged=��� -   $��stkRadioButtons��$��4��$��1��.+�	� -   $��rdAvailable��$��	Available��$��5q� d� 	IsChecked �� $ IsAvailable�$ PropertyChanged=� �� Mode$ TwoWay=�	� -   $��rdNotAvailable��$��Not Available��$��5q� �� $ IsNotAvailable�$ PropertyChanged=�$ TwoWay=��� -   $��btnDoneWithManaging��$��5��$��2��$
��Done��$��Bottom=�$��10q�$��35��$��80��$��16(�$��Right=��� -	   $��lstScheduleView��$��0��$��6��$��0��	 �� DisplayMemberPath$	 StartTimeFormatted������ $ AvailableShifts�
 �� SelectedItem
 �� $ SelectedSchedule�$ PropertyChanged=�$ TwoWay=�