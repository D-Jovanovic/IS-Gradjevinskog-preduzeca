   M S B A M L   `   `   `  ����D  @ISGradnja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ISGradnja.WindowsISGradnja.Windows  5          ISGradnja.Windows.Radnici   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      +localclr-namespace:ISGradnja.Windows  5      .��5
      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��60 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ radniciDataGrid��5      $��0��6,      AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .    CanUserReorderColumns .    CanUserSortColumns .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ RB��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� *id+  5      $ Ime i Prezime��6%   	 6<   �� *ime_prezime+  5      $ Adresa��6%   	 65   �� *adresa+  5      $ Broj telefona��6%   	 6<   �� *broj_telefona+  5      $
 JMBG��6%   	 63   �� *jmbg+  5      $ 	Delatnost��6%   	 68   �� *	delatnost+  5      $ 
Gradiliste��6%   	 69   �� *
gradiliste+4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5      �� 5      .R�5      ��  ��Name$ btnDel��6%   -   5        $��30��5   K   $��50��6W   
�������$��Center=�6v   ��6�   0  *MaterialDesignThemes.Wpf.PackIconExtension  *Close+6�   5      5        5       
 5!      �� 5"      .R�5#      �� $ btnEdit��6%   -   5        $��30��5#   M   $��50��6Y   
�������$��Center=�6x   ��6�     *Edit+6�   5$      5&      5(      �� 5*   
   -   5        $ btnAdd��5*      
�������$��1��6I   $��Dodaj��6V   $��40��6f   $��80��6r   $��Right=�6}   $��Bottom=�6�   $��	0,0,20,20q�6�   �� 5+   
   -   5        $ 
btnRefresh��5+      
�������$��1��6Q   $��Osveži��6^   $��40��6o   $��80��6{   $��Right=�6�   $��Bottom=�6�   $��
0,0,150,20q�6�   5-      5.      