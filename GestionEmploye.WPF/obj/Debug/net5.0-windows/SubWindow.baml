   M S B A M L   `   `   `  ����M  IGestionEmploye.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:GestionEmploye.WPFGestionEmploye.WPF  5   	   "    GestionEmploye.WPF.SubWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:GestionEmploye.WPF     5   	     � Title$  	SubWindow��5   	   $	��450��6   $	��800��6(   .��5	      � .+�5   
   � $��1��6   $��1��6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� 	Prénom6"   �� 5      $��1��6   $��10q�6$   ��60   �� *prenom+�� 5      $��2��6   Nom6+   �� 5      $��3��6   $��10q�6#   ��6/   �� *nom+�� 5      $��4��6   Date d'embauche67   (  "System.Windows.Controls.DatePicker  5       $��5��6   $��10q�6&      Text 62   �� *date+�� 5"      $��6��6   Rôle6,   �� 5#      -   5        $
��role��5(      $��7��5#       �� DisplayMemberPath$	 Nom��5%       �� SelectedValuePath$ IdRole��5&      $��10q�5'      ��5$      �� *Roles+ �� Mode$ OneWay=�5(      �� 5*      $��8��6   $��Pilote de ligne��6$   $��10q�6>   �� 5,      $��9��6   $��Enregistrer��6"   
�������
���   �$��1q�6^   $��10 10 10 30q�6r   $��Bottom=�5.      ��5-      �� *AddCmd+5.      5/      52      53      