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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string Expando_ExpandPath(string path);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string Expando_CollapsePath(string path);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Expando_AddPathExpando(string expando, string path);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Expando_RemovePathExpando(string expando);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern bool Expando_IsPathExpando(string expando);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern int Expando_GetPathExpandoCount();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string Expando_GetPathExpandoKey(int expandoIndex);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string Expando_GetPathExpandoValue(int expandoIndex);
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