   M S B A M L   `   `   `  ���� J  FImplementations, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD3clr-namespace:Scheduleator;assembly=ImplementationsScheduleator  D @ManagerUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ScheduleatorScheduleator    Scheduleator.Shiftviewer   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Csrc3clr-namespace:Scheduleator;assembly=Implementations     +src1clr-namespace:Scheduleator       � Title$  Shift Viewer�� � WindowStartupLocation$ CenterScreen=�.���  � RowDefinitions �� $	��50* ��� $	��71* ��� $	��29* ��� $	��51* ��� $	��50* ��� $	��51* ��� $	��50* ��� $	��51* ��� $	��50* ��� $	��51* � � ColumnDefinitions �� $��9* ��� $��9* ��� $��9* ��� $��9* ��� $��9* ��� $��9* ��� $��9* ��� $��9* ��� $��9* �.+��� -   $��Previous��$��0��$��4��$��30(�$��
24,10,10,0q����� *.+�� -   $
��Next��$��8��$��4��$��30(�$��
10,10,25,0q����� *.+�� -   $��	AddShifts��$��7��$��8��$��	Add Shift��$��15(�$��
10,7,80,10q�$��2���� -   $��
HomeButton��$��8��$��1��$
��Home��$��10q�$��15(��� -   $��lblCompanyProductName��$��0,10,0,0q�$��0��$��0��$��Scheduleator��$��22(�
����  �$��2���� -   $	��One��$��0,10,0,0q� � DataContext$  ��$��1��$��1��$��15(�
���   � J� RenderTransformOrigin$ 0.081,0.098&�.���� .+��� ���� *
.DayOfWeek+�� ���� *.+ �� StringFormat$ d���� -   $	��Two��$��0,10,0,0q�$��1��$��2��$��15(�
���   �$ 0.081,0.098&�.���� .+��� ���� *
.DayOfWeek+�� ���� *.+$ d���� -   $��Three��$��0,10,0,0q�$��1��$��3��$��15(�
���   �$ 0.081,0.098&�.���� .+��� ���� *
.DayOfWeek+�� ���� *.+$ d���� -	   $
��Four��$��0,10,0,0q�$��1��$��4��$��15(�
���   �$ 0.081,0.098&�.���� .+��� ���� *
.DayOfWeek+�� ���� *.+$ d���� -
   $
��Five��$��0,10,0,0q�$��1��$��5��$��15(�
���   �$ 0.081,0.098&�.���� .+��� ���� *
.DayOfWeek+�� ���� *.+$ d���� -   $	��Six��$��0,10,0,0q�$��1��$��6��$��15(�
���   �$ 0.081,0.098&�.���� .+��� ���� *
.DayOfWeek+�� ���� *.+$ d���� -   $��Seven��$��0,10,0,0q�$��1��$��7��$��15(�
���   �$ 0.081,0.098&�.���� .+��� ���� *
.DayOfWeek+�� ���� *.+$ d���� -    ��Name$ 
SundayList��$��2��$��5��$��1������ .R��� 
�������.+�� .+��� $��Start: ���� ���� *StartTimeFormatted+� .+��� $��End: ���� ���� *EndTimeFormatted+�� -   $ 
MondayList��$��2��$��5��$��2������ .R��� 
�������.+�� .+��� $��Start: ���� ���� *StartTimeFormatted+� .+��� $��End: ���� ���� *EndTimeFormatted+�� -   $ TuesdayList��$��2��$��5��$��3������ .R��� 
�������.+�� .+��� $��Start: ���� ���� *StartTimeFormatted+� .+��� $��End: ���� ���� *EndTimeFormatted+�� -   $ WednesdayList��$��2��$��5��$��4������ .R��� 
�������.+�� .+��� $��Start: ���� ���� *StartTimeFormatted+� .+��� $��End: ���� ���� *EndTimeFormatted+�� -   $ ThursdayList��$��2��$��5��$��5������ .R��� 
�������.+�� .+��� $��Start: ���� ���� *StartTimeFormatted+� .+��� $��End: ���� ���� *EndTimeFormatted+�� -   $ 
FridayList��$��2��$��5��$��6������ .R��� 
�������.+�� .+��� $��Start: ���� ���� *StartTimeFormatted+� .+��� $��End: ���� ���� *EndTimeFormatted+�� -   $ SaturdayList��$��2��$��5��$��7������ .R��� 
�������.+�� .+��� $��Start: ���� ���� *StartTimeFormatted+� .+��� $��End: ���� ���� *EndTimeFormatted+