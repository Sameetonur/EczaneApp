   M S B A M L   `   `   `  ����H  DEczaneApp.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:EczaneApp.Wpf.Views.SatisViewsEczaneApp.Wpf.Views.SatisViews  5      2    ,EczaneApp.Wpf.Views.SatisViews.SatisListView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:EczaneApp.Wpf.Views.SatisViews     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  SatisListView��5	         MaterialDesignBody#���   5   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper N� 
Background# �  5   
     MaterialDesignFont N� 
FontFamily# �  5   
    � Language$ tr-TR�5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� $��
Satışlar��6      MaterialDesignBody1TextBlock#��[ 5      $
��10 5q�5      $��Center=�5      $��Right=�5      �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5       ��   MaterialDesignFlatButton#��[ 6   ��5!      �� *
SilCommand+��5"      �� *SelectedItem+.��5#      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Trash=�6*   5$      �� 5%      #��[ 6   ��5&      �� *DetayCommand+��5'      �� *SelectedItem+.��5(        $ Looks=�6*   5)      5*      &   System.Windows.Controls.DataGrid  5+   
   $��1��5,      	   AutoGenerateColumns	 .  
   SelectionMode$
 Single=�5.         SelectionUnit$ FullRow=�5/         
IsReadOnly . ��51      �� *Items+ �� SelectedItem 52      �� *SelectedItem+   Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  55      $ Tarih��6%    64   �� *Tarih+ �� StringFormat$ {0:dd.MM.yy HH.mm.ss}��  56      $ Tutar��6%    64   �� *Tutar+$ C2��  57      $ 	Müşteri��6%    66   �� *
Musteri.Ad+  58      $ Personel��6%    67   �� *Personel.Ad+5:      5;      5<      