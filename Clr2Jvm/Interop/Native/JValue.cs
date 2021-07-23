﻿using System;
using System.Runtime.InteropServices;

namespace Clr2Jvm.Interop.Native
{

    /// <summary>
    /// Represents a reference to a 'jcharArray'.
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

        public static implicit operator JValue(JBoolean z) => new JValue(z);
        public static implicit operator JValue(JByte b) => new JValue(b);
        public static implicit operator JValue(JChar c) => new JValue(c);
        public static implicit operator JValue(JShort s) => new JValue(s);
        public static implicit operator JValue(JInt i) => new JValue(i);
        public static implicit operator JValue(JLong j) => new JValue(j);
        public static implicit operator JValue(JFloat f) => new JValue(f);
        public static implicit operator JValue(JDouble d) => new JValue(d);
        public static implicit operator JValue(JObject o) => new JValue(o);

        public JValue(JBoolean z)
        {
            this.b = 0;
            this.c = '\n';
            this.s = 0;
            this.i = 0;
            this.j = 0;
            this.f = 0;
            this.d = 0;
            this.l = IntPtr.Zero;
            this.z = z;
        }

        public JValue(JByte b)
        {
            this.z = 0;
            this.c = '\n';
            this.s = 0;
            this.i = 0;
            this.j = 0;
            this.f = 0;
            this.d = 0;
            this.l = IntPtr.Zero;
            this.b = b;
        }

        public JValue(JChar c)
        {
            this.z = 0;
            this.b = 0;
            this.s = 0;
            this.i = 0;
            this.j = 0;
            this.f = 0;
            this.d = 0;
            this.l = IntPtr.Zero;
            this.c = c;
        }

        public JValue(JShort s)
        {
            this.z = 0;
            this.b = 0;
            this.c = '\n';
            this.i = 0;
            this.j = 0;
            this.f = 0;
            this.d = 0;
            this.l = IntPtr.Zero;
            this.s = s;
        }

        public JValue(JInt i)
        {
            this.z = 0;
            this.b = 0;
            this.c = '\n';
            this.s = 0;
            this.j = 0;
            this.f = 0;
            this.d = 0;
            this.l = IntPtr.Zero;
            this.i = i;
        }

        public JValue(JLong j)
        {
            this.z = 0;
            this.b = 0;
            this.c = '\n';
            this.s = 0;
            this.i = 0;
            this.f = 0;
            this.d = 0;
            this.l = IntPtr.Zero;
            this.j = j;
        }

        public JValue(JFloat f)
        {
            this.z = 0;
            this.b = 0;
            this.c = '\n';
            this.s = 0;
            this.i = 0;
            this.j = 0;
            this.d = 0;
            this.l = IntPtr.Zero;
            this.f = f;
        }

        public JValue(JDouble d)
        {
            this.z = 0;
            this.b = 0;
            this.c = '\n';
            this.s = 0;
            this.i = 0;
            this.j = 0;
            this.f = 0;
            this.l = IntPtr.Zero;
            this.d = d;
        }

        public JValue(JObject l)
        {
            this.z = 0;
            this.b = 0;
            this.c = '\n';
            this.s = 0;
            this.i = 0;
            this.j = 0;
            this.f = 0;
            this.d = 0;
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