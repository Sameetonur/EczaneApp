   M S B A M L   `   `   `  ����H  DEczaneApp.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:EczaneApp.Wpf.Views.SatisViewsEczaneApp.Wpf.Views.SatisViews  5   	   0    *EczaneApp.Wpf.Views.SatisViews.SatisWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:EczaneApp.Wpf.Views.SatisViews     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	     � Title$  Satış Detayları��5   	   $	��450��6!   $	��400��6.      MaterialDesignBody#���   5   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�66    � Language$ tr-TR�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� -   5        ���#00897B._�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5       $
��Auto �6'   .+�5#      �� $��Center=�5$      $��10 0 0 0q�5%      ��5&      �� *Title+	 �� RelativeSource	 �� *FindAncestor+
 �� AncestorType$
 WindowL��� 5'      $��1��6    �� Orientation$ 
Horizontal=�5(   %   $��Center=�5)   %   .+�5+      �� -   5         ��Name$ btnClose��5,   %     MaterialDesignFlatButton#��[ 5+       ! PrimaryHueDarkForegroundBrush#��[ 5-   %   .��5/      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowClose=�62   50      51      53      54      &   System.Windows.Controls.DataGrid  55   
   $��1��6      AutoGenerateColumns .     SelectionMode$ Single=�57         SelectionUnit$ FullRow=�58         
IsReadOnly . ��5:      �� *Items+ �� SelectedItem 5;      �� *SelectedItem+   Columns 5<      0  *System.Windows.Controls.DataGridTextColumn  5=      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5>      $ İlaç��6%    63   �� *	Ilac.Ad+  5?      $
 Adet��6%    63   �� *Adet+  5@      $ 
Adet Fiyat��6%    69   �� *	AdetFiyat+ �� StringFormat$ C2��  5A      $ Tutar��6%    64   �� *Tutar+$ C2��5C      5D      5E      