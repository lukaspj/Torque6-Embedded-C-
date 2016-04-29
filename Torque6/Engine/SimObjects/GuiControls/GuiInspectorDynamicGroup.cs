using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInspectorDynamicGroup : GuiInspectorGroup
   {
      
      public GuiInspectorDynamicGroup()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInspectorDynamicGroupCreateInstance());
      }

      public GuiInspectorDynamicGroup(uint pId) : base(pId)
      {
      }

      public GuiInspectorDynamicGroup(string pName) : base(pName)
      {
      }

      public GuiInspectorDynamicGroup(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorDynamicGroup(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorDynamicGroup(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorDynamicGroupCreateInstance();
         private static _GuiInspectorDynamicGroupCreateInstance _GuiInspectorDynamicGroupCreateInstanceFunc;
         internal static IntPtr GuiInspectorDynamicGroupCreateInstance()
         {
            if (_GuiInspectorDynamicGroupCreateInstanceFunc == null)
            {
               _GuiInspectorDynamicGroupCreateInstanceFunc =
                  (_GuiInspectorDynamicGroupCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorDynamicGroupCreateInstance"), typeof(_GuiInspectorDynamicGroupCreateInstance));
            }

            return _GuiInspectorDynamicGroupCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiInspectorDynamicGroupAddDynamicField(IntPtr group);
         private static _GuiInspectorDynamicGroupAddDynamicField _GuiInspectorDynamicGroupAddDynamicFieldFunc;
         internal static void GuiInspectorDynamicGroupAddDynamicField(IntPtr group)
         {
            if (_GuiInspectorDynamicGroupAddDynamicFieldFunc == null)
            {
               _GuiInspectorDynamicGroupAddDynamicFieldFunc =
                  (_GuiInspectorDynamicGroupAddDynamicField)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorDynamicGroupAddDynamicField"), typeof(_GuiInspectorDynamicGroupAddDynamicField));
            }

            _GuiInspectorDynamicGroupAddDynamicFieldFunc(group);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiInspectorDynamicGroupInspectGroup(IntPtr group);
         private static _GuiInspectorDynamicGroupInspectGroup _GuiInspectorDynamicGroupInspectGroupFunc;
         internal static void GuiInspectorDynamicGroupInspectGroup(IntPtr group)
         {
            if (_GuiInspectorDynamicGroupInspectGroupFunc == null)
            {
               _GuiInspectorDynamicGroupInspectGroupFunc =
                  (_GuiInspectorDynamicGroupInspectGroup)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorDynamicGroupInspectGroup"), typeof(_GuiInspectorDynamicGroupInspectGroup));
            }

            _GuiInspectorDynamicGroupInspectGroupFunc(group);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void AddDynamicField()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiInspectorDynamicGroupAddDynamicField(ObjectPtr->ObjPtr);
      }

      public void InspectGroup()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiInspectorDynamicGroupInspectGroup(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}