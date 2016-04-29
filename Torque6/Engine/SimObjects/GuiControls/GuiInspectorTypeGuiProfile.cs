using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInspectorTypeGuiProfile : GuiInspectorTypeEnum
   {
      
      public GuiInspectorTypeGuiProfile()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInspectorTypeGuiProfileCreateInstance());
      }

      public GuiInspectorTypeGuiProfile(uint pId) : base(pId)
      {
      }

      public GuiInspectorTypeGuiProfile(string pName) : base(pName)
      {
      }

      public GuiInspectorTypeGuiProfile(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeGuiProfile(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeGuiProfile(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeGuiProfileCreateInstance();
         private static _GuiInspectorTypeGuiProfileCreateInstance _GuiInspectorTypeGuiProfileCreateInstanceFunc;
         internal static IntPtr GuiInspectorTypeGuiProfileCreateInstance()
         {
            if (_GuiInspectorTypeGuiProfileCreateInstanceFunc == null)
            {
               _GuiInspectorTypeGuiProfileCreateInstanceFunc =
                  (_GuiInspectorTypeGuiProfileCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorTypeGuiProfileCreateInstance"), typeof(_GuiInspectorTypeGuiProfileCreateInstance));
            }

            return _GuiInspectorTypeGuiProfileCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}