   M S B A M L   `   `   `  ����J  FObserverChatter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ObserverChatterObserverChatter  5   	        ObserverChatter.ChatClient   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ObserverChatter     5   	   -   5          � Title$  
ChatClient��5   	   $	��440��6   $	��390��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��29* �6   6+   �� 5      $��30 �6   6*   �� 5      $
��346* �6   6,   �� 5      $	��38* �6   6+    � ColumnDefinitions 5   
   �� 5      $	��42* �6   6-   �� 5      $
��200* �6   6.   �� 5      $��85 �6   6,   �� 5      $	��55* �6   6-   .+�5   
   �� 
�������$��0��6'   $��0��64   $��4��6D   6Z   �� 5   
   -   5         ��Name$ clientNameLabel��5      $	��row��6)   $��0��67   $��0��6D   $��4��6T   $��Center=�6h   �� 5   
   $��Topics of interest:��6   $��1��6.   $��0��6;   6M   �� 5   
   -   5         ��Name$ 
themesText��5      $��1��6&   $��1��63   $��3��6C   $	��5,5q�6W   6�   �� 5   
   -   5         ��Name$ messagesListView��5      $��2��6-   $��0��6:   $��4��6J   6`   �� 5   
   $
��Msg:��6   $��3��6   $��0��6,   $��0,2,0,0q�6<   �� 5   
   -   5        $ msgText��5      $��3��6#   $��1��60   $	��5,5q�6@   6O   �� 5    
   -   5        $ 	themeText��5       $��3��6%   $��2��62   $	��5,5q�6B   6Q   �� 5!   
   -   5        $
��Send��5!      $��3��6    $��3��6-   6T   5"      5#      