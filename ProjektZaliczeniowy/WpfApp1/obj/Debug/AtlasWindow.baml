   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.AtlasWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  AtlasWindow��5   	   $	��450��6   $	��800��6*    � WindowState$ 	Maximized=�67   .��5	      � 
����ح� � RowDefinitions 5
   
   �� 5      $
��0.5* �6   6,   �� 5      $��3* �6   6*   �� 5      $��1* �6   6*   �� 5      $��2* �6   6*   �� 5      $
��0.5* �6   6,    � ColumnDefinitions 5   
   �� 5      $
��0.8* �6   6.   �� 5      $��3* �6   6,   �� 5      $��0.125* �6   60   .+�5   
   �� -   5         ��Name$ lblCwiczenia��5      $��Lista ćwiczeń:��6&   $��1��6?   $��26(�6L   $��Center=�6Z   �� 5   
   -   5         ��Name$ lstKat��5      $��1��6"   $��1��62   $��26(�6?   
�������5      �� 5   
   -   5        $ lblOpis��5      $��Opis:��6!   $��3��61   $��26(�6>   $��Center=�6L   �� 5   
   -   5         ��Name$ txtOpis��5       �� TextWrapping$
 Wrap=�6#   $��1��67   $��3��6G   $��26(�6T   
�������6b   �� 5   
   -   5         ��Name$ 
btnWybierz��5      $��Wybierz��6%   $��1��67   $��2��6G   $��26(�6T   
�������6{   5      5       