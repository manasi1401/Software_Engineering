   M S B A M L   `   `   `  ����  
MainWindow    Scheduleator.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Scheduleator��5   	   $	��350��6   $	��420��6+    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      �  � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $��3* �6   �� 5      $��3* �6   �� 5      $��3* �6   �� 5      $��3* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��lblCompanyProductName��5      $��10,10,10,30q�5      $��0��5      $��0��5      $��Scheduleator��5      $��22(�5      
����  �5      �� 5!   
   $ ��/Images/DropTablesLogo.jpg��6   $
��Left=�5"      $��0��5#      $��1��5$      �� 5&   
   -   5        $��btnEmployeeLoginSelection��5&      $��1��5'      $��1��5(      $��Employee��5)      $��10q�5*      $	��100��5+      {�5-      ��  �� Path$ EmployeeEnabled� �� UpdateSourceTrigger$ PropertyChanged=��� 5/   
   -   5        $��btnManagerLoginSelection��5/      $��1��50      $��2��51      $��Manager��52      $��10q�53      $	��100��54      {�56      �� *ManagerEnabled+$ PropertyChanged=��� 59   
   -   5        $��lblUserName��59      $��
Username: ��5:      $��2��5;      $��Center=�5<      $��20(�5=      $��10,10,10,10q�5>      $��0��5?      �� 5@   
   -   5        $��txtUserName��5@      $��2��5A      $��1��5B      $��2��5C      $��18(�5D      $	��200��5E      $��10q�5F      $��Center=�5G      ��5H      �� $ UserName��� 5J   
   -   5        $��lblPassword��5J      $��	Password:��5K      $��Center=�5L      $��3��5M      $��20(�5N      $��10,10,10,10q�5O      $��0��5P      �� 5R   
   -   5        $��txtPassword��5R      $��3��5S      $��1��5T      $��2��5U      $��18(�5V      $	��200��5W      $��10q�5X      $��Center=�5Y      ��5Z      �� $ Password��� 5\   
   -   5        $��	btnSignIn��5\      $��Sign In��5]      $��4��5^      $��1��5_      $��16(�5`      $��20,15,20,15q�5a      5b      5d      5e      