   M S B A M L   `   `   `  ����N  JDiplom_Ivanov_Admin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Diplom_Ivanov_Admin.Pages.mainWindowDish(Diplom_Ivanov_Admin.Pages.mainWindowDish  5      c6clr-namespace:Diplom_Ivanov_Admin.resources.Converters(Diplom_Ivanov_Admin.resources.Converters  6L   7    1Diplom_Ivanov_Admin.Pages.mainWindowDish.PageDish   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:Diplom_Ivanov_Admin.Pages.mainWindowDish     5      M
Converters6clr-namespace:Diplom_Ivanov_Admin.resources.Converters     6L   -   5        $��window��5	        N� Title$  
Блюда��5
      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��
10,100,0,0q�6,   $
��Left=�6@   .+�5      �� -   5         ��Name$ addDish��5      $	��150��6&   $��30��62   $��14(�6T   .��6c   Добавить6m   �� 5      -   5        $ redactorDish��5      $	��150��6F   $��30��6R   $
��5,10q�6^   $��14(�6l   .��6z   Редактировать6�   �� 5      -   5        $ 
deleteDish��5      $	��150��6)   $��30��65   $��14(�6Z   .��6i   Удалить6r   5      �� 5   
   $ Vertical=�6   $	��200��6,   $��
10,230,0,0q�68   $
��Left=�6L   .+�5      9�  9� 
IsExpanded . $��Вид блюда��6)   .��5      ��  �� SelectionMode$ Extended=�6N   $��0q�5      
������ ��5      �� *SectionFilters+ �� Mode$ OneWay=���5      �� 5      .R�5      �� -   5        ��5   '   �� *Category_Of_Dishes.Name+ d� 	IsChecked 6S   �� *	IsChecked+6u   5      5      5      5      �� 5   
   -   5        ���#10101A$��Center=�5   (   $��16(�5       $��220,30,30,0q�5!      $	��Top=�6'   $��35��6?      SearchTextBoxStyle#��[  5"      ��5    B   �� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=�5"   @   �� 5#   
   $
��Left=�6   $	��Top=�6/   $��Roboto)�6G   $��25(�6[   $��30q�6i   ��6u   ��  �� ElementName$ window��	 �� Path$	 Title�6�   �� 5$   
   $��0q�6   $��220,100,35,35q�6)     tabItemStyle#��[ 6@   .@�5%      �� -   5        
 ��Name$	
 _ti��5%      ��5&      �� 5'      $��5q�6   $��20��6'   $��20��62   ��5(      H� 5)       H� Drawing 5*   "   I� 5+   &   .��5,   *   �   vec1 � Geometry# [ 6m    � Brush 6:   �� $	 _ti��$	 
Foreground�6�   5-   '   5/      51      ��53      �� 54      -   5         ��Name$ spisok��54      $��0q�6.   $��0q�69   
������   PetsItemstyle#��[ 55      $��Disabled=�6R   ��54   f   �� *Dishes+��56      �� 57      .R�58   "   � 6.   59      ��5;      �� 5<      .R�5=   "   ]� $	��250��6,   $	��450��68   .+�5>   &   �� $��0,20,0,0q�6,   $	��Top=�6>   $	��150��6S   $	��250��6_   ��6l   �� *Image+  	imageConv �� 	Converter# [ 6�   �� 5?   &   $	��Top=�60   $��20,0,0,0q�6E    �� TextAlignment$
 Left=�6r   $��16(�6�   $
��Wrap=�6�   ��6W   �� *	Name_dish+6�   5@   #   5A      5C      5E      �� 5F      -	   5        $

 _ti2��5F      ��5G      �� 5H      $��5q�6   $��20��6'   $��20��62   ��5I      H� 5J       5K   "   I� 5L   &   .��5M   *   �   vec2# [ 6n    6:   �� $
 _ti2��$	 
Foreground�6�   5N   '   5P      5R      ��5T      &   System.Windows.Controls.DataGrid  5U      -
   5          Name$ spisok2��5U         SelectionMode$ Single=�60      GridLinesVisibility$ 
Horizontal=�6G      RowHeaderWidth$ 0Q�5V      
������    
IsReadOnly .    CanUserSortColumns .  $��0q�5W   L      AutoGenerateColumns .  ��5X      �� *Dishes+   Columns 5Y      0  *System.Windows.Controls.DataGridTextColumn  5Z      ,  &System.Windows.Controls.DataGridColumn   Header$ Код Блюда��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	id_Dish+6b   4  .System.Windows.Controls.DataGridTemplateColumn  5[         Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 65   $ Изображение��6A      CellTemplate 5\   "   �� 5]   &   .R�5^   *   �� $	��100��60   ��6=   �� *Image+# [ 6~   5_   '   5a        5b      $ Название��61    6C   �� *	Name_dish+6c     5c      $ Категория��61    6D   �� *Category_of_dishes.Name+6r     5d      $ Вес��61    6>   �� *	Wheight+6\     5e      $ Цена��61    6?   �� *Price+6[     5f      $% Пищевая ценность��61    6K   �� *The_nutritional_value+6w     5g      $ Состав��61    6A   �� *
Compound+6`   5i      5k      5l      5m      5n      