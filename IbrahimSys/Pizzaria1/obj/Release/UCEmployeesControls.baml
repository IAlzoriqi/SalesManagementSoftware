   M S B A M L   `   `   `  ���� D  @Pizzaria1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Pizzaria1	Pizzaria1  #    Pizzaria1.UCEmployeesControls   =telerik1http://schemas.telerik.com/2008/xaml/presentation  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:Pizzaria1     U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $
��1000��$��731.376��  � 	Resources     contextMenu m� CommandParameter �� RelativeSource �� Path��%�   &	        �� .@�m� $
��View�� ��  �� *Self+$ Parent�m� $
��Edit�� ��  �� *Self+$ Parent�m� $��Delete�� ��  �� *Self+$ Parent�.��� $��0,0,-0.2,10.2q� � RowDefinitions �� $
��652* ��� $	��49* �.+�&   System.Windows.Controls.DataGrid  -     Name$ dataGrid��   AutoGenerateColumns . $
��Left=�$��0,75,0,0q�$	��708��   AlternatingRowBackground �	#FF2196F3$	��625��$	��Top=�$��2��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	  الرقم ��
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 50 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *EMPLOYEE_ID+  $	  اسم الاول��$	
 100  �� *
FIRST_NAME+  $	 الاسم الاخير��$	
 100  �� *	LAST_NAME+  $	 التلفون��$	
 100  �� *PHONE_NUMBER+  $	  الايميل ��$	
 100  �� *EMAIL+  $!	  تاريخ التوظيف ��$	
 100  �� *
HIRED_DATE+  $	  الوظيفة ��$
 50  �� *JOB_ID+  $"	   عنوان الوظيفة ��$	
 100  �� *	JOB_TITLE+  $	  الراتب��$	
 100  �� *SALARY+  $	  العملة��$
 50  �� *Curence_Type+  $	 الموقع��$
 50  �� *LOCATION_ID+�� $	��Top=�$��730,75,0.2,0q�$	��625��$��2��.+�� ���	#FF0069C0$��10��� $��-1,5,5,5q�$	��611��.+���  �� Orientation$ Vertical=�$	��609��$	��Top=�$��10,-8,0.4,0q�.+��� -    ��Name$ label�����	#FF2196F3$
��Left=�$	��Top=�
������ $��	83,12,0,0q�$��14(��� -   $ label_Copy5�����	#FF2196F3$��رقم الموظف ��$��Center=�$	��Top=�
������ $��0,0,0,0q�$��14(��� -    ��Name$ txtid��{�.  $��Center=�$��29��$��0,2,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ 
label_Copy�����	#FF2196F3$�� الاسم الاول��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -   $ txtFIRST_NAME��$��Center=�$��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ label_Copy1�����	#FF2196F3$��الاسم الاخير��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -	   $ txtlastname�� �� 	IsEnabled .  $��Center=�$��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -
   $ label_Copy2�����	#FF2196F3$��  رقم التلفون ��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -   $ 
txtphoneno��$��Center=�$��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ label_Copy4�����	#FF2196F3$�� الايميل��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -   $ txtemail��$��Center=�$��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ label_Copy3�����	#FF2196F3$'��! رقم تاريخ التوظيف��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -   $ txtdate��$��Center=�{�.  $��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� $ 
Horizontal=�$��46��$	��Top=�$��10,389,0.6,0q�.+��� -    ��Name$ compySelectday��$
��Left=�$��3,0,0,0q�$	��Top=�$��78��$��29�����	#FF2196F3���	#FF2196F3$��0,0,0,3q�����  �� EndPoint$	 0,1&� �� 
StartPoint$	 0,0&�.���  � Color$ White�� � Offset$ 0Q�� $ White��$ 1Q��� -   $ compySelectmonth��$��Center=�$��3,0,0,0q�$	��Top=�$��86��$��29�����	#FF2196F3���	#FF2196F3$��0,0,0,3q����� $	 0,1&�$	 0,0&�.��� $ White��$ 0Q�� $ White��$ 1Q��� -   $ compySelecyears��$��Right=�$��3,0,0,2q�$	��Top=�$��78��$��29�����	#FF2196F3
������ $��0,0,0,3q����� $	 0,1&�$	 0,0&�.��� $ Wheat��$ 0Q�� $ Wheat��$ 1Q��� $ Vertical=�$	��161��$	��Top=�$��10,440,0.6,0q�.+��� -   $ label_Copy6�����	#FF2196F3$�� رقم الوظيفة��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -   $ txtjopno��$��Center=�$��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ label_Copy7�����	#FF2196F3$�� رقم الموقع��$��Center=�$	��Top=�
������ $��0,2,0,0q�$��14(��� -   $ txtlocationno��$��Center=�$��29��$��0,2,0,0q�$
 Wrap=�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ lblSomSalary��$��Center=�$��29��$��1.1,2,1.1,0q�$	��Top=�$	��253�����	#FF2196F3���	#FF2196F3$��0 0 0 3q��� -   $ lblerror��
���  ��$
��Left=�$	��Top=�
������ $��
252,50,0,0q�$��14(�$��25��$	��233���� $	��Top=�$��	0,0,0.2,0q�.+�� ���	#FF0069C0$��10��� $��5q� �� $	��11* ��� $��4* �.+��� $ 
Horizontal=�$��Right=�$��0,0,0,-2q�$	��980��$��2��.+��� -   $ 	txtSearch�� �� AcceptsReturn . $��Right=�$��28��$��10,2,0,2q�$
 Wrap=�$��Center=�$	��209�����	#FF2196F3���	#FF2196F3$��0 0 0 3q�.���� -    ��Name$ 	btnsearch�����	#FF2196F3$��0q�$��بحث��$��Center=�$	��103��$��32��$��0,0,0,0q��� -   $ btnexportpdf�����	#FF2196F3$��0q�$��تصدير كتاب��$��Center=�$	��120��$��32��$��0,0,0,0q��� -   $ btnprintalldataingride��$(��"طباعة كل المنتوجات��$��2,0,0,0q�$��Bottom=�$	��147���� -   $ btnselectprint��$-��'طباعة المنتوج المحدد ��$��2,0,0,0q�$��Center=�$	��155���� -   $ btnDelet��$��حذف��$��2,0,0,0q�$��Center=�$��75�����	#FF2196F3�� -   $ 	btnupdate��$��
تعديل�����	#FF2196F3
�������$��2,0,0,0q�$��Right=�$��0q�$��Center=�$��75���� -    $ 	btninsert��$��
اضافة��$��2,0,0,0q�$��Center=�$��75��