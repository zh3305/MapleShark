using System.Text;

namespace tools
{

    //using ServerConstants = constants.ServerConstants;
    //using IoBuffer = org.apache.mina.core.buffer.IoBuffer;
    public class HexTool
    {
        private static readonly char[] HEX = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are not available in .NET:
        //ORIGINAL LINE: public static String toString(final byte byteValue)
        public static string ToString(sbyte byteValue)
        {
            //JAVA TO C# CONVERTER WARNING: The original Java variable was marked 'final':
            //ORIGINAL LINE: final int tmp = byteValue << 8;
            int tmp = byteValue << 8;
            char[] retstr = new char[] { HEX[(tmp >> 12) & 0x0F], HEX[(tmp >> 8) & 0x0F] };
            return new string(retstr);
        }
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are not available in .NET:
        //ORIGINAL LINE: public static String toString(final org.apache.mina.core.buffer.IoBuffer buf)
        //public static string ToString(IoBuffer buf)
        //{
        //    buf.flip();
        //    //JAVA TO C# CONVERTER WARNING: The original Java variable was marked 'final':
        //    //ORIGINAL LINE: final byte arr[] = new byte[buf.remaining()];
        //    sbyte[] arr = new sbyte[buf.remaining()];
        //    buf.get(arr);
        //    string ret = ToString(arr);
        //    buf.flip();
        //    buf.put(arr);
        //    return ret;
        //}
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are not available in .NET:
        //ORIGINAL LINE: public static String toString(final int intValue)
        public static string ToString(int intValue)
        {
            return intValue.ToString("x");
        }
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are not available in .NET:
        //ORIGINAL LINE: public static String toString(final byte[] bytes)
        public static string ToString(sbyte[] bytes)
        {
            if (bytes.Length <= 0)
            {
                return "";
            }
            StringBuilder hexed = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                hexed.Append(ToString(bytes[i]));
                hexed.Append(' ');
            }
            return hexed.ToString().Substring(0, hexed.Length - 1);
        }
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are not available in .NET:
        //ORIGINAL LINE: public static String toStringFromAscii(final byte[] bytes)
        public static string toStringFromAscii(sbyte[] bytes)
        {
            sbyte[] ret = new sbyte[bytes.Length];
            for (int x = 0; x < bytes.Length; x++)
            {
                if (bytes[x] < 32 && bytes[x] >= 0)
                {
                    ret[x] = 46;
                }
                else
                {
                    ret[x] = bytes[x];
                }
            }
            try
            {
                return StringHelperClass.NewString(ret, "GB18030");
            }
            catch
            {
                return "";
            }
        }

        //JAVA TO C# CONVERTER WARNING: 'final' parameters are not available in .NET:
        //ORIGINAL LINE: public static String toPaddedStringFromAscii(final byte[] bytes)
        public static string toPaddedStringFromAscii(sbyte[] bytes)
        {
            //JAVA TO C# CONVERTER WARNING: The original Java variable was marked 'final':
            //ORIGINAL LINE: final String str = toStringFromAscii(bytes);
            string str = toStringFromAscii(bytes);
            StringBuilder ret = new StringBuilder(str.Length * 3);
            for (int i = 0; i < str.Length; i++)
            {
                ret.Append(str[i]);
                ret.Append("  ");
            }
            return ret.ToString();
        }
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are not available in .NET:
        //ORIGINAL LINE: public static byte[] getByteArrayFromHexString(final String hex)
        public static byte[] getByteArrayFromHexString(string hex)
        {
            System.IO.MemoryStream baos = new System.IO.MemoryStream();
            int nexti = 0;
            int nextb = 0;
            bool highoc = true;
            for (;;)
            {
                int number = -1;
                while (number == -1)
                {
                    if (nexti == hex.Length)
                    {
                        goto outerBreak;
                    }
                    char chr = hex[nexti];
                    if (chr >= '0' && chr <= '9')
                    {
                        number = chr - '0';
                    }
                    else if (chr >= 'a' && chr <= 'f')
                    {
                        number = chr - 'a' + 10;
                    }
                    else if (chr >= 'A' && chr <= 'F')
                    {
                        number = chr - 'A' + 10;
                    }
                    else
                    {
                        number = -1;
                    }
                    nexti++;
                }
                if (highoc)
                {
                    nextb = number << 4;
                    highoc = false;
                }
                else
                {
                    nextb |= number;
                    highoc = true;
                    baos.WriteByte((byte)nextb);
                }
            //outerContinue:;
            }
        outerBreak:
            return baos.ToArray();
        }
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are not available in .NET:
        //ORIGINAL LINE: public static String getOpcodeToString(final int op)
        public static string getOpcodeToString(int op)
        {
            return "0x" + getLeftPaddedStr(op.ToString("x").ToUpper(), '0', 4);
        }
        /// <summary>
        /// Gets a string padded from the left to <code>length</code> by
        /// <code>padchar</code>.
        /// </summary>
        /// <param name="in"> The input string to be padded. </param>
        /// <param name="padchar"> The character to pad with. </param>
        /// <param name="length"> The length to pad to. </param>
        /// <returns> The padded string. </returns>
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are not allowed in .NET:
        //ORIGINAL LINE: public static String getLeftPaddedStr(final String in, final char padchar, final int length)
        public static string getLeftPaddedStr(string @in, char padchar, int length)
        {
            StringBuilder builder = new StringBuilder(length);
            for (int x = @in.Length; x < length; x++)
            {
                builder.Append(padchar);
            }
            builder.Append(@in);
            return builder.ToString();
        }

        /// <summary>
        /// Gets a string padded from the right to <code>length</code> by
        /// <code>padchar</code>.
        /// </summary>
        /// <param name="in"> The input string to be padded. </param>
        /// <param name="padchar"> The character to pad with. </param>
        /// <param name="length"> The length to pad to. </param>
        /// <returns> The padded string. </returns>
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are not allowed in .NET:
        //ORIGINAL LINE: public static String getRightPaddedStr(final String in, final char padchar, final int length)
        public static string getRightPaddedStr(string @in, char padchar, int length)
        {
            StringBuilder builder = new StringBuilder(@in);
            for (int x = @in.Length; x < length; x++)
            {
                builder.Append(padchar);
            }
            return builder.ToString();
        }
    }

}

//-------------------------------------------------------------------------------------------
//	Copyright ? 2007 - 2016 Tangible Software Solutions Inc.
//	This class can be used by anyone provided that the copyright notice remains intact.
//
//	This class is used to convert some aspects of the Java String class.
//-------------------------------------------------------------------------------------------
internal static class StringHelperClass
{
    //----------------------------------------------------------------------------------
    //	This method replaces the Java String.substring method when 'start' is a
    //	method call or calculated value to ensure that 'start' is obtained just once.
    //----------------------------------------------------------------------------------
    internal static string SubstringSpecial(this string self, int start, int end)
    {
        return self.Substring(start, end - start);
    }

    //------------------------------------------------------------------------------------
    //	This method is used to replace calls to the 2-arg Java String.startsWith method.
    //------------------------------------------------------------------------------------
    internal static bool StartsWith(this string self, string prefix, int toffset)
    {
        return self.IndexOf(prefix, toffset, System.StringComparison.Ordinal) == toffset;
    }

    //------------------------------------------------------------------------------
    //	This method is used to replace most calls to the Java String.split method.
    //------------------------------------------------------------------------------
    internal static string[] Split(this string self, string regexDelimiter, bool trimTrailingEmptyStrings)
    {
        string[] splitArray = System.Text.RegularExpressions.Regex.Split(self, regexDelimiter);

        if (trimTrailingEmptyStrings)
        {
            if (splitArray.Length > 1)
            {
                for (int i = splitArray.Length; i > 0; i--)
                {
                    if (splitArray[i - 1].Length > 0)
                    {
                        if (i < splitArray.Length)
                            System.Array.Resize(ref splitArray, i);

                        break;
                    }
                }
            }
        }

        return splitArray;
    }

    //-----------------------------------------------------------------------------
    //	These methods are used to replace calls to some Java String constructors.
    //-----------------------------------------------------------------------------
    internal static string NewString(sbyte[] bytes)
    {
        return NewString(bytes, 0, bytes.Length);
    }
    internal static string NewString(sbyte[] bytes, int index, int count)
    {
        return System.Text.Encoding.UTF8.GetString((byte[])(object)bytes, index, count);
    }
    internal static string NewString(sbyte[] bytes, string encoding)
    {
        return NewString(bytes, 0, bytes.Length, encoding);
    }
    internal static string NewString(sbyte[] bytes, int index, int count, string encoding)
    {
        return System.Text.Encoding.GetEncoding(encoding).GetString((byte[])(object)bytes, index, count);
    }

    //--------------------------------------------------------------------------------
    //	These methods are used to replace calls to the Java String.getBytes methods.
    //--------------------------------------------------------------------------------
    internal static sbyte[] GetBytes(this string self)
    {
        return GetSBytesForEncoding(System.Text.Encoding.UTF8, self);
    }
    internal static sbyte[] GetBytes(this string self, System.Text.Encoding encoding)
    {
        return GetSBytesForEncoding(encoding, self);
    }
    internal static sbyte[] GetBytes(this string self, string encoding)
    {
        return GetSBytesForEncoding(System.Text.Encoding.GetEncoding(encoding), self);
    }
    private static sbyte[] GetSBytesForEncoding(System.Text.Encoding encoding, string s)
    {
        sbyte[] sbytes = new sbyte[encoding.GetByteCount(s)];
        encoding.GetBytes(s, 0, s.Length, (byte[])(object)sbytes, 0);
        return sbytes;
    }
}
