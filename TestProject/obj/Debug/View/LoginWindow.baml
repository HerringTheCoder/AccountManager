   M S B A M L   `   `   `  ����F  BTestProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TestProjectTestProject  5   	       TestProject.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TestProject     5   	     � Title$  LoginWindow��5   	    � WindowStartupLocation$ CenterScreen=�6      DefaultWindow#��[  6B   .��5
      �� -   5         ��Name$ 
LoginPanel��5
      .+�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��0��6     MyTextBlockBold#��[ 6(   Login:6Y   5      �� 5   
   -   5         ��Name$ loginBox��5        	TextInput#��[ 6;   ��6$   �� *Login+6`   �� 5   
   $��0��6   #��[ 6$   	Password:6X   G� 5   
   -   5         G�Name$ passwordBox��5      #��[ 6O   � 5   
    5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� -   5         ��Name$ LoginButton��5      $��Login��6D   {�.  $��0��6f   �� 5      -   5        $ 
BackButton��5      $
��Back��6B   $��1��6Q   5      5      5       