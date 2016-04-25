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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Console_Print(string text);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Console_PrintSeparator();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Console_Warn(string text);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Console_Error(string text);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string Console_ExpandEscape(string text);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string Console_CollapseEscape(string text);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Console_SetLogMode(int mode);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Console_PrintEchoFileLoads(bool isEnabled);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Console_OpenWebPage(string address);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Console_Cls();
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