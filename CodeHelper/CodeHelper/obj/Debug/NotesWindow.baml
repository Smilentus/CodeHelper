   M S B A M L   `   `   `  ����E  ACodeHelper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CodeHelper
CodeHelper  5   	       CodeHelper.NotesWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:CodeHelper     5   	     � Title$!  Список записок��5   	   $
��1000��6    $
��1920��6.    � WindowStartupLocation$ CenterScreen=�6;   ���	#FF323232 � WindowState$ 	Maximized=�6w    � 	Resources 5	         noteBtn �� 
TargetType �� Property �� Value��%�   &	        �� 5
   
   " ��6    .�5      ��  � �� �	#FF1D1D1D6?   �� 5       � �� �	#FFFFEC946?   �� 5       � �� �	#FFFFD1006@   �� 5       � ��$ 15q�6'   64   5      5      .��5      � .+�5   
   �� $��10,50,10,10q�6   ���	#FF1D1D1D$
��Auto=�6C   $��Stretch=�6f   $��Stretch=�6�   .��5      � -   5         �Name$ 	MainPanel��5       � 	ItemWidth$	 200��6+   	 � 
ItemHeight$		 200��6;   5      5      �� 5   
   -   5        
 ��Name$
 	createBtn��5      $��Создать��6$   $
��Left=�66   $��	10,10,0,0q�6Q   $	��Top=�6d   $	��100��6|   $��30��6�   ���	#FFFFD100���	#FF1D1D1D���	#FFFFEC946�   �� 5   
   -   5         ��Name$ searchBarBox��5      $
��Left=�6(   $��30��6C   $��
175,10,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��300��6�   $��Center=�6�   ���	#FF1D1D1D���	#FFFFEC94���	#FFFFD1006  �� 5   
   $��Поиск:��6   $
��Left=�6!   $��
120,10,0,0q�6<   $	��Top=�6P   ���	#FFFFEC94���	#FFFFD100$��30��6�   $��50��6�   $��Right=�6�   $��Center=�6�   ��6h   Z� 6�   5      5      