var EdtTxt = intb.Document.Text;//读取数据


//using
var pattern = /using\s?\([^\)]+\)\s?\{/igm;
var NextKh=[];
EdtTxt = EdtTxt.replace(pattern, function () {
      Console.WriteLine("Regex:" + arguments[0]);
NextKh.pop(findPP( EdtTxt.substring(arguments[arguments.length - 2])));
      return " /* " + arguments[0]+ " */ ";
});
/* */
for (var i =0;i<NextKh.length;i++)
{
    EdtTxt=EdtTxt.substring(0,NextKh[i] )+" /* }*/ "+EdtTxt.substring(NextKh[i] +1)
}

outtb.Document.Text = EdtTxt;//打印数据

//查找
function findPP(Str) {
    for (var i = 0; i < Str.length; i++) {
        if (Str[i] == '{' ) {
         i+= findPP(Str);
        }
        if(Str[i] == '}' )
        {
            return i;
        }
    }
}

