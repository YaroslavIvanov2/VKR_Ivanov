   M S B A M L   `   `   `  ����N  JDiplom_Ivanov_Admin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:Diplom_Ivanov_Admin.Pages.mainWindowEmployee,Diplom_Ivanov_Admin.Pages.mainWindowEmployee  5   	   D    >Diplom_Ivanov_Admin.Pages.mainWindowEmployee.WindowAddEmployee   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Llocal:clr-namespace:Diplom_Ivanov_Admin.Pages.mainWindowEmployee     5   	     � Title$  WindowAddEmployee��5   	   $	��477��6#   $	��299��60   .��5
      � $��10q�6    � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $��0.15* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5         ��Name$ Photo��5   S   $	��102��6b   $	��115��6o   $	��Top=�6{   $
��Left=�6�   $��
10,10,10,0q�5      ��5      �� *Image+   	imageConv �� 	Converter# [  5   *   �� 5      -   5         ��Name$ addImage��5      $'��!Добавить картинку��5      $	��130��61   $��	0,70,0,26q�5      $��14(�6(   5      �� 5!   
   $��1��6   $��Center=�5"      .+�5$      �� $��Фамилия��6   $��14(�6'   �� 5%      -   5         ��Name$ login��5%      ��5&      �� *	Surname+5(      �� 5*   
   $��2��6   $��Center=�5+      .+�5-      �� $��Имя��6   $��14(�6#   �� 5.      -   5        $ password��5.      ��5/      �� *Name+51      �� 54   
   $��3��6   $��Center=�55      .+�57      �� $��Отчество��6   $��14(�6(   �� 58      -   5        $ username��58      ��59      �� *
Patronymic+5;      �� 5>   
   $��4��6   $��Center=�5?      .+�5A      �� $��Дата рождения��6   $��14(�6-   (  "System.Windows.Controls.DatePicker  5B      -   5          Name$ usersurname��5B      $��23��5C   5   	   Text	 6   �� *Date_of_Birth+65   5E      �� 5G   
   $��5��6   $��Center=�5H      .+�5J      �� $��Телефон��6   $��14(�6'   �� 5K      -   5        $ 
userRoleCB��5K      ��6*   �� *	Telephone+.��6E   5M      5O      �� 5Q   
   $��6��6   $��Center=�5R      .+�5T      �� $��Должность��6   $��14(�6)   �� 5U      -   5        
 ��Name$
 comboboxPositon��5U       �� DisplayMemberPath$
 Name��5V       �� SelectedItem 6/   �� *
Position+5X      �� 5[   
   -	   5        $ 	addbutton��5[      $��Сохранить��5\      $��7��5]      $��25,10,21,10q�5^      $��14(�5_   )   5b      5c      