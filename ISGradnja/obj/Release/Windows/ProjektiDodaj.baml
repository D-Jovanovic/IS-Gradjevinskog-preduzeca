   M S B A M L   `   `   `  ���� D  @ISGradnja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ISGradnja.WindowsISGradnja.Windows  %    ISGradnja.Windows.ProjektiDodaj   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:ISGradnja.Windows     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��500��$	��600��  � 
ResizeMode$  NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�$��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�   MaterialDesignPaper#���     MaterialDesignFont#���  .���� $��1q����	#FF5C99D6._�� .+�� -   $��60��$	��Top=����	#FF5C99D6 J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 1Q�   ShadowDepth$ 1Q�   Color$ 	#FFACACAC��.+��� 	 �� Orientation$	 
Horizontal=�$��Right=�.+��� -   
 ��Name$
 btnClose��$��Right=�$��30��$��30��$��0q�
���������Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=��� -    ��Name$ naslov��$$��IS Gradjevina - Dodaj projekat��$��Center=�$��Center=�$��22(�
�������� $	��440��$��Bottom=� � ColumnDefinitions �� $��* ��� $��* � � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� -    ��Name$ txtNaziv��$��0��$��0��$��10q�
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Naziv projekta�� % !MaterialDesignFloatingHintTextBox#��[ $��Center=��� -   $ txtInvestitor��$��0��$��1��$��10q�
�������$ 
Investitor��#��[ $��Center=��� -   $ 	txtAdresa��$��1��$��0��$��10q�
�������$ Adresa��#��[ $��Center=��� -    ��Name$ cmbTip��$��1��$��1��$��10q�$��35��
�������$	 Tip��$��Center=��� -   $ txtSpratnost��$��2��$��0��$��10q�
�������$ 	Spratnost��#��[ $��Center=�(  "System.Windows.Controls.DatePicker  -	     Name$ 	dpPocetak��$��3��$��0��$��10q�
�������$ Početak��$��Center=� ( $MaterialDesignFloatingHintDatePicker#��[   -
   $ dpRok��$��3��$��1��$��10q�
�������$	 Rok��$��Center=�#��[ �� -   $ txtDokumenta��$��Center=�$��0��$��4��$��Dokumenta: ��$��Center=�$��23(��� -   $
 btnDoc1��$��0��$��5��$
��Left=�$��Dodaj prvi dokument��
������ 
������ 
����  ��� -   $
 btnDoc2��$��0��$��6��$
��Left=�$��Dodaj drugi dokument��
������ 
������ 
����  ��� -   $
 btnDoc3��$��0��$��7��$
��Left=�$��Dodaj treći dokument��
������ 
������ 
����  ��� -   $
 btnAdd��
������� � ToolTip$ Enter��$��2��$��7��$��Dodaj��$��40��$��80��$��Right=�$��Center=�$��
0,8,10.4,8q�