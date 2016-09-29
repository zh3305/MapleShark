var EdtTxt = intb.Document.Text;
//替换函数
var pattern = /(public|private|protected)([^\(]+)(\b\w+)([\(].+[\)])([^\)]+)$/igm;
EdtTxt = EdtTxt.replace(pattern, function () {
      Console.WriteLine("Regex:" + arguments[0]);
      return "function " + arguments[3] + "()" + arguments[5] + "//" + arguments[0];
});
//替换LittleEndianAccessor
pattern = /(([\w\.]+)(\s?=\s?))?lea\.(\w+)\s?\(/igm;
EdtTxt = EdtTxt.replace(pattern, function () {
      Console.WriteLine("Regex:" + arguments[0]);
      // return arguments[3]+"()"+arguments[5]+"//"+arguments[0];
      var Tempt = "mplew."
      var tmp2 = '("';
      if (arguments[1] !== null || arguments[1] !== undefined || arguments[1] !== '') {
            tmp2 += arguments[2];
            Tempt = arguments[2] + arguments[3] + Tempt;
      }
      tmp2 += '"';
      switch (arguments[4]) {
            case "readByte":
                  Tempt += "write";
                  break;
            case "readChar":
            case "readShort":
            case "readUShort":
                  Tempt += "writeShort";
                  break;
            case "unReadInt":
            case "readInt":
            case "readFloat":
                  Tempt += "writeInt";
                  break;
            case "readDouble":
            case "readLong":
                  Tempt += "writeLong";
                  break;
            case "readAsciiString":
                  Tempt += "writeAsciiString";
                  break;
            // case "getBytesRead":
            //       break;
            case "readMapleAsciiString":
                  Tempt += "writeMapleAsciiString";
                  break;
            case "readPos":
                  Tempt += "writePos";
                  break;
            case "read":
                  Tempt += "writeBuffer";
                  break;
            //取消读取未实现
            case "unReadByte":
            case "unReadShort":
            case "unReadLong":
            case "unReadAsciiString":
            case "unReadPos":
            case "unRead":
                  Tempt += arguments[4] + " 取消读取未实现";
                  break;
            case "readLastByte":
            case "readLastInt":
            case "readLastShort":
            case "readLastLong":
            case "readLastAsciiString":
            case "readLastPos":
            case "readLastBytes":
                  Tempt += arguments[4] + " readLast未实现";

            case "available":
                  Tempt += "Remaining";
                  break;
            case "seek":
            case "getPosition":
                  Tempt += arguments[4] + "[未实现]";
                  break;
            case "skip":
                  Tempt += arguments[4];
                  tmp2 = "(";
                  break;
            default:
                  Tempt += arguments[4];
                  break;
      }
      return Tempt + tmp2;
});
// (LittleEndianAccessor lea,;= 
// 类型替换
pattern = /(\W)(?!return)([\w\.]+\s+)(\w+\s?)(,|=|;)/igm;
EdtTxt = EdtTxt.replace(pattern, function () {
      Console.WriteLine("Regex:" + arguments[0]);
      return  arguments[1]+ "var " + arguments[3] + arguments[4];
});
// List<Pair<Integer, Boolean>>
pattern = /List\s?<[^<>]*(?:<[^<>]*>)?[^<>]*>\s+(\w+)/igm;//最大深度,不能超过JAVASCRIPT限定
EdtTxt = EdtTxt.replace(pattern, "var $1 ");

//=new 替换 ArrayList
pattern = /=\s?new\s?ArrayList[^\(]*\([^\)]*\)/igm;
EdtTxt = EdtTxt.replace(pattern, " = [] ");
//ArrayList.add to array.push
pattern = /([\w]+)\s?\.\s?add\s?\(/igm;
EdtTxt = EdtTxt.replace(pattern, "$1.push(");

//(new xxx(x,x)) 替换
pattern = /(\(\s?)new\s+[^(]+\(([^()]*(\([^()]*\)[^()]*)?)\)/igm;
EdtTxt = EdtTxt.replace(pattern, "$1 [$2]");

//= new xxx(x,x) 替换
pattern = /(=\s?)new\s+[^(]+\(([^()]*(\([^()]*\)[^()]*)?)\)/igm;
EdtTxt = EdtTxt.replace(pattern, "$1 {/* $2 */}");

//替换显示类型转换 (int)a
pattern = /(\([\w.]+\))((?:\s?\()|(?:\w+))/igm;
EdtTxt = EdtTxt.replace(pattern, "/*$1*/ $2");


outtb.Document.Text = EdtTxt;

//嵌套括号 匹配
// var str = '(1+2)(1+(1+2))',
//     i = -1,
//     len = str.length,
//     stack = 0,
//     start = 0,
//     result = [];
// while (++i < len) {
//     var c = str.charAt(i);
//     if (c === '(') {
//         if (stack === 0) {
//             start = i;
//         }
//         stack++;
//     } else if (c === ')') {
//         stack--;
//         if (stack === 0) {
//             result.push(str.substring(start, i + 1));
//         }
//     }
// }
// console.log(result);