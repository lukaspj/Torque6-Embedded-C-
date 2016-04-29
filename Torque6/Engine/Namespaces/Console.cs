using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Console
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Console_Print(string text);
         private static _Console_Print _Console_PrintFunc;
         internal static void Console_Print(string text)
         {
            if (_Console_PrintFunc == null)
            {
               _Console_PrintFunc =
                  (_Console_Print)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Console_Print"), typeof(_Console_Print));
            }

            _Console_PrintFunc(text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Console_PrintSeparator();
         private static _Console_PrintSeparator _Console_PrintSeparatorFunc;
         internal static void Console_PrintSeparator()
         {
            if (_Console_PrintSeparatorFunc == null)
            {
               _Console_PrintSeparatorFunc =
                  (_Console_PrintSeparator)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Console_PrintSeparator"), typeof(_Console_PrintSeparator));
            }

            _Console_PrintSeparatorFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Console_Warn(string text);
         private static _Console_Warn _Console_WarnFunc;
         internal static void Console_Warn(string text)
         {
            if (_Console_WarnFunc == null)
            {
               _Console_WarnFunc =
                  (_Console_Warn)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Console_Warn"), typeof(_Console_Warn));
            }

            _Console_WarnFunc(text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Console_Error(string text);
         private static _Console_Error _Console_ErrorFunc;
         internal static void Console_Error(string text)
         {
            if (_Console_ErrorFunc == null)
            {
               _Console_ErrorFunc =
                  (_Console_Error)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Console_Error"), typeof(_Console_Error));
            }

            _Console_ErrorFunc(text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Console_ExpandEscape(string text);
         private static _Console_ExpandEscape _Console_ExpandEscapeFunc;
         internal static IntPtr Console_ExpandEscape(string text)
         {
            if (_Console_ExpandEscapeFunc == null)
            {
               _Console_ExpandEscapeFunc =
                  (_Console_ExpandEscape)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Console_ExpandEscape"), typeof(_Console_ExpandEscape));
            }

            return _Console_ExpandEscapeFunc(text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Console_CollapseEscape(string text);
         private static _Console_CollapseEscape _Console_CollapseEscapeFunc;
         internal static IntPtr Console_CollapseEscape(string text)
         {
            if (_Console_CollapseEscapeFunc == null)
            {
               _Console_CollapseEscapeFunc =
                  (_Console_CollapseEscape)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Console_CollapseEscape"), typeof(_Console_CollapseEscape));
            }

            return _Console_CollapseEscapeFunc(text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Console_SetLogMode(int mode);
         private static _Console_SetLogMode _Console_SetLogModeFunc;
         internal static void Console_SetLogMode(int mode)
         {
            if (_Console_SetLogModeFunc == null)
            {
               _Console_SetLogModeFunc =
                  (_Console_SetLogMode)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Console_SetLogMode"), typeof(_Console_SetLogMode));
            }

            _Console_SetLogModeFunc(mode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Console_PrintEchoFileLoads(bool isEnabled);
         private static _Console_PrintEchoFileLoads _Console_PrintEchoFileLoadsFunc;
         internal static void Console_PrintEchoFileLoads(bool isEnabled)
         {
            if (_Console_PrintEchoFileLoadsFunc == null)
            {
               _Console_PrintEchoFileLoadsFunc =
                  (_Console_PrintEchoFileLoads)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Console_PrintEchoFileLoads"), typeof(_Console_PrintEchoFileLoads));
            }

            _Console_PrintEchoFileLoadsFunc(isEnabled);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Console_OpenWebPage(string address);
         private static _Console_OpenWebPage _Console_OpenWebPageFunc;
         internal static void Console_OpenWebPage(string address)
         {
            if (_Console_OpenWebPageFunc == null)
            {
               _Console_OpenWebPageFunc =
                  (_Console_OpenWebPage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Console_OpenWebPage"), typeof(_Console_OpenWebPage));
            }

            _Console_OpenWebPageFunc(address);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Console_Cls();
         private static _Console_Cls _Console_ClsFunc;
         internal static void Console_Cls()
         {
            if (_Console_ClsFunc == null)
            {
               _Console_ClsFunc =
                  (_Console_Cls)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Console_Cls"), typeof(_Console_Cls));
            }

            _Console_ClsFunc();
         }
      }

      #endregion
      
      #region Functions

      public static void Print(string text)
      {
         InternalUnsafeMethods.Console_Print(text);
      }

      public static void PrintSeparator()
      {
         InternalUnsafeMethods.Console_PrintSeparator();
      }

      public static void Warn(string text)
      {
         InternalUnsafeMethods.Console_Warn(text);
      }

      public static void Error(string text)
      {
         InternalUnsafeMethods.Console_Error(text);
      }

      public static string ExpandEscape(string text)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Console_ExpandEscape(text));
      }

      public static string CollapseEscape(string text)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Console_CollapseEscape(text));
      }

      public static void SetLogMode(int mode)
      {
         InternalUnsafeMethods.Console_SetLogMode(mode);
      }

      public static void PrintEchoFileLoads(bool isEnabled)
      {
         InternalUnsafeMethods.Console_PrintEchoFileLoads(isEnabled);
      }

      public static void OpenWebPage(string address)
      {
         InternalUnsafeMethods.Console_OpenWebPage(address);
      }

      public static void Cls()
      {
         InternalUnsafeMethods.Console_Cls();
      }      

      #endregion
   }
}