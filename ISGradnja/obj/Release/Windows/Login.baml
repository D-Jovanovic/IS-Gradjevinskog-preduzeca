   M S B A M L   `   `   `  ���� D  @ISGradnja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ISGradnja.WindowsISGradnja.Windows      ISGradnja.Windows.Login   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:ISGradnja.Windows     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  Login��$	��550��$	��350�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���  .���� $��1q����	#FF5C99D6._��  � RowDefinitions �� $��30 ��� $��* �.+��� ���	#FF2281D1.+��� -    ��Name$ btnClose��$��Right=�$��30��$��30��$��0q�
���������Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�� $��1��.+��� $	��280��$	��Top=����� 	 �� EndPoint$	 0.5,1&�
 �� 
StartPoint$
 0.5,0&�.���  � Color$ 	#FF2281D1��� $ 	#FF34268A�� � Offset$ 1Q�� $ 	#FF33288B��$ 0.546Q��� $	��240��$	��280��$��Bottom=�$
��0,80q� �� RadiusX$ 10�� �� RadiusY$ 10��
������� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 15Q�   	Direction$ 0Q�   RenderingBias$ Quality=�   ShadowDepth$ 1Q�   Color$ 	#FFBBBBBB��� $��Bottom=�$��35,80q�$	��240��.+��� $��Login��$��Center=�$	��Top=�$��5q�
�������$��18(��� $��Center=�$��15q�.+��� -    ��Name$ txtUsername��$
��0,10q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Korisničko ime�� % !MaterialDesignFloatingHintTextBox#��[ $��18(�G� -    G�Name$ txtPassword��$
��0,10q�$ Lozinka�� ) %MaterialDesignFloatingHintPasswordBox#��[ $��18(��� -   $ btnLogin��
�������$	��150��$��Center=�$��Bottom=�$
��0,65q�$��	Uloguj se�� � ToolTip$ Enter���� $��/Res/LoginLogo.png��$	��100��$	��100��$	��Top=�$��30q�