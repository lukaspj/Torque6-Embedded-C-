using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Plugins
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Plugins_Load(string path);
      }

      #endregion
      
      #region Functions

      public static void Load(string path)
      {
         InternalUnsafeMethods.Plugins_Load(path);
      }      

      #endregion
   }
}