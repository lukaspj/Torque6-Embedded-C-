using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInspectorTypeColorI : GuiInspectorTypeColor
   {
      
      public GuiInspectorTypeColorI()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInspectorTypeColorICreateInstance());
      }

      public GuiInspectorTypeColorI(uint pId) : base(pId)
      {
      }

      public GuiInspectorTypeColorI(string pName) : base(pName)
      {
      }

      public GuiInspectorTypeColorI(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeColorI(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeColorI(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeColorICreateInstance();
         private static _GuiInspectorTypeColorICreateInstance _GuiInspectorTypeColorICreateInstanceFunc;
         internal static IntPtr GuiInspectorTypeColorICreateInstance()
         {
            if (_GuiInspectorTypeColorICreateInstanceFunc == null)
            {
               _GuiInspectorTypeColorICreateInstanceFunc =
                  (_GuiInspectorTypeColorICreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorTypeColorICreateInstance"), typeof(_GuiInspectorTypeColorICreateInstance));
            }

            return _GuiInspectorTypeColorICreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}