   M S B A M L   `   `   `  ����@  <CNC12, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CNC12.ViewsCNC12.Views  5   	   7 clr-namespace:CNC12.UserControlsCNC12.UserControls  5	   	       CNC12.Views.ReportWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CNC12.Views     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   )uc clr-namespace:CNC12.UserControls  5	   	   -   5        $��ReportWindow1��5   	      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	     VMreportWindow � DataContext# [ 5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � Title$ REPORT SCREEN��5   	   $	��800��5   	   $
��1500��6   .��5      �  J� OpacityMask 5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      � 	 � Color$	 White��6   
 � Offset$
 0.274Q�6-   � 5      $	 Black��6   $
 0.547Q�6-   5        � RowDefinitions 5"   
   �� 5#      $
��auto �6   6,   �� 5$      $��80 �6   6*   �� 5%      6   .+�5*   
   � $��0��6   .+�5+      #   CNC12.UserControls.ControlBar  
 � Tag 6   �� *Title+ �� ElementName$ ReportWindow1��6O   5,      �� 5.   
   $��2��6   .+�50      #  MaterialDesignThemes.Wpf.Card  $	��430��6"   $��2��6/   $��5q�6<   $��Stretch=�6G   .��51      �� $
��Auto=�6   .��52      �� ��6    �� *
ListData+ �� View 54      �� 55      .P�56   "   ��  �� Width$
 auto��61   $��Id��6>    �� DisplayMemberBinding 6J   �� *Id+6p   �� 57   "   $	 150��61   $��	Tên máy��6=    6N   �� *IdCNC+6w   �� 58   "   $	 250��61   $��Hiện trạng máy CNC��6=    6Y   �� *IdHienTrangMayCNC+6�   �� 59   "   $	 250��61   $#��Hiện trạng của máy CNC��6=    6]   �� *IdHienTrangCuaMayCNC+6�   �� 5:   "   $	 250��61   $��Ngày��6=    6K   �� *Ngay+6s   �� 5;   "   $	 250��61   $��Thời điểm��6=    6P   �� *
ThoiDiem+6|   5=      5?      5@      5A      �� 5B      -   5         ��Name$ 	btnImport��5B      $��60��5C      $��30(�5D      $��Import��5F      ��5E      �� *ImportCommand+5F   (   �� 5G      $��5��6   �� 5H      -   5        $ 	btnExport��5H      $��60��5I      $��30(�5J      $��Export��5L      ��5K      �� *ExportCommand+5L   (   5M      5N      5O      