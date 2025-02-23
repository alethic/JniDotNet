﻿using System.Runtime.InteropServices;

namespace Clr2Jvm.Interop.Native
{

    /// <summary>
    /// Represents a 'jvalue'.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    readonly struct JValue
    {

        public static implicit operator JBoolean(JValue v) => v.Z;
        public static implicit operator JByte(JValue v) => v.B;
        public static implicit operator JChar(JValue v) => v.C;
        public static implicit operator JShort(JValue v) => v.S;
        public static implicit operator JInt(JValue v) => v.I;
        public static implicit operator JLong(JValue v) => v.J;
        public static implicit operator JFloat(JValue v) => v.F;
        public static implicit operator JDouble(JValue v) => v.D;
        public static implicit operator JObject(JValue v) => v.L;

        public static implicit operator JValue(JBoolean z) => new(z);
        public static implicit operator JValue(JByte b) => new(b);
        public static implicit operator JValue(JChar c) => new(c);
        public static implicit operator JValue(JShort s) => new(s);
        public static implicit operator JValue(JInt i) => new(i);
        public static implicit operator JValue(JLong j) => new(j);
        public static implicit operator JValue(JFloat f) => new(f);
        public static implicit operator JValue(JDouble d) => new(d);
        public static implicit operator JValue(JObject o) => new(o);

        public static implicit operator JValue(bool z) => new((JBoolean)z);
        public static implicit operator JValue(sbyte b) => new((JByte)b);
        public static implicit operator JValue(char c) => new((JChar)c);
        public static implicit operator JValue(short s) => new((JShort)s);
        public static implicit operator JValue(int i) => new((JInt)i);
        public static implicit operator JValue(long j) => new((JLong)j);
        public static implicit operator JValue(float f) => new((JFloat)f);
        public static implicit operator JValue(double d) => new((JDouble)d);

        public JValue(JBoolean z)
        {
            this = new JValue();
            this.z = z;
        }

        public JValue(JByte b)
        {
            this = new JValue();
            this.b = b;
        }

        public JValue(JChar c)
        {
            this = new JValue();
            this.c = c;
        }

        public JValue(JShort s)
        {
            this = new JValue();
            this.s = s;
        }

        public JValue(JInt i)
        {
            this = new JValue();
            this.i = i;
        }

        public JValue(JLong j)
        {
            this = new JValue();
            this.j = j;
        }

        public JValue(JFloat f)
        {
            this = new JValue();
            this.f = f;
        }

        public JValue(JDouble d)
        {
            this = new JValue();
            this.d = d;
        }

        public JValue(JObject l)
        {
            this = new JValue();
            this.l = l;
        }

        [FieldOffset(0)]
        readonly JBoolean z;

        public JBoolean Z => z;

        [FieldOffset(0)]
        readonly JByte b;

        public JByte B => b;

        [FieldOffset(0)]
        readonly JChar c;

        public JChar C => c;

        [FieldOffset(0)]
        readonly JShort s;

        public JShort S => s;

        [FieldOffset(0)]
        readonly JInt i;

        public int I => i;

        [FieldOffset(0)]
        readonly JLong j;

        public JLong J => j;

        [FieldOffset(0)]
        readonly JFloat f;

        public JFloat F => f;

        [FieldOffset(0)]
        readonly JDouble d;

        public JDouble D => d;

        [FieldOffset(0)]
        readonly JObject l;

        public JObject L => l;

    }

}
