   M S B A M L   `   `   `  ����D  @ISGradnja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ISGradnja.WindowsISGradnja.Windows  5   	   #    ISGradnja.Windows.RadnikDodaj   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ISGradnja.Windows     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��400��5   	   $	��600��6     � 
ResizeMode$  NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignPaper#���   5   	     MaterialDesignFont#���  5   	   .��5      �� $��1q�6   ���	#FF5C99D6._�5   
   � .+�5      � -   5        $��60��5      $	��Top=�6   ���	#FF5C99D6 J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 1Q�6'      ShadowDepth$ 1Q�66      Color$ 	#FFACACAC��6F   .+�5      �� 	 �� Orientation$	 
Horizontal=�6   $��Right=�66   .+�5      �� -   5        
 ��Name$
 btnClose��5      $��Right=�6F   $��30��6b   $��30��6m   $��0q�6�   
���������6y   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�62   5       5!      �� 5"      $'��!IS Gradjevina - Dodavanje radnika��6   $��Center=�6E   $��Center=�6b   $��22(�6}   
�������6�   5#      � 5%      $	��340��6   $��Bottom=�6     � ColumnDefinitions 5&      �� 5'      $
��299* �6'   �� 5(      $	��61* �6'   �� 5)      $
��238* �6'    � RowDefinitions 5+      �� 5,      $��* �6$   �� 5-      $��* �6$   �� 5.      $��* �6$   �� 5/      $��* �6$   �� 50      $��* �6$   �� 51      $��* �6$   .+�54      �� -   5         ��Name$ txtFullName��55      $��0��56      $��0��57      $��10,11,9.2,9.8q�58      
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ime Prezime��5:       % !MaterialDesignFloatingHintTextBox#��[ 5;      $��Center=�5<      �� 5=      -   5        $ 	txtAddres��5>      $��0��5?      $��1��5@      $��9.8,11,9.4,9.8q�5A      
�������$ Adresa stanovanja��5C      #��[ 5D      $��Center=�5E      $��2��66   �� 5F      -   5        $ txtJMBG��5G      $��1��5H      $��0��5I      $��10,10.2,9.2,10.6q�5J      
�������$
 JMBG��5L      #��[ 5M      $��Center=�5N      �� 5O      -   5        $ txtPhoneNumber��5P      $��1��5Q      $��1��5R      $��9.8,10.2,9.4,10.6q�5S      
�������$ Broj telefona��5U      #��[ 5V      $��Center=�5W      $��2��66   �� 5X      -   5         ��Name$ cmbDelatnost��5Y      $��2��5Z      $��0��5[      $��10,10.4,10.2,10.4q�5\      
�������$��36��5^      $ 	Delatnost��5_      5`      �� 5a      -   5        $ cmbGradiliste��5b      $��2��5c      $��1��5d      $��9.8,10.4,10.4,10.4q�5e      
�������$��36��5g      $ Angažovan na��5h      $��2��6I   5i      �� 5k      -	   5        $
 btnAdd��5k   i   
������� � ToolTip$ Enter��6,   $��2��6<   $��5��6L   $��Dodaj��6Y   $��40��6�   $��80��6�   $��Right=�6�   $��Center=�6�   $��
0,8,10.4,8q�6�   5m      5o      5p      5q      