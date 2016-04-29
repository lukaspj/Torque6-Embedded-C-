using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiArrayCtrl : GuiControl
   {
      
      public GuiArrayCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiArrayCtrlCreateInstance());
      }

      public GuiArrayCtrl(uint pId) : base(pId)
      {
      }

      public GuiArrayCtrl(string pName) : base(pName)
      {
      }

      public GuiArrayCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiArrayCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiArrayCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiArrayCtrlCreateInstance();
         private static _GuiArrayCtrlCreateInstance _GuiArrayCtrlCreateInstanceFunc;
         internal static IntPtr GuiArrayCtrlCreateInstance()
         {
            if (_GuiArrayCtrlCreateInstanceFunc == null)
            {
               _GuiArrayCtrlCreateInstanceFunc =
                  (_GuiArrayCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiArrayCtrlCreateInstance"), typeof(_GuiArrayCtrlCreateInstance));
            }

            return _GuiArrayCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}