   M S B A M L   `   `   `  ����G  CM318GameTime, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:M318GameTime.ViewModelsM318GameTime.ViewModels  5   	   /    )M318GameTime.Views.UpdateorDeleteUserView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   7local%clr-namespace:M318GameTime.ViewModels     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Title$ UpdateorDeleteUserView��5   	   $��755.175��6(   $	��800��69   .��5
      � -   5        $��UpdateorDeleteGrid��5
      $��0,0,0,4q�6%    � ColumnDefinitions 5   
   �� 5      $��14 �6   �� 5      $��93 �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��1��6   $��2��6$   $��0��5      $��22,10,36,10q�5      $��Center=�5       $��20(�5!      $��View, Update, Delete User��5"      �� 5$   
   $��0��6   $��1��5%      $��10q�5&      $��Select to View:��5'      $��2��6*   �� 5(   
   $��0��6   $��2��5)      $��10q�5*      $��Pseudo:��5+      $��2��6"   �� 5,   
   $��0��6   $��4��5-      $��10q�5.      $
��Nom:��5/      $��2��6   �� 51   
   -   5        $��userComboBox��51      $��2��52      $��1��53      $��
10,20,10,0q�54      $ �� IsSynchronizedWithCurrentItem$
 TrueY�57       �� SelectedIndex$ 0��58       �� DisplayMemberPath$ ProfilsPseudo��59      ��55      ��  �� Path$ NewUsersCollection� �� SelectedItem 56      �� $ SelectedUser�	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 TwoWay=�59      �� 5=   
   -   5        $��ProfilsPseudoTextBox��5=      $��2��5>      $��2��5?      $��10q�5@      {�.  ��5B      ��  �� ElementName$ userComboBox��$  SelectedItem.ProfilsPseudo�$	 PropertyChanged=�$
 TwoWay=�� 5D   
   -   5        $��Update1Grid��5D      $��2��5E      $��3��5F       5G      �� 5H      $
��175* �6#   �� 5I      $
��432* �6#   �� 5J      $
��Auto �6#    5L      �� 5M      $
��Auto �6    .+�5O      �� -   5        $ ��ProfilsPseudoUpdateTextBox��5O      $��0��5P      $��0��5Q      $��10q�5R      $��2��5S   s   ��6   �� $ UpdatedProfilsPseudo�$	 PropertyChanged=�$
 TwoWay=�6s   �� 5T      -   5        $��ProfilsPseudoUpdateBtn��5T      $��2��5U      $��0��5V      $��10q�5W      $��60��5X      $��Update��5Y      ��5Z      �� $  UpdateProfilsPseudoCommand�5[      �� 5]   
   -   5        $��ProfilsNomTextBox��5]      $��2��5^      $��4��5_      $��10q�5`      {�.  ��5b      �� $ userComboBox��$ SelectedItem.ProfilsNom�$	 PropertyChanged=�$
 TwoWay=�� 5d   
   -   5        $��Update2Grid��5d      $��2��5e      $��5��5f       5g      �� 5h      �� 5i      $
��Auto �6#    5k      �� 5l      $
��Auto �6    .+�5n      �� -	   5        $��ProfilsNomUpdateTextBox��5n      $��0��5o      $��0��5p      $��10q�5q      ��5r      �� $ UpdatedProfilsNom�$	 PropertyChanged=�$
 TwoWay=��� 5s      -
   5        $��ProfilsNomUpdateBtn��5s      $��1��5t      $��0��5u      $��10q�5v      $��60��5w      $��Update��5x      ��5y      �� $ UpdateProfilsNomCommand��� 5z      $��0��6   $��-98,46,592,-26q�5{      $��Prenom:��5|      �� 5}      -   5         ��Name$ ProfilsPrenomTextBox��5}      $��9,46,11,-26q�5~      {�.  ��5�      �� $ userComboBox��$  SelectedItem.ProfilsPrenom�$	 PropertyChanged=�$
 TwoWay=�� 5�      -   5         �Name$ Update2Grid_Copy��5�      $��2��5�   	   $��-1,83,1,-77q�6    5�      �� 5�      �� 5�      $
��Auto �6'    5�      �� 5�      $
��Auto �6$   .+�5�      �� -   5        $  ProfilsPrenomUpdateTextBox��5�      $��0��5�      $��0��5�      $��10q�5�      ��5�      �� $ UpdatedProfilsPrenom�$
 TwoWay=�$	 PropertyChanged=��� 5�      -   5         ��Name$ ProfilsPrenomBtn��5�      $��1��5�      $��0��5�      $��10q�5�      $��60��5�      $��Update��5�      ��5�      �� $  UpdateProfilsPrenomCommand�5�      �� 5�      $��0��6   $��-98,126,592,-106q�5�      $��DateNaissance:��5�      �� 5�      -   5        $! ProfilsDateNaissanceTextBox��5�      $��9,126,11,-106q�5�      {�.  ��5�      �� $ userComboBox��$' !SelectedItem.ProfilsDateNaissance�$	 PropertyChanged=�$
 TwoWay=�� 5�      -   5        $ Update2Grid_Copy1��5�      $��2��5�      $��-1,163,1,-157q�6%    5�      �� 5�      �� 5�      $
��Auto �6'    5�      �� 5�      $
��Auto �6$   .+�5�      (  "System.Windows.Controls.DatePicker  -   5          Name$' !ProfilsDateNaissanceUpdateTextBox��5�      $��0��5�      $��0��5�      $��10q�5�         Text 5�      �� $! UpdatedProfilsDateNaissance�$
 TwoWay=�$	 PropertyChanged=��� 5�      -   5        $# ProfilsDateNaissanceUpdateBtn��5�      $��1��5�      $��0��5�      $��10q�5�      $��60��5�      $��Update��5�      ��5�      �� $' !UpdateProfilsDateNaissanceCommand�5�      �� 5�      $��0��6   $��-98,210,592,-190q�5�      $��Email:��5�      �� 5�      -   5        $ ProfilsEmailTextBox��5�      $��9,210,11,-190q�5�      {�.  ��5�      �� $ userComboBox��$ SelectedItem.ProfilsEmail�$	 PropertyChanged=�$
 TwoWay=�� 5�      -   5        $ Update2Grid_Copy2��5�      $��2��5�      $��-1,247,1,-241q�6%    5�      �� 5�      �� 5�      $
��Auto �6'    5�      �� 5�      $
��Auto �6$   .+�5�      �� -   5        $ ProfilsEmailUpdateTextBox��5�      $��0��5�      $��0��5�      $��10q�5�      ��5�      �� $ UpdatedProfilsEmail�$
 TwoWay=�$	 PropertyChanged=��� 5�      -   5        $ ProfilsEmailUpdateBtn��5�      $��1��5�      $��0��5�      $��10q�5�      $��60��5�      $��Update��5�      ��5�      �� $ UpdateProfilsEmailCommand�5�      �� 5�      $��0��6   $��-98,295,592,-275q�5�      $��	MotPasse:��5�      �� 5�      -   5        $ ProfilsMotPasseTextBox��5�      $��9,295,11,-275q�5�      {�.  ��5�      �� $ userComboBox��$" SelectedItem.ProfilsMotPasse�$	 PropertyChanged=�$
 TwoWay=�� 5�      -   5        $ Update2Grid_Copy3��5�      $��2��5�      $��-1,332,1,-326q�6%    5�      �� 5�      �� 5�      $
��Auto �6'    5�      �� 5�      $
��Auto �6$   .+�5�      �� -   5        $" ProfilsMotPasseUpdateTextBox��5�      $��0��5�      $��0��5�      $��10q�5�      ��5�      �� $ UpdatedProfilsMotPasse�$
 TwoWay=�$	 PropertyChanged=��� 5�      -   5        $ ProfilsMotPasseUpdateBtn��5�      $��1��5�      $��0��5�      $��10q�5�      $��60��5�      $��Update��5�      ��5�      �� $" UpdateProfilsMotPasseCommand�5�      5�      �� 5�   
   $��3��6   $��8��5�      $��Stretch=�5�      $��10,355,10,-335q�5�      $��Delete User��5�      ��5�      �� $ RemoveUserCommand�5�      5�      