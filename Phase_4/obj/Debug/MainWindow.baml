   M S B A M L   `   `   `  ����B  >Phase_4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Phase_4Phase_4  5   	       Phase_4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Phase_4     5   	   -   5          � Title$  Phase_4��5   	   $	��600��6   $	��810��6&    � 	Resources 5         Phase_4.ThumbnailSize   thumbnailSize   Phase_4.ThumbnailWidth  thumbnailWidth   Phase_4.ThumbnailHeight  thumbnailHeight   Phase_4.ImageConverter  ImageConverter  stackPanelStyle �� 
TargetType �� Property �� Value  sliderStyle  TextBlockStyle��%t  &	        &	      &	 &     &	 9     &	 L     &	 �     &	 �      5   
   6     5   
   6     5   
   6      5   
   6   �� 5   
   " ��6(   .�5      ��  �@��Orientation$ 
Horizontal=�6,   �� 5       � ��$ 0,5,0 0q�6'   �� 5       � ��$	 Top=�62   5      �� 5   
   " ��6$   .�5      ��  � ��$ 20��6'   �� 5       � ��$ 90��6&   �� 5       � ��$ 10,0,0,0q�6'   �� 5       �@��IsSnapToTickEnabled . 64   5      �� 5   
   " ��6'   .�5      ��  � ��$ 30��6'   �� 5       � ��$ 50��6&   5      5       .��5"      ]� .+�5#   
   ��  �� Orientation$ Vertical=�6   $	��Top=�6,   .+�5$      �� $ 
Horizontal=�6   .+�5'      �� $��操作��6   $��	10,0,10,0q�6'   $��60��6:   $��60��6E   .��5(      �� -   5        $��開く��5(      $��0,5,0,0q�6*   $��30��6;   $��25��6F   6R   5)      �� 5,      $��サムネイルサイズ��6   .��5-      �� #��[ 6!   .+�5.      �� #��[ 6�   ��6$   ��  �� ElementName$ 
sliderSize�� �� Path$ Value� �� 	Converter# [  	 �� Mode$	 OneWay=�6�   �� 5/      -   5        $��
sliderSize��5/   !   #��[ 63   
 � Maximum$
 3Q�6X    � Minimum$ 1Q�6d    � Value$ 2Q�6p   50      51      �� 54      $��拡大／縮小��6   .��55      �� #��[ 6!   .+�56      �� #��[ 6|   ��6$   �� $ sliderScaling��$ Value�$	 OneWay=� �� StringFormat$ 	0.0倍：��6|   �� 57      -   5        $��sliderScaling��57   !   #��[ 66   $
 5Q�6[   $	 0.1Q�6g   $	 1.0Q�6u    �� TickFrequency$	 0.1Q�6�   58      59      �� 5<      $��回転��6   .��5=      �� #��[ 6!   .+�5>      �� #��[ 6}   ��6$   �� $ sliderRotation��$ Value�$	 OneWay=�$ 	000度：��6}   �� 5?      -   5        $��sliderRotation��5?   !   #��[ 67   $	
 360Q�6\   $ 0Q�6j   $ 0Q�6v   $ 1Q�6�   5@      5A      �� 5D      -   5         ��Name$ filePath��5D      $��TextBox��6,   $
��Left=�6;   $��20��6V   $	��200��6b   $��	10,10,0,0q�6n    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   5E      �� 5H      -   5         ��Name$ listBoxThumbnail��5H      $��Disabled=�6H   $
��Left=�6~   $	��100��6�   $	��770��6�   $��	10,10,0,0q�6�   $	��Top=�6�   ��60   �� ��5I      �� 5J      .R�5K      � 5L      ��5N      �� 5O      .R�5P      � ��6   �� $ 
sliderSize��$ Value�# [ ��6   �� $ 
sliderSize��$ Value�# [ .+�5R      �� ��6$   �� *Image+# [ 5Z      5[      5]      5^      �� 5a   
   -   5        $��scrollViewer1��5a      $
��Auto=�6,   $
��Auto=�6Q   $��10,10,10,10q�6t   .��5b      �� -	   5         ��Name$ imageBottom��5b      $
��None=�6)   ��68   �� $ listBoxThumbnail��$ SelectedItem.Image�$	 OneWay=� � LayoutTransform 5c      V� 5d      .~�5e      ��  �� ScaleX 6)   �� $ sliderScaling��$ Value�$	 OneWay=� �� ScaleY 6o   �� $ sliderScaling��$ Value�$	 OneWay=��� 5f       �� Angle 6*   �� $ sliderRotation��$ Value�$	 OneWay=�5g      5i      5j      5k      5l      