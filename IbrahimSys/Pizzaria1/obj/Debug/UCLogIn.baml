   M S B A M L   `   `   `  ����D  @Pizzaria1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Pizzaria1	Pizzaria1  5      "    Pizzaria1.UserControlEscolha   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Pizzaria1     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $
��auto��5	      $
��auto��6   .��5
      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  TrainsitionigContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      � $	��364��6   $	��679��6     � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5      � $��
0,0,10.2,0q�6    J� RenderTransformOrigin$ 0.478,0.507&�6,   $	��354��6P   $��Bottom=�6]   $��3��6x    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6+      Color$ 	#FFDEDEDE��6;      ShadowDepth$ 1Q�6M   .+�5      �� $��	48,0,10,0q�6!   .+�5      �� $��46,44,-16,27.4q�6!   .+�5      �� -   5        $��50��5   +   $	��342��69   	 �� Left$	 50��6E   

 �� Top$	
 160��6V   ���	#FF2196F3.��5   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ Login=�6>   $��30��6K   $��34��6V   
�������$��Center=�6v   ��6�   Z� �� 5   &   -   5         ��Name$ btnlogin��5   -   
�������$��20(�6Y   $��0q�6}   $��تسجيل الدخول��6�   $
��Left=�6�   $	��Top=�6�   $	��297��6�   $��34��6�   ��6g   Z� 6�   5   #   5!      �� 5$      -   5         ��Name$ txtbxpassowrd��5$   &   $��15(�6=   ���	#FF2196F3
�������$
��Left=�6|   $��30��6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��342��6�   $	 50��6�   $	
 109��6�   $��0,0,0,3q�6  ���	#FF2196F36  �� 5%      -   5        $ txtpxsusername��5%   &   $
��Left=�6>   $��30��6Y   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��342��6�   $	 50��6�   $
 43��6�   ���	#FF2196F3$��0,0,0,3q�6�   
����������	#FF2196F36  �� 5&      -   5         ��Name$ label��5&   $   ���	#FF2196F3$ ��ادخل كلمة السر��6J   $
��Left=�6c   $	��Top=�6~   $		 188��6�   $
 78��6�   
������ 6�   �� 5'      -   5        $ 
label_Copy��5'   $   ���	#FF2196F3$-��'ادخل اسمك لدخول لنظام��6O   $
��Left=�6o   $	��Top=�6�   $		 175��6�   $
 18��6�   �� 5(      -   5        $ label1��5(   $   $��تسجيل الدخول��64   $��18(�6K   $��Tahoma)�6Y   ���	#FF2196F3$
��Bold"�6�   $��35��6�   $		 124��6�   $	
 -35��6�   $	��196��6�   $ 0.288,0.136&�6�   5)      5-      5.      5/      50      51      52      