   M S B A M L   `   `   `  ����D  @Pizzaria1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Pizzaria1	Pizzaria1  5      !    Pizzaria1.UCCateguryControl   5      =telerik1http://schemas.telerik.com/2008/xaml/presentation  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Pizzaria1     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $
��1000��5
      $��710.576��6,     � 	Resources  5         contextMenu m� CommandParameter �� RelativeSource �� Path��%  &	        �� 5   
   .@�5      m� $
��View��6    5      ��  �� *Self+$ Parent�m� 5      $
��Edit��6    5      ��  �� *Self+$ Parent�m� 5      $��Delete��6    5      ��  �� *Self+$ Parent�5      5      .��5      � $��0,0,-0.2,10.2q�6   .+�5    
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5    /      AutoGenerateColumns . $
��Left=�6o   $��0,75,0,0q�6�   $	��732��6�      AlternatingRowBackground �	#FF2196F3$	��625��6�   $	��Top=�6�      Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$  رقم الصنف ��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 6Z   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6:   �� *CATEGORY_ID+6h     5$      $  اسم الصنف ��6%   $		 100 6T   
 6:   �� *NAME+6b     5&      $   وصف الصنف ��6%   $		 200 6\   
 6;   �� *DESCRIPTION+6j   5(      �� 5+   
   $	��Top=�6   $��730,75,0.2,0q�6-   $	��625��6C   .+�5-      � ���	#FF0069C0$��10��6*   � 5.      $��-1,5,5,5q�6   $	��611��6%   .+�5/      ��  �� Orientation$ Vertical=�6   $	��609��64   $	��Top=�6A   $��10,-8,0.4,0q�6Y   .+�51      �� -   5         ��Name$ label��51      ���	#FF2196F3$
��Left=�6B   $	��Top=�6]   
������ $��	83,12,0,0q�6�   $��14(�6�   �� 55      -   5        $ label_Copy5��55      ���	#FF2196F3$��الرقم الصنف��6H   $��Center=�6^   $	��Top=�6{   
������ $��0,0,0,0q�6�   $��14(�6�   �� 56      -   5         ��Name$ txtid��56      {�.  $��Center=�6@   $��29��6]   $��0,2,0,0q�6i    �� TextWrapping$
 Wrap=�6z   $	��Top=�6�   $	��253��6�   ���	#FF2196F3���	#FF2196F3$��0 0 0 3q�6�   �� 58      -   5        $ 
label_Copy��58      ���	#FF2196F3$�� اسم الصنف��6G   $��Center=�6\   $	��Top=�6y   
������ $��0,2,0,0q�6�   $��14(�6�   �� 59      -   5        $ txtFIRST_NAME��59      $��Center=�65   $��29��6R   $��0,2,0,0q�6^   $
 Wrap=�6o   $	��Top=�6�   $	��253��6�   ���	#FF2196F3���	#FF2196F3$��0 0 0 3q�6�   �� 5;      -   5        $ label_Copy1��5;      ���	#FF2196F3$��وصف الصنف��6H   $��Center=�6\   $	��Top=�6y   
������ $��0,2,0,0q�6�   $��14(�6�   �� 5<      -	   5        $ 
txtdescrib��5<       �� 	IsEnabled .  $��Center=�6Q   $��29��6n   $��0,2,0,0q�6z   $
 Wrap=�6�   $	��Top=�6�   $	��253��6�   ���	#FF2196F3���	#FF2196F3$��0 0 0 3q�6�   5?      5@      5B      �� 5D   
   -
   5        $ lblerror��5D      
���  ��$
��Left=�63   $	��Top=�6N   
������ $��
252,50,0,0q�6   $��14(�6�   $��25��6�   $	��233��6�   �� 5F   
   $	��Top=�6   .+�5G      � ���	#FF0069C0$��10��6*   � 5H      $��5q�6    � RowDefinitions 5I      �� 5J      $	��11* �6$   �� 5K      $��4* �6$   .+�5M      �� $ 
Horizontal=�6   $��Right=�66   $��0,0,0,-2q�6R   $	��980��6d   $��2��6p   .+�5O      �� -   5        $ 	txtSearch��5O       �� AcceptsReturn . $��Right=�6k   $��28��6�   $��10,2,0,2q�6�   $
 Wrap=�6�   $��Center=�6�   $	��209��6�   ���	#FF2196F3���	#FF2196F3$��0 0 0 3q�6  .��6)  5Q      �� 5R      -   5         ��Name$ 	btnsearch��5R      ���	#FF2196F3$��0q�6`   $��بحث��6t   $��Center=�6�   $	��103��6�   $��32��6�   $��0,0,0,0q�6�   �� 5S      -   5        $ btnexportpdf��5S      ���	#FF2196F3$��0q�6f   $��تصدير كتاب��6z   $��Center=�6�   $	��120��6�   $��32��6�   $��0,0,0,0q�6�   �� 5U      -   5        $ btnprintalldataingride��5U      $%��طباعة كل الاصناف ��5W      $��2,0,0,0q�6:   $��Bottom=�6K   $	��147��6f   �� 5Y      -   5        $ btnselectprint��5Y      $-��'طباعة المنتوج المحدد ��6R   $��2,0,0,0q�6s   $��Center=�6�   $	��155��6�   �� 5Z      -   5        $ btnDelet��5Z      $��حذف��6F   $��2,0,0,0q�6U   $��Center=�6f   $��75��6�   ���	#FF2196F36�   �� 5\      -   5        $ 	btnupdate��5\      $��
تعديل��60   ���	#FF2196F3
�������$��2,0,0,0q�6�   $��Right=�6�   $��0q�6�   $��Center=�6�   $��75��6�   �� 5]      -   5        $ 	btninsert��5]      $��
اضافة��6H   $��2,0,0,0q�6X   $��Center=�6i   $��75��6�   5d      5e      5f      5j      5l      