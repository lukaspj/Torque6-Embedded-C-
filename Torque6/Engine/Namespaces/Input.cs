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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Input_DeactivateDirectInput();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Input_ActivateDirectInput();
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