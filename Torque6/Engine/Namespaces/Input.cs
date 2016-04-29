using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Input
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Input_DeactivateDirectInput();
         private static _Input_DeactivateDirectInput _Input_DeactivateDirectInputFunc;
         internal static void Input_DeactivateDirectInput()
         {
            if (_Input_DeactivateDirectInputFunc == null)
            {
               _Input_DeactivateDirectInputFunc =
                  (_Input_DeactivateDirectInput)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Input_DeactivateDirectInput"), typeof(_Input_DeactivateDirectInput));
            }

            _Input_DeactivateDirectInputFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Input_ActivateDirectInput();
         private static _Input_ActivateDirectInput _Input_ActivateDirectInputFunc;
         internal static void Input_ActivateDirectInput()
         {
            if (_Input_ActivateDirectInputFunc == null)
            {
               _Input_ActivateDirectInputFunc =
                  (_Input_ActivateDirectInput)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Input_ActivateDirectInput"), typeof(_Input_ActivateDirectInput));
            }

            _Input_ActivateDirectInputFunc();
         }
      }

      #endregion
      
      #region Functions

      public static void DeactivateDirectInput()
      {
         InternalUnsafeMethods.Input_DeactivateDirectInput();
      }

      public static void ActivateDirectInput()
      {
         InternalUnsafeMethods.Input_ActivateDirectInput();
      }      

      #endregion
   }
}