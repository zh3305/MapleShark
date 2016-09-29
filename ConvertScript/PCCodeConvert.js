//伪代码替换
// outtb.Document.Text=s;
var EdtTxt = intb.Document.Text;

//替换函数 //__stdcall __thiscall  int __cdecl
var pattern = /^(.+__(:?stdcall|userpurge|thiscall|cdecl))([^\(]+)(\b[\w_]+)([\(].+[\)])(:?([^\n]+)?)/igm;
EdtTxt = EdtTxt.replace(pattern, function () {
    Console.WriteLine("Regex:" + arguments[0]);
    return "function " + arguments[4] + "()" + arguments[6] + "//" + arguments[0];
});


//替换 &v3->_ZtlSecureTear_nPvPExp[1]
var pattern = /&?([\w_]+)->([\w_]+)/igm;
EdtTxt = EdtTxt.replace(pattern, function () {
    return arguments[1] + "." + arguments[2];
});

//替换Packet_ CInPacket::Decode2
pattern = /(([\w\.]+)(\s?=\s?))?(?:Packet_|CInPacket::)(\w+)\s?\(([^\)]+)/igm;
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
        case "Decode1":
        case "ReadByte":
            Tempt += "write";
            break;
        case "Decode2":
        case "ReadShort":
            Tempt += "writeShort";
            break;
        case "Decode4":
        case "ReadInt":
            Tempt += "writeInt";
            break;
        case "Decode4":
        case "ReadLong":
            Tempt += "writeLong";
            break;
        case "readAsciiString":
            Tempt += "writeAsciiString";
            break;
        case "ReadString":
        case "DecodeStr":
        case "readMapleAsciiString":
            Tempt += "writeMapleAsciiString";
            break;
        case "readPos":
            Tempt += "writePos";
            break;
        case "DecodeBuffer":
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

pattern = /mplew.writeBuffer\(([^,\)]+)\s?[,\)]\s?([^,\)]+)\s?[,\)]\s?&?([^,\)]+)\s?[,\)]\s?([^,\)u]+)u?[,\)]/igm;
EdtTxt = EdtTxt.replace(pattern, function () {
    if (arguments[3].indexOf("(") > -1) {
        return "mplew.writeBuffer(\"" + arguments[3] + "\"" + arguments[4] + ")";
    }
    else {
        return arguments[3] + "= mplew.writeBuffer(\"" + arguments[3] + "\"," + arguments[4] + ")";
    }
});


//&loc_7FFFFC dword_2000000 
pattern = /(&loc_|dword_)([a-fA-F0-9]+)/igm;
EdtTxt = EdtTxt.replace(pattern, "0x$2");//  "/*$0*/"

//  *(v3 + 26) 
pattern = /\*\s?\([^\)]+\)\s?=/igm;
EdtTxt = EdtTxt.replace(pattern, "");//  "/*$0*/"

// 类型替换
pattern = /(\s)(?!return|goto)([\w\.]+\s+)\*?(\w+\s?)(,|=|;)/igm;
EdtTxt = EdtTxt.replace(pattern, function () {
    Console.WriteLine("Regex:" + arguments[0]);
    return arguments[1] + "var " + arguments[3] + arguments[4];
});

// sub_D6E2E0(Int_4, Int_npcID, CInPacket2, CInPacket1, 1);
pattern = /(sub_[^(]+)\(([^()]*(\([^()]*\)[^()]*)?)\)/igm;
EdtTxt = EdtTxt.replace(pattern, "$1 (/* $2 */)");

// LOBYTE(v7)
pattern = /(LOBYTE)\(([^()]*(\([^()]*\)[^()]*)?)\)/igm;
EdtTxt = EdtTxt.replace(pattern, " $2 ");


//gotu 替换 continue 
pattern = /goto\s+([\w_]+\s?;)/igm;
EdtTxt = EdtTxt.replace(pattern, "continue $1");

outtb.Document.Text = EdtTxt;
