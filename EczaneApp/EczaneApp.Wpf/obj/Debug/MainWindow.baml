   M S B A M L   `   `   `  ����H  DEczaneApp.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:EczaneApp.WpfEczaneApp.Wpf  5   	       EczaneApp.Wpf.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:EczaneApp.Wpf     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          � Title$  	EczaneApp��5   	   $	��450��6   $	��800��6(      MaterialDesignBody#���   5   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�66    � Icon$" iconfinder_medic_6673745.png��6r   .��5      � .+�5   
   )  #MaterialDesignThemes.Wpf.DrawerHost  -   5          Name$ 
DrawerHost��5      $��2q�5        MaterialDesignDivider#���  5         LeftDrawerContent 5      �� 5      $��16q�5      .+�5      �� $��4q�5      $��Center=�5       $��Menü��5!      �� 5"      �� 5#      -   5        	 ��Name$	 btnPersoneller��5'      $��4q�5$      $��Center=�5%        MaterialDesignFlatButton#���  5&      .��5)      �� 
 �� Orientation$
 
Horizontal=�6%   .+�5*      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�66   $��0 0 3 0q�6B   
�������6S   �� 5+      $��Personeller��6(   5,      5-      �� 5.      -   5        $	 btnMusteriler��52      $��4q�5/      $��Center=�50      #���  51      .��54      �� $
 
Horizontal=�6%   .+�55        $ Users=�66   $��0 0 3 0q�6C   
�������6T   �� 56      $��Müşteriler��6(   57      58      �� 59      -   5        $	 btnKategoriler��5=      $��4q�5:      $��Center=�5;      #���  5<      .��5?      �� $
 
Horizontal=�6%   .+�5@        $ AlphabetAurebesh=�66   $��0 0 3 0q�6N   
�������6_   �� 5A      $��Kategoriler��6(   5B      5C      �� 5D      -   5        $	 
btnIlaclar��5H      $��4q�5E      $��Center=�5F      #���  5G      .��5J      �� $
 
Horizontal=�6%   .+�5K        $ MortarPestlePlus=�66   $��0 0 3 0q�6N   
�������6_   �� 5L      $��	İlaçlar��6(   5M      5N      �� 5O      -   5        $	 btnKullanicilar��5S      $��4q�5P      $��Center=�5Q      #���  5R      .��5U      �� $
 
Horizontal=�6%   .+�5V        $ 
AccountCog=�66   $��0 0 3 0q�6H   
�������6Y   �� 5W      $��Kullanıcılar��6(   5X      5Y      �� 5Z      -   5        $	 btnSatislar��5^      $��4q�5[      $��Center=�5\      #���  5]      .��5`      �� $
 
Horizontal=�6%   .+�5a        $ SemanticWeb=�66   $��0 0 3 0q�6I   
�������6Z   �� 5b      $��
Satışlar��6(   5c      5d      �� 5e      -	   5        $	 btnSatis��5i      $��4q�5f      $��Center=�5g      #���  5h      .��5k      �� $
 
Horizontal=�6%   .+�5l        $ CashRegister=�66   $��0 0 3 0q�6J   
�������6[   �� 5m      $��Satış Yap��6(   5n      5o      5q      .��5u      �  � RowDefinitions 5v      �� 5w      $��50 �6$   �� 5x      $��* �6$   .+�5z      �� -
   5        ���#00897B._�5|      �  � ColumnDefinitions 5}      �� 5~      $��50 �6/   �� 5      $��* �6/   �� 5�      $
��Auto �6/   .+�5�      ��    OpenDrawerCommand#��Z 5�      "  System.Windows.Controls.Dock   Left#��Z 5�      $��4 0 0 0q�5�      $��0q�5�       ! PrimaryHueDarkForegroundBrush#��[ 5�        MaterialDesignIconButton#��[ 5�      ��5�      0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ 
Backburger=�5�      �� 5�      $��1��6%   $
 
Horizontal=�65   .+�5�        $ MortarPestlePlus=�66   $��0 0 3 0q�6N   
�������$��Center=�6r   �� 5�      $��Center=�5�      $��3 0 0 0q�5�      ��5�      �� *Title+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�5�      �� 5�      $��2��6%   $
 
Horizontal=�5�   %   $��Center=�5�   %   .+�5�      �� -   5        $	 btnMinimize��5�   %   #��[ 5�   %   #��[ 5�   %   .��5�   "     $ WindowMinimize=�6:   5�      �� 5�      -   5        $	 btnMaximize��5�   %   #��[ 5�   %   #��[ 5�   %   .��5�   "     $ WindowMaximize=�6:   5�      �� 5�      -   5        $	 btnClose��5�   %   #��[ 5�   %   #��[ 5�   %   .��5�   "     $ WindowClose=�6:   5�      5�      5�      5�       � 5�      -   5          �Name$ mainFrm��5�      $��1��5�        � Source$/ )Views/PersonelViews/PersonelListView.xaml?�5�        � NavigationUIVisibility$ Hidden=�5�      5�      5�      5�      5�      