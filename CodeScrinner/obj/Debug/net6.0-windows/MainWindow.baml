   M S B A M L   `   `   `  ????G  CCodeScrinner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CodeScrinnerCodeScrinner  5   	       CodeScrinner.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:CodeScrinner     5   	   -   5          ? Title$  Code Scrinner??5	   	    ? 
ResizeMode$ CanMinimize=?6   $	??450??68   $	??300??6E   ???#1E1E1E.??5      ?  ? ColumnDefinitions 5   
   ?? 5       ? RowDefinitions 5   
   ?? 5      .+?5   
   ??  ?? Orientation$ Vertical=?6   .+?5      ?? ???#141414$??50??6*   ._?5      ?? $ 
Horizontal=?6   .+?5      ?? $??Icons\Logo.png??6   ?? 5      -   5         ??Name$ Github??5      $??10q?6-   ???#141414$??0q?6N   $
??Left=?6w   .??5      ?? $??Icons\Git.png??6    5      ?? 5      -   5        $	 Web??5      $??10q?6*   ???#141414$??0q?6K   $
??Left=?6q   .??5      ?? $??Icons\Web.png??6    5       ?? 5!      -   5        $ Donate??5!      $??10q?6-   ???#141414$??0q?6N   $
??Left=?6w   .??5"      ?? $??Icons\Donate.png??6    5#      5$      5&      ?? 5'      $??5,5,5,5q?6   $	??280??6+   $	??280??6:   ???#C5C5C5$??WrapWithOverflow=?6[   $??Center=?6{    ?? TextAlignment$ Center=?6?   $??15(?6?   $
??Bold"?6?   ><Click on the button to generate an image from the clipboard.6  ?? 5(      -   5        $ GenerateButton??5(   U   $??5q?6   ???#C5C5C5$??18(?65   $
??Bold"?6C   $??50??6m   $	??200??6y   ???#141414$??0q?6?   .??6?   
Generate5+      ?? 5,      $??5q?6   ???#C5C5C56$   ?? 5-      $??5,5,5,5q?6   $	??280??6+   $	??280??6:   ???#C5C5C5$??WrapWithOverflow=?6[   $??Center=?6{   $ Center=?6?   $??15(?6?   $
??Bold"?6?   ??Hide this window - the program will continue to work in the background. You can set design your label on images in the settings.6Q  ?? 5.      $??5q?6   ???#C5C5C56$   ?? 50       ?? CornerRadius$ 10??6   ???#141414$??5q?6<    J? Effect 51      3  -System.Windows.Media.Effects.DropShadowEffect  52      	   
BlurRadius$	 15Q?6'   
   	Direction$	
 -90Q?67      RenderingBias$ Quality=?53         ShadowDepth$ 4Q?67   ._?55      ?? .+?56      ?? $??Center=?6   $??18(?69   $
??Bold"?6G   ???#C5C5C5.??6n   
Settings6x   ?? 57      $ 
Horizontal=?6!   $??5,5,5,5q?6;   .+?58      ?? $??	NickName:??6    $
??Bold"?64   ???#C5C5C56F   ?? 59      -   5         ??Name$ NicknameTextBox??59   "   $	??220??6;   $??0q?6G   ???#1E1E1E$??Center=?6p   ???#E8E8E86?   5:      ?? 5;      -   5         ??Name$ 
LightTheme??5;      $??5,5,5,5q?63   $??Light console theme??6D   ???#C5C5C5$
??Bold"?6w   $??Center=?6?   ?? 5>      -   5        $ SaveSettingsButton??5>   >   $??5q?6   ???#C5C5C5$??20??6Z   $	??100??6f   ???#1E1E1E$??0q?6?   .??6?   Save5A      5B      5D      5F      5K      5L      