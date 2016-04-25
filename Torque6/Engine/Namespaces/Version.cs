using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Version
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern bool Version_IsDebugBuild();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern int Version_GetVersionNumber();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string Version_GetVersionString();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string Version_GetCompileTimeString();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string Version_GetBuildString();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string Version_GetEngineVersion();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string Version_GetiPhoneToolsVersion();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Version_SetCompanyAndProduct(string company, string product);
      }

      #endregion
      
      #region Functions

      public static bool IsDebugBuild()
      {
         return InternalUnsafeMethods.Version_IsDebugBuild();
      }

      public static int GetVersionNumber()
      {
         return InternalUnsafeMethods.Version_GetVersionNumber();
      }

      public static string GetVersionString()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Version_GetVersionString());
      }

      public static string GetCompileTimeString()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Version_GetCompileTimeString());
      }

      public static string GetBuildString()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Version_GetBuildString());
      }

      public static string GetEngineVersion()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Version_GetEngineVersion());
      }

      public static string GetiPhoneToolsVersion()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Version_GetiPhoneToolsVersion());
      }

      public static void SetCompanyAndProduct(string company, string product)
      {
         InternalUnsafeMethods.Version_SetCompanyAndProduct(company, product);
      }      

      #endregion
   }
}