   M S B A M L   `   `   `  ���� D  @Pizzaria1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Pizzaria1	Pizzaria1      Pizzaria1.UCShowProdect   =telerik1http://schemas.telerik.com/2008/xaml/presentation  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:Pizzaria1     U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $
��1000��$��710.576��  � 	Resources     contextMenu m� CommandParameter �� RelativeSource �� Path��%�   &	        �� .@�m� $
��View�� ��  �� *Self+$ Parent�m� $
��Edit�� ��  �� *Self+$ Parent�m� $��Delete�� ��  �� *Self+$ Parent�.��� $��0,0,-0.2,10.2q�.+�&   System.Windows.Controls.DataGrid  -     Name$ dataGrid��   AutoGenerateColumns . $
��Left=�$��0,75,0,0q�$	��732��   AlternatingRowBackground �	#FF2196F3$	��561��$	��Top=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$  رقم المنتج��	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *	PRODECTid+  $  اسم المنتج��$		 100 
 �� *NAMEORodect+  $ وصف المنتج��$		 150 
 �� *DESCRIPTIONPRODUCT+  $ الكمية��$	 50 
 �� *
quantyty+  $  السعر ��$	 50 
 �� *PRICE+  $  رقم الصنف ��$	 50 
 �� *
CATEGORYID+  $  اسم الصنف ��$	 50 
 �� *NAMECATEGURY+  $   وصف الصنف ��$		 150 
 �� *DESCRIPTIONCATEGURY+�� $	��Top=�$��730,75,0.2,0q�$	��625��.+�� ���	#FF0069C0$��10��� $��-1,5,5,5q�$	��611��.+���  �� Orientation$ Vertical=�$	��609��$	��Top=�$��10,-8,0.4,0q�.+��� -    ��Name$ label�����	#FF2196F3$
��Left=�$	��Top=�
������ $��	83,12,0,0q�$��14(��� -   $ label_Copy5�����	#FF2196F3$��الرقم المنتج��$��Center=�$	��Top=�
������ $��0,0,0,0q�$��14(��� -    ��Name$ txtid��{�.  $��Center=�$��29��$��0,2,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ 
label_Copy�����	#FF2196F3$�� الاسم المنتج��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -   $ txtFIRST_NAME��$��Center=�$��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ label_Copy1�����	#FF2196F3$��وصف المنتج��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -	   $ 
txtdescrib�� �� 	IsEnabled .  $��Center=�$��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -
   $ label_Copy2�����	#FF2196F3$��  الكمية ��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -   $ txtqty��$��Center=�$��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ label_Copy4�����	#FF2196F3$�� السعر��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -   $ txtprice��$��Center=�$��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ label_Copy3�����	#FF2196F3$�� رقم الصينف��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -   $ 
txtcategid��$��Center=�$��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ label_Copy6�����	#FF2196F3$��اسم الدخول��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -   $ txtusername��$��Center=�$��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ label_Copy7�����	#FF2196F3$��كلمة السر��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -   $ txtpass��$��Center=�$��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ label_Copy8�����	#FF2196F3$��كلمة السر��$��Center=�$	��Top=�
������ $��94.8,2,94.8,0q�$��14(��� $ 
Horizontal=�$��54��$��Bottom=�$��0,0,0.2,10.2q� J� RenderTransformOrigin$ 0.5,0.5&�$��Right=�$	��998��.+�� ���	#FF0069C0$��10��� $��
-1,0,5,0.4q�$	��997�� � ColumnDefinitions �� $
��439* ��� $
��558* �.+��� -   $ lblSumSalary�����	#FF2196F3$�� ��$
��Left=�
������ $��
23.8,0,0,0q�$��14(�$��1��$	��143���� -   $ lb�����	#FF2196F3$��الاجمالي��$��Center=�
������ $��400,10,538.8,10q�$��14(�$��2���� -   $ lblerror��
���  ��$
��Left=�$	��Top=�
������ $��
252,50,0,0q�$��14(�$��25��$	��233���� $	��Top=�.+�� ���	#FF0069C0$��10��� $��5q� � RowDefinitions �� $	��11* ��� $��4* �.+��� $ 
Horizontal=�$��Right=�$��0,0,0,-2q�$	��980��$��2��.+��� -   $ 	txtSearch�� �� AcceptsReturn . $��Right=�$��28��$��10,2,0,2q�$
 Wrap=�$��Center=�$	��209�����	#FF2196F3���	#FF2196F3$��0 0 0 3q�.���� -    ��Name$ 	btnsearch�����	#FF2196F3$��0q�$��بحث��$��Center=�$	��103��$��32��$��0,0,0,0q��� -   $ btnexportpdf�����	#FF2196F3$��0q�$��تصدير كتاب��$��Center=�$	��120��$��32��$��0,0,0,0q��� -   $ btnprintalldataingride��$(��"طباعة كل المنتوجات��$��2,0,0,0q�$��Bottom=�$	��147���� -   $ btnselectprint��$-��'طباعة المنتوج المحدد ��$��2,0,0,0q�$��Center=�$	��155���� -   $ btnDelet��$��حذف��$��2,0,0,0q�$��Center=�$��75�����	#FF2196F3�� -   $ 	btnupdate��$��
تعديل�����	#FF2196F3
�������$��2,0,0,0q�$��Right=�$��0q�$��Center=�$��75���� -   $ 	btninsert��$��
اضافة��$��2,0,0,0q�$��Center=�$��75���� -    $ label1��$
��Left=�$��	10,50,0,0q�$	��Top=�.���� -!   $ labalerr��$�� ��
���  ��