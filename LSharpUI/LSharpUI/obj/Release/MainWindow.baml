   M S B A M L   `   `   `  ���� C  ?LSharpUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:LSharpUILSharpUI  T PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls     LSharpUI.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -
staticDataclr-namespace:LSharpUI     ;Controls,http://metro.mahapps.com/winfx/xaml/controls  Jcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  :d2http://schemas.microsoft.com/expression/blend/2008  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  (  "MahApps.Metro.Controls.MetroWindow    	TitleCaps  .   � Title$ L# - ��$��449.355��$��900.596�� � WindowStartupLocation$ CenterScreen=�$��Arial)�   RightWindowCommands +  %MahApps.Metro.Controls.WindowCommands  .@��� -    ��Name$ 
Connectedb�� � ToolTip _� .���� .+��� -    ��Name$ injected���� $�Not Injected��.����  �� Orientation$ 
Horizontal=�.+��� $��14��$��14������ *
Foreground+ �� RelativeSource �� 	 �� AncestorType"	 ��
 J� OpacityMask
 !�  j� Stretch$
 Fill=�-   iconinjected��   appbar_network_disconnect !� Visual# [  �� -   .���� $ 
Horizontal=�.+��� $��14��$��14������ *
Foreground+ �� "	 ��
 !� $
 Fill=�  appbar_page_text# [ �� $��4 0 0 0q�$��Center=�$
��News���� -   .���� $ 
Horizontal=�.+��� $��14��$��14������ *
Foreground+ �� "	 ��
 !� $
 Fill=�  appbar_layer# [ �� $��4 0 0 0q�$��Center=�$��
Assemblies���� -   .���� $ 
Horizontal=�.+��� $��13��$��13������ *
Foreground+ �� "	 ��
 !� $
 Fill=�# [ �� $��4 0 0 0q�$��Center=�$��
AssemblyDB���� -   $ Unknowb��.���� $ 
Horizontal=�.+��� $��14��$��14������ *
Foreground+ �� "	 ��
 !� $
 Fill=�  appbar_refresh# [ �� $��4 0 0 0q�$��Center=�$��Unknown���� -   .���� $ 
Horizontal=�.+��� $��14��$��14������ *
Foreground+ �� "	 ��
 !� $
 Fill=�  appbar_settings# [ �� $��4 0 0 0q�$��Center=�$��Settings��.��� .+��� -	   $��MainTab��$��	2,-33,2,2q�.@��� $
��news�� �� 
IsSelected . .��� ���	#FFE5E5E5�� $��
Assemblies��.��� ���	#FFE5E5E5.+��� $��Champion��$
��Left=�$��
319,14,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.587,0.481&��� $
��Left=�$��	10,10,0,0q�$	��Top=�$	��166���� $��Libary��$
��Left=�$��
407,14,0,0q�$	��Top=�$ 0.587,0.481&��� $��Utility��$
��Left=�$��
476,14,0,0q�$	��Top=�$ 0.587,0.481&��� $
��Left=�$��23��$��
700,10,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��169��&   System.Windows.Controls.DataGrid  -
     Name$ 	dataGrid1��   AutoGenerateColumns .  $
��Left=�$��	10,41,0,0q�$	��Top=�$	��319��$	��859��   Columns 4  .System.Windows.Controls.DataGridCheckBoxColumn  -   CheckBoxColumn1��,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .     Width5  /System.Windows.Controls.DataGridLengthConverter$	 100   MetroDataGridCheckBox1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# �     EditingElementStyle# �     Header$  ��0  *System.Windows.Controls.DataGridTextColumn   . $	 140 $
 NAME��   Binding �� *Name+   . $ 70 $
 TYPE�� �� *Type+   . $ 86 $ VERSION�� �� *	Version+   . $ 80 $ AUTHOR�� �� *Author+   . $ * $ DESCRIPTION�� �� *Desc+�� -    ��Name$ 	DebugText��$
��Left=�$��23��$��
88,369,0,0q�$
 Wrap=�$��TextBox��$	��Top=�$	��120���� $��
AssemblyDB��.��� ���	#FFE5E5E5�� $��Settings��$��-1,0,1,0q�.��� ���	#FFE5E5E5$��0,0,-1,0q�.+��� -   $��TextBox1��$
��Left=�$��23��$��371,196,0,0q�$
 Wrap=�$��Debug...��$	��Top=�$	��120��o� $
��Left=�$	��385��$��	10,10,0,0q�$	��Top=�$	��154���� -   $��ButtonG��$��      General��  AccentedSquareButtonStyle#��[ $
��Left=�$��	12,12,0,0q�$	��Top=�$	��150��
�������+	  %MahApps.Metro.Controls.ControlsHelper 	  ContentCharacterCasing$ Normal=� �� 	ClickMode$ Press=�$��Bottom=�$
��Left=�
���   �#
 � ��
�������$��27���� -   $ ButtonH��$��      Hotkeys��#��[ $
��Left=�$��	12,39,0,0q�$	��Top=�$	��150��
�������$ Normal=�$ Press=�$��Bottom=�$
��Left=�
���   �#
 � ��
�������$��28���� -   $ ButtonL��$��	      Log��#��[ $
��Left=�$��	12,67,0,0q�$	��Top=�$	��150��
�������$ Normal=�$ Press=�$��Bottom=�$
��Left=�
���   �#
 � ��
�������$��28��  -   $ dgData�� .  $��169,10,10,219q�    . $ GAME SETTINGS��$	 340  �� *	Subject+4
  .System.Windows.Controls.DataGridTemplateColumn
  $  ��$ *  
  CellTemplate �� .R��� ���� *Status+ 
  CellEditingTemplate �� .R��� $��20�� �� 
IsEditable . ���� *
StatusList+ �� SelectedItem �� *Status+�� -     ��Name$  Langcb��$
��Left=�$��237,195,0,0q�$	��Top=�$	��120���� $��Language��$
��Left=�$��169,196,0,0q�$	��Top=�$��65���� -   $  Themecb��$
��Left=�$��237,227,0,0q�$	��Top=�$	��120���� $��Color��$
��Left=�$��169,228,0,0q�$	��Top=�$��65���� -   ! ��Name$! 
UseCloudcb��$��Use Cloud Integration��$
��Left=�$��169,262,0,0q�$	��Top=�$	��153���� -   $! Debugcb��$5��/Enable Assembly Debug (may decrese performance)��$
��Left=�$��169,285,0,0q�$	��Top=�$	��302���� -   $! Developercb��$��Enable developer options��$
��Left=�$��169,308,0,0q�$	��Top=�$	��169���� -   $! 	Updateacb��$ ��Update assemblies on start��$
��Left=�$��169,331,0,0q�$	��Top=�$	��169���� -   $! CoreInjectcb��$��Update core on inject��$
��Left=�$��169,354,0,0q�$	��Top=�$	��169���� -   $! Injectcb��$��Inject��$
��Left=�$��169,377,0,0q�$	��Top=�$	��169���� $��Logout��$
��Left=�$��795,370,0,0q�$	��Top=�$��75���� $��APPDATA��$
��Left=�$��795,340,0,0q�$	��Top=�$��75���� -   $��SAVE CONFIG��$
��Left=�$��795,310,0,0q�$	��Top=�$��75��