   M S B A M L   `   `   `  ����N  JDiplom_Ivanov_Admin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Diplom_Ivanov_Admin.Pages.mainWindowDish(Diplom_Ivanov_Admin.Pages.mainWindowDish  5   	   <    6Diplom_Ivanov_Admin.Pages.mainWindowDish.WindowAddDish   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:Diplom_Ivanov_Admin.Pages.mainWindowDish     5   	     � Title$  
Блюдо��5   	   $	��527��6   $	��314��6$   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $��0.15* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5         ��Name$ Photo��5   S   $	��120��6b   $	��130��6o   $	��Top=�6{   $
��Left=�6�   $��
10,10,10,0q�5      ��5      �� *Image+   	imageConv �� 	Converter# [  5   *   �� 5      -   5         ��Name$ addImage��5      $'��!Добавить картинку��5      $	��130��61   $��	0,85,0,26q�5      $��14(�6(   5      �� 5   
   $��1��6   $��Center=�6"   .+�5      �� $!��Название блюда��6   $��14(�6.   6>   �� 5       ��6   �� *	Name_dish+63   5!      �� 5"   
   $��2��6   $��Center=�5#      .+�5$      �� $��Цена��6   $��14(�6$   64   �� 5%      ��6   �� *Price+6/   5&      �� 5'   
   $��3��6   $��Center=�6"   .+�5(      �� $��Вес��6   $��14(�6#   63   �� 5)      ��6   �� *	Wheight+61   5*      �� 5+   
   $��4��6   $��Center=�6"   .+�5,      �� $#��Категория блюда��6   $��14(�6/   6?   �� 5-      -   5         ��Name$ categorycombobox��5-       �� DisplayMemberPath$
 Name��61   	 �� SelectedItem	 6J   �� *Category_of_dishes+6x   5.      �� 5/   
   $��5��6   $��Center=�6"   .+�50      �� $%��Пищевая ценность��6   $��14(�60   6@   �� 51      ��6   �� *The_nutritional_value+6?   52      �� 53   
   $��6��6   $��Center=�6"   .+�54      �� $��Состав��6   $��14(�6&   66   �� 55      ��6   �� *
Compound+62   56      �� 58   
   -   5        $��7��58      $��15q�59      $��Сохранить��6   $��14(�5:   &   5;      5=      5>      