   M S B A M L   `   `   `  ����E  ACodeHelper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CodeHelper
CodeHelper  5   	       CodeHelper.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:CodeHelper     5   	   -   5          � Title$'  !Изменение записки��5   	   $
��1000��6#   $
��1920��61    � WindowStartupLocation$ CenterScreen=�6>   ���	#FF323232 � WindowState$ 	Maximized=�6z    � 	Resources 5	       �� 
TargetType �� Property �� Value �� Triggers P� Property	 P� Value��%�   '��       �� 5
   
   " ��6   �5      �� 5       � �� �	#FF1D1D1D6C    5      P� 5       �@J�IsMouseOver	 . . �5      ��  � �� �	#FFBF7A006G   5      5      5      .��5      � .+�5   
   �� -   5        
 ��Name$
 codeBox��5      $��10,50,10,10q�6'   ���	#FFFFEC94 �� SelectionBrush �	#FFE28C0F���	#FF1D1D1D���	#FFFFD100$ �� HorizontalScrollBarVisibility$
 Auto=�6�   $��15q�6�   " �� VerticalScrollBarVisibility$
 Auto=�6�    �� 	UndoLimit$
 1024��6�   $��16(�6   �� 
AcceptsTab .  �� 
LineHeight$ 6��6#  . �5      /� .T�5      J� .*�6   .*�5      �� $� ��6   5      5      5      �� 5   
   -   5         ��Name$ minusBtn��5      $��-��6#   $
��Left=�6/   $��
315,10,0,0q�6J   $	��Top=�6^   $��50��6v   $��30��6�   $��18(�6�   $��Center=�6�   $	��Top=�6�   ���	#FFFFD100���	#FF1D1D1D���	#FFFFEC946$  �� 5   
   -   5         ��Name$ noteNameInput��5      $
��Left=�6)   $��30��6D   $��	10,10,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��300��6�   $��Center=�6�   $��Center=�6�   ���	#FF1D1D1D���	#FFFFEC94���	#FFFFD1006  �� 5   
   -   5        $ backBtn��5      $��
Назад��6"   $
��Left=�62   $��
690,10,0,0q�6M   $	��Top=�6a   $	��100��6y   $��30��6�   ���	#FFFFD100���	#FF1D1D1D���	#FFFFEC946�   �� 5    
   -   5        $ copyBtn��5       $��Копировать��6"   $
��Left=�67   $��
585,10,0,0q�6R   $	��Top=�6f   $	��100��6~   $��30��6�   ���	#FFFFD100���	#FF1D1D1D���	#FFFFEC946�   �� 5!   
   -   5        $ plusBtn��5!      $��+��6"   $
��Left=�6.   $��
370,10,0,0q�6I   $	��Top=�6]   $��50��6u   $��30��6�   $��18(�6�   $	��Top=�6�   ���	#FFFFD100���	#FF1D1D1D���	#FFFFEC946�   �� 5"   
   -   5        $ descrBtn��5"      $��Описание��6#   $
��Left=�66   $��
480,10,0,0q�6Q   $	��Top=�6e   $	��100��6}   $��30��6�   ���	#FFFFD100���	#FF1D1D1D���	#FFFFEC94$��30��6�   �� 5#   
   -	   5        $ 	deleteBtn��5#      $��Удалить��6$   $
��Left=�66   $��
1802,9,0,0q�6Q   $	��Top=�6e   $	��100��6}   $��30��6�   ���	#FFFFD100���	#FF1D1D1D���	#FFFFEC946�   �� 5$   
   -
   5        $ descrBox��5$      $
��Left=�6$   $��
315,40,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $	��420��6   ���	#FF1D1D1D���	#FFFFD100���	#FFFFEC94$��15,10q�6�   $y�Hidden=�6�    �� AcceptsReturn .  . $	��114��6  $
 Auto=�6,  $	��342��6O  �� 5%   
   -   5        $ resetRtbBtn��5%      $	��↺��6&   $
��Left=�62   $��
425,10,0,0q�6M   $	��Top=�6a   $��50��6y   $��30��6�   $��18(�6�   $	��Top=�6�   ���	#FFFFD100���	#FF1D1D1D���	#FFFFEC946  5&      5'      