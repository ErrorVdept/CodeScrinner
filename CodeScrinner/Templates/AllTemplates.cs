using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeScrinner.Templates
{
    
    public class AllTemplates
    {
        public List<string> AllTmplt = new List<string>();

        public AllTemplates()
        {
            AllTmplt.Add(
            @"
<!DOCTYPE html>  
<html>
<head>
<meta charset=""utf-8"">
    <style type=""text/css"">
    * { margin: 0; padding: 0; }


pre {
    white-space: pre-wrap;       /* Since CSS 2.1 */
    white-space: -moz-pre-wrap;  /* Mozilla, since 1999 */
    white-space: -pre-wrap;      /* Opera 4-6 */
    white-space: -o-pre-wrap;    /* Opera 7 */
    word-wrap: break-word;       /* Internet Explorer 5.5+ */
}


.terminal {
    border-radius: 5px 5px 0 0;
    position: relative;
}
.terminal .top {
    background: #141414;
    color: black;
    padding: 5px;
    border-radius: 5px 5px 0 0;
}
.terminal .btns {
    position: absolute;
    top: 7px;
    left: 5px;
}
.terminal .circle {
    width: 12px;
    height: 12px;
    display: inline-block;
    border-radius: 15px;
    margin-left: 2px;
    border-width: 1px;
    border-style: solid;
}
.title{
    text-align: center;
    color: #C5C5C5;
}
.red { background: #EC6A5F; border-color: #D04E42; }
.green { background: #64CC57; border-color: #4EA73B; }
.yellow{ background: #F5C04F; border-color: #D6A13D; }
.clear{clear: both;}
.terminal .body {
    background: #1E1E1E;
    color: #7AFB4C;
    padding: 8px;
    overflow: auto;
    border-radius: 0 0 5px 5px 
}
.space {
    margin: 25px;
    
}
.bg {|BG|}
.shadow { box-shadow: 0px 0px 10px rgba(0,0,0,.4)}
    </style>
</head>
<body class=""bg"">

    <div class=""terminal space shadow"">
        <div class=""top"">
            <div class=""btns"">
                <span class=""circle red""></span>
                <span class=""circle yellow""></span>
                <span class=""circle green""></span>
            </div>
            <div class=""title""><b>|TITLE|</b></div>
        </div>
        <pre class=""body"">
|CONTENT|
        </pre>
    </div>

</body>
</html>
");
            AllTmplt.Add(@"
<!DOCTYPE html>  
<html>
<head>
<meta charset=""utf-8"">
    <style type=""text/css"">
    * { margin: 0; padding: 0; }


pre {
    white-space: pre-wrap;       /* Since CSS 2.1 */
    white-space: -moz-pre-wrap;  /* Mozilla, since 1999 */
    white-space: -pre-wrap;      /* Opera 4-6 */
    white-space: -o-pre-wrap;    /* Opera 7 */
    word-wrap: break-word;       /* Internet Explorer 5.5+ */
}


.terminal {
    border-radius: 5px 5px 0 0;
    position: relative;
}
.terminal .top {
    background: #4C4C4C;
    color: black;
    padding: 5px;
    border-radius: 5px 5px 0 0;
}
.terminal .btns {
    position: absolute;
    top: 7px;
    left: 5px;
}
.terminal .circle {
    width: 12px;
    height: 12px;
    display: inline-block;
    border-radius: 15px;
    margin-left: 2px;
    border-width: 1px;
    border-style: solid;
}
.title{
    text-align: center;
    color: #C5C5C5;
}
.red { background: #EC6A5F; border-color: #D04E42; }
.green { background: #64CC57; border-color: #4EA73B; }
.yellow{ background: #F5C04F; border-color: #D6A13D; }
.clear{clear: both;}
.terminal .body {
    background: #D4C8C8;
    color: #141414;
    padding: 8px;
    overflow: auto;
    border-radius: 0 0 5px 5px 
}
.space {
    margin: 25px;
    
}
.bg {|BG|}
.shadow { box-shadow: 0px 0px 10px rgba(0,0,0,.4)}
    </style>
</head>
<body class=""bg"">

    <div class=""terminal space shadow"">
        <div class=""top"">
            <div class=""btns"">
                <span class=""circle red""></span>
                <span class=""circle yellow""></span>
                <span class=""circle green""></span>
            </div>
            <div class=""title""><b>|TITLE|</b></div>
        </div>
        <pre class=""body"">
|CONTENT|
        </pre>
    </div>

</body>
</html>
");


            
        }
    }
}
