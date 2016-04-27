using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class SceneObject : GameObject
   {
      
      public SceneObject()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.SceneObjectCreateInstance());
      }

      public SceneObject(uint pId) : base(pId)
      {
      }

      public SceneObject(string pName) : base(pName)
      {
      }

      public SceneObject(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public SceneObject(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public SceneObject(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr SceneObjectGetTemplate(IntPtr SceneObject);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void SceneObjectSetTemplate(IntPtr SceneObject, string templatePath);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr SceneObjectCreateInstance();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr SceneObjectFindComponent(IntPtr SceneObject, string name);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr SceneObjectFindComponentByType(IntPtr SceneObject, string name);
      }
      
      #endregion

      #region Properties

      public string Template
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SceneObjectGetTemplate(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.SceneObjectSetTemplate(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public SimObject FindComponent(string name)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new SimObject(InternalUnsafeMethods.SceneObjectFindComponent(ObjectPtr->ObjPtr, name));
      }

      public SimObject FindComponentByType(string name)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new SimObject(InternalUnsafeMethods.SceneObjectFindComponentByType(ObjectPtr->ObjPtr, name));
      }
      
      #endregion

      
   }
}