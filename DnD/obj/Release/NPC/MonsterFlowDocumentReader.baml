   M S B A M L   `   `   `  ���� >  :DnD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DnD.NPCDnD.NPC  '    !DnD.NPC.MonsterFlowDocumentReader   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:DnD.NPC     -   .��� ����   �� EndPoint$  0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFFDF1DC�� � Offset$ 0Q�� $ White��$ 0.981Q�� $ 	#FFFDF1DD��$ 0.662Q�.+��� -    ��Name$ btnClearAll��$��	Clear All��$
��Left=�$��45��$��	10,10,0,0q�$	��Top=�$	��100��$��14(�$��1���� -   $��cbFont��$��	0,10,10,0q�$��
Calisto MT)�$��13(�$��Right=�$	��230��$��27��$	��Top=�$��1��$y�Hidden=�����    System.Windows.Media.Fonts   SystemFontFamilies �� Source# Z �� -    ��Name$ chkMultipleMonsters��$��Multiple Monsters��$��1��$
��Left=�$��
122,14,0,0q�$	��Top=�
���   � d� 	IsChecked$ FalseY��� -   $ chkPageBreak��$��Single Monster Per Column��$��1��$
��Left=�$��20��$��
122,35,0,0q�$	��Top=�$	��175��
���   �$
 TrueY��� ���	#FFFDF1DC$��1��	 �� CornerRadius$	 5��
 �� Padding$
 5,5,5,5q�$��2q�$��
0,64,10,10q����� $  0.5,1&�$ 0.5,0&�.��� $ 	#FFFDF1DC��$ 0.356Q�� $ 	#FFDAB67A��$ 1Q�� $ 	#FFA8823D��� $ 	#FFFAECD4��$ 0.713Q�._�-� -   $��MonsterFlowReader�� -� ViewingMode$ TwoPage=�$��1��$��8,23,8,8q�$��0q�
���   �
���   � � ContextMenu �� .��/� -    �Name$ MonsterFlow�� /� 
PageHeight$
 Auto�� /� 	PageWidth$
 Auto�� /� MinPageWidth$	 4in�� /� MaxPageWidth$	 4in�� /� 
FontFamily$ 
Calisto MT)� /� 
Background ��  �� ImageSource$" /DnD;component/Images/bg.jpg�� � 	Resources  �� 
TargetType �� Property �� Value   statName  
statNumber��%�   'J�       &	  2     &	 u     �� Para��" J�.���  �@��Margin$ 5q��� " ��.���  � �� �	#FFAC2F2F��  � ��$
 Bold"��� " ��.���  � �� �	#FFAC2F2F�� -    ��Name$ lblCount��$��Monsters: 0 (XP Total: 0)��$��Center=�$
��Left=�$��45��$��
355,10,0,0q�$	��Top=�$	��250��
���   �