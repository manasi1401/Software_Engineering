   M S B A M L   `   `   `  ����   	ManagerUI'    !Scheduleator.UserManagementWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Manage Users�� � WindowStartupLocation$ CenterScreen=�.���  � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto � � ColumnDefinitions �� $
��Auto ��� $��* �.+��� -   $��lblCompanyProductName��$��10q�$��0��$��0��$��Scheduleator��$��22(�
����  ��� -   $��btnHomeButton��$��0��$��1��$��15q�$	��120��$��40��$
��Home��$��25(�$��Right=��� -   $��lstEmployeeViewer��$��10q�$��16(�$��1��$��0�� �� DisplayMemberPath$ UserName�� �� SelectionMode$ Single=�����  �� Path$ RegisteredEmployees� �� SelectedItem �� $ CurrentSelectedEmployee� �� UpdateSourceTrigger$ PropertyChanged=�	 �� Mode$	 TwoWay=��� -   $��
btnAddUser��$��2��$��0��$��AddUser��$��10q�$��35��
�������$��18(��� -   $��btnManageAvalability��$��2��$��1��$��Manage Availability��$��10q�$��16(�$	��150��
�������$��35��$
��Left=��� $��2��$��1��
 �� Orientation$
 
Horizontal=�$��Right=�.+��� -   $��btnSaveButton��$
��Save��$��10q�$��35��$��80��$��18(��� -   $��btnDeleteButton��$��Delete��$��10q�$��35��$��80��$��18(��� -   $��btnCancelButton��$��Cancel��$��10q�$��35��$��80��$��18(�� -	   $��grdEditUserGrid��$��1��$��1��{��� $ IsNoneZeroUserCount�$ PropertyChanged=� �� $
��Auto ��� $
��Auto ��� $
��Auto � �� $
��Auto ��� $��* �.+��� -
   $��lblUserName��$��UserName��$��20(�$��15,30,15,15q�$��0��$��0���� -   $��lblPIN��$	��PIN��$��20(�$��15q�$��2��$��0���� -   $��lblEmployeeID��$��Employee ID��$��20(�$��15q�$��1��$��0���� -   $��txtUserName��$��0��$��1��$��10q�$��16(�$��45��$
��Left=�$��Center=����� $ UserName�$ PropertyChanged=�$	 TwoWay=��� -   $��txtEmployeeID��$��1��$��1��$��10q�$��45��$
��Left=�$��Center=�$��16(����� $ ID�$ PropertyChanged=�$	 TwoWay=��� -   $��txtEmployeePIN��$��2��$��1��$��10q�$��45��$
��Left=�$��Center=�$��16(����� $	 PIN�$ PropertyChanged=�$	 TwoWay=�