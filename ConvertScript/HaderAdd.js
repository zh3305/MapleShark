//偏移计算


//偏移量 1 or -1
var Offset = 0;
//输出值为16进制 还是10进制 True=十六进制
var Outhex = true;
//匹配表达式索引
var regexindex = 1;
//末尾备注文字 {0} 旧编码  {1} 新编码 {2}偏移量
var Remark = "  // [136] by Script";

var regexs = [
    {
        // BUff 批量偏移    INDIE_MAX_DAMAGE_OVER(29, true,135), 改136
        pattern: /([\w\._]+)\s*\(\s*((:?\d+)|(:?0x[a-fA-F0-9]{1,8}))(\s*,\s*(:?true|false))*(\s*,\s*(:?135))*\s*\)/igm,
        replace: function () {
            Console.WriteLine("Regex:" + arguments[0]);
            var d = parseInt(arguments[2]) + Offset;
            if (Outhex) {
                d = "0x" + d.toString(16).toUpperCase();
            } else {
                d = d.toString(10);
            }
            return arguments[1] + "(" + d + " " + arguments[5] + ",136" + ")"
        }
    },
    {
        // RecvPacketOpcode 批量偏移    STRANGE_DATA(0x66),
        pattern: /([\w\._]+)\s*\(\s*((:?\d+)|(:?0x[a-fA-F0-9]{1,8}))(\s*,\s*(:?true|false))*(\s*,\s*(:?135))*\s*\)\s?,/igm,
        replace: function () {
            Console.WriteLine("Regex:" + arguments[0]);
            var d = parseInt(arguments[2]) + Offset;
            if (Outhex) {
                d = "0x" + d.toString(16).toUpperCase();
            } else {
                d = d.toString(10);
            }
            return arguments[1] + "(" + d + " " + arguments[5] +  ")"
        }
    }
];

//读取
var EdtTxt = intb.Document.Text;
if (!Offset) {
    Offset = parseInt(window.prompt("请输入偏移量!", "偏移为负,请输负数", "3"));
    if (!Offset) {
        throw new Error("Something went badly wrong!");
    }
}

EdtTxt = EdtTxt.replace(regexs[regexindex].pattern, regexs[regexindex].replace);




//显示
outtb.Document.Text = EdtTxt;

String.prototype.format = function (args) {
    var result = this;
    if (arguments.length > 0) {
        if (arguments.length == 1 && typeof (args) == "object") {
            for (var key in args) {
                if (args[key] != undefined) {
                    var reg = new RegExp("({" + key + "})", "g");
                    result = result.replace(reg, args[key]);
                }
            }
        }
        else {
            for (var i = 0; i < arguments.length; i++) {
                if (arguments[i] != undefined) {
                    var reg = new RegExp("({[" + i + "]})", "g");
                    result = result.replace(reg, arguments[i]);
                }
            }
        }
    }
    return result;
}
//两种调用方式
// var template1 = "我是{0}，今年{1}了";
// var template2 = "我是{name}，今年{age}了";
// var result1 = template1.format("loogn", 22);
// var result2 = template2.format({ name: "loogn", age: 22 });