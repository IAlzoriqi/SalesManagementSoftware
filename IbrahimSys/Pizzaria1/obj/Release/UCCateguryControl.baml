   M S B A M L   `   `   `  ���� D  @Pizzaria1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Pizzaria1	Pizzaria1  !    Pizzaria1.UCCateguryControl   =telerik1http://schemas.telerik.com/2008/xaml/presentation  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:Pizzaria1     U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $
��1000��$��710.576��  � 	Resources     contextMenu m� CommandParameter �� RelativeSource �� Path��%�   &	        �� .@�m� $
��View�� ��  �� *Self+$ Parent�m� $
��Edit�� ��  �� *Self+$ Parent�m� $��Delete�� ��  �� *Self+$ Parent�.��� $��0,0,-0.2,10.2q�.+�&   System.Windows.Controls.DataGrid  -     Name$ dataGrid��   AutoGenerateColumns . $
��Left=�$��0,75,0,0q�$	��732��   AlternatingRowBackground �	#FF2196F3$	��625��$	��Top=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$  رقم الصنف ��	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *CATEGORY_ID+  $  اسم الصنف ��$		 100 
 �� *NAME+  $   وصف الصنف ��$		 200 
 �� *DESCRIPTION+�� $	��Top=�$��730,75,0.2,0q�$	��625��.+�� ���	#FF0069C0$��10��� $��-1,5,5,5q�$	��611��.+���  �� Orientation$ Vertical=�$	��609��$	��Top=�$��10,-8,0.4,0q�.+��� -    ��Name$ label�����	#FF2196F3$
��Left=�$	��Top=�
������ $��	83,12,0,0q�$��14(��� -   $ label_Copy5�����	#FF2196F3$��الرقم الصنف��$��Center=�$	��Top=�
������ $��0,0,0,0q�$��14(��� -    ��Name$ txtid��{�.  $��Center=�$��29��$��0,2,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ 
label_Copy�����	#FF2196F3$�� اسم الصنف��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -   $ txtFIRST_NAME��$��Center=�$��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ label_Copy1�����	#FF2196F3$��وصف الصنف��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -	   $ 
txtdescrib�� �� 	IsEnabled .  $��Center=�$��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -
   $ lblerror��
���  ��$
��Left=�$	��Top=�
������ $��
252,50,0,0q�$��14(�$��25��$	��233���� $	��Top=�.+�� ���	#FF0069C0$��10��� $��5q� � RowDefinitions �� $	��11* ��� $��4* �.+��� $ 
Horizontal=�$��Right=�$��0,0,0,-2q�$	��980��$��2��.+��� -   $ 	txtSearch�� �� AcceptsReturn . $��Right=�$��28��$��10,2,0,2q�$
 Wrap=�$��Center=�$	��209�����	#FF2196F3���	#FF2196F3$��0 0 0 3q�.���� -    ��Name$ 	btnsearch�����	#FF2196F3$��0q�$��بحث��$��Center=�$	��103��$��32��$��0,0,0,0q��� -   $ btnexportpdf�����	#FF2196F3$��0q�$��تصدير كتاب��$��Center=�$	��120��$��32��$��0,0,0,0q��� -   $ btnprintalldataingride��$%��طباعة كل الاصناف ��$��2,0,0,0q�$��Bottom=�$	��147���� -   $ btnselectprint��$-��'طباعة المنتوج المحدد ��$��2,0,0,0q�$��Center=�$	��155���� -   $ btnDelet��$��حذف��$��2,0,0,0q�$��Center=�$��75�����	#FF2196F3�� -   $ 	btnupdate��$��
تعديل�����	#FF2196F3
�������$��2,0,0,0q�$��Right=�$��0q�$��Center=�$��75���� -   $ 	btninsert��$��
اضافة��$��2,0,0,0q�$��Center=�$��75��