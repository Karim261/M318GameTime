   M S B A M L   `   `   `  ����G  CM318GameTime, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:M318GameTime.ViewModelsM318GameTime.ViewModels  5   	   $    M318GameTime.Views.AddUserView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   7local%clr-namespace:M318GameTime.ViewModels     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Title$ Add to Collection��5   	   $	��469��6#   $	��800��60   .��5
      � -   5        $��AddGameGrid��5
      $	��721��6   $	��Top=�6+    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��2��6$   $��0��5      $��10q�5      $��Center=�5      $��20(�5      �� 5      $�Add New ��6   �� 60   $
�User��64   6C   �� 5   
   $��0��6   $��1��5      $��10q�5       $��Pseudo:��5!      �� 5"   
   $��0��6   $��2��5#      $��10q�5$      $
��Nom:��5%      �� 5'   
   -   5        $��ProfilsPseudoTextBox��5'      $��1��5(      $��1��5)      $��10q�5*      ��5+      ��  �� Path$ NewProfilsPseudo� �� UpdateSourceTrigger$ PropertyChanged=��� 5,   
   -   5        $��ProfilsNomTextBox��5,      $��1��5-      $��2��5.      $��10q�5/      ��50      �� $ NewProfilsNom�$ PropertyChanged=��� 51   
   -   5         ��Name$ ProfilsPrenomTextBox��51      $��1��52      $��3��53      $��10,0,10,205q�54      $��2��55   Y   ��6   �� $ NewProfilsPrenom�$ PropertyChanged=�6Y   �� 56   
   $��0��6   $��4��57      $��9,41,11,164q�58      $��DateNaissance:��59      (  "System.Windows.Controls.DatePicker  5:      -   5          Name$! ProfilsDateNaissanceTextBox��5:      $��1��5;      $��4��5<      $��9,41,11,164q�5=         Text 5>      �� $ NewProfilsDateNaissance�$ PropertyChanged=��� 5?   
   $��0��6   $��5��5@      $��9,88,11,117q�5A      $��Email:��5B      �� 5C   
   -   5        $ ProfilsEmailTextBox��5C      $��1��5D      $��4��5E      $��10,88,11,117q�5F      ��5G      �� $ NewProfilsEmail�$ PropertyChanged=��� 5H   
   $��0��6   $��6��5I      $��10,132,10,73q�5J      $��	MotPasse:��5K      �� 5L   
   -   5        $ ProfilsMotPasseTextBox��5L      $��1��5M      $��6��5N      $��10,132,10,73q�5O      ��5P      �� $ NewProfilsMotPasse�$ PropertyChanged=��� 5T   
   -   5        $��
addUserBtn��5T      $��0��5U      $��2��6!   $��4��5V      $��10,199,10,0q�5W      $��Add User��5X      ��5Y      �� $ AddNewUserCommand�6<   �� 5Z   
   $��0��6   $��4��5[      $��10,0,10,205q�5\      $��Prenom:��5]      5_      5`      