using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInspector : GuiStackControl
   {
      
      public GuiInspector()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInspectorCreateInstance());
      }

      public GuiInspector(uint pId) : base(pId)
      {
      }

      public GuiInspector(string pName) : base(pName)
      {
      }

      public GuiInspector(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspector(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspector(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorCreateInstance();
         private static _GuiInspectorCreateInstance _GuiInspectorCreateInstanceFunc;
         internal static IntPtr GuiInspectorCreateInstance()
         {
            if (_GuiInspectorCreateInstanceFunc == null)
            {
               _GuiInspectorCreateInstanceFunc =
                  (_GuiInspectorCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorCreateInstance"), typeof(_GuiInspectorCreateInstance));
            }

            return _GuiInspectorCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorGetInspectObject(IntPtr inspector);
         private static _GuiInspectorGetInspectObject _GuiInspectorGetInspectObjectFunc;
         internal static IntPtr GuiInspectorGetInspectObject(IntPtr inspector)
         {
            if (_GuiInspectorGetInspectObjectFunc == null)
            {
               _GuiInspectorGetInspectObjectFunc =
                  (_GuiInspectorGetInspectObject)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorGetInspectObject"), typeof(_GuiInspectorGetInspectObject));
            }

            return _GuiInspectorGetInspectObjectFunc(inspector);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiInspectorSetName(IntPtr inspector, string newObjectName);
         private static _GuiInspectorSetName _GuiInspectorSetNameFunc;
         internal static void GuiInspectorSetName(IntPtr inspector, string newObjectName)
         {
            if (_GuiInspectorSetNameFunc == null)
            {
               _GuiInspectorSetNameFunc =
                  (_GuiInspectorSetName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorSetName"), typeof(_GuiInspectorSetName));
            }

            _GuiInspectorSetNameFunc(inspector, newObjectName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiInspectorInspect(IntPtr inspector, IntPtr obj);
         private static _GuiInspectorInspect _GuiInspectorInspectFunc;
         internal static void GuiInspectorInspect(IntPtr inspector, IntPtr obj)
         {
            if (_GuiInspectorInspectFunc == null)
            {
               _GuiInspectorInspectFunc =
                  (_GuiInspectorInspect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorInspect"), typeof(_GuiInspectorInspect));
            }

            _GuiInspectorInspectFunc(inspector, obj);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public SimObject GetInspectObject()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new SimObject(InternalUnsafeMethods.GuiInspectorGetInspectObject(ObjectPtr->ObjPtr));
      }

      public void SetName(string newObjectName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiInspectorSetName(ObjectPtr->ObjPtr, newObjectName);
      }

      public void Inspect(SimObject obj)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiInspectorInspect(ObjectPtr->ObjPtr, obj.ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}