   M S B A M L   `   `   `  ���� D  @ISGradnja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ISGradnja.WindowsISGradnja.Windows      ISGradnja.Windows.Magacin   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  +localclr-namespace:ISGradnja.Windows  .���   � RowDefinitions  �� $��* ��� $��* �.+�� $��0��.+��� $	��Top=�
���   �$��Center=� $   MaterialDesignHeadline5TextBlock#��[  $��Dostupno���� $��1q����	#FF5C99D6._�&   System.Windows.Controls.DataGrid  -     Name$ magacinDataGrid��$��0��   AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .    CanUserSortColumns . $��0,35,0,0q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ RB��1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *id+  $ Naziv stavke��	 �� *naziv+  $ Merna jedinica��	 �� *merna_jedinica+  $ 	Količina��	 �� *
kolicina+  $ Dostupno��	 �� *
dostupno+4  .System.Windows.Controls.DataGridTemplateColumn  
   CellTemplate
 �� .R���  ��Name$ btnDel��-   $��30��$��50��
�������$��Center=���0  *MaterialDesignThemes.Wpf.PackIconExtension  *Close+  
 �� .R��� $ btnEdit��-   $��30��$��50��
�������$��Center=���  *Edit+  
 �� .R��� $ btnRaspodela��-   $��30��$��50��
�������$��Center=���  *Send+� $��1��  �� $��* ��� $��60 �.+��� $	��Top=�
���   �$��Center=�#��[  $��	Raspodela���� $��1q����	#FF5C99D6._�  -   $ magacinRaspodelaDataGrid��$��0�� .   .   .   .  . $��0,35,0,0q�   $ RB��	 �� *id+  $ Naziv stavke��	 �� *naziv+  $ Gradilište��	 �� *
gradiliste+  $ 	Količina��	 �� *
kolicina+  
 �� .R��� $ btnDelRaspodela��-   $��30��$��50��
�������$��Center=���  *Close+�� -   $ btnAddMagacin��
�������$��1��$��Dodaj��$��40��$��80��$��Right=�$��Bottom=�$��
0,10,20,10q��� -   $ 	btnOsvezi��
�������$��1��$��Osveži��$��40��$	��100��$��Right=�$��Bottom=�$��0,10,150,10q�