using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInspectorField : GuiControl
   {
      
      public GuiInspectorField()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInspectorFieldCreateInstance());
      }

      public GuiInspectorField(uint pId) : base(pId)
      {
      }

      public GuiInspectorField(string pName) : base(pName)
      {
      }

      public GuiInspectorField(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorField(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorField(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorFieldCreateInstance();
         private static _GuiInspectorFieldCreateInstance _GuiInspectorFieldCreateInstanceFunc;
         internal static IntPtr GuiInspectorFieldCreateInstance()
         {
            if (_GuiInspectorFieldCreateInstanceFunc == null)
            {
               _GuiInspectorFieldCreateInstanceFunc =
                  (_GuiInspectorFieldCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorFieldCreateInstance"), typeof(_GuiInspectorFieldCreateInstance));
            }

            return _GuiInspectorFieldCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiInspectorFieldApply(IntPtr field, string newValue);
         private static _GuiInspectorFieldApply _GuiInspectorFieldApplyFunc;
         internal static void GuiInspectorFieldApply(IntPtr field, string newValue)
         {
            if (_GuiInspectorFieldApplyFunc == null)
            {
               _GuiInspectorFieldApplyFunc =
                  (_GuiInspectorFieldApply)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorFieldApply"), typeof(_GuiInspectorFieldApply));
            }

            _GuiInspectorFieldApplyFunc(field, newValue);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void Apply(string newValue)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiInspectorFieldApply(ObjectPtr->ObjPtr, newValue);
      }
      
      #endregion

      
   }
}