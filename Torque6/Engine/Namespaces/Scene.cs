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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Scene_Clear();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Scene_Load(string filename);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Scene_Save(string filename);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Scene_Refresh();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Scene_AddObject(IntPtr entity, string name);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Scene_RemoveObject(IntPtr entity, string name);
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