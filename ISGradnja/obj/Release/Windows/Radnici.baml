   M S B A M L   `   `   `  ���� D  @ISGradnja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ISGradnja.WindowsISGradnja.Windows      ISGradnja.Windows.Radnici   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  +localclr-namespace:ISGradnja.Windows  .���   � RowDefinitions  �� $��* ��� $��60 �.+�&   System.Windows.Controls.DataGrid  -     Name$ radniciDataGrid��$��0��   AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .    CanUserReorderColumns .    CanUserSortColumns .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ RB��1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *id+  $ Ime i Prezime��	 �� *ime_prezime+  $ Adresa��	 �� *adresa+  $ Broj telefona��	 �� *broj_telefona+  $
 JMBG��	 �� *jmbg+  $ 	Delatnost��	 �� *	delatnost+  $ 
Gradiliste��	 �� *
gradiliste+4  .System.Windows.Controls.DataGridTemplateColumn  
   CellTemplate
 �� .R���  ��Name$ btnDel��-   $��30��$��50��
�������$��Center=���0  *MaterialDesignThemes.Wpf.PackIconExtension  *Close+  
 �� .R��� $ btnEdit��-   $��30��$��50��
�������$��Center=���  *Edit+�� -   $ btnAdd��
�������$��1��$��Dodaj��$��40��$��80��$��Right=�$��Bottom=�$��	0,0,20,20q��� -   $ 
btnRefresh��
�������$��1��$��Osveži��$��40��$��80��$��Right=�$��Bottom=�$��
0,0,150,20q�