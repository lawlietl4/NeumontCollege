   M S B A M L   `   `   `  ����F  BSpotify 2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Spotify_2._0Spotify_2._0  5   	       Spotify_2._0.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Spotify_2._0     5   	     � Title$  MainApplicationWindow��5   	   $	��450��6'   $	��800��64   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��3* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ SearchUserText��5      $��25��6*   $	��150��66   $��0��6B   $��0��6O   $��Center=�6_   $��Center=�6|   �� 5   
   -   5         ��Name$ SearchUserBtn��5      $��Search��6(   $��25��6U   $��64��6a   $��0��6l   $��1��6y   $
��Left=�6�   $��Center=�6�   �� 5   
   $��	Song Name��6   $��1��6$   $��0��61   $��Center=�6A   $	��Top=�6^   �� 5   
   $��Playlist��6   $��1��6#   $��1��60   $��Center=�6@   $	��Top=�6]   �� 5   
   $��
Album Name��6   $��1��6%   $��2��62   $��Center=�6B   $	��Top=�6_   �� 5   
   $��Artist name��6   $��1��6&   $��3��63   $��Center=�6C   $	��Top=�6`   �� 5   
   -   5         ��Name$ Song_Text_Block��5      $��1��6-   $��0��6:   $
��Wrap=�6J   $��Center=�6^   $��Center=�6y   $	��257��6�   $	��180��6�   �� 5   
   -   5        $ Playlist_Text_Block��5      $��1��61   $��1��6>   $
��Wrap=�6N   $��Center=�6b   $��Center=�6}   $	��257��6�   $	��180��6�   �� 5   
   -   5        $ 
Album_name��5      $��1��6(   $��2��65   $
��Wrap=�6E   $��Center=�6Y   $��Center=�6t   $	��257��6�   $	��180��6�   �� 5   
   -   5        $ Artist_Name��5      $��1��6)   $��3��66   $
��Wrap=�6F   $��Center=�6Z   $��Center=�6u   $	��257��6�   $	��180��6�   5      5      