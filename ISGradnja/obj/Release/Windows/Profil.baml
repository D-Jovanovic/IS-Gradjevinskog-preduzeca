   M S B A M L   `   `   `  ���� D  @ISGradnja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ISGradnja.WindowsISGradnja.Windows      ISGradnja.Windows.Profil   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:ISGradnja.Windows     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��400��$	��600��  � 
ResizeMode$  NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�$��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�   MaterialDesignPaper#���     MaterialDesignFont#���  .���� $��1q����	#FF5C99D6._�� .+�� -   $��60��$	��Top=����	#FF5C99D6 J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 1Q�   ShadowDepth$ 1Q�   Color$ 	#FFACACAC��.+��� 	 �� Orientation$	 
Horizontal=�$��Right=�.+��� -   
 ��Name$
 btnClose��$��Right=�$��30��$��30��$��0q�
���������Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=��� $��IS Gradjevina - Profil��$��Center=�$��Center=�$��22(�
�������� $	��340��$��Bottom=� � ColumnDefinitions �� $��* ��� $��* � � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� -    ��Name$ txtUsername��$��0��$��1��$��	10,0,10,0q�
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Korisničko ime�� % !MaterialDesignFloatingHintTextBox#��[ $��Center=��� -   $ txtPassword��$��1��$��1��$��	10,0,10,0q�
�������$ Lozinka��#��[ $��Center=��� -   $ txtFullName��$��2��$��1��$��	10,0,10,0q�
�������$ Puno ime��#��[ $��Center=��� -   $ txtPhoneNumber��$��3��$��1��$��	10,0,10,0q�
�������$ Broj telefona��#��[ $��Center=��� -   $ txtEmail��$��4��$��1��$��	10,0,10,0q�
�������$ Email��#��[ $��Center=��� $��0��$��2��$��Bottom=�$��Center=� $  MaterialDesignHeadline4TextBlock#��[ $��Dozvola���� -    ��Name$ txtRola��$��0��$��3��$	��Top=�$��Center=� $  MaterialDesignHeadline5TextBlock#��[ $�� ���� -	   $
 btnEdit��
������� � ToolTip$ Enter��$��1��$��5��$��Izmeni��$��40��$��80��$��Right=�$��Center=�$��0,0,10,0q�