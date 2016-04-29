using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiBackgroundCtrl : GuiControl
   {
      
      public GuiBackgroundCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiBackgroundCtrlCreateInstance());
      }

      public GuiBackgroundCtrl(uint pId) : base(pId)
      {
      }

      public GuiBackgroundCtrl(string pName) : base(pName)
      {
      }

      public GuiBackgroundCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiBackgroundCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiBackgroundCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBackgroundCtrlCreateInstance();
         private static _GuiBackgroundCtrlCreateInstance _GuiBackgroundCtrlCreateInstanceFunc;
         internal static IntPtr GuiBackgroundCtrlCreateInstance()
         {
            if (_GuiBackgroundCtrlCreateInstanceFunc == null)
            {
               _GuiBackgroundCtrlCreateInstanceFunc =
                  (_GuiBackgroundCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBackgroundCtrlCreateInstance"), typeof(_GuiBackgroundCtrlCreateInstance));
            }

            return _GuiBackgroundCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}