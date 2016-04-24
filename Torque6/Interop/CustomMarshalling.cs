﻿using System;
using System.Runtime.InteropServices;

namespace Torque6.Interop
{
   class CustomMarshalling
   {
      public static string[] IntPtrToStringArray(IntPtr ptr, int count)
      {
         //convert the received pointer into a pointer array
         IntPtr[] stringPointers = new IntPtr[count];
         Marshal.Copy(ptr, stringPointers, 0, count);
         //convert the pointer array into a string array
         string[] strings = new string[count];
         for (int i = 0; i < count; i++)
         {
            if (stringPointers[i] == IntPtr.Zero)
            {
               strings[i] = null;
            }
            else
            {
               strings[i] = Marshal.PtrToStringAnsi(stringPointers[i]);
            }
         }
         return strings;
      }
   }
}
