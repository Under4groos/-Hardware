   M S B A M L   `   `   `  ����C  ?Hardware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HardwareHardware  5   	   5clr-namespace:Hardware.ControlsHardware.Controls  6.       Hardware.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Hardware     5   	   4Controlsclr-namespace:Hardware.Controls     6.      WindowStyle#���   5        � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   � $	��Top=�6   $��30��6'   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5         Hardware.Controls.LBorder  -   5          Name$
 bmin��5   #      Content$	 ��61     DefButtonStyleBorderHover#��[ 6E     SegoeMDL2StyleLabelText   
LabelStyle# [ 6x   $��48��6�     5      -   5        $
 bmax��5   #   $	 ��61   #��[ 6E   # [ 6x   $��48��6�     5      -   5        $ bclose��5   #   $	 ��63     CloseButtonStyleBorderHover#��[ 6G   # [ 6|   $��48��6�   5      5      � 5   
   $��8,35,8,8q�6   .+�5      �� -   5         ��Name$ ComboBoxKeys��5   "   $��5q�6     ComboBoxFlatStyle#���  68   $	��Top=�5      $	��200��6/   $
��Left=�5      $��25��62   6>   �� 5      -   5         ��Name$ listboxitems��5      $��0,35,0,0q�6,   $��Disabled=�5      $��Disabled=�5        ListBoxStyle#���  5        _ListBoxItemStyle_hover#���  5      5      �� 5      $��2,0,0,0q�6   ���#881798$��5,0,5,5q�6E   $��Bottom=�6V   ���	#E5212121$��Right=�6�   ._�5      � .+�5      �� -   5         ��Name$ list_inf��5   !   $��5q�63   $��Stretch=�6>   $
��Left=�6Z   .+�5        -   5        $	 Key��5   +   $
 Key:��68      FontSize$ 14Q�6G   	   LabelForeground
	 �����$
��Left=�6o   6�     5       -   5        $
 Name��5    +   $ Addres��69   $ 14Q�6J   
	 �����$
��Left=�6r   6�     5!      -	   5        $ Value��5!   +   $ 	Value: 64��6:   $ 14Q�6O   
	 �����$
��Left=�6w   6�     5"      -
   5        $
 Type��5"   +   $ Type: string��69   $ 14Q�6P   
	 �����$
��Left=�6x   6�   5#        5$      $y�	Collapsed=�6'   $ 
To C# code��6>     StyleBorderHover#���  6S   $ 14Q�6~   
	 �����$��Right=�6�   $��Bottom=�6�   $��25��6�   $��80��6�   6�   5&      5'      5)      �� 5*   
   -   5        
 ��Name$
 resizeborder��5*      $��20��6'   $��20��62   $��Right=�6>   $��Bottom=�6Z   ���	#02FFFFFF J� Opacity$	 0.1Q�6�   6�   5,      5-      