   M S B A M L   `   `   `  ����W  SCourseworkBankMessageService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CourseworkBankMessageServiceCourseworkBankMessageService  5   	   -    'CourseworkBankMessageService.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:CourseworkBankMessageService     5   	     � Title$+  %Napier Bank Message Filtering Service��5   	   $��451.231��67   $��756.372��6H   
���   �.��5	      � .+�5
   
   �� -   5         ��Name$ 	txtSender��5
      $
��Left=�6%   $��30��6@   $��	8,129,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��175��6�   �� 5   
   -   5        $ txtMsgID��5      $
��Left=�6$   $��30��6?   $��	8,220,0,0q�6K   $
 Wrap=�6^   $	��Top=�6r   $	��175��6�   �� 5   
   -   5        $ 
txtMsgText��5      $
��Left=�6&   $	��233��6A   $��
192,86,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��362��6�   �� 5   
   -   5         ��Name$ btnIndentify��5      $��Fliter Message Type��6'   $
��Left=�6E   $��	8,164,0,0q�6`   $	��Top=�6s   $	��175��6�   6�   �� 5   
   $7��1Enter Email Address, 
Twitter ID or Phone Number��6   $
��Left=�6T   $��8,86,0,0q�6o   $	��Top=�6�   $	��224��6�   �� 5   
   -   5         ��Name$ lblMsgID��5      $��
Message ID��6"   $
��Left=�67   $��	8,189,0,0q�6R   $	��Top=�6e   $��72��6}   �� 5   
   -   5        $ 
txtSubject��5      $
��Left=�6&   $��30��6A   $��559,129,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��175��6�   	� 5   
   -   5         	�Name$ 
rdStandard��5      $��Standard��6*   $
��Left=�6=   $��
192,23,0,0q�6X   $	��Top=�6l   6�   	� 5   
   -   5        $ 
rdIncident��5      $��Incident Report��6*   $
��Left=�6D   $��
192,58,0,0q�6_   $	��Top=�6s    J� RenderTransformOrigin$ 0.176,-0.467&�6�   6�   �� 5   
   -	   5        $ 
lblSubject��5      $��Subject��6$   $
��Left=�66   $��
559,98,0,0q�6Q   $	��Top=�6e   $��66��6}   �� 5   
   -
   5        $ btnSave��5      $��Save Message��6"   $
��Left=�69   $��192,336,0,0q�6T   $	��Top=�6i   $	��175��6�   $��50��6�   6�   �� 5   
   -   5        $ btnShowMessages��5      $��View Saved Messages��6*   $
��Left=�6H   $��379,336,0,0q�6c   $	��Top=�6x   $	��175��6�   $��50��6�   6�   �� 5   
   -   5         ��Name$ cmbIncident��5      $
��Left=�6(   $��
338,43,0,0q�6C   $	��Top=�6W   $	��175��6o   $��30��6{   �� 5   
   -   5        $ lblIncident��5      $��Nature of Incident��6%   $
��Left=�6B   $��	338,9,0,0q�6]   $	��Top=�6p   $	��108��6�   �� 5   
   -   5        $ txtSortCode��5      $
��Left=�6'   $��30��6B   $��559,220,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��175��6�   �� 5   
   -   5        $ lblSortCode��5      $��	Sort Code��6%   $
��Left=�69   $��559,189,0,0q�6T   $	��Top=�6i   �� 5   
   -   5        $ btnClear��5      $��Clear Input��6#   $
��Left=�69   $��336,391,0,0q�6T   $	��Top=�6i   $��75��6�   6�   5      5      