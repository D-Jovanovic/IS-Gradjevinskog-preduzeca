   M S B A M L   `   `   `  ����D  @ISGradnja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ISGradnja.WindowsISGradnja.Windows  5   	       ISGradnja.Windows.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ISGradnja.Windows     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Login��5   	   $	��550��6   $	��350��6$    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      �� $��1q�6   ���	#FF5C99D6._�5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   �� ���	#FF2281D1.+�5      �� -   5         ��Name$ btnClose��5      $��Right=�6>   $��30��6Z   $��30��6e   $��0q�6�   
���������6q   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6*   5       5!      � 5#   
   $��1��6   .+�5$      �� $	��280��6   $	��Top=�6%   ��5%      �� 5&      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5'      �  � Color$ 	#FF2281D1��6#   � 5(      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5)      $ 	#FF33288B��6#   $ 0.546Q�65   5*      5,      �� 5.   
   $	��240��6   $	��280��6!   $��Bottom=�6-   $
��0,80q�6H    �� RadiusX$ 10��6V    �� RadiusY$ 10��6c   
������� J� Effect 5/      3  -System.Windows.Media.Effects.DropShadowEffect  50         
BlurRadius$ 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   52      � 54   
   $��Bottom=�6   $��35,80q�6*   $	��240��69   .+�56      �� $��Login��6   $��Center=�6$   $	��Top=�6A   $��5q�6Y   
�������$��18(�6v   �� 57      $��Center=�6   $��15q�64   .+�58      �� -   5         ��Name$ txtUsername��58      $
��0,10q�6/   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Korisničko ime��6=    % !MaterialDesignFloatingHintTextBox#��[ 6m   $��18(�6�   G� 59      -   5         G�Name$ txtPassword��59      $
��0,10q�63   $ Lozinka��6A    ) %MaterialDesignFloatingHintPasswordBox#��[ 6j   $��18(�6�   5:      5;      �� 5<      -   5        $ btnLogin��5<   ,   
�������$	��150��6U   $��Center=�6a   $��Bottom=�6~   $
��0,65q�6�   $��	Uloguj se��6�    � ToolTip$ Enter��6�   �� 5=      $��/Res/LoginLogo.png��6   $	��100��64   $	��100��6@   $	��Top=�6M   $��30q�6e   5>      5?      5@      5A      