   M S B A M L   `   `   `  ����  MinerClient    MinerClient.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          �Name$  Miner��5   	    � Title$ 
MainWindow��5   	   $	��360��6   $	��290��6)   $��Center=�6N    � 
ResizeMode$ NoResize=�6r    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5        New��   Command$ ApplicationCommands.New��5   &   .��5      � .+�5
   
   o� $	��Top=�6   $��20��6'   $��3��63   .@�5      m� -   5         m�Name$ MI��5      $
��File��6#   .@�5      m� $	��New��6   .@�5      m� -   5        $
��Easy��5      6-   m� 5      -   5        $��Normal��5      6/   m� 5      -   5        $
��Hard��5      6-   5      �� 5      m� 5      -   5        $
��Exit��5      5      5      5      �� 5   
   -   5         ��Name$ cnvMain��5      $��Center=�6"   $��1��6?   $��0,50,0,0q�6O   � 5   
   -	   5         �Name$ 	gridPanel��5      $
��Left=�6"   $��30��6=   $��0,20,0,0q�6I   $	��Top=�6[    � ColumnDefinitions 5      �� 5      $
��100* �6#   �� 5      $	��50* �6#   �� 5      $
��300* �6#   �� 5      $	��50* �6#   �� 5      $
��120* �6#   .+�5       �� -
   5        	 ��Name$	 btnMiner��5       $��RightToLeft=�6=   $	��Top=�6Y   $��30��6q   $��2��6}   $��36��6�   .��5!      �� $��Images/new_game.jpg��6   $��30��65   $��Center=�6@   5"      �� 5#      $��Images/clock.jpg��6   $��30��6.   $��0��6:   $��Right=�6J   $��0,0,5,0q�6f   �� 5$      -   5        
 ��Name$
 lblTimer��5$      $��0��6&   $
��Left=�62   $��1��6M   $��0q�6]   $��Center=�6i   $��5,0,0,0q�6�   �� 5%      -   5        $
 lblFlags��5%      $
��Left=�6&   $��4��6A   $��0q�6Q   $��Center=�6]   $	��5,0q�6x   �� 5&      $��Images/bomb.jpg��6   $��30��6-   $��3��69   $��Right=�6I   5'      �� 5(   
   -   5         ��Name$ 
NamePlayer��5(      $��Right=�6&   $��20��6B    �� TextWrapping$
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $��	0,-1,75,0q�6�   $��UserName��6�   �� 5)   
   -   5        $	 btnEnter��5)      $��Enter��6#   $��20��63   $��Right=�6?   $	��Top=�6[   $��75��6s   $��0,-1,0,0q�6~   6�   �� 5*   
   -   5        $	 ButExi��5*      $
��Exit��6!   $��Right=�60   $��75��6L   $��0,-1,0,0q�6W   $��20��6~   $	��Top=�6�   $y�Hidden=�6�   5+      5,      