   M S B A M L   `   `   `  ����D  @Pizzaria1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Pizzaria1	Pizzaria1  5          Pizzaria1.UCAddProdacts   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Pizzaria1     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        .��5
      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  TrainsitionigContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      ��  �� Orientation$ 
Horizontal=�6   $��Bottom=�62   .+�5      � ��6   Z� .+�5      �� .+�5      � $
��Left=�6   $	��616��6:   $��0,44,-0.4,0q�6G   $	��Top=�6\   $	��626��6t    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��6�   Z� .+�5      �� -   5         ��Name$ txtprodctname��5   &   $
��Left=�6=   $��30��6X   $��146,115,0,0q�6d    �� TextWrapping$
 Wrap=�6y   $�� ��6�   $	��Top=�6�   $	��278��6�   
�������$��0,0,0,3q�6�   ���	#FF2196F3���	#FF2196F36�   �� 5      -   5         ��Name$ labelCreateAcount��5   $   $�� اضافة منتجات ��6?   ���	#FF2196F3$
��Left=�6o   $��35��6�   $��
199,19,0,0q�6�   $	��Top=�6�   $	��136��6�   
������ $��Segoe UI Black)�6�   $��20(�6  �� 5      -   5        $ label��5   $   ���	#FF2196F3$&�� ادخل الاسم المنتج��6J   $
��Left=�6f   $	��Top=�6�    �� Left$	 201��6�   
	 �� Top$		 150��6�   
������ $��
228,81,0,0q�6�   $��14(�6�   �� 5      -   5        $ 
txtquality��5   &   $
��Left=�6_   $��12(�6z   $��30��6�   $��146,290,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��278��6�   
�������$��0,0,0,3q�6�   ���	#FF2196F3���	#FF2196F360  �� 5      -   5        $ txtprice��5   &   $
��Left=�6[   $��12(�6v   $��30��6�   $��146,351,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��278��6�   
�������$��0,0,0,3q�6�   ���	#FF2196F3���	#FF2196F36,  �� 5      -   5        $ label_Copy3��5   $   ���	#FF2196F3$"��اختار نوع الصنف��6P   $
��Left=�6j   $	��Top=�6�   
������ $��229,397,0,0q�6�   $��14(�6�   $ 0.504,7.818&�6�   �� 5      -	   5        $ label_Copy4��5   $   ���	#FF2196F3$�� ادخل السعر��6P   $
��Left=�6f   $	��Top=�6�   
������ $��228,320,0,0q�6�   $��14(�6�   �� 5      -
   5        $ label_Copy5��5   $   ���	#FF2196F3$"��ادخل وصف للمنتج��6Q   $
��Left=�6k   $	��Top=�6�   
������ $��218,150,0,0q�6�   $��14(�6�   $ 0.471,-5.102&�6�   �� 5      -   5        $ label_Copy6��5   $   ���	#FF2196F3$.��(ادخل الكمية في المخزن ��6P   $
��Left=�6q   $	��Top=�6�   
������ $��199,258,0,0q�6�   $��14(�6�   $ 0.471,-5.102&�6�   �� 5      -   5        
 ��Name$
 btnSaveProdacts��5   %   $��حفظ المنتج��6\   $
��Left=�6q   $��166,490,0,0q�6�   $	��Top=�6�   $	��258��6�   $ -0.492,-0.085&�6�   �� 5      -   5         ��Name$ txtDescribprodacts��5   *   $
��Left=�6F   $��63��6a   $��146,195,0,0q�6m   $	��Top=�6�   $	��278��6�   . �5   "   /� .T�5   &   J� .*�60   .*�5   *   �� $�RichTextBox��6.   5   '   5   #   5       �� 5"      -   5         ��Name$ compySelectCategory��5"   '   $
��Left=�6E   $��146,430,0,0q�6`   $	��Top=�6u   $	��278��6�   $��29��6�   ���	#FF2196F3���	#FF2196F3$��0,0,0,3q�6�   ��5#   "   �� 5$   &    �� EndPoint$	 0,1&�6:    �� 
StartPoint$	 0,0&�6I   .��5%   *   �  � Color$ White��67    � Offset$ 0Q�6E   � 5&   *   $ White��67   $ 1Q�6E   5'   '   5)      �� 5*      -   5        $ lblerror��5*   $   
���  ��$
��Left=�6H   $	��Top=�6c   
������ $��166,527,0,0q�6�   $��14(�6�   $ 0.471,-5.102&�6�   5,      5-      5/      50      51      54      55      