   M S B A M L   `   `   `  ����B  >ViewWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ViewWPFViewWPF  5   	       ViewWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ViewWPF     5   	     � Title$  
MainWindow��5   	   $��434.016��6   $	��800��6-   .��5	      � .+�5
   
   �� $
��Left=�5      $	��357��6(   $��	10,10,0,0q�65   $	��Top=�6H   $	��230��6`   ��5
      ��  �� Path$ 	Employees� �� SelectedItem 69   �� *CurrentEmployee+5   `   �� 5   
   $:��4Получить список сотрудников��5      $
��Left=�63   $��
10,372,0,0q�6N   $	��Top=�6b   $	��230��6z   ��5      �� *GetEmpsCommand+5   z   �� 5   
   $
��Left=�6   $��23��6-   $��
366,10,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6x   $	��120��6�   ��6a   �� *eName+6�   �� 5   
   $
��Left=�6   $��23��6-   $��
366,38,0,0q�69   $
 Wrap=�6M   $	��Top=�6x   $	��120��6�   ��6a   �� *ePost+6�   �� 5   
   $
��Left=�6   $��23��6-   $��
366,94,0,0q�69   $
 Wrap=�6M   $	��Top=�6w   $	��120��6�   ��6a   �� *eAge+6�   �� 5   
   $
��Left=�6   $��23��6-   $��
366,66,0,0q�69   $
 Wrap=�6M   $	��Top=�6z   $	��120��6�   ��6a   �� *	eSalary+6�   �� 5   
   $!��Имя сотрудника��6   $
��Left=�6)   $��	245,7,0,0q�6D   $	��Top=�6W   �� 5   
   $��Должность��6   $
��Left=�6$   $��
245,35,0,0q�6?   $	��Top=�6S   �� 5   
   $��Возраст��6   $
��Left=�6"   $��
245,91,0,0q�6=   $	��Top=�6Q   �� 5   
   $��
Оклад��6   $
��Left=�6    $��
245,63,0,0q�6;   $	��Top=�6O   �� 5   
   $��Обновить��5      $
��Left=�6    $��245,133,0,0q�6;   $	��Top=�6P   $	��100��6h   ��5      �� *UpdEmpCommand+5   h   �� 5   
   $��Удалить��5      $
��Left=�6   $��386,133,0,0q�6:   $	��Top=�6O   $	��100��6g   ��5      �� *DelEmpCommand+5   g   5      5      