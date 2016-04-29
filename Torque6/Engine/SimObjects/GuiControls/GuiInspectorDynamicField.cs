using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInspectorDynamicField : GuiInspectorField
   {
      
      public GuiInspectorDynamicField()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInspectorDynamicFieldCreateInstance());
      }

      public GuiInspectorDynamicField(uint pId) : base(pId)
      {
      }

      public GuiInspectorDynamicField(string pName) : base(pName)
      {
      }

      public GuiInspectorDynamicField(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorDynamicField(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorDynamicField(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorDynamicFieldCreateInstance();
         private static _GuiInspectorDynamicFieldCreateInstance _GuiInspectorDynamicFieldCreateInstanceFunc;
         internal static IntPtr GuiInspectorDynamicFieldCreateInstance()
         {
            if (_GuiInspectorDynamicFieldCreateInstanceFunc == null)
            {
               _GuiInspectorDynamicFieldCreateInstanceFunc =
                  (_GuiInspectorDynamicFieldCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorDynamicFieldCreateInstance"), typeof(_GuiInspectorDynamicFieldCreateInstance));
            }

            return _GuiInspectorDynamicFieldCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiInspectorDynamicFieldRenameField(IntPtr field, string newName);
         private static _GuiInspectorDynamicFieldRenameField _GuiInspectorDynamicFieldRenameFieldFunc;
         internal static void GuiInspectorDynamicFieldRenameField(IntPtr field, string newName)
         {
            if (_GuiInspectorDynamicFieldRenameFieldFunc == null)
            {
               _GuiInspectorDynamicFieldRenameFieldFunc =
                  (_GuiInspectorDynamicFieldRenameField)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorDynamicFieldRenameField"), typeof(_GuiInspectorDynamicFieldRenameField));
            }

            _GuiInspectorDynamicFieldRenameFieldFunc(field, newName);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void RenameField(string newName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiInspectorDynamicFieldRenameField(ObjectPtr->ObjPtr, newName);
      }
      
      #endregion

      
   }
}