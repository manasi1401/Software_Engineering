   M S B A M L   `   `   `  ����  	ManagerUI    Scheduleator.EditShift   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $	��600��5   	   $	��800��5   	     � Title$  	EditShift��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��54* �6   �� 5      $	��50* �6   �� 5      $	��54* �6   �� 5      $	��54* �6   �� 5      $	��54* �6   �� 5      $	��37* �6   �� 5      $	��37* �6   �� 5      $	��37* �6   �� 5      $	��37* �6   �� 5      $	��37* �6   �� 5      $	��90* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   $	��162��6,   �� 5      $
��Auto �6   $	��241��6,   �� 5      $
��Auto �6   $	��179��6,   �� 5      $
��Auto �6   $	��479��6,   .+�5    
   �� -   5        $��lblCompanyProductName��5       $��10q�5!      $��0��5"      $��0��5#      $��Scheduleator��5$      $��22(�5%      
����  �5&      �� 5'   
   -   5        $��ShiftId��5'      $��0��5(      $��1��5)      $��Id��5*      $��18(�5+      $��10,0,0,0q�6   �� 5-   
   -   5        $��id��5-      $��1��5.      $��1��5/      $��
28,10,33,0q�50   )   ��6   �� *Id+6)   �� 51   
   -   5        $��	ShiftDate��51      $��0��52      $��2��53      $
��Date��54      $��18(�55      $��10,0,0,0q�6   (  "System.Windows.Controls.DatePicker  57   
   -   5        $
��Date��57      $��41��58      $��Center=�59      $��
28,10,34,0q�5:      $	��Top=�5;      $��1��5<      $��2��5=      $	��179��6"      SelectedDate 5>      �� *Date+�� 5?   
   -   5        $��	StartTime��5?      $��0��5@      $��3��5A      $��
Start Time��5B      $��18(�5C      $��10,0,0,0q�6   �� 5F   
   -   5        $��	StartHour��5F      $��1��5I      $��3��5J      $��28,10,164,0q�6   $��39��6/   $	��Top=�6;   5L      �� 5M   
   -   5        $��Colon��5M      $��1��5N      $��3��5O      $��:��5P      $��20(�5Q      $��
0,10,139,0q�6   $��Right=�62   $��19��6N    J� RenderTransformOrigin$ -2.593,0.635&�6Y   $��56��6~   $	��Top=�6�   $��2��6�   �� 5T   
   -	   5        $��StartMin��5T      $��1��5U      $��3��5V      $��107,10,85,0q�6   $��39��5X   5   $	��Top=�6A   �� 5Z   
   -
   5        $
��AMPM��5Z      $��1��5[      $��3��5\      $��182,10,10,0q�6   $��39��5^   ,   $	��Top=�68   �� 5a   
   -   5        $��EndTime��5a      $��0��5b      $��4��5c      $��End Time��5d      $��18(�5e      $��10,0,0,0q�6   �� 5h   
   -   5        $��EndHour��5h      $��1��5k      $��4��5l      $��28,10,164,0q�6   $��34��6/   $	��Top=�6;   5n      �� 5p   
   -   5        $��EColon��5p      $��1��5q      $��4��5r      $��:��5s      $��20(�5t      $��
0,10,144,0q�6   $��Right=�62   $��19��6N   $ -2.593,0.635&�6Y   $��51��6~   $	��Top=�6�   $��2��6�   �� 5v   
   -   5        $��EndMin��5v      $��1��5w      $��4��5x      $��107,10,85,0q�6   $��34��5z   3   $	��Top=�6?   �� 5{   
   -   5        $��EAMPM��5{      $��1��5|      $��4��5}      $��182,10,10,0q�6   $��34��5   /   $	��Top=�6;   �� 5�   
   -   5        $��NumberOfCooks��5�      $��Number of Cooks��5�      $��5��5�      $��0��5�      $��10,0,0,0q�5�      $��18(�5�      �� 5�   
   -   5        $��NumCooksRead��5�      $��1��5�      $��5��5�      $��	28,5,33,5q�5�   1   ��6   �� *NumberOfCooks+61   �� 5�   
   -   5        $��NumberOfDishwashers��5�      $��Number of Dishwashers��5�      $��6��5�      $��0��5�      $��10,0,0,0q�5�      $��18(�5�      �� 5�   
   -   5        $��NumDishwasherRead��5�      $��1��5�      $��6��5�      $��	28,5,33,5q�5�   6   ��6   �� *NumberOfDiswashers+66   �� 5�   
   -   5        $��NumberOfManager��5�      $��Number of Managers��5�      $��7��5�      $��0��5�      $��10,0,0,0q�5�      $��18(�5�      �� 5�   
   -   5        $��NumManagerRead��5�      $��1��5�      $��7��5�      $��	28,5,33,5q�5�   4   ��6   �� *NumberOfManagers+64   �� 5�   
   -   5        $��NumberOfCashier��5�      $��Number of Cashiers��5�      $��8��5�      $��0��5�      $��10,0,0,0q�5�      $��18(�5�      �� 5�   
   -   5        $��NumCashierRead��5�      $��1��5�      $��8��5�      $��	28,5,33,5q�5�   4   ��6   �� *NumberOfCashiers+64   �� 5�   
   -   5        $��NumberOfWaiter��5�      $��Number of Waiters��5�      $��9��5�      $��0��5�      $��10,0,0,0q�5�      $��18(�5�      �� 5�   
   -   5        $��NumWaiterRead��5�      $��1��5�      $��9��5�      $��	28,5,33,5q�5�   3   ��6   �� *NumberOfWaiters+63   �� 5�   
   -   5        $
��Save��5�      $��11��5�      $��1��5�      $
��Save��5�      $��15(�5�      $��
29,15,0,10q�6   $
��Left=�5�   $   $	��177��6?   �� 5�   
   -   5        $��Discard��5�      $��11��5�      $��2��5�      $��Discard��5�      $��15(�5�      $��0,16,0,9q�5�   '   $��Right=�69   $	��155��6U   �� 5�   
   -   5        $��Deleteshift��5�      $��0��5�      $��11��5�      $��Delete Shift��5�      $��15(�5�      $��26,16,10,10q�5�   %   �� 5�   
   -   5        $��	ListAvail��5�      $��Available Employees��5�      $��1��5�      $��2��5�      $��15(�5�      �� 5�   
   -   5        $��AvailableEmp��5�      $��2��5�      $��2��5�      $��8��5�      ��5�      �� *AvailableEmployee+��5�      �� 5�      .R�5�      �� 
�������.+�5�      � .+�5�      �� ��6(   �� *
EmployeeID+5�      � 5�      .+�5�      �� ��6(   �� *
UserName+5�      5�      5�      5�      �� 5�   
   -   5        $��ListWorking��5�      $��Scheduled Employees��5�      $��1��5�      $��3��5�      $��15(�5�      �� 5�   
   -    5        $��ScheduledEmp��5�      $��3��5�      $��2��5�      $��8��5�      $��	0,0,317,0q�5�   <   ��6   �� *WorkingEmployees+��5�      �� 5�      .R�5�      �� 
�������.+�5�      � .+�5�      �� ��6(   �� *
EmployeeID+5�      � 5�      .+�5�      �� ��6(   �� *
UserName+5�      5�      5�      5�      5�      5      