   M S B A M L   `   `   `  ���� D  @Pizzaria1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Pizzaria1	Pizzaria1      Pizzaria1.UCShowOrder   =telerik1http://schemas.telerik.com/2008/xaml/presentation  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:Pizzaria1     U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $
��1000��$��710.576��  � 	Resources     contextMenu m� CommandParameter �� RelativeSource �� Path��%�   &	        �� .@�m� $
��View�� ��  �� *Self+$ Parent�m� $
��Edit�� ��  �� *Self+$ Parent�m� $��Delete�� ��  �� *Self+$ Parent�.��� $��0,0,-0.2,10.2q�.+���  �� Orientation$ 
Horizontal=�$��30��$	��Top=�$��10,50,-5.8,0q� J� RenderTransformOrigin$ 0.5,0.5&�.+��� -    ��Name$ label_Copy6��$��Heavy"����	#FF2196F3$�� الايدي ��$��Center=�$	��Top=�
������ $��5,2,0.2,-0.6q�$��14(�$��62���� -   $ label_Copy7�����	#FF2196F3$��اسم العميل��$��Center=�$	��Top=�
������ $��5,2,0.2,-0.6q�$��14(�$��89���� -   $ label_Copy8�����	#FF2196F3$��رقم التلفون��$��Center=�$	��Top=�
������ $��5,2,0.2,-0.6q�$��14(�$��98���� -   $ label_Copy9�����	#FF2196F3$��المحافظة��$��Center=�$	��Top=�
������ $��5,2,0.2,-0.6q�$��14(�$��96���� -   $ label_Copy13�����	#FF2196F3$��الشارع��$��Center=�$	��Top=�
������ $��5,2,0.2,-0.6q�$��14(�$	��100���� $ 
Horizontal=�$��30��$	��Top=�$��10,75,-5.6,0q�$ 0.5,0.5&�.+��� -    ��Name$ 	txtiduser��{�.  $��Center=�$��29��$��5,2,0.2,-0.6q� �� TextWrapping$
 Wrap=�$	��Top=�$��74�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ txtnamecombnyuser��{�.  $��Center=�$��29��$��5,2,0.2,-0.6q�$
 Wrap=�$	��Top=�$��73�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -	   $ txtphonNumberuser��{�.  $��Center=�$��29��$��5,2,0.2,-0.6q�$
 Wrap=�$	��Top=�$��77�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -
   $ txtcityuser��{�.  $��Center=�$��29��$��5,2,0.2,-0.6q�$
 Wrap=�$	��Top=�$��49�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ txtstreetuser��{�.  $��Center=�$��29��$��5,2,0.2,-0.6q�$
 Wrap=�$	��Top=�$��66�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   	 ��Name$	 btninsertSuplier��$��اضافة العميل��$��5,2,0.2,-0.6q�$��Center=��� $ 
Horizontal=�$��55��$	��Top=�$��10,257,-5.8,0q�$ 0.5,0.5&�.+��� -   $ label_Copy10��$��Center=����	#FF2196F3$�� الايدي��$��Center=�$	��Top=�
������ $��10,10,0.10,10q�$��14(�$ 0.917,0.907&��� -   $ label_Copy1��$��Center=����	#FF2196F3$�� وصف الفاتورة ��$��Center=�$	��Top=�
������ $��10,10,0.1,0q�$��14(�$	��193���� -   $ label_Copy3��$��Center=����	#FF2196F3$��  سعر الحبه��$��Center=�$	��Top=�
������ $��10,10,0.10,10q�$��14(��� -   $ label_Copy2�����	#FF2196F3$��Center=�$�� الكمية��$��Center=�$	��Top=�
������ $��10,10,0.10,10q�$��14(��� -   $ 
label_Copy��$��Center=����	#FF2196F3$��اجمالي��$��Center=�$	��Top=�
������ $��10,10,0.10,10q�$��14(��� -   $ label_Copy4��$��Center=����	#FF2196F3$��تاريخ البيع��$��Center=�$	��Top=�
������ $��10,10,0.10,10q�$��14(��� -   $ label_Copy54��$��Center=����	#FF2196F3$��تاريخ البيع��$��Center=�$	��Top=�
������ $��10,10,0.10,10q�$��14(�$��72���� $ 
Horizontal=�$��55��$	��Top=�$��10,312,0.2,0q�$ 0.5,0.5&�.+��� -   $ txtID_ORDER_INVOICE��
 �� 	IsEnabled
 .  $��Center=�$��29��$��10,10,0.1,0q�$
 Wrap=�$	��Top=�$��79�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $" txtNAMEPRODACT_ORDER_INVOICE��
 .  $��Center=�$��29��$��10,10,0.1,0q�$
 Wrap=�$	��Top=�$��52�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $" txtDESCRIBTUON_ORDER_INVOICE��
 .  $��Center=�$��29��$��
0,10,0.1,0q�$
 Wrap=�$	��Top=�$��84�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ txtPRICE_ORDERinvoice��{�. $��Center=�$��29��$��	10,10,0,0q�$
 Wrap=�$	��Top=�$��73�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ txtQTY_ORDER_INVOICE��
 .  $��Center=�$��29��$��10,10,0.1,0q�$
 Wrap=�$	��Top=�$��63�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ txtTOTAL_AMOUNT_INVOICE��
 .  $��Center=�$��29��$��10,10,0.1,0q�$
 Wrap=�$	��Top=�$��99�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ txtDATE_ORDER_INVOICE��{�. $��Center=�$��29��$��	10,10,0,0q�$
 Wrap=�$	��Top=�$	��103�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� $ 
Horizontal=�$��55��$	��Top=�$ 0.5,0.5&�$	��204��$��10,10,0.1,-9.8q�.+��� -    ��Name$ compySelectday��$
��Left=�$��3,0,0,0q�$	��Top=�$��60��$��29�����	#FF2196F3���	#FF2196F3$��0,0,0,3q�����  �� EndPoint$	 0,1&� �� 
StartPoint$	 0,0&�.���  � Color$ White�� � Offset$ 0Q�� $ White��$ 1Q��� -   $ compySelectmonth��$��Center=�$��3,0,0,0q�$	��Top=�$��68��$��29�����	#FF2196F3���	#FF2196F3$��0,0,0,3q����� $	 0,1&�$	 0,0&�.��� $ White��$ 0Q�� $ White��$ 1Q��� -   $ compySelecyears��$��Right=�$��
3,0,0,25.2q�$��Stretch=�$��63�����	#FF2196F3���	#FF2196F3$��0,0,0,3q����� $	 0,1&�$	 0,0&�.��� $ White��$ 0Q�� $ White��$ 1Q�&   System.Windows.Controls.DataGrid  -     Name$ dataGrid��   AutoGenerateColumns .     CanUserAddRows .  $
��Left=�$��
-2,358,0,0q�$	��992��   AlternatingRowBackground �	#FF2196F3$	��332��$	��Top=� J� 	CacheMode &   System.Windows.Media.BitmapCache     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$  الايدي  ��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *SUPPLIER_ID+  $!   وصف الفاتورة  ��$	 200  �� *DESCRIBTUON_ORDER+  $    سعر الحبه ��$	 100  �� *PRICE_ORDER+  $  الكمية ��$	 100  �� *	QTY_ORDER+  $  اجمالي��$	 100  �� *TOTAL_AMOUNT+  $  تاريخ البيع  ��$	 100  �� *
DATE_ORDER+�� -   $ lblerror��
���  ��$
��Left=�$	��Top=�
������ $��367,198,0,0q�$��14(�$��25��$	��233���� $	��Top=�.+�� ���	#FF0069C0$��10��� $��5q� � RowDefinitions �� $	��11* ��� $��4* �.+��� $ 
Horizontal=�$��Right=�$��0,0,0,-2q�$	��980��$��2��.+��� -    $ 	txtSearch�� �� AcceptsReturn . $��Right=�$��28��$��10,2,0,2q�$
 Wrap=�$��Center=�$	��209�����	#FF2196F3���	#FF2196F3$��0 0 0 3q�.���� -!   $	 	btnsearch�����	#FF2196F3$��0q�$��بحث��$��Center=�$	��103��$��32��$��0,0,0,0q��� -"   $	 btnexportpdf�����	#FF2196F3$��0q�$��تصدير كتاب��$��Center=�$	��120��$��32��$��0,0,0,0q��� -#   $	 btnprintalldataingride��$(��"طباعة كل المنتوجات��$��2,0,0,0q�$��Bottom=�$	��147���� -$   $	 btnselectprint��$-��'طباعة المنتوج المحدد ��$��2,0,0,0q�$��Center=�$	��155���� -%   $	 btnDelet��$��حذف��$��2,0,0,0q�$��Center=�$��75�����	#FF2196F3�� -&   $	 	btnupdate��$��
تعديل�����	#FF2196F3
�������$��2,0,0,0q�$��Right=�$��0q�$��Center=�$��75���� -'   $	 	btninsert��$��
اضافة��$��2,0,0,0q�$��Center=�$��75��  -(   $ dataGridSuplier�� .   .  $
��Left=�$��
-2,109,0,0q�$	��430�� �	#FF2196F3$	��145��$	��Top=�   $  الايدي  ��$ 60  �� *SUPPLIER_ID+  $   اسم المحل ��$	 100  �� *COMPANY_NAME+  $   التلفون ��$	 100  �� *PHONE_NUMBER+  $   المحافظة ��$	 100  �� *CITY+  $   الشارع ��$	 100  �� *STREET+� ���	#FF0069C0$��434,107,550.2,439.2q�� ���	#FF0069C0$��10,259,0.2,431.2q��� -)   $	 btninsertNewSuplier��$��اضافة  منتج��$��853,76,19.2,592.2q�$��Center=�  -*   $ dataGridProdact�� . $
��Left=�$��455,109,0,0q�$	��535�� �	#FF2196F3$	��143��$	��Top=�   $  رقم المنتج��$ 50  �� *	PRODECTid+  $  اسم المنتج��$	 100  �� *NAMEORodect+  $ وصف المنتج��$	 110  �� *DESCRIPTIONPRODUCT+  $ الكمية��$ 70  �� *
quantyty+  $  السعر ��$ 70  �� *PRICE+  $   وصف الصنف ��$	 150  �� *DESCRIPTIONCATEGURY+