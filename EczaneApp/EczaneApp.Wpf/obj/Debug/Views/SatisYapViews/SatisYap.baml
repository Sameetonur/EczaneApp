   M S B A M L   `   `   `  ����H  DEczaneApp.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:EczaneApp.Wpf.Views.SatisYapViews!EczaneApp.Wpf.Views.SatisYapViews  5   	   0    *EczaneApp.Wpf.Views.SatisYapViews.SatisYap   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:EczaneApp.Wpf.Views.SatisYapViews     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          � Title$  Satış��5   	   $	��600��6   $
��1000��6$      MaterialDesignBody#���   5   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�66    � Language$ tr-TR�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   �� -   5        ���#00897B._�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $
��Auto �6'   .+�5"      �� 	 �� Orientation$	 
Horizontal=�6   $��3 0 0 0q�66   .+�5#      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 CashRegister=�6.   $��0 0 3 0q�6B   
�������$��Center=�5$   A   �� 5%      $��Center=�5&      $��3 0 0 0q�5'      ��5(      �� *Title+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�5)      �� 5+      $��1��6   $	 
Horizontal=�5,   %   $��Center=�5-   %   .+�5/      �� -   5         ��Name$ btnMinimize��50   %     MaterialDesignFlatButton#��[ 5/       ! PrimaryHueDarkForegroundBrush#��[ 51   %   .��53        $
 WindowMinimize=�62   54      �� 55      -   5        $ btnMaximize��56   %   #��[ 55      #��[ 57   %   .��59        $
 WindowMaximize=�62   5:      �� 5;      -   5        $ btnClose��5<   %   #��[ 5;      #��[ 5=   %   .��5?        $
 WindowClose=�62   5@      5A      5B      5C      � 5D   
   $��1��6    5E      �� 5F      $��50 �6    �� 5G      $��* �6    �� 5H      $��70 �6     5J      �� 5K      $	��450 �6#   �� 5L      $��* �6#   �� 5M      $	��450 �6#   .+�5P      �� $��	İlaçlar��6      MaterialDesignBody1TextBlock#��[ 5Q      $
��10 5q�5R      &   System.Windows.Controls.DataGrid  5S      $��1��5T         AutoGenerateColumns .     SelectionMode$ Single=�5V         SelectionUnit$ FullRow=�5W         
IsReadOnly . ��5Y      �� *	ItemsIlac+ �� SelectedItem 5Z      �� *SelectedItemIlac+   Columns 5[      0  *System.Windows.Controls.DataGridTextColumn  5\      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)      
Visibility$ Hidden=�6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+6L     5]      $ Ad��6)    65   �� *Ad+  5^      $	 SKT��6)    66   �� *SKT+ �� StringFormat$ {0:dd.MM.yy}��  5_      $ Fiyat��6)    68   �� *Fiyat+$ C2��  5`      $
 Adet��6)    67   �� *Adet+  5a      $ Kategori��6)    6;   �� *Kategori.Ad+5c      �� 5e      $��1��6   $��1��6&   $	 Vertical=�66   $��Center=�6M   $��Center=�6h   .+�5f      �� $	��0 5q�5g       � ToolTip$ Sepete Ekle��5j      ��5f      0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ 
ArrowRight=���5h      �� *
SepeteEkle+��5i      �� *SelectedItemIlac+5j      �� 5k      $	��0 5q�5l      $ Sepetten Çıkar��5o      ��5k        $ 	ArrowLeft=���5m      �� *SepettenCikar+��5n      �� *SelectedItemDetay+5o      �� 5p      $	��0 5q�5q      
���  ��$ Sepeti İptal Et��5t      ��5p        $ Close=���5s      �� *
SepetIptal+5t      �� 5u      $	��0 5q�5v      
��� � �$ Sepeti Onayla��5y      ��5u        $ CheckOutline=���5x      �� *SepetOnayla+5y      5z      �� 5|      $��Sepet��6   $��2��5}      #��[ 5~      $
��10 5q�5        5�      $��2��5�      $��1��5�       .  $ Single=�5�      $ FullRow=�5�       . ��5�      �� *ItemsDetaylar+ 5�      �� *SelectedItemDetay+ 5�        5�      $ Id��6-   $ Hidden=�6P    69   �� *Id+6P     5�      $ İlaç��6-    6;   �� *	Ilac.Ad+  5�      $ Adedi��6-    6<   �� *Adet+  5�      $ Adet Fiyatı��6-    6B   �� *	AdetFiyat+$ C2��  5�      $ Tutar��6-    6<   �� *Tutar+$ C2��5�      �� 5�      $��Bottom=�6   $��Right=�5�      $	 
Horizontal=�5�      $��2��5�      $��3��5�      .+�5�      �� $��Toplam Tutar : ��6    $
��10 5q�67   #��[ 5�       �� 5�      #��[ 5�      $
��10 5q�5�      ��5�       �� *ToplamTutar+$ C2��5�      5�      �� 5�      -   5         ��Name$ 
musteriler��5�      $��2��5�      $��10 5 0 0q�5�      $	��300��5�       & "MaterialDesignFloatingHintComboBox#��[ 5�       �� SelectedValuePath$ Id��5�       �� DisplayMemberPath$ Ad��5�      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Müşteri��5�      .	  (MaterialDesignThemes.Wpf.TextFieldAssist 	  HasClearButton . ��5�      �� *
Musteriler+ 5�      �� *SelectedMusteri+ �� UpdateSourceTrigger$ PropertyChanged=��� 5�      $	 Vertical=�6   $��2��60   $��1��5�      .+�5�      �� $��Personel��6   $��Center=�6,   $	��0 3q�6I   �� 5�      �� 5�      $��Center=�69   $	��0 3q�6V   ��6   �� *Personel.Ad+6V   5�      5�      5�      5�      