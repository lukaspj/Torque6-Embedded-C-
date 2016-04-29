using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Profiler
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Profiler_MarkerEnable(string markerName, bool enable);
         private static _Profiler_MarkerEnable _Profiler_MarkerEnableFunc;
         internal static void Profiler_MarkerEnable(string markerName, bool enable)
         {
            if (_Profiler_MarkerEnableFunc == null)
            {
               _Profiler_MarkerEnableFunc =
                  (_Profiler_MarkerEnable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Profiler_MarkerEnable"), typeof(_Profiler_MarkerEnable));
            }

            _Profiler_MarkerEnableFunc(markerName, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Profiler_Enable(bool enable);
         private static _Profiler_Enable _Profiler_EnableFunc;
         internal static void Profiler_Enable(bool enable)
         {
            if (_Profiler_EnableFunc == null)
            {
               _Profiler_EnableFunc =
                  (_Profiler_Enable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Profiler_Enable"), typeof(_Profiler_Enable));
            }

            _Profiler_EnableFunc(enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Profiler_Dump();
         private static _Profiler_Dump _Profiler_DumpFunc;
         internal static void Profiler_Dump()
         {
            if (_Profiler_DumpFunc == null)
            {
               _Profiler_DumpFunc =
                  (_Profiler_Dump)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Profiler_Dump"), typeof(_Profiler_Dump));
            }

            _Profiler_DumpFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Profiler_DumpToFile(string file);
         private static _Profiler_DumpToFile _Profiler_DumpToFileFunc;
         internal static void Profiler_DumpToFile(string file)
         {
            if (_Profiler_DumpToFileFunc == null)
            {
               _Profiler_DumpToFileFunc =
                  (_Profiler_DumpToFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Profiler_DumpToFile"), typeof(_Profiler_DumpToFile));
            }

            _Profiler_DumpToFileFunc(file);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Profiler_Reset();
         private static _Profiler_Reset _Profiler_ResetFunc;
         internal static void Profiler_Reset()
         {
            if (_Profiler_ResetFunc == null)
            {
               _Profiler_ResetFunc =
                  (_Profiler_Reset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Profiler_Reset"), typeof(_Profiler_Reset));
            }

            _Profiler_ResetFunc();
         }
      }

      #endregion
      
      #region Functions

      public static void MarkerEnable(string markerName, bool enable)
      {
         InternalUnsafeMethods.Profiler_MarkerEnable(markerName, enable);
      }

      public static void Enable(bool enable)
      {
         InternalUnsafeMethods.Profiler_Enable(enable);
      }

      public static void Dump()
      {
         InternalUnsafeMethods.Profiler_Dump();
      }

      public static void DumpToFile(string file)
      {
         InternalUnsafeMethods.Profiler_DumpToFile(file);
      }

      public static void Reset()
      {
         InternalUnsafeMethods.Profiler_Reset();
      }      

      #endregion
   }
}