   M S B A M L   `   `   `  ����N  JDiplom_Ivanov_Admin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:Diplom_Ivanov_Admin.Pages.mainWindowEmployee,Diplom_Ivanov_Admin.Pages.mainWindowEmployee  5      ?    9Diplom_Ivanov_Admin.Pages.mainWindowEmployee.PageEmployee   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Llocal:clr-namespace:Diplom_Ivanov_Admin.Pages.mainWindowEmployee     5      -   5        $��window��5	        N� Title$  Сотрудники��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.5* �6   �� 5      $
��0.3* �6    � RowDefinitions 5   
   �� 5      .+�5   
   �� $
��Left=�6   $��0��6/   $	��Top=�6<   $��25(�6T   $��5q�6b   ��6m   ��  �� ElementName$ window�� �� Path$ Title�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	userTabel��5         AutoGenerateColumns .  $��1��5      $��0,50,0,0q�5   A      CanUserAddRows .     
IsReadOnly . 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$!
 Код сотрудника��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *id_Employee+6_     5       $
 Фамилия��6%    66   �� *	Surname+  5!      $
 Имя��6%    62   �� *Name+  5"      $
 Отчество��6%    67   �� *
Patronymic+  5#      $
 Телефон��6%    66   �� *	Telephone+  5$      $
 Дата рождения��6%    6<   �� *Date_of_Birth+  5%      $
 Должность��6%    68   �� *Position.Name+5'       � 5)   
   -   5          �Name$ UserCardFrame��5)      $	��450��5*      $	��200��6    $��2��5+      $��1��6      � NavigationUIVisibility$ Hidden=�5.      �� 51   
   $��0��6   .+�53      �� -   5         ��Name$ AddUser��53      $+��%Добавить сотрудника��54      $��5,50,5,5q�55      $��40��6#   $��14(�56   '   $��30��65   �� 58      -   5        $ redactorUser��58      $ ��Редактировать��59      $��40��5:      $��5q�5;      $��14(�5<   0   5=      �� 5>      -   5        $ deletebutton��5>      $��Удалить��5?      $��40��6#   $��5q�5@      $��14(�6;   5B      �� 5C   
    �� Orientation$ Vertical=�6   $	��140��6,   $��	9,200,0,0q�68   $
��Left=�6K   .+�5D      9�  9� 
IsExpanded . $��Должность��6)   .��5E      ��  �� SelectionMode$ Extended=�6O   $��0q�5F      
������ ��5E      �� *SectionFilters2+ �� Mode$ OneWay=���5G      �� 5H      .R�5I      �� -   5        ��5J   '   �� *Position.Name+ d� 	IsChecked 6J   �� *	IsChecked+6l   5K      5M      5N      5O      �� 5P   
   -   5         ��Name$ Searctextbox��5P      $��1��6(   ���#10101A$��Center=�6N   $��16(�5Q      $��
10,10,10,0q�5R      $	��Top=�6&   $��30��6>      SearchTextBoxStyle#��[  5S      ��5Q   B   �� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=�5S   @   5T      5U      