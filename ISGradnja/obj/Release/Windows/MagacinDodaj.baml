   M S B A M L   `   `   `  ���� D  @ISGradnja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ISGradnja.WindowsISGradnja.Windows  $    ISGradnja.Windows.MagacinDodaj   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:ISGradnja.Windows     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��400��$	��600��  � 
ResizeMode$  NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�$��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�   MaterialDesignPaper#���     MaterialDesignFont#���  .���� $��1q����	#FF5C99D6._�� .+�� -   $��60��$	��Top=����	#FF5C99D6 J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 1Q�   ShadowDepth$ 1Q�   Color$ 	#FFACACAC��.+��� 	 �� Orientation$	 
Horizontal=�$��Right=�.+��� -   
 ��Name$
 btnClose��$��Right=�$��30��$��30��$��0q�
���������Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=��� $��IS Gradjevina - Magacin��$��Center=�$��Center=�$��22(�
�������� $	��340��$��Bottom=� � ColumnDefinitions �� $��* ��� $��* � � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� -    ��Name$ txtName��$��1��$��0��$��3��$��10,11,9.2,9.8q�
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Naziv�� % !MaterialDesignFloatingHintTextBox#��[ $��Center=��� -   $ txtKolicina��$��2��$��1��$��10,10.2,9.2,10.6q�
�������$ Kolicina��#��[ $��Center=��� -    ��Name$ cmbMernaJedinica��$��2��$��0��$��9.8,10.4,10.4,10.4q�
�������$��36��$ Merna jedinica��.@��� $	��kom���� $	��lit���� $��kg���� $��m���� -   $
 btnAdd��
������� � ToolTip$ Enter��$��2��$��5��$��Dodaj��$��40��$��80��$��Right=�$��Center=�$��
0,8,10.4,8q�