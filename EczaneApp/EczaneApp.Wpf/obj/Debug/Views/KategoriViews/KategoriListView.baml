   M S B A M L   `   `   `  ����H  DEczaneApp.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:EczaneApp.Wpf.Views.KategoriViews!EczaneApp.Wpf.Views.KategoriViews  5      8    2EczaneApp.Wpf.Views.KategoriViews.KategoriListView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:EczaneApp.Wpf.Views.KategoriViews     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  KategoriListView��5	         MaterialDesignBody#���   5   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper N� 
Background# �  5   
     MaterialDesignFont N� 
FontFamily# �  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� $��Kategoriler��6      MaterialDesignBody1TextBlock#��[ 5      $
��10 5q�5      $��Center=�5      $��Right=�5      �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      ��   MaterialDesignFlatButton#��[ 6   ��5       �� *EkleCommand+.��5!      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$	 Add=�6*   5"      �� 5#      #��[ 6   ��5$      �� *
SilCommand+��5%      �� *SelectedItem+.��5&        $ Trash=�6*   5'      �� 5(      #��[ 6   ��5)      �� *GuncelleCommand+��5*      �� *SelectedItem+.��5+        $ Pencil=�6*   5,      5-      &   System.Windows.Controls.DataGrid  5.   
   $��1��5/         AutoGenerateColumns .  	   SelectionMode$	 Single=�51      
   SelectionUnit$
 FullRow=�52         
IsReadOnly . ��54      �� *Items+ �� SelectedItem 55      �� *SelectedItem+   Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  58      $ Ad��6%    61   �� *Ad+5:      5;      5<      