   M S B A M L   `   `   `  ����D  @ISGradnja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ISGradnja.WindowsISGradnja.Windows  5          ISGradnja.Windows.Magacin   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      +localclr-namespace:ISGradnja.Windows  5      .��5
      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� $	��Top=�5      
���   �$��Center=�5       $   MaterialDesignHeadline5TextBlock#��[  5      $��Dostupno��5      �� 5      $��1q�6   ���	#FF5C99D6._�5      &   System.Windows.Controls.DataGrid  -   5          Name$ magacinDataGrid��5      $��0��64      AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .    CanUserSortColumns . $��0,35,0,0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ RB��6-   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 69   �� *id+  5      $ Naziv stavke��6-   	 6C   �� *naziv+  5      $ Merna jedinica��6-   	 6E   �� *merna_jedinica+  5       $ 	Količina��6-   	 6?   �� *
kolicina+  5!      $ Dostupno��6-   	 6?   �� *
dostupno+4  .System.Windows.Controls.DataGridTemplateColumn  5"      
   CellTemplate
 5#      �� 5$   "   .R�5%   &   ��  ��Name$ btnDel��6-   -   5        $��30��5%   S   $��50��6_   
�������$��Center=�6~   ��6�   0  *MaterialDesignThemes.Wpf.PackIconExtension  *Close+6�   5&   #   5(        5)      
 5*      �� 5+   "   .R�5,   &   �� $ btnEdit��6-   -   5        $��30��5,   U   $��50��6a   
�������$��Center=�6�   ��6�     *Edit+6�   5-   #   5/        50      
 51      �� 52   "   .R�53   &   �� $ btnRaspodela��6-   -   5        $��30��53   _   $��50��6k   
�������$��Center=�6�   ��6�     *Send+6�   54   #   56      58      59      5<      � 5>   
   $��1��6     5?      �� 5@      $��* �6    �� 5A      $��60 �6    .+�5D      �� $	��Top=�5E      
���   �$��Center=�5G      #��[  5H      $��	Raspodela��5I      �� 5K      $��1q�6   ���	#FF5C99D6._�5L        -   5        $ magacinRaspodelaDataGrid��5L      $��0��6=    .   .   .   .  . $��0,35,0,0q�6�    5M        5N      $ RB��6-   	 69   �� *id+  5O      $ Naziv stavke��6-   	 6C   �� *naziv+  5P      $ Gradilište��6-   	 6A   �� *
gradiliste+  5Q      $ 	Količina��6-   	 6?   �� *
kolicina+  5R      
 5S      �� 5T   "   .R�5U   &   �� $ btnDelRaspodela��6-   -   5        $��30��5U   e   $��50��6q   
�������$��Center=�6�   ��6�     *Close+6�   5V   #   5X      5Z      5[      �� 5]      -   5        $ btnAddMagacin��5]      
�������$��1��6[   $��Dodaj��6h   $��40��6x   $��80��6�   $��Right=�6�   $��Bottom=�6�   $��
0,10,20,10q�6�   �� 5^      -   5        $ 	btnOsvezi��5^      
�������$��1��6S   $��Osveži��6`   $��40��6q   $	��100��6}   $��Right=�6�   $��Bottom=�6�   $��0,10,150,10q�6�   5`      5a      5b      