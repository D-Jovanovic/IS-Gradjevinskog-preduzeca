   M S B A M L   `   `   `  ���� D  @ISGradnja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ISGradnja.WindowsISGradnja.Windows  $    ISGradnja.Windows.GlavniProzor   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:ISGradnja.Windows     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��600��$
��1200��
�������  � 
ResizeMode$  NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�$��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�   MaterialDesignPaper#���     MaterialDesignFont#���   � 	Resources   OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value  	CloseMenu��%�   &	       &	 q     �� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$	 70Q�  $ 0:0:0.2��$		 200Q��� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$		 200Q�  $ 0:0:0.2��$	 70Q�
 � Triggers
 :�  :� RoutedEvent$ ButtonBase.Click�� :� 
SourceName$ ButtonOpenMenu��.[��� #��[ :� $ ButtonBase.Click��$ ButtonCloseMenu��.[��� #��[ .���� $��1q����	#FF5C99D6._�� .+�� -    �Name$ GridMain��$��Right=�$��Bottom=�$	��540��$
��1130��� -   $��60��$	��Top=����	#FF5C99D6 J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 1Q�   ShadowDepth$ 1Q�   Color$ 	#FFACACAC��.+���  �� Orientation$ 
Horizontal=�$��Right=�.+�'  !MaterialDesignThemes.Wpf.PopupBox     PlacementMode$ BottomAndAlignRightEdges=�   	StaysOpen .  $��10q�   PopupContent. �� $	��150��.+��� -    ��Name$ 	btnProfil��$��Profil�� � ToolTip$ CTRL+O���� -   $ btnAdminPanel��$��Admin panel��$ CTRL+A���� -   $ btnPomoc��$��Pomoć��$ F5���� �� -   $��
Izloguj se��$ ALT+F4���� -    ��Name$ naslovPorzora��$��IS Gradjevina��$��Center=�$��Center=�$��22(�� -   $ GridMenu��$��70��$
��Left=����	#FF31577E   $ 2Q�$ 1Q�$ 	#FFACACAC��.+��� .+�� $	��150��
�������z�V� .~��� �� �� T� .+��� -	   $ ButtonOpenMenu��$��60��$��60��$��Right=�$	��Top=� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ ���	#FF31577E��Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�$��25��$��25���� $��60��$	��200��$��/Res/LogoFinal.png��$
��Left=�$��0,30,0,0q��� -
   $ ButtonCloseMenu��$y�	Collapsed=�$��60��$��60��$��Right=�$	��Top=�#��[ ���	#FF31577E��Z� ��Z� .��  $ 	ArrowLeft=�$��25��$��25���� -    ��Name$ ListViewMenu�����	#FF5C99D6$��Disabled=�.@��� -    ��Name$ ItemProjekti��$��60��$ CTRL+P��.���� $ 
Horizontal=�.+�  $ DriveDocument=�$��25��$��25��$��10q��� $��Projekti��$��Center=�$��20 10q��� -   $ ItemMagacin��$��60��$ CTRL+M��.���� $ 
Horizontal=�.+�  $ Storage=�$��25��$��25��$��10q��� $��Magacin��$��Center=�$��20 10q��� -   $ ItemRadnici��$��60��$ CTRL+R��.���� $ 
Horizontal=�.+�  $ People=�$��25��$��25��$��10q��� $��Radnici��$��Center=�$��20 10q�