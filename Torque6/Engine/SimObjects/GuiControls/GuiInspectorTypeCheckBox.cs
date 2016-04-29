using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInspectorTypeCheckBox : GuiInspectorField
   {
      
      public GuiInspectorTypeCheckBox()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInspectorTypeCheckBoxCreateInstance());
      }

      public GuiInspectorTypeCheckBox(uint pId) : base(pId)
      {
      }

      public GuiInspectorTypeCheckBox(string pName) : base(pName)
      {
      }

      public GuiInspectorTypeCheckBox(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeCheckBox(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeCheckBox(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeCheckBoxCreateInstance();
         private static _GuiInspectorTypeCheckBoxCreateInstance _GuiInspectorTypeCheckBoxCreateInstanceFunc;
         internal static IntPtr GuiInspectorTypeCheckBoxCreateInstance()
         {
            if (_GuiInspectorTypeCheckBoxCreateInstanceFunc == null)
            {
               _GuiInspectorTypeCheckBoxCreateInstanceFunc =
                  (_GuiInspectorTypeCheckBoxCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorTypeCheckBoxCreateInstance"), typeof(_GuiInspectorTypeCheckBoxCreateInstance));
            }

            return _GuiInspectorTypeCheckBoxCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}