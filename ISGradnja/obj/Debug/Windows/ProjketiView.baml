   M S B A M L   `   `   `  ����D  @ISGradnja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ISGradnja.WindowsISGradnja.Windows  5   	   $    ISGradnja.Windows.ProjketiView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ISGradnja.Windows     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��500��5   	   $	��600��6     � 
ResizeMode$  NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignPaper#���   5   	     MaterialDesignFont#���  5   	   .��5      �� $��1q�6   ���	#FF5C99D6._�5   
   � .+�5      � -   5        $��60��5      $	��Top=�6   ���	#FF5C99D6 J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 1Q�6'      ShadowDepth$ 1Q�66      Color$ 	#FFACACAC��6F   .+�5      �� 	 �� Orientation$	 
Horizontal=�6   $��Right=�66   .+�5      �� -   5        
 ��Name$
 btnClose��5      $��Right=�6F   $��30��6b   $��30��6m   $��0q�6�   
���������6y   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�62   5       5!      �� 5"      -   5         ��Name$ naslov��5"      $��IS Gradjevina - Projekat��6,   $��Center=�6L   $��Center=�6i   $��22(�6�   
�������6�   5#      � 5%      $	��440��6   $��Bottom=�6     � ColumnDefinitions 5&      �� 5'      $��* �6'   �� 5(      $��* �6'    � RowDefinitions 5*      �� 5+      $��* �6$   �� 5,      $��* �6$   �� 5-      $��* �6$   �� 5.      $��* �6$   �� 5/      $��* �6$   �� 50      $��* �6$   �� 51      $��* �6$   �� 52      $��* �6$   .+�55      �� -   5         ��Name$ txtNaziv��56       �� 
IsReadOnly . $��0��58      $��0��59      $��10q�5:      
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Naziv projekta��5<       % !MaterialDesignFloatingHintTextBox#��[ 5=      $��Center=�5>      �� 5@      -   5        $ txtInvestitor��5A       . $��0��5C      $��1��5D      $��10q�5E      
�������$ 
Investitor��5G      #��[ 5H      $��Center=�5I      �� 5K      -   5        $ 	txtAdresa��5L       . $��1��5N      $��0��5O      $��10q�5P      
�������$ Adresa��5R      #��[ 5S      $��Center=�5T      �� 5V      -   5        $ txtTip��5W       . $��1��5Y      $��1��5Z      $��10q�5[      
�������$	 Tip��5]      #��[ 5^      $��Center=�5_      �� 5a      -   5        $ txtSpratnost��5b       . $��2��5d      $��0��5e      $��10q�5f      
�������$ 	Spratnost��5h      #��[ 5i      $��Center=�5j      �� 5l      -	   5        $ 
txtPocetak��5m       . $��3��5o      $��0��5p      $��10q�5q      
�������$ Početak��5s      #��[ 5t      $��Center=�5u      �� 5w      -
   5        $ txtRok��5x       . $��3��5z      $��1��5{      $��10q�5|      
�������$	 Rok��5~      #��[ 5      $��Center=�5�      �� 5�      -   5        $ txtDokumenta��5�      $��Right=�5�      $��0��5�      $��4��5�      $��Dokumenta: ��5�      $��Center=�5�      $��23(�5�      �� 5�      -   5        $
 btnDoc1��5�      $��1��5�      $��5��5�      $
��Left=�5�      $��ime dokumenta��5�      
������ 
������ 
����  �5�      �� 5�      -   5        $
 btnDoc2��5�      $��1��5�      $��6��5�      $
��Left=�5�      $��ime dokumenta��5�      
������ 
������ 
����  �5�      �� 5�      -   5        $
 btnDoc3��5�      $��1��5�      $��7��5�      $
��Left=�5�      $��ime dokumenta��5�      
������ 
������ 
����  �5�      5�      5�      5�      5�      