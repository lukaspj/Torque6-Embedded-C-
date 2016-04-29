using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Mac
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Mac_SetFSAA(int samples);
         private static _Mac_SetFSAA _Mac_SetFSAAFunc;
         internal static void Mac_SetFSAA(int samples)
         {
            if (_Mac_SetFSAAFunc == null)
            {
               _Mac_SetFSAAFunc =
                  (_Mac_SetFSAA)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Mac_SetFSAA"), typeof(_Mac_SetFSAA));
            }

            _Mac_SetFSAAFunc(samples);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Mac_IncreaseFSAA();
         private static _Mac_IncreaseFSAA _Mac_IncreaseFSAAFunc;
         internal static void Mac_IncreaseFSAA()
         {
            if (_Mac_IncreaseFSAAFunc == null)
            {
               _Mac_IncreaseFSAAFunc =
                  (_Mac_IncreaseFSAA)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Mac_IncreaseFSAA"), typeof(_Mac_IncreaseFSAA));
            }

            _Mac_IncreaseFSAAFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Mac_DecreaseFSAA();
         private static _Mac_DecreaseFSAA _Mac_DecreaseFSAAFunc;
         internal static void Mac_DecreaseFSAA()
         {
            if (_Mac_DecreaseFSAAFunc == null)
            {
               _Mac_DecreaseFSAAFunc =
                  (_Mac_DecreaseFSAA)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Mac_DecreaseFSAA"), typeof(_Mac_DecreaseFSAA));
            }

            _Mac_DecreaseFSAAFunc();
         }
      }

      #endregion
      
      #region Functions

      public static void SetFSAA(int samples)
      {
         InternalUnsafeMethods.Mac_SetFSAA(samples);
      }

      public static void IncreaseFSAA()
      {
         InternalUnsafeMethods.Mac_IncreaseFSAA();
      }

      public static void DecreaseFSAA()
      {
         InternalUnsafeMethods.Mac_DecreaseFSAA();
      }      

      #endregion
   }
}