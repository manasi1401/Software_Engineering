   M S B A M L   `   `   `  ����M  IXamarin.Forms.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI7clr-namespace:Xamarin.Forms;assembly=Xamarin.Forms.CoreXamarin.Forms  5
   	    	ManagerUI   Scheduleator.EditUser   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      &localusing:XAMLTimePicker     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      :xctk)http://schemas.xceed.com/wpf/xaml/toolkit     5	   	   Iforms7clr-namespace:Xamarin.Forms;assembly=Xamarin.Forms.Core     5
   	   $	��350��5   	   $	��400��6     � 
ResizeMode$  NoResize=�5   
    � Title$ Add a Shift��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   $��59��6*   �� 5      $
��Auto �6   $��54��6*   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $	��43* �6   �� 5      $	��47* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��lblCompanyProductName��5      $��10q�5      $��0��5      $��0��5      $��Scheduleator��5       $��22(�5!      
����  �5"      �� 5#   
   -   5        $��lblUserName��5#      $��UserName��5$      $��1��5%      $��0��5&      $��18(�5'      $��10q�5(      �� 5)   
   -   5        $��lblEmployeeID��5)      $��
EmployeeID��5*      $��2��5+      $��0��5,      $��18(�5-      $��10q�5.      �� 5/   
   -   5        $��lblPin��5/      $	��PIN��50      $��3��51      $��0��52      $��18(�53      $��10q�54      �� 56   
   -   5        $��txtUserName��56      $��1��57      $��1��58      $��10,10,12,10q�59      $��Stretch=�5:      $��Stretch=�5;      ��5<      ��  �� Path$ UserName� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 5=   
   -   5        $��txtEmployeeID��5=      $��2��5>      $��1��5?      $��10,10,12,10q�5@      $��Stretch=�5A      $��Stretch=�5B      ��5C      �� $ ID�$ PropertyChanged=�$ TwoWay=��� 5D   
   -   5        $��txtEmployeePIN��5D      $��3��5E      $��1��5F      $��10,10,12,10q�5G      $��Stretch=�5H      $��Stretch=�5I      ��5J      �� $	 PIN�$ PropertyChanged=�$ TwoWay=��� 5K   
   -   5        $��lblWage��5K      $��Wage ($/hr)��5L      $��4��5M      $��0��5N      $��18(�5O      $
��10,0q�5P      �� 5Q   
   -	   5        $��txtHourlyWage��5Q      $��4��5R      $��1��5S      $��10,10,12,10q�5T      $��Stretch=�5U      $��Stretch=�5V      ��5W      �� $ 
HourlyWage�$ PropertyChanged=�$ TwoWay=��� 5X   
   $��5��6   $��1��5Y       �� Orientation$ 
Horizontal=�5Z      $��Bottom=�5[      $��Right=�5\      $��45��61   $	��200��6=   .+�5^      �� -
   5        $��btnSaveUserProgress��5^      $
��Save��5_      $��10q�5`      $��Right=�5a      $��Bottom=�5b      $��80��5c      $��25��5d      {�5f      �� *ManagerCanSave+$ PropertyChanged=��� 5g      -   5        $��btnCancelButton��5g      $��Cancel��5h      $��10q�5i      $��Right=�5j      $��Bottom=�5k      $��80��5l      $��25��5m      5n      5p      5q      5r      