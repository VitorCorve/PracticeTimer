   M S B A M L   `   `   `  ����C  ?WPFTimer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPFTimerWPFTimer  5   	   7 clr-namespace:WPFTimer.ViewModelWPFTimer.ViewModel  5   	   /clr-namespace:WPFTimer.ModelWPFTimer.Model  5	   	       WPFTimer.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPFTimer     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   )vm clr-namespace:WPFTimer.ViewModel  5   	   (modelclr-namespace:WPFTimer.Model  5	   	   -   5          � Title$  Practice��5   	   $	��400��6   $	��780��6'    � 
ResizeMode$ NoResize=�63    � WindowStyle$
 None=�6I   
������  � DataContext 5      ,   &WPFTimer.ViewModel.MainWindowViewModel  5   
    � 	Resources 5       �� 
TargetType �� Property �� Value �� ImageSource	 �� 
TargetType
 �� Triggers P� Property P� Value N� EnterActions �� TargetProperty	 �� To g� Duration N� ExitActions W� From	 W� To g� AutoReverse g� RepeatBehavior'   !WPFTimer.Model.TimeTicksConverter   TickConverter��%5  '��       '�� k    &	      �� 5   
   " ��6   .�5      ��  � ��
 ���� 6+   �� 5       � ��
 �����6+   �� 5       � ��
 ���� 6,   �� 5       � ��$ 35��6*   �� 5       � �� 5      �� 5      $ /Images/buttonBG.png��6!   5      �� 5       � �� 5      �� 5      "	 ��6&   .R�5      � .+�5      �� #��z��6%   ._�5   "   �� $��Center=�63   $��Center=�6P   5       5!      5"      5$      
 5%      P� 5&       �@J�IsMouseOver$
 True��61    5'      �� 5(      .��5)      �� .��5*   "   �� $1 +(Button.Foreground).(SolidColorBrush.Color)�61    	#FF0693B26y   $ 0:0:0.3D�6�   5+      5,       5.      �� 5/      .��50      �� .��51   "   �� $1 +(Button.Foreground).(SolidColorBrush.Color)�61   	 White6y   $ 0:0:0.3D�6�   52      53      55      P� 56       �@J�IsMouseOver$
 True��62    57      �� 58      .��59      �� .��5:   "   W� $ Opacity�5;   %    15<   %    0.55=   %   $ 0:0:1D�5>   %   $
 True��66   $ Forever��6I   5?      5@      5B      5D      �� 5E   
   " ��6   .�5F      ��  � ��
 �   �6+   �� 5G       � ��$ 16(�6)   �� 5H       � ��$ 	Agency FB)�6+   5I        5J   
   6#   5K      .��5L      �  � ColumnDefinitions 5M   
   �� 5N      �� 5O      .+�5Q   
   r� $��2��6    r� Source$ /bgPlay.mp4?�6+    r� Stretch$
 Fill=�6@   � 5R   
   $
��Left=�6   $��10q�6*   
������  � RowDefinitions 5S      �� 5T      �� 5U      .+�5W      �� .+�5X      �� $��Today��6   $
��Left=�6)   �� 5Y       �� Orientation$ 
Horizontal=�6   $
��Left=�66   .+�5Z      �� $��Center=�6y   ��6    �� *CountService.Model.HoursToday+ �� 	Converter# [  6y   �� 5[      $��Center=�6�   ��6    �� *!CountService.Model.MinutesToday+ �� StringFormat$
 :{0}��# [  6�   �� 5\      $��Center=�6�   ��6    �� *!CountService.Model.SecondsToday+$
 :{0}��# [  6�   5]      5^      �� 5_      -   5         ��Name$ NotificationElement��5_      $��/Images/onPlay.png��61   $��35��6M    J� RenderTransformOrigin$ .5,.5&�6X   $��1��6�   $��Bottom=�6�   {�6v   �� *IsOnPlayImageEnabled+z�5`      �� 5a       �� Angle$ 0Q�6&   ��5c      �� 5d      
 5e      P� 5f       � {�$
 True��6A    5g   "   �� 5h   &   .��5i   *   �� .��5j   .   W� $ RenderTransform.Angle�5k   %    05l   %    3605m   %   $ 0:0:0.5D�5n   %   $ Forever��5o   %   5p   +   5q   '    5s   "   �� 5t   &   .��5u   *   �� .��5v   .   W� $ RenderTransform.Angle�5w   %    05x   %    05y   %   $ 0:0:0.5D�5z   %   $ Forever��5{   %   5|   +   5}   '   5      5�      5�      5�      � 5�   
   $��1��6   $��Right=�6   $��10q�6;    5�      �� 5�      �� 5�       5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      .+�5�      �� $��Right=�6   .+�5�      �� $��Total��6   $��Right=�6)   �� 5�      $ 
Horizontal=�6   .+�5�      �� $��Center=�6y   ��6    �� *CountService.Model.HoursTotal+# [  6y   �� 5�      $��Center=�6�   ��6    �� *!CountService.Model.MinutesTotal+$
 :{0}��# [  6�   �� 5�      $��Center=�6�   ��6    �� *!CountService.Model.SecondsTotal+$
 :{0}��# [  6�   5�      5�      �� 5�      $��1��6r   $��Right=�6   ��6   �� *$"CountService.Model.HoursInThisWeek+$ Hours in this week: {0}��6   �� 5�      $��2��6t   $��Right=�6�   ��6   �� *%#CountService.Model.HoursInThisMonth+$ Hours in this month: {0}��6�   �� 5�      $��3��6d   $��Right=�6q   ��6   �� *CountService.Model.DaysTotal+$ Days total: {0}��6q   �� 5�      $��4��6f   $��Right=�6s   ��6   �� *CountService.Model.WeeksTotal+$ Weeks total: {0}��6s   �� 5�      $��5��6f   $��Right=�6s   ��6   �� *CountService.Model.MontsTotal+$ Monts total: {0}��6s   �� 5�      -   5          ��Name$  EngageElement��5�      $��6��5�      $	��125��6   ! K� ZIndex$! 1��5�      $��50��5�      
�������$��0q�5�      
������ $��	Agency FB)�5�      $��16(�5�      ��5�      �� *	Statement+.  (System.Windows.Interactivity.Interaction"   Triggers" 5�      /  )System.Windows.Interactivity.EventTrigger  5�      #   	EventName$ # PreviewMouseLeftButtonDown��6%   .  (System.Windows.Interactivity.TriggerBase$   Actions.$ 5�      6  0System.Windows.Interactivity.InvokeCommandAction  %   Command% 60   �� *Engage+5�      & J� InputBindings& 5�      �� 5�      
' �� Key$' Space��6!   ( �� Command( 6-   �� *Engage+�� 5�      $	' Esc��6!   ( 6+   �� *Exit+��5�      �� 5�      $ /Images/buttonBG.png��6!   5�      5�      5�      5�      