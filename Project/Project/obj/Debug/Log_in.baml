   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5   	       Project.Log_in   5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Project     5   	     � WindowStartupLocation$  CenterScreen=�5	       � Title$ Log in��5
   	   $	��383��6   $��499.333��6&    � 
ResizeMode$ NoResize=�66   ��5      �� 5   
    �� ImageSource$ Resources/BACK.jpg��6   .��5      � $��0,-1,0,1q�6    � ColumnDefinitions 5   
   �� 5      .+�5   
   �� $��Login��6   $
��Left=�6    $��
279,85,0,0q�6;   $	��Top=�6O   $��30��6g   $��46��6s   $��Calibri Light)�6~   $��16(�6�   �� 5   
   $��Password��6   $
��Left=�6#   $��258,141,0,0q�6>   $	��Top=�6S   $��25��6k   $��69��6w   $��16(�6�   $�� Calibri light)�6�   �� 5   
   -   5         ��Name$ login��5      $
��Left=�6!   $��28��6<   $��
332,83,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��140��6�    �� 
CaretBrush �	#FF2247C56�   G� 5   
   -   5         G�Name$ password��5      $
��Left=�6(   $��332,140,0,0q�6C   $	��Top=�6X   $��28��6p   $	��140��6|   	 G� 
CaretBrush	 �	#FF2247C5
���   �6�   �� 5   
   $��Log in��6   $
��Left=�6!   $��
258,34,0,0q�6<   $	��Top=�6P   $��34��6h   $��67��6t   
 � Cursor$

 None��6   ���	#DD0C248F$��20(�6�   $��Calibri Light)�6�   �� 5   
   -   5         ��Name$ enter��5      $
��Left=�6    $��33��6;   $��387,200,0,0q�6G   $	��Top=�6\   $��79��6t   ���	#FF0064A0���	#FF005064.��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Login=�6&   $��30��63   $��34��6?   $��Center=�6J   $��Center=�6g   5      �� 5   
   -   5        $ registration��5      $
��Left=�6'   $��33��6B   $��287,200,0,0q�6N   $	��Top=�6c   $��79��6{   ���	#FF0064A0���	#FF005064.��5        $ Register=�6&   $��34��66   $��Center=�6A   $��Center=�6^   $��30��6y   5      �� 5   
   -   5        $ close��5      $
��Left=�6    $��37��6;   $��419,303,0,0q�6G   $	��Top=�6\   $��59��6t   ���	#FF0064A0���	#FF005064 J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5          
BlurRadius$ 1Q�6#      Opacity$	 0.3Q�62      ShadowDepth$ 6Q�6@   .��5"        $ ExitRun=�6&   $��34��65   $��30��6@   ���	#FF00042D$��Center=�6c   $��Center=�6~   5#      5$      5%      