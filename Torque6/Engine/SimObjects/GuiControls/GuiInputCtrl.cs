using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInputCtrl : GuiControl
   {
      
      public GuiInputCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInputCtrlCreateInstance());
      }

      public GuiInputCtrl(uint pId) : base(pId)
      {
      }

      public GuiInputCtrl(string pName) : base(pName)
      {
      }

      public GuiInputCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInputCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInputCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInputCtrlCreateInstance();
         private static _GuiInputCtrlCreateInstance _GuiInputCtrlCreateInstanceFunc;
         internal static IntPtr GuiInputCtrlCreateInstance()
         {
            if (_GuiInputCtrlCreateInstanceFunc == null)
            {
               _GuiInputCtrlCreateInstanceFunc =
                  (_GuiInputCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInputCtrlCreateInstance"), typeof(_GuiInputCtrlCreateInstance));
            }

            return _GuiInputCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}