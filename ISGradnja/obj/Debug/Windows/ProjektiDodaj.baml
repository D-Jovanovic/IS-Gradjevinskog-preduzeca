   M S B A M L   `   `   `  ����D  @ISGradnja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ISGradnja.WindowsISGradnja.Windows  5   	   %    ISGradnja.Windows.ProjektiDodaj   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ISGradnja.Windows     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��500��5   	   $	��600��6     � 
ResizeMode$  NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignPaper#���   5   	     MaterialDesignFont#���  5   	   .��5      �� $��1q�6   ���	#FF5C99D6._�5   
   � .+�5      � -   5        $��60��5      $	��Top=�6   ���	#FF5C99D6 J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 1Q�6'      ShadowDepth$ 1Q�66      Color$ 	#FFACACAC��6F   .+�5      �� 	 �� Orientation$	 
Horizontal=�6   $��Right=�66   .+�5      �� -   5        
 ��Name$
 btnClose��5      $��Right=�6F   $��30��6b   $��30��6m   $��0q�6�   
���������6y   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�62   5       5!      �� 5"      -   5         ��Name$ naslov��5"      $$��IS Gradjevina - Dodaj projekat��6,   $��Center=�6R   $��Center=�6o   $��22(�6�   
�������6�   5#      � 5%      $	��440��6   $��Bottom=�6     � ColumnDefinitions 5&      �� 5'      $��* �6'   �� 5(      $��* �6'    � RowDefinitions 5*      �� 5+      $��* �6$   �� 5,      $��* �6$   �� 5-      $��* �6$   �� 5.      $��* �6$   �� 5/      $��* �6$   �� 50      $��* �6$   �� 51      $��* �6$   �� 52      $��* �6$   .+�55      �� -   5         ��Name$ txtNaziv��56      $��0��57      $��0��58      $��10q�59      
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Naziv projekta��5;       % !MaterialDesignFloatingHintTextBox#��[ 5<      $��Center=�5=      �� 5?      -   5        $ txtInvestitor��5@      $��0��5A      $��1��5B      $��10q�5C      
�������$ 
Investitor��5E      #��[ 5F      $��Center=�5G      �� 5I      -   5        $ 	txtAdresa��5J      $��1��5K      $��0��5L      $��10q�5M      
�������$ Adresa��5O      #��[ 5P      $��Center=�5Q      �� 5R      -   5         ��Name$ cmbTip��5S      $��1��5T      $��1��5U      $��10q�5V      $��35��5W      
�������$	 Tip��5Y      $��Center=�5Z      �� 5]      -   5        $ txtSpratnost��5^      $��2��5_      $��0��5`      $��10q�5a      
�������$ 	Spratnost��5c      #��[ 5d      $��Center=�5e      (  "System.Windows.Controls.DatePicker  5g      -	   5          Name$ 	dpPocetak��5h      $��3��5i      $��0��5j      $��10q�5k      
�������$ Početak��5m      $��Center=�5n       ( $MaterialDesignFloatingHintDatePicker#��[ 5o        5q      -
   5        $ dpRok��5r      $��3��5s      $��1��5t      $��10q�5u      
�������$	 Rok��5w      $��Center=�5x      #��[ 5y      �� 5{      -   5        $ txtDokumenta��5}      $��Center=�5|      $��0��5~      $��4��5      $��Dokumenta: ��5�      $��Center=�5�      $��23(�5�      �� 5�      -   5        $
 btnDoc1��5�      $��0��5�      $��5��5�      $
��Left=�5�      $��Dodaj prvi dokument��5�      
������ 
������ 
����  �5�      �� 5�      -   5        $
 btnDoc2��5�      $��0��5�      $��6��5�      $
��Left=�5�      $��Dodaj drugi dokument��5�      
������ 
������ 
����  �5�      �� 5�      -   5        $
 btnDoc3��5�      $��0��5�      $��7��5�      $
��Left=�5�      $��Dodaj treći dokument��5�      
������ 
������ 
����  �5�      �� 5�      -   5        $
 btnAdd��5�   i   
������� � ToolTip$ Enter��6,   $��2��6<   $��7��6L   $��Dodaj��6Y   $��40��6�   $��80��6�   $��Right=�6�   $��Center=�6�   $��
0,8,10.4,8q�6�   5�      5�      5�      5�      