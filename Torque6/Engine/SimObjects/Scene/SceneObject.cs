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
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SceneObjectGetTemplate(IntPtr SceneObject);
         private static _SceneObjectGetTemplate _SceneObjectGetTemplateFunc;
         internal static IntPtr SceneObjectGetTemplate(IntPtr SceneObject)
         {
            if (_SceneObjectGetTemplateFunc == null)
            {
               _SceneObjectGetTemplateFunc =
                  (_SceneObjectGetTemplate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SceneObjectGetTemplate"), typeof(_SceneObjectGetTemplate));
            }

            return _SceneObjectGetTemplateFunc(SceneObject);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SceneObjectSetTemplate(IntPtr SceneObject, string templatePath);
         private static _SceneObjectSetTemplate _SceneObjectSetTemplateFunc;
         internal static void SceneObjectSetTemplate(IntPtr SceneObject, string templatePath)
         {
            if (_SceneObjectSetTemplateFunc == null)
            {
               _SceneObjectSetTemplateFunc =
                  (_SceneObjectSetTemplate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SceneObjectSetTemplate"), typeof(_SceneObjectSetTemplate));
            }

            _SceneObjectSetTemplateFunc(SceneObject, templatePath);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SceneObjectCreateInstance();
         private static _SceneObjectCreateInstance _SceneObjectCreateInstanceFunc;
         internal static IntPtr SceneObjectCreateInstance()
         {
            if (_SceneObjectCreateInstanceFunc == null)
            {
               _SceneObjectCreateInstanceFunc =
                  (_SceneObjectCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SceneObjectCreateInstance"), typeof(_SceneObjectCreateInstance));
            }

            return _SceneObjectCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SceneObjectFindComponent(IntPtr SceneObject, string name);
         private static _SceneObjectFindComponent _SceneObjectFindComponentFunc;
         internal static IntPtr SceneObjectFindComponent(IntPtr SceneObject, string name)
         {
            if (_SceneObjectFindComponentFunc == null)
            {
               _SceneObjectFindComponentFunc =
                  (_SceneObjectFindComponent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SceneObjectFindComponent"), typeof(_SceneObjectFindComponent));
            }

            return _SceneObjectFindComponentFunc(SceneObject, name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SceneObjectFindComponentByType(IntPtr SceneObject, string name);
         private static _SceneObjectFindComponentByType _SceneObjectFindComponentByTypeFunc;
         internal static IntPtr SceneObjectFindComponentByType(IntPtr SceneObject, string name)
         {
            if (_SceneObjectFindComponentByTypeFunc == null)
            {
               _SceneObjectFindComponentByTypeFunc =
                  (_SceneObjectFindComponentByType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SceneObjectFindComponentByType"), typeof(_SceneObjectFindComponentByType));
            }

            return _SceneObjectFindComponentByTypeFunc(SceneObject, name);
         }
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