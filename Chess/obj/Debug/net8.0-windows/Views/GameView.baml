   M S B A M L   `   `   `  ����@  <Chess, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Chess.ViewsChess.Views  5      3clr-namespace:Chess.ConvertersChess.Converters  5          Chess.Views.GameView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Chess.Views     5      /convclr-namespace:Chess.Converters     5      
�������  � 	Resources  5      -   'Chess.Converters.HeightToWidthConverter   HeightToWidthConverter,   &Chess.Converters.ColorToBrushConverter  ColorToBrushConverter��%:   &	        &	        5   
   6&     5   
   6%   5      .��5      �  � RowDefinitions 5   
   �� 5      $	��15* �6   �� 5      -   5         ��Name$ 	MiddleRow��5   )   $	��70* �6   6)   �� 5      $	��15* �6   .+�5   
   � $��1��6    � ColumnDefinitions 5      �� 5      $��5* �6#   �� 5      ��6#   ��  �� RelativeSource ��  �� AncestorType Grid �� Path$ ActualHeight� �� 	Converter# [  �� 5      $	��30* �6#   .+�5      �� $��1��6   $��1��6(   ��68   �� *
BoardState+��5      �� 5      .R�5       �  �Name$ Board��6    5!      �� 5"   "   $��* �63   �� 5#   "   $��* �63   �� 5$   "   $��* �63   �� 5%   "   $��* �63   �� 5&   "   $��* �63   �� 5'   "   $��* �63   �� 5(   "   $��* �63   �� 5)   "   $��* �63    5+      �� 5,   "   $��* �60   �� 5-   "   $��* �60   �� 5.   "   $��* �60   �� 5/   "   $��* �60   �� 50   "   $��* �60   �� 51   "   $��* �60   �� 52   "   $��* �60   �� 53   "   $��* �60   55      56      ��59      �� 5:      .R�5;      � ��6   �� *Color+# [ .+�5<      �� 
������ $��0q�5?   %   ��5<   %   �� *DataContext.MovePiece+ ��  ItemsControl��5=   %   �� .��5@   "   �� $��Center=�5A   (   $��Center=�5B   (   ��5@   (   �� *Piece.ImageSource+5B   (   5C      5D      5E      ��5H      �� 5I      	 �� 
TargetType"	 ��6   .�5J      �� 
 �� Property
 � �� �� Value 65   �� *Row+�� 5K      
 � �� 68   �� *Column+5L      5N      �� 5P      
�������$��0��6$   $��0��64   $��3��6A    �� Stretch$
 Fill=�6R   �� 5Q      
�������$��2��6)   $��0��69   $��3��6F   $
 Fill=�6W   5R      �� 5T   
   
�������$��0��6    $��3��6-   $
 Fill=�6A   �� 5U   
   
�������$��2��6    $��3��6-   $
 Fill=�6A   5V      5W      