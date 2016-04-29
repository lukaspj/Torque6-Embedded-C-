using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Graphics
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Graphics_SetDefaultShaderPath(string path);
         private static _Graphics_SetDefaultShaderPath _Graphics_SetDefaultShaderPathFunc;
         internal static void Graphics_SetDefaultShaderPath(string path)
         {
            if (_Graphics_SetDefaultShaderPathFunc == null)
            {
               _Graphics_SetDefaultShaderPathFunc =
                  (_Graphics_SetDefaultShaderPath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Graphics_SetDefaultShaderPath"), typeof(_Graphics_SetDefaultShaderPath));
            }

            _Graphics_SetDefaultShaderPathFunc(path);
         }
      }

      #endregion
      
      #region Functions

      public static void SetDefaultShaderPath(string path)
      {
         InternalUnsafeMethods.Graphics_SetDefaultShaderPath(path);
      }      

      #endregion
   }
}