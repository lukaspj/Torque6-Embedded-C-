using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInspectorTypeEnum : GuiInspectorField
   {
      
      public GuiInspectorTypeEnum()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInspectorTypeEnumCreateInstance());
      }

      public GuiInspectorTypeEnum(uint pId) : base(pId)
      {
      }

      public GuiInspectorTypeEnum(string pName) : base(pName)
      {
      }

      public GuiInspectorTypeEnum(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeEnum(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeEnum(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeEnumCreateInstance();
         private static _GuiInspectorTypeEnumCreateInstance _GuiInspectorTypeEnumCreateInstanceFunc;
         internal static IntPtr GuiInspectorTypeEnumCreateInstance()
         {
            if (_GuiInspectorTypeEnumCreateInstanceFunc == null)
            {
               _GuiInspectorTypeEnumCreateInstanceFunc =
                  (_GuiInspectorTypeEnumCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorTypeEnumCreateInstance"), typeof(_GuiInspectorTypeEnumCreateInstance));
            }

            return _GuiInspectorTypeEnumCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}