   M S B A M L   `   `   `  ����N  JDiplom_Ivanov_Admin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:Diplom_Ivanov_Admin.Pages.mainWindowZakaz)Diplom_Ivanov_Admin.Pages.mainWindowZakaz  5      9    3Diplom_Ivanov_Admin.Pages.mainWindowZakaz.PageZakaz   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:Diplom_Ivanov_Admin.Pages.mainWindowZakaz     5      -   5        $��window��5	        N� Title$  Заказы��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.6* �6   �� 5      $
��0.2* �6    � RowDefinitions 5   
   �� 5      .+�5   
   �� $
��Left=�6   $��0��6/   $	��Top=�6<   $��25(�6T   $��5q�6b   ��6m   ��  �� ElementName$ window�� �� Path$ Title�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ spisokZakaz��5         AutoGenerateColumns .  $��1��6(   $��0,50,0,0q�68      CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID заказа��6B   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *
id_Order+6B     5      $	 Номер столика��6L   
 6%   �� *Table.Number_table+6L     5      $	 Время заказа��6>   
 6%   �� *Time+6>     5      $	 Официант��6G   
 6%   �� *Employee.Name+6G   5        � 5!   
   -   5          �Name$ UserCardFrame��5!      $	��450��5"      $	��150��6    $��2��5#        � NavigationUIVisibility$ Hidden=�5&      �� 5(   
   $��0��6   .+�5*      �� -   5         ��Name$ AddZalaz��5*      $!��Добавить заказ��5+      $��5,50,5,5q�5,      $��40��6#   $��14(�5-   (   �� 5/      -   5        $ 
RedacZakaz��5/      $ ��Редактировать��50      $��40��51      $��5q�53      $��14(�6    54      �� 55      -   5        $ DeleteZakaz��55      $��Удалить��56      $��40��57      $��5q�59      $��14(�6    5;      5<      5@      5A      