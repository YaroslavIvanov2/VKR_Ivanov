   M S B A M L   `   `   `  ����N  JDiplom_Ivanov_Admin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:Diplom_Ivanov_Admin.Pages.mainWindowZakaz)Diplom_Ivanov_Admin.Pages.mainWindowZakaz  5   	   >    8Diplom_Ivanov_Admin.Pages.mainWindowZakaz.WindowAddZakaz   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Ilocal7clr-namespace:Diplom_Ivanov_Admin.Pages.mainWindowZakaz     5   	     � Title$  
Заказ��5   	   $	��477��6   $	��309��6$   .��5	      �  � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $��0.15* �6   .+�5   
   �� $��0��6   $��Center=�5      .+�5      �� $��Столик��6   $��14(�6&   �� 5      -   5         ��Name$ stoliccombobox��5       �� DisplayMemberPath$ Number_table��5       �� SelectedItem 67   �� *Table+5      �� 5    
   $��1��6   $��Center=�5!      .+�5#      �� $��Время заказа��6   $��14(�6,   �� 5$      -   5         ��Name$ times��5$      ��5%      �� *Time+5'      �� 5*   
   $��2��6   $��Center=�5+      .+�5-      �� $��Дата заказа��6   $��14(�6+   (  "System.Windows.Controls.DatePicker  5.      -   5          Name$ 	datezakaz��5.         Text 5/      �� *Date+53      �� 56   
   $��3��6   $��Center=�57      .+�59      �� $��Комментарий��6   $��14(�6+   �� 5:      -   5        $
 note��5:      ��5;      �� *Note+5=      �� 5>   
   $��4��6   $��Center=�5?      .+�5A      �� $��Официант��6   $��14(�6(   �� 5B      -   5        $ Employeecomobox��5B      $
 Name��60    5C      �� *
Employee+5D      5F      �� 5G   
   $��5��6   $��Center=�5H      .+�5I      �� $��
Блюда��6   $��14(�6%   66   �� 5J      -   5        $ dishcombobox��5J      ��5K      �� 5L      .R�5M      �� 	 �� Orientation$	 
Horizontal=�6%   .+�5N      �� ��6'   �� *Name+
 d� 	IsChecked
 6@   �� *	IsCheched+6b   �� 5O      $ kolcombobox��6&   $��40��6X   $��Right=�6c   ��6;   �� *colichestvo+6�   5P      5Q      5T      5U      �� 5Y   
   -   5        $��6��5Y      $��15,18,15,21q�5Z      $��Сохранить��5[      $��14(�5\   &   5]      5_      5`      