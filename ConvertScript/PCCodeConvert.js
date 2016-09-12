//伪代码替换
// outtb.Document.Text=s;
var EdtTxt = intb.Document.Text;

//替换函数
var pattern = /^(.+thiscall)([^\(]+)(\b[\w_]+)([\(].+[\)])(:?([^\n]+)?)/igm;
EdtTxt = EdtTxt.replace(pattern, function () {
    Console.WriteLine("Regex:" + arguments[0]);
    return "function " + arguments[3] + "()" + arguments[5] + "//" + arguments[0];
});


//替换 &v3->_ZtlSecureTear_nPvPExp[1]
var pattern = /&?([\w_]+)->([\w_]+)/igm;
EdtTxt = EdtTxt.replace(pattern, function () {
    return  arguments[1] + "." + arguments[2];
});

//替换Packet_
pattern = /(([\w\.]+)(\s?=\s?))?Packet_(\w+)\s?\(([^\)]+)/igm;
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
        case "ReadByte":
            Tempt += "write";
            break;
        case "ReadShort":
            Tempt += "writeShort";
            break;
        case "ReadInt":
            Tempt += "writeInt";
            break;
        case "ReadLong":
            Tempt += "writeLong";
            break;
        case "readAsciiString":
            Tempt += "writeAsciiString";
            break;
        case "readMapleAsciiString":
            Tempt += "writeMapleAsciiString";
            break;
        case "readPos":
            Tempt += "writePos";
            break;
        case "ReadBuffer":
            Tempt += "writeBuffer";
            tmp2 = tmp2 + "," + arguments[5];
            break;
        default:
            Tempt += arguments[4];
            break;
    }
    return Tempt + tmp2;
});


//  mplew.writeBuffer("",iPacket, v3.DayLimit, 0x15u);
//读取ReadBuffer 数量 //(((-?\d+)(\.\d+)?)|0x[a-fA-F0-9]{1,8})
// pattern2 = /,\s?((0x)?[a-fA-F0-9]+)u?/igm;
// //读取ReadBuffer 变量
// pattern3 = /,\s?\&([\w]+)/igm;

pattern=/mplew.writeBuffer\(([^,\)]+)\s?[,\)]\s?([^,\)]+)\s?[,\)]\s?&?([^,\)]+)\s?[,\)]\s?([^,\)u]+)u?[,\)]/igm;
EdtTxt = EdtTxt.replace(pattern, function () {
if(arguments[3].indexOf("(")>-1){
      return "mplew.writeBuffer(\""+arguments[3] + "\""+ arguments[4] + ")";
      }
      else
      {
      return arguments[3] + "= mplew.writeBuffer(\""+arguments[3] + "\","+ arguments[4] + ")";
    }
});


//&loc_7FFFFC dword_2000000 
pattern = /(&loc_|dword_)([a-fA-F0-9]+)/igm;
EdtTxt = EdtTxt.replace(pattern, "0x$2");//  "/*$0*/"

//  *(v3 + 26) 
pattern = /\*\s?\([^\)]+\)\s?=/igm;
EdtTxt = EdtTxt.replace(pattern, "");//  "/*$0*/"

// 类型替换
pattern = /(\W)(?!return|goto)([\w\.]+\s+)\*?(\w+\s?)(,|=|;)/igm;
EdtTxt = EdtTxt.replace(pattern, function () {
      Console.WriteLine("Regex:" + arguments[0]);
      return arguments[1] + "var " + arguments[3] + arguments[4];
});

//gotu 替换 continue 
pattern = /goto\s+([\w_]+\s?;)/igm;
EdtTxt = EdtTxt.replace(pattern, "continue $1");

outtb.Document.Text = EdtTxt;
