   M S B A M L   `   `   `  ����H  DEczaneApp.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:EczaneApp.WpfEczaneApp.Wpf  5   	       EczaneApp.Wpf.GirisYap   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:EczaneApp.Wpf     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	     � Title$  	EczaneApp��5   	   $	��350��6   $	��300��6(      MaterialDesignBody#���   5   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�66    � Icon$" iconfinder_medic_6673745.png��6[   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��11* �6   �� 5      $
��139* �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   �� -   5        ���#00897B$��2��5   .   ._�5      �  5       �� 5!      $��* �6'   �� 5"      $
��Auto �6'   .+�5&      �� $��Center=�5'      $��10 0 0 0q�5(      ��5)      �� *Title+	 �� RelativeSource	 �� *FindAncestor+
 �� AncestorType$
 WindowL��� 5+      $��1��6    �� Orientation$ 
Horizontal=�5,   %   $��Center=�5-   %   .+�5.      �� -   5         ��Name$ btnClose��5/   %     MaterialDesignFlatButton#��[ 5.       ! PrimaryHueDarkForegroundBrush#��[ 51   %    �� IsCancel . .��53      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowClose=�62   54      55      56      57      � 58   
   $��1��6   $��2��6    59      �� 5:      $	��100 �6    �� 5;      $��* �6    .+�5=      (� $	��100��6   $��80��6"   .��5>      F� 
������������ $� ��� �@]� ��� �@]� @f��ا @f��ا ��� � z ��� � z  � ��ا  � ��ا @T� �@]� @T� �@]�  � � $�  � �@o@@KL Ѱ�@KL ���)�: �0�@B �i� @KL ���- @KL ���- ��j �@KL @]� ���- ��!���- @o@�@o@@o@�@o@��!���!@]� �@o@��j �@o@@KL 	6$   5@      �� 5B      $��1��6   .+�5D      �� $ 
Horizontal=�6   $
��40 5q�66   .+�5E        $
 User=�6.   $��Center=�5F   *   $��20��5G   *   $��20��5H   *   $��0 0 5 0q�5I   *   �� 5J      -   5         ��Name$ txtAd��5J      $	��195��6-    % !MaterialDesignFloatingHintTextBox#��[ 5K      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ad��5L      5M      �� 5N      $ 
Horizontal=�6   $
��40 5q�66   .+�5O        $ Password=�6.   $��Center=�5P   *   $��20��5Q   *   $��20��5R   *   $��0 0 5 0q�5S   *   G� 5T      -   5         G�Name$ txtSifre��5T   #   $	��195��65    ) %MaterialDesignFloatingHintPasswordBox#��[ 5U      $ Şifre��5V       G� PasswordChar$ *��5W       G� 	MaxLength$ 20��6+   5X      �� 5Y      -   5         ��Name$ 
hataMesaji��5Z      $��
40 10 40 0q�5[      $��10(�5\      
���  ��5]      �� 5^      -   5        $ btnGiris��5`      $��
Giriş Yap��5^      $��40 20q�5_       �� 	IsDefault . 5b      5d      5e      5i      5j      