using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiButtonCtrl : GuiButtonBaseCtrl
   {
      
      public GuiButtonCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiButtonCtrlCreateInstance());
      }

      public GuiButtonCtrl(uint pId) : base(pId)
      {
      }

      public GuiButtonCtrl(string pName) : base(pName)
      {
      }

      public GuiButtonCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiButtonCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiButtonCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiButtonCtrlCreateInstance();
         private static _GuiButtonCtrlCreateInstance _GuiButtonCtrlCreateInstanceFunc;
         internal static IntPtr GuiButtonCtrlCreateInstance()
         {
            if (_GuiButtonCtrlCreateInstanceFunc == null)
            {
               _GuiButtonCtrlCreateInstanceFunc =
                  (_GuiButtonCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiButtonCtrlCreateInstance"), typeof(_GuiButtonCtrlCreateInstance));
            }

            return _GuiButtonCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}