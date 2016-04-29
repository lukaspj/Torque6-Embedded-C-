using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Scene
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Scene_Clear();
         private static _Scene_Clear _Scene_ClearFunc;
         internal static void Scene_Clear()
         {
            if (_Scene_ClearFunc == null)
            {
               _Scene_ClearFunc =
                  (_Scene_Clear)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Scene_Clear"), typeof(_Scene_Clear));
            }

            _Scene_ClearFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Scene_Load(string filename);
         private static _Scene_Load _Scene_LoadFunc;
         internal static void Scene_Load(string filename)
         {
            if (_Scene_LoadFunc == null)
            {
               _Scene_LoadFunc =
                  (_Scene_Load)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Scene_Load"), typeof(_Scene_Load));
            }

            _Scene_LoadFunc(filename);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Scene_Save(string filename);
         private static _Scene_Save _Scene_SaveFunc;
         internal static void Scene_Save(string filename)
         {
            if (_Scene_SaveFunc == null)
            {
               _Scene_SaveFunc =
                  (_Scene_Save)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Scene_Save"), typeof(_Scene_Save));
            }

            _Scene_SaveFunc(filename);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Scene_Refresh();
         private static _Scene_Refresh _Scene_RefreshFunc;
         internal static void Scene_Refresh()
         {
            if (_Scene_RefreshFunc == null)
            {
               _Scene_RefreshFunc =
                  (_Scene_Refresh)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Scene_Refresh"), typeof(_Scene_Refresh));
            }

            _Scene_RefreshFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Scene_AddObject(IntPtr entity, string name);
         private static _Scene_AddObject _Scene_AddObjectFunc;
         internal static void Scene_AddObject(IntPtr entity, string name)
         {
            if (_Scene_AddObjectFunc == null)
            {
               _Scene_AddObjectFunc =
                  (_Scene_AddObject)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Scene_AddObject"), typeof(_Scene_AddObject));
            }

            _Scene_AddObjectFunc(entity, name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Scene_RemoveObject(IntPtr entity, string name);
         private static _Scene_RemoveObject _Scene_RemoveObjectFunc;
         internal static void Scene_RemoveObject(IntPtr entity, string name)
         {
            if (_Scene_RemoveObjectFunc == null)
            {
               _Scene_RemoveObjectFunc =
                  (_Scene_RemoveObject)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Scene_RemoveObject"), typeof(_Scene_RemoveObject));
            }

            _Scene_RemoveObjectFunc(entity, name);
         }
      }

      #endregion
      
      #region Functions

      public static void Clear()
      {
         InternalUnsafeMethods.Scene_Clear();
      }

      public static void Load(string filename)
      {
         InternalUnsafeMethods.Scene_Load(filename);
      }

      public static void Save(string filename)
      {
         InternalUnsafeMethods.Scene_Save(filename);
      }

      public static void Refresh()
      {
         InternalUnsafeMethods.Scene_Refresh();
      }

      public static void AddObject(SceneObject entity, string name)
      {
         InternalUnsafeMethods.Scene_AddObject(entity.ObjectPtr->ObjPtr, name);
      }

      public static void RemoveObject(SceneObject entity, string name)
      {
         InternalUnsafeMethods.Scene_RemoveObject(entity.ObjectPtr->ObjPtr, name);
      }      

      #endregion
   }
}