   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5   	       Project.Menu   5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Project     5   	     � WindowStartupLocation$  CenterScreen=�5	       � Title$
 Menu��5
   	   $	��526��6   $	��894��6#    � 
ResizeMode$ NoResize=�6/   .��5      � ���	#FF3A538D.+�5   
   �� -   5         ��Name$ 
loginlabel��5      $��login��6$   $
��Left=�64   $��36��6O   $��	506,8,0,0q�6[   $	��Top=�6n   $��83��6�   $��18(�6�   �� 5   
   -   5         ��Name$ radiost��5       K� ZIndex$ 1��6&   $��0��67   $	��176��6B   $��RightToLeft=�6N   $
��Left=�6j   $	��Top=�6�   ���	#FF0064A0$��6,6,0,0q�6�   $y�Hidden=�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 9Q�6#      ShadowDepth$ 2Q�62   .+�5      �� $��Radio-Stations��6   $
��Left=�6-   $��37��6H   $��13,3,0,0q�6T   $	��Top=�6f   $	��154��6~   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   $��22(�6�   �� 5      -   5        
 ��Name$
 radio1��5      $��Radiopepper��6%   $
��Left=�6;   $��42��6V   $��16,5,0,0q�6b   $	��Top=�6t   $	��145��6�   ���	#FF272C9E
�������$��Calibri Light)�6�   $��20(�6�   $��2q�6  �� 5      -   5        $
 radio2��5      $��Bukovyna��6%   $
��Left=�68   $��42��6S   $��16,5,0,0q�6_   $	��Top=�6q   $	��145��6�   ���	#FF272C9E
�������$��Calibri Light)�6�   $��20(�6�   $��2q�6�   �� 5      -   5        $
 radio3��5      $��	Starlight��6%   $
��Left=�69   $��42��6T   $��16,5,0,0q�6`   $	��Top=�6r   $	��145��6�   ���	#FF272C9E
�������$��Calibri Light)�6�   $��20(�6�   $��2q�6   �� 5      -   5        $
 radio4��5      $��	RadioRock��6%   $
��Left=�69   $��42��6T   $��16,5,0,0q�6`   $	��Top=�6r   $	��145��6�   ���	#FF272C9E
�������$��Calibri Light)�6�   $��20(�6�   $��2q�6   �� 5      -   5        $
 radio5��5      $��UARadio��6%   $
��Left=�67   $��42��6R   $��16,5,0,0q�6^   $	��Top=�6p   $	��145��6�   ���	#FF272C9E
�������$��Calibri Light)�6�   $��20(�6�   $��2q�6�   �� 5      -   5        $
 radio6��5      $��Energy��6%   $
��Left=�66   $��42��6Q   $��16,5,0,0q�6]   $	��Top=�6o   $	��145��6�   ���	#FF272C9E
�������$��Calibri Light)�6�   $��20(�6�   $��2q�6�   �� 5      -	   5        $
 	listradio��5      $��16,5,0,0q�6(   ���	#FF272C9E$��21��6Q   $	��145��6]   $	��Top=�6i   $
��Left=�6�   
�������$��1q�6�   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ ArrowUp=�6*   $��Center=�69   $��Center=�6V   5      5      �� 5   
   -
   5        $
 close��5      $
��Left=�6    $��46��6;   $��785,419,0,0q�6G    J� Opacity$	 100Q�6\   $	��Top=�6j   $��66��6�   ���	#FF3A538D���	#FF005064 5        5      $ 3Q�6#      Opacity$	 0.3Q�62   $ 6Q�6@   .��5         $ ExitRun=�6&   $��31��65   $��30��6@   ���	#FF00042D6L   5!      �� 5"   
   -   5        $
 log_out��5"      $
��Left=�6"   $��33��6=   $��	813,8,0,0q�6I   $	��Top=�6\   $��60��6t   ���	#FF0064A0���	#FF005064.��5#        $ Logout=�6&   $��34��64   $��30��6?   $��Center=�6K   $��Center=�6h   5$      �� 5%   
   -   5        $
 users��5%      $
��Left=�6    $��30��6;   $��
295,11,0,0q�6G   $	��Top=�6[   $	��101��6s   ���	#FF0064A0���	#FF005064$y�Visible=�6�   .��5&        $ Accounts=�6&   $��30��66   $��30��6B   $��Center=�6M   $��Center=�6j   5'      � 5(   
   -   5         �Name$ 	radioinfo��5(      $��42,52,182,149q�6"   $y�Visible=�69   $	 100Q�6N   ��5)      �� 5*       �� ImageSource$ Resources/BACK.jpg��6    �� Opacity$	 0.6Q�6>   .+�5,      A� -   5         A�Name$
 logo��5,      $	��103��6$   $	��102��61   $��	10,10,0,0q�6=   $
��Left=�6P   $	��Top=�6k   $��3��6�   ���#000��5-      �� 5.      -   5        	logoradio��$ Resources/BACK.jpg��5.   4    j� TileMode$
 Tile=�6U   50      �� 51      -   5        $
 name��51      $��Change Radio��6"   $
��Left=�69   $��30��6T   $��
10,112,0,0q�6`   $	��Top=�6t   $	��107��6�   $	 0.5,0.5&�6�   $��15(�6�   �� 52      -   5        $ chast��52      $��30��6#   $��Chastota��6/   $��11,115,539,111q�6B   �� 53      -   5        $ chastota��53      $��30��6&   $��120 Ghz��62   $��71,135,532,133q�6D   $
��Bold"�6\   &   System.Windows.Controls.DataGrid  54      -   5          Name$ rozklad��54      $
��Left=�6(   $	��265��6C   $��
141,10,0,0q�6P   $	��Top=�6d   $	��512��6|   ���	#00000000���	#DDFDFDFD   CanUserResizeColumns .  6�   �� 55      -   5        $
 delfav��55      $y�Hidden=�6%   $
��Left=�69   $��30��6T   $��
36,165,0,0q�6`   $	��Top=�6t   $��65��6�   ��6�   Z� ��6�   Z� .��56        $ Favorite=�6*   $��Center=�6:   $��30��6W   $��30��6c   $��Center=�6n   
������ 6�   57      �� 58      -   5        $
 addfav��58      $y�Visible=�6%   $
��Left=�6:   $��30��6U   $��
36,165,0,0q�6a   $	��Top=�6u   $��65��6�   ��6�   Z� ��6�   Z� .��59        $ FavoriteOutline=�6*   $��Center=�6A   $��30��6^   $��30��6j   $��Center=�6u   
������ 6�   5:         Project.CRating  5;      -   5          Name$	 rat��5;      $
��Left=�6)   $��34��6D   $��	4,204,0,0q�6P   $	��Top=�6c   $	��140��6{   �� 5<      -   5        $
��Left=�5<      $��26��60   $��
76,253,0,0q�6<   $	��Top=�6P   $��46��6h   ���	#FF0064A0���	#FF005064.��5=        $
 Edit=�6*   $��Center=�66   $��Center=�6S   5>      �� 5?      -   5        $
��Left=�5?      $��26��60   $��
11,253,0,0q�6<   $	��Top=�6P   $��46��6h   ���	#FF0064A0���	#FF005064.��5@        $ DeleteForever=�6*   $��Center=�6?   $��Center=�6\   5A      5C      � 5D   
   -   5        $ deluser��5D      $y�Hidden=�6    $��188,51,170,157q�64   .+�5E        -   5        $ userss��5E      $��10,10,297,10q�6'   ���	#00F0FFFF$y�Visible=�6T   5G      �� 5H      -   5        $
 delete��5H      $
��Left=�6%   $��28��6@   $��423,251,0,0q�6L   $	��Top=�6a   $��92��6y   ���	#FF0064A0���	#FF005064.��5I        $ AccountRemove=�6*   $��30��6?   $��30��6K   $��Center=�6V   $��Center=�6s   5J      �� 5K      -   5         ��Name$ userdel��5K      $
��Left=�6'   $��28��6B   $��258,251,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��140��6�   5L      �� 5M   
   -   5        $
 
addprogram��5M      $
��Left=�6%   $��30��6@   $��
401,11,0,0q�6L   $	��Top=�6`   $	��101��6x   ���	#FF0064A0���	#FF005064$y�Visible=�6�   .��5N        $ PlaylistAdd=�6&   $��30��69   $��30��6D   $��Center=�6P   $��Center=�6m   5O      � 5P   
   -   5        $ addprog��5P      $��188,52,170,156q�6    $y�Hidden=�68   ��5Q      �� 5R      $ Resources/BACK.jpg��6   $	 0.6Q�6>   .+�5T      �� $��Name Station��6   $��34��6+   $	��100��67   $��0,15,181,240q�6C   $��13(�6Y   $��Right=�6g   $��Center=�6�   �� 5U      -   5        $ namestation��5U      $
��Left=�6+   $��28��6F   $��
340,10,0,0q�6R   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��152��6�   �� 5V      $��Name Program��6   $	��109��6+   $��0,49,181,205q�67   $��13(�6M   $��Right=�6[   $��Center=�6w   $��35��6�   �� 5W      -    5        $ nameprogram��5W      $
��Left=�6+   $��28��6F   $��
340,44,0,0q�6R   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��152��6�   �� 5X      $��Period��6   $��70��6%   $��0,85,169,174q�60   $��13(�6F   $��Right=�6T   $��Center=�6p   $��30��6�   $	 0.5,0.5&�6�   �� 5Y      -!   5        $ period��5Y      $
��Left=�6&   $��28��6A   $��
340,79,0,0q�6M   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��152��6�   �� 5Z      $��
Hour begin��6   $��35��6)   $��0,119,169,135q�65   $��13(�6L   $��Right=�6Z   $��96��6v   $��Center=�6�   �� 5[      -"   5        $ 	hourbegin��5[      $
��Left=�6)   $��28��6D   $��340,114,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��152��6�   �� 5\      $��Hour end��6   $��32��6'   $��65��63   $��0,154,190,103q�6>   $��13(�6U   $��Right=�6c   $��Center=�6   �� 5]      -#   5        $ hourend��5]      $
��Left=�6'   $��28��6B   $��340,148,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��152��6�   �� 5^      -$   5        $
��Left=�5^      $��29��60   $��410,215,0,0q�6<   $	��Top=�6Q   $��85��6i   ���	#FF0064A0���	#FF005064.��5_        $ AddBox=�6*   $��20��68   $��20��6D   $��Center=�6O   $��Center=�6l   5`      5a        5b   
   -%   5        $ ratings��5b      $
��Left=�6$   $	��258��6?   $	��Top=�6L   $	��180��6d   $��
703,91,0,0q�6p   ���	#00FAFAFA .     CanUserReorderColumns .     CanUserSortColumns .     GridLinesVisibility$
 None=�6�      VerticalGridLinesBrush �	#00000000   HorizontalGridLinesBrush �	#00DEDEDE   HeadersVisibility$
 None=�6T  �� 5c   
   $��Ratings��6   $
��Left=�6"   $��34��6=   $��
770,57,0,0q�6I   $	��Top=�6]   $��78��6u   $	 0.5,0.5&�6�   $��17(�6�   �� 5d   
   -&   5        $
 showfav��5d      $
��Left=�6"   $��30��6=   $��
189,11,0,0q�6I   $	��Top=�6]   $	��101��6u   ���	#FF0064A0���	#FF005064.��5e        $ Favorite=�6&   $��30��66   $��30��6A   $��Center=�6M   $��Center=�6j   5f      � 5g   
   -'   5        $ 	favorites��5g      $��189,52,492,149q�6"   $��0��6:   $ 1��6E   ���	#FF0064A0$y�Hidden=�6m    5h        5i      $ 9Q�6#   $ 2Q�62   .+�5k        -(   5        $ favorit��5k      $��10,34,24,10q�6(   ���	#00F0FFFF$y�Visible=�6T   $	 0.5,0.5&�6i   ���	#DDFFFFFF$��14(�6�   5l      �� 5m      $��	Favorites��6   $
��Left=�6(   $��63,1,0,0q�6C   $	��Top=�6U   $��33��6m   $��80��6y   ���	#DDFFFFFF$��14(�6�   �� 5n      -)   5        $
 closefav��5n      $��24��6'   $��40��63   $��143,5,24,266q�6>   $��Center=�6U   $��Center=�6r   ���	#FF0064A0���	#FF0064A0.��5o        $��20��6*   $��20��66   $ Close=�6A   $��Center=�6N   $��Center=�6k   ���#fff6�   5p      5q      �� 5r   
   -*   5        $
 settings��5r      $
��Left=�6#   $��33��6>   $��	746,8,0,0q�6J   $	��Top=�6]   $��60��6u   ���	#FF0064A0���	#FF005064.��5s        $ Settings=�6&   $��34��66   $��30��6A   $��Center=�6M   $��Center=�6j   5t      �� 5u   
   -+   5        $ kredyts��5u      $��Kredyts��6!   $��30��63   $��
596,12,0,0q�6?   $	��Top=�6S   $��55��6k   $��14(�6v   $
��Left=�6�   $��Italic$�6�   �� 5v   
   -,   5        $ kredyt��5v      $��Kredyt��6    $
��Left=�61   $��29��6L   $��
658,13,0,0q�6X   $	��Top=�6l   $��68��6�   $��14(�6�   ���	#FF43F50F$	��1,0q�6�   ���	#DDFFFFFF6�   � 5w   
   --   5        $ setting��5w      $��0��6    $ 1��6*   ���	#FF0064A0$��628,53,10,116q�6R   $y�Hidden=�6i    5x        5y      $ 9Q�6#   $ 2Q�62   .+�5{      �� $	��130��6   $��35��6    $��6,13,114,280q�6,   $��14(�6B   $
��Bold"�6P   .��6b   Change password6s   G� 5|      -.   5         G�Name$ pass1��5|      $
��Left=�6)   $��
111,51,0,0q�6E   $	��Top=�6Y   $��28��6q   $	��130��6}    G� 
CaretBrush �	#FF2247C5
���   �6�   �� 5}      $��33��6   $��6,55,138,240q�6    $��12(�66   $��Current password��6D   G� 5~      -/   5        $ pass2��5~      $
��Left=�6)   $��	96,88,0,0q�6E   $	��Top=�6X   $��28��6p   $	��130��6|    �	#FF2247C5
���   �6�   �� 5      $��33��6   $��92��6!   $��12(�6,   $��New Password��6;   $��6,92,152,203q�6R   G� 5�      -0   5        $ pass3��5�      $
��Left=�6)   $��115,126,0,0q�6D   $	��Top=�6Y   $��28��6q   $	��130��6}    �	#FF2247C5
���   �6�   �� 5�      $��33��6   $	��110��6"   $��6,130,134,165q�6.   $��12(�6E   $��Confirm password��6T   �� 5�      -1   5        $
 closeset��5�      $��24��6'   $��40��63   $��195,11,15,293q�6>   $��Center=�6V   $��Center=�6s   ���	#FF0064A0���	#FF0064A0.��5�        $��20��6*   $��20��66   $ Close=�6A   $��Center=�6N   $��Center=�6k   ���#fff6�   5�      �� 5�      -2   5        $��30��5�      $	��120��6!   $��117,162,13,134q�6-   $��Center=�6F   $��Center=�6c   ���	#FF0064A0���	#FF0064A0.��5�        $��25��6*   $��30��66   $ PlaylistEdit=�6A   $��Center=�6U   $��Center=�6r   ���#fff6�   5�      �� 5�      $��33��6   $��6,192,132,103q�6    $��14(�67   $
��Bold"�6E   $��Delete Account��6W   G� 5�      -3   5        $ pass4��5�      $
��Left=�6)   $��104,220,0,0q�6E   $	��Top=�6Z   $��25��6r   $	��130��6~    �	#FF2247C5
���   �6�   �� 5�      $��90��6   $��30��6   $��10,224,150,74q�6+   $��12(�6B   $��Your password��6P   �� 5�      -4   5        $��30��5�      $��72��6!   $��146,280,32,18q�6,   $��Center=�6D   $��Center=�6a   ���	#FF0064A0���	#FF0064A0.��5�        $��30��6*   $��30��66   $
 Tick=�6A   $��Center=�6M   $��Center=�6j   ���#fff6�   5�      �� 5�      -5   5        $��30��5�      $��72��6!   $��39,280,139,18q�6,   $��Center=�6D   $��Center=�6a   ���	#FF0064A0���	#FF0064A0.��5�        $��30��6*   $��30��66   $ Close=�6A   $��Center=�6N   $��Center=�6k   ���#fff6�   5�      �� 5�      $	��165��6   $��33��6    $��10,247,75,48q�6,   $��12(�6B   $!��Do you want delete account?��6P   $��Italic$�6v   5�      �� 5�   
   -6   5        $

 down��5�      $
��Left=�6   $��30��6:   $��	12,11,0,0q�6F   $	��Top=�6Y   $	��161��6q   ���	#FF0064A0���	#FF005064$y�Visible=�6�   .��5�        $ 	ArrowDown=�6&   $��30��67   $��30��6B   $��Center=�6N   $��Center=�6k   5�      �� 5�   
   -7   5        $ 	passlabel��5�      $�� ��6#   $
��Left=�6.   $��	506,8,0,0q�6I   $	��Top=�6\   $��18(�6u   $y�Hidden=�6�   �� 5�   
   -8   5          ��Name$  comments��5�      $y�Visible=�6$   $	��Top=�6:   $	��103��6S   $��209,387,229,0q�6`   �� 5�   
   $��Comments��6   $
��Left=�6#   $��175,356,0,0q�6>   $	��Top=�6S   $��84��6k   $��13(�6v   $��35��6�     5�   
   $ Comments=�6"   $��25��62   $��25��6>   $��260,361,0,0q�6I   �� 5�   
   -9   5        $ comment��5�      $
��Left=�6#   $��31��6>   $��312,353,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��277��6�   
�������$��12(�6�   ! �� 
CaretBrush
! �����6�   �� 5�   
   -:   5        $
��Left=�5�      $��26��6,   $��609,355,0,0q�68   $	��Top=�6M   $��97��6e   ���	#FF0064A0���	#FF005064.��5�        $ CommentPlus=�6&   $��Center=�69   $��Center=�6V   5�      � 5�   
   -;   5        $ edits��5�      $��189,50,464,147q�6   $��0��66   $	��233��6A   $ 1��6M   ���	#FF0064A0$y�Hidden=�6u    5�        5�      $ 9Q�6#   $ 2Q�62   .+�5�      �� $
��Edit��6   $
��Left=�6#   $��74,9,0,0q�6>   $	��Top=�6P   $��33��6h   $��50��6t   ���	#DDFFFFFF$��16(�6�   �� 5�      -<   5        $
 	closeedit��5�      $��24��6(   $��40��64   $��161,13,34,260q�6?   $��Center=�6W   $��Center=�6t   ���	#FF0064A0���	#FF0064A0.��5�        $��20��6*   $��20��66   $ Close=�6A   $��Center=�6N   $��Center=�6k   ���#fff6�   5�      �� 5�      $��Name Station��6   $��34��6+   $	��100��67   $��0,59,125,204q�6C   $��13(�6Y   $��Right=�6g   $��Center=�6�   �� 5�      -=   5        $ namest��5�      $
��Left=�6&   $��28��6A   $��
100,53,0,0q�6M   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��118��6�   �� 5�      $��Name Program��6   $	��106��6+   $��0,92,126,168q�67   $��13(�6M   $��Right=�6[   $��Center=�6w   $��35��6�   �� 5�      ->   5        $ namepr��5�      $
��Left=�6&   $��28��6A   $��
100,86,0,0q�6M   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��118��6�   �� 5�      $��Period��6   $��50��6%   $��0,123,136,144q�60   $��13(�6G   $��Right=�6U   $��Center=�6q   $��30��6�   $	 0.5,0.5&�6�   �� 5�      -?   5        $	 per��5�      $
��Left=�6#   $��28��6>   $��100,118,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   �� 5�      $��
Hour begin��6   $��35��6)   $��0,154,132,108q�65   $��13(�6L   $��Right=�6Z   $��81��6v   $��Center=�6�   �� 5�      -@   5        $ hourb��5�      $
��Left=�6%   $��28��6@   $��
99,148,0,0q�6L   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��122��6�   �� 5�      $��Hour end��6   $��32��6'   $��65��63   $��0,186,138,79q�6>   $��13(�6T   $��Right=�6b   $��Center=�6~   �� 5�      -A   5        $ houre��5�      $
��Left=�6%   $��28��6@   $��
99,180,0,0q�6L   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��122��6�   �� 5�      -B   5        $
��Left=�5�      $��29��60   $��410,215,0,0q�6<   $	��Top=�6Q   $��85��6i   ���	#FF0064A0���	#FF005064.��5�        $ AddBox=�6*   $��20��68   $��20��6D   $��Center=�6O   $��Center=�6l   5�      �� 5�      -C   5        $
 
editaccept��5�      $��33��6)   $��93��65   $��73,235,69,29q�6@   $��Center=�6W   $��Center=�6t   ���	#FF0064A0���	#FF0064A0.��5�        $��25��6*   $��25��66   $
 Edit=�6A   $��Center=�6M   $��Center=�6j   ���#fff6�   5�      5�      5�      5�      