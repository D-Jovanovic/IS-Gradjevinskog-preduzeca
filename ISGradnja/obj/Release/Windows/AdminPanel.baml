   M S B A M L   `   `   `  ���� D  @ISGradnja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ISGradnja.WindowsISGradnja.Windows  "    ISGradnja.Windows.AdminPanel   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:ISGradnja.Windows     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��400��$	��600��  � 
ResizeMode$  NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�$��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�   MaterialDesignPaper#���     MaterialDesignFont#���  .���� $��1q����	#FF5C99D6._�� .+�� -   $��60��$	��Top=����	#FF5C99D6 J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 1Q�   ShadowDepth$ 1Q�   Color$ 	#FFACACAC��.+��� 	 �� Orientation$	 
Horizontal=�$��Right=�.+��� -   
 ��Name$
 btnClose��$��Right=�$��30��$��30��$��0q�
���������Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=��� $!��IS Gradjevina - Admin panel��$��Center=�$��Center=�$��22(�
�������� $	��337��$��70��$��Bottom=�$
��Left=�
�������.+��� -    ��Name$ ListViewMenu�����	#FF5C99D6$��Disabled=�.@��� -    ��Name$ ItemAddUser��$��60�� � ToolTip$ Dodavanje korisnika��.���� $	 
Horizontal=�.+�  $ UserAdd=�$��25��$��25��$��10q��� -   $ ItemAddPolja��$��60��$ Dodavanje polja��.���� $	 
Horizontal=�.+�  $ AddThick=�$��25��$��25��$��10q�� -    �Name$ userAddGrid��$	��340��$	��530��$��Bottom=�$��Right=�$y�Visible=� � ColumnDefinitions �� $��* ��� $��* � � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� -    ��Name$ txtUsername��$��0��$��0��$��	10,0,10,0q�
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Korisničko ime�� % !MaterialDesignFloatingHintTextBox#��[ $��Center=��� -   $ txtPassword��$��0��$��1��$��	10,0,10,0q�
�������$ Lozinka��#��[ $��Center=��� -	   $ txtFullName��$��1��$��0��$��	10,0,10,0q�
�������$ Puno ime��#��[ $��Center=��� -
   $ txtPhoneNumber��$��1��$��1��$��	10,0,10,0q�
�������$ Broj telefona��#��[ $��Center=��� -   $ txtEmail��$��2��$��0��$��	10,0,10,0q�
�������$ Email��#��[ $��Center=��� -    ��Name$ cmbRole��$��2��$��1��$��	10,0,10,0q�
�������$��35��$ Dozvola��.@��� $
��Gost���� $��Radnik���� $��Admin���� -   $
 btnAdd��
�������$ Enter��$��1��$��5��$��Dodaj��$��40��$��80��$��Right=�$��Center=�$��0,0,10,0q�� -   $ userTableGrid��$	��337��$	��530��$��Bottom=�$��Right=�$y�Hidden=� �� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+�&   System.Windows.Controls.DataGrid  -     Name$ userTableDataGrid��   AutoGenerateColumns .    CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .    CanUserSortColumns . $��2��$��5���� -   $
 
btnDelUser��
�������$ Enter��$��1��$��5��$��Obrisi��$��40��$��80��$��Right=�$��Center=�$��0,0,10,0q�� -   $ poljaAddGrid��$	��337��$	��530��$��Bottom=�$��Right=�$y�Hidden=� �� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+�  -   $ delatnostiDataGrid�� .   .   .   .  . $��0��$��4��$��0,0,10,0q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Naziv delatnosti��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *naziv+4	  .System.Windows.Controls.DataGridTemplateColumn	   	  CellTemplate �� .R��� $
 btnDelDelatnosti��-   
�������$��Center=�$��X��  -   $ tipObjektaDataGrid�� .   .   .   .  . $��1��$��4��$��0,0,10,0q�   $ Tip objketa�� �� *naziv+	   �� .R��� $
 	btnDelTip��-   
�������$��Center=�$��X���� -   $ txtDelatnost��$��4��$��0��$��	10,0,10,0q�
�������$ 	Delatnost��#��[ $��Center=��� -   $ txtTipObjekta��$��4��$��1��$��	10,0,10,0q�
�������$ Tip objekta��#��[ $��Center=��� -   $
 btnAddTipObjekta��
�������$ Enter��$��1��$��5��$��Dodaj��$��40��$��80��$��Right=�$��Center=�$��0,0,10,0q��� -   $
 btnAddDelatnost��
�������$ Enter��$��0��$��5��$��Dodaj��$��40��$��80��$��Right=�$��Center=�$��0,0,10,0q�