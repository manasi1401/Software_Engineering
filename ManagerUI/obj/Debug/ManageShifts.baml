   M S B A M L   `   `   `  ����M  IXamarin.Forms.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI7clr-namespace:Xamarin.Forms;assembly=Xamarin.Forms.CoreXamarin.Forms  5
   	    	ManagerUI   Scheduleator.ManageShifts   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      &localusing:XAMLTimePicker     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      :xctk)http://schemas.xceed.com/wpf/xaml/toolkit     5	   	   Iforms7clr-namespace:Xamarin.Forms;assembly=Xamarin.Forms.Core     5
   	   $	��340��5   	   $	��400��6     � 
ResizeMode$  NoResize=�5   
    � Title$ Add a Shift��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��lblCurrentUserName��5      $��0��5       $��1��5!      $��5q�5"      $
��Left=�5#      $	��Top=�5$      $��12(�5%      ��5      ��  �� Path$ NameOfCurrentUser� �� UpdateSourceTrigger$ PropertyChanged=�5%      �� 5'   
   -   5        $��lblDateOfShift��5'      $��1��5)      $��1��5*      $��5q�5+      $
��Left=�5,      $	��Top=�5-      $��12(�5.      ��5(      �� $ DateOfShift�$ PropertyChanged=�5.      �� 50   
   -   5        $��lblStartTimeOfShift��50      $��2��52      $��1��53      $��5q�54      $
��Left=�55      $	��Top=�56      $��12(�57      ��51      �� $ StartTimeShift�$ PropertyChanged=�57      �� 59   
   -   5        $��lblEndTimeOfShift��59      $��3��5;      $��1��5<      $��5q�5=      $
��Left=�5>      $	��Top=�5?      $��12(�5@      ��5:      �� $ EndTimeShift�$ PropertyChanged=�5@      �� 5B   
   -   5        $��stkRadioButtons��5B      $��4��5C      $��1��5D      .+�5E      	� -   5        $��rdAvailable��5E      $��	Available��5F      $��5q�5G       d� 	IsChecked 5H      �� $ IsAvailable�$ PropertyChanged=� �� Mode$ TwoWay=�5K      	� 5L      -   5        $��rdNotAvailable��5L      $��Not Available��5M      $��5q�5N       5O      �� $ IsNotAvailable�$ PropertyChanged=�$ TwoWay=�5R      5S      �� 5U   
   -   5        $��btnDoneWithManaging��5U      $��5��5W      $��2��5X      $
��Done��5Y      $��Bottom=�5Z      $��10q�5[      $��35��5\      $��80��5]      $��16(�5^      $��Right=�5_      �� 5a   
   -	   5        $��lstScheduleView��5a      $��0��5b      $��6��5c      $��0��5d      	 �� DisplayMemberPath$	 StartTimeFormatted��5h      ��5e      �� $ AvailableShifts�
 �� SelectedItem
 5f      �� $ SelectedSchedule�$ PropertyChanged=�$ TwoWay=�5h      5i      5j      