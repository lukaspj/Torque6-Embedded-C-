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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Mac_SetFSAA(int samples);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Mac_IncreaseFSAA();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Mac_DecreaseFSAA();
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