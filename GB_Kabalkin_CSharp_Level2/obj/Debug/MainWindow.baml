   M S B A M L   `   `   `  ����T  PGB_Kabalkin_CSharp_Level2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:GB_Kabalkin_CSharp_Level2GB_Kabalkin_CSharp_Level2  5   	   *    $GB_Kabalkin_CSharp_Level2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:GB_Kabalkin_CSharp_Level2     5   	     � Title$  
MainWindow��5   	   $��429.294��6   $��941.658��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   6,   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��30 �6   6+   �� 5      $��* �6   6)   .+�5   
   �� -   5         ��Name$ 	LableText��5      $��Center=�6'   $��5q�6D   $
��Wrap=�6O   $��	TextBlock��6c   $	��Top=�6t   $��16(�6�    �� TextAlignment$ Center=�6�   $��0��6�   $��3��6�   $
��Bold"�6�   �� 5   
   $��Center=�6   $��5q�61   $
��Wrap=�6<   $��Departaments:��6P   $	��Top=�6e   $��1��6}   $��0��6�   �� 5   
   -   5         ��Name$ DepartamentsListBox��5      $��Center=�60   $	��250��6M   $��10,50,10,10q�6Z   $	��Top=�6o   $	��191��6�   $��1��6�   $��0��6�   �� 5   
   -   5         ��Name$ 	AddDepBtn��5      $	��Add��6$   $��Center=�62   $��10,312,10,0q�6O   $	��Top=�6d   $��76��6|   $��1��6�   $��0��6�   �� 5   
   $��Center=�6   $��5q�61   $
��Wrap=�6<   $��Staff:��6P   $	��Top=�6^   $��1��6v   $��1��6�   �� 5   
   -   5        $ StafflistBox��5      $��Center=�6)   $	��250��6F   $��10,50,10,10q�6S   $	��Top=�6h   $	��191��6�   $��1��6�   $��1��6�   �� 5   
   -   5        $ EditStaffBtn��5      $
��Edit��6'   $��Center=�66   $��162,312,48,0q�6S   $	��Top=�6i   $��76��6�   $��1��6�   $��1��6�   �� 5   
   -   5        $ AddStaffBtn��5      $	��Add��6&   $��Center=�64   $��48,312,162,0q�6Q   $	��Top=�6g   $��76��6   $��1��6�   $��1��6�   �� 5   
   -   5        $ DelStaffBtn��5      $	��Del��6&   $��Center=�64   $��48,337,162,0q�6Q   $	��Top=�6g   $��76��6   $��1��6�   $��1��6�   �� 5!   
   -   5        $ CompanyInfoTextBox��5!      $��Stretch=�60   $��25q�6N   $
��Wrap=�6Z   $��	TextBlock��6n   $	��Top=�6   $��1��6�   $��2��6�   $ Justify=�6�   ���	#FFE2E2E26�   5#      5%      