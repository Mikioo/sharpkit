
function doTest()
{writeLine("Working with DateTime...");writeLine("Local time is: "+System.DateTime.get_Now().ToString());writeLine("Working with String...");writeLine(System.String.Format("This {0} a {1} string","is","formatted"));writeLine("Working with Path...");writeLine("The extensions of 'index.htm' is "+System.IO.Path.GetExtension$$String("index.htm"));}
function writeLine(s)
{document.body.appendChild(document.createTextNode(s));document.body.appendChild(document.createElement("br"));}