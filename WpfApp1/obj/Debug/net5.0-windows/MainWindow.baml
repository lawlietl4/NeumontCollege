   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  MyPaint��5   	   $	��450��6   $	��800��6&   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��152* �6   �� 5      $
��159* �6   .+�5   
   �� -   5        $��
inkCanvas1��5   '   $��	9,30,9,68q�6   $
��Auto��5      $��2��6!   62   �� 5   
   -   5         ��Name$ increaseBrush��5   k   $��Increase Brush Size��6   $��23��6/   $
��Left=�6;   $��574,154,0,0q�6V   $	��109��5      $��1��64   $	��Top=�6A   �� 5   
   -   5        $ decreaseBrush��5   k   $��Decrease Brush Size��6   $��23��6/   $
��Left=�6;   $��138,154,0,0q�6V   $	��118��5      $��1��64   $	��Top=�6A   5      �� 5   
   -   5        $ clearBtn��5   ]   $��Clear��6   $��23��6!   $
��Left=�6-   $��160,189,0,0q�6H   $	��Top=�5      $��74��6)   $��1��6K   �� 5   
   -   5        $ closeBtn��5   ]   $��Close��6   $��23��6!   $
��Left=�6-   $��591,189,0,0q�6H   $	��Top=�5      $��75��6)   $��1��6K   �� 5   
   -   5        $ redBtn��5      $	��RED��6!   $
��Left=�6/   $��300,156,0,0q�6J   $��1��6_   $	��Top=�6l   6�   �� 5   
   -   5        $ greenBtn��5      $��GREEN��6#   $
��Left=�63   $��400,156,0,0q�6N   $��1��6c   $	��Top=�6p   6�   �� 5   
   -   5        $ blueBtn��5      $
��BLUE��6"   $
��Left=�61   $��499,156,0,0q�6L   $��1��6a   $	��Top=�6n   6�   �� 5   
   -	   5        $ eraseBtn��5      $��Erase��6#   $
��Left=�63   $��328,189,0,0q�6N   $��1��6c   $	��Top=�6p   5      �� 5   
   -
   5        $ DrawBtn��5      $
��Draw��6"   $
��Left=�61   $��494,189,0,0q�6L   $��1��6a   $	��Top=�6n   6�   5      5       