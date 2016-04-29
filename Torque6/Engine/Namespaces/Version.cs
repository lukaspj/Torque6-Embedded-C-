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
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Version_IsDebugBuild();
         private static _Version_IsDebugBuild _Version_IsDebugBuildFunc;
         internal static bool Version_IsDebugBuild()
         {
            if (_Version_IsDebugBuildFunc == null)
            {
               _Version_IsDebugBuildFunc =
                  (_Version_IsDebugBuild)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Version_IsDebugBuild"), typeof(_Version_IsDebugBuild));
            }

            return _Version_IsDebugBuildFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Version_GetVersionNumber();
         private static _Version_GetVersionNumber _Version_GetVersionNumberFunc;
         internal static int Version_GetVersionNumber()
         {
            if (_Version_GetVersionNumberFunc == null)
            {
               _Version_GetVersionNumberFunc =
                  (_Version_GetVersionNumber)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Version_GetVersionNumber"), typeof(_Version_GetVersionNumber));
            }

            return _Version_GetVersionNumberFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Version_GetVersionString();
         private static _Version_GetVersionString _Version_GetVersionStringFunc;
         internal static IntPtr Version_GetVersionString()
         {
            if (_Version_GetVersionStringFunc == null)
            {
               _Version_GetVersionStringFunc =
                  (_Version_GetVersionString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Version_GetVersionString"), typeof(_Version_GetVersionString));
            }

            return _Version_GetVersionStringFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Version_GetCompileTimeString();
         private static _Version_GetCompileTimeString _Version_GetCompileTimeStringFunc;
         internal static IntPtr Version_GetCompileTimeString()
         {
            if (_Version_GetCompileTimeStringFunc == null)
            {
               _Version_GetCompileTimeStringFunc =
                  (_Version_GetCompileTimeString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Version_GetCompileTimeString"), typeof(_Version_GetCompileTimeString));
            }

            return _Version_GetCompileTimeStringFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Version_GetBuildString();
         private static _Version_GetBuildString _Version_GetBuildStringFunc;
         internal static IntPtr Version_GetBuildString()
         {
            if (_Version_GetBuildStringFunc == null)
            {
               _Version_GetBuildStringFunc =
                  (_Version_GetBuildString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Version_GetBuildString"), typeof(_Version_GetBuildString));
            }

            return _Version_GetBuildStringFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Version_GetEngineVersion();
         private static _Version_GetEngineVersion _Version_GetEngineVersionFunc;
         internal static IntPtr Version_GetEngineVersion()
         {
            if (_Version_GetEngineVersionFunc == null)
            {
               _Version_GetEngineVersionFunc =
                  (_Version_GetEngineVersion)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Version_GetEngineVersion"), typeof(_Version_GetEngineVersion));
            }

            return _Version_GetEngineVersionFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Version_GetiPhoneToolsVersion();
         private static _Version_GetiPhoneToolsVersion _Version_GetiPhoneToolsVersionFunc;
         internal static IntPtr Version_GetiPhoneToolsVersion()
         {
            if (_Version_GetiPhoneToolsVersionFunc == null)
            {
               _Version_GetiPhoneToolsVersionFunc =
                  (_Version_GetiPhoneToolsVersion)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Version_GetiPhoneToolsVersion"), typeof(_Version_GetiPhoneToolsVersion));
            }

            return _Version_GetiPhoneToolsVersionFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Version_SetCompanyAndProduct(string company, string product);
         private static _Version_SetCompanyAndProduct _Version_SetCompanyAndProductFunc;
         internal static void Version_SetCompanyAndProduct(string company, string product)
         {
            if (_Version_SetCompanyAndProductFunc == null)
            {
               _Version_SetCompanyAndProductFunc =
                  (_Version_SetCompanyAndProduct)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Version_SetCompanyAndProduct"), typeof(_Version_SetCompanyAndProduct));
            }

            _Version_SetCompanyAndProductFunc(company, product);
         }
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