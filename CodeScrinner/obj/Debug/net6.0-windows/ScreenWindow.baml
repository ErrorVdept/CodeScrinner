   M S B A M L   `   `   `  ????G  CCodeScrinner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CodeScrinnerCodeScrinner  5   	       CodeScrinner.ScreenWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:CodeScrinner     5   	     ? Title$  Code Scrinner??5      $	??600??6   $	??750??6+   ???#1E1E1E.??5	      ?  ? ColumnDefinitions 5
   
   ?? 5       ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      ?? 5      $??50 ?6   .+?5   
   ?? ???#141414$??50??6&   ._?5      ??  ?? Orientation$ 
Horizontal=?6   .+?5      ?? $??Icons\Logo.png??6   ?? 5      -   5         ??Name$ Github??5      $??10q?6)   ???#141414$??0q?6J   $
??Left=?6s   .??5      ?? $??Icons\Git.png??6   5      ?? 5      -   5        $	 Web??5      $??10q?6&   ???#141414$??0q?6G   $
??Left=?6m   .??5      ?? $??Icons\Web.png??6   5      ?? 5      -   5        $ Donate??5      $??10q?6)   ???#141414$??0q?6J   $
??Left=?6s   .??5      ?? $??Icons\Donate.png??6   5      5       5"      ?? 5#   
   $??1??6   $??Hidden=?6%   $??Hidden=?6J   .??5$      ?? -   5         ??Name$ 
ImgPreview??5$      5%      ?? 5&   
   -   5        $ 
SaveButton??5&   4   $??2??6   ???#C5C5C5???#141414$??24(?6^   $
??Bold"?6l   $??0q?6~   .??6?   Save full quality5)      5,      5-      