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
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Plugins_Load(string path);
         private static _Plugins_Load _Plugins_LoadFunc;
         internal static void Plugins_Load(string path)
         {
            if (_Plugins_LoadFunc == null)
            {
               _Plugins_LoadFunc =
                  (_Plugins_Load)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Plugins_Load"), typeof(_Plugins_Load));
            }

            _Plugins_LoadFunc(path);
         }
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