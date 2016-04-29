using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Expando
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Expando_ExpandPath(string path);
         private static _Expando_ExpandPath _Expando_ExpandPathFunc;
         internal static IntPtr Expando_ExpandPath(string path)
         {
            if (_Expando_ExpandPathFunc == null)
            {
               _Expando_ExpandPathFunc =
                  (_Expando_ExpandPath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Expando_ExpandPath"), typeof(_Expando_ExpandPath));
            }

            return _Expando_ExpandPathFunc(path);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Expando_CollapsePath(string path);
         private static _Expando_CollapsePath _Expando_CollapsePathFunc;
         internal static IntPtr Expando_CollapsePath(string path)
         {
            if (_Expando_CollapsePathFunc == null)
            {
               _Expando_CollapsePathFunc =
                  (_Expando_CollapsePath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Expando_CollapsePath"), typeof(_Expando_CollapsePath));
            }

            return _Expando_CollapsePathFunc(path);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Expando_AddPathExpando(string expando, string path);
         private static _Expando_AddPathExpando _Expando_AddPathExpandoFunc;
         internal static void Expando_AddPathExpando(string expando, string path)
         {
            if (_Expando_AddPathExpandoFunc == null)
            {
               _Expando_AddPathExpandoFunc =
                  (_Expando_AddPathExpando)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Expando_AddPathExpando"), typeof(_Expando_AddPathExpando));
            }

            _Expando_AddPathExpandoFunc(expando, path);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Expando_RemovePathExpando(string expando);
         private static _Expando_RemovePathExpando _Expando_RemovePathExpandoFunc;
         internal static void Expando_RemovePathExpando(string expando)
         {
            if (_Expando_RemovePathExpandoFunc == null)
            {
               _Expando_RemovePathExpandoFunc =
                  (_Expando_RemovePathExpando)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Expando_RemovePathExpando"), typeof(_Expando_RemovePathExpando));
            }

            _Expando_RemovePathExpandoFunc(expando);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Expando_IsPathExpando(string expando);
         private static _Expando_IsPathExpando _Expando_IsPathExpandoFunc;
         internal static bool Expando_IsPathExpando(string expando)
         {
            if (_Expando_IsPathExpandoFunc == null)
            {
               _Expando_IsPathExpandoFunc =
                  (_Expando_IsPathExpando)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Expando_IsPathExpando"), typeof(_Expando_IsPathExpando));
            }

            return _Expando_IsPathExpandoFunc(expando);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Expando_GetPathExpandoCount();
         private static _Expando_GetPathExpandoCount _Expando_GetPathExpandoCountFunc;
         internal static int Expando_GetPathExpandoCount()
         {
            if (_Expando_GetPathExpandoCountFunc == null)
            {
               _Expando_GetPathExpandoCountFunc =
                  (_Expando_GetPathExpandoCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Expando_GetPathExpandoCount"), typeof(_Expando_GetPathExpandoCount));
            }

            return _Expando_GetPathExpandoCountFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Expando_GetPathExpandoKey(int expandoIndex);
         private static _Expando_GetPathExpandoKey _Expando_GetPathExpandoKeyFunc;
         internal static IntPtr Expando_GetPathExpandoKey(int expandoIndex)
         {
            if (_Expando_GetPathExpandoKeyFunc == null)
            {
               _Expando_GetPathExpandoKeyFunc =
                  (_Expando_GetPathExpandoKey)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Expando_GetPathExpandoKey"), typeof(_Expando_GetPathExpandoKey));
            }

            return _Expando_GetPathExpandoKeyFunc(expandoIndex);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Expando_GetPathExpandoValue(int expandoIndex);
         private static _Expando_GetPathExpandoValue _Expando_GetPathExpandoValueFunc;
         internal static IntPtr Expando_GetPathExpandoValue(int expandoIndex)
         {
            if (_Expando_GetPathExpandoValueFunc == null)
            {
               _Expando_GetPathExpandoValueFunc =
                  (_Expando_GetPathExpandoValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Expando_GetPathExpandoValue"), typeof(_Expando_GetPathExpandoValue));
            }

            return _Expando_GetPathExpandoValueFunc(expandoIndex);
         }
      }

      #endregion
      
      #region Functions

      public static string ExpandPath(string path)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Expando_ExpandPath(path));
      }

      public static string CollapsePath(string path)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Expando_CollapsePath(path));
      }

      public static void AddPathExpando(string expando, string path)
      {
         InternalUnsafeMethods.Expando_AddPathExpando(expando, path);
      }

      public static void RemovePathExpando(string expando)
      {
         InternalUnsafeMethods.Expando_RemovePathExpando(expando);
      }

      public static bool IsPathExpando(string expando)
      {
         return InternalUnsafeMethods.Expando_IsPathExpando(expando);
      }

      public static int GetPathExpandoCount()
      {
         return InternalUnsafeMethods.Expando_GetPathExpandoCount();
      }

      public static string GetPathExpandoKey(int expandoIndex)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Expando_GetPathExpandoKey(expandoIndex));
      }

      public static string GetPathExpandoValue(int expandoIndex)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Expando_GetPathExpandoValue(expandoIndex));
      }      

      #endregion
   }
}