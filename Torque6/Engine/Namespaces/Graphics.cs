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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Graphics_SetDefaultShaderPath(string path);
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