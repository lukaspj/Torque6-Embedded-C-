using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiTickCtrl : GuiControl
   {
      
      public GuiTickCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiTickCtrlCreateInstance());
      }

      public GuiTickCtrl(uint pId) : base(pId)
      {
      }

      public GuiTickCtrl(string pName) : base(pName)
      {
      }

      public GuiTickCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTickCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTickCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTickCtrlCreateInstance();
         private static _GuiTickCtrlCreateInstance _GuiTickCtrlCreateInstanceFunc;
         internal static IntPtr GuiTickCtrlCreateInstance()
         {
            if (_GuiTickCtrlCreateInstanceFunc == null)
            {
               _GuiTickCtrlCreateInstanceFunc =
                  (_GuiTickCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTickCtrlCreateInstance"), typeof(_GuiTickCtrlCreateInstance));
            }

            return _GuiTickCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTickCtrlSetProcessTicks(IntPtr ctrl, bool tick);
         private static _GuiTickCtrlSetProcessTicks _GuiTickCtrlSetProcessTicksFunc;
         internal static void GuiTickCtrlSetProcessTicks(IntPtr ctrl, bool tick)
         {
            if (_GuiTickCtrlSetProcessTicksFunc == null)
            {
               _GuiTickCtrlSetProcessTicksFunc =
                  (_GuiTickCtrlSetProcessTicks)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTickCtrlSetProcessTicks"), typeof(_GuiTickCtrlSetProcessTicks));
            }

            _GuiTickCtrlSetProcessTicksFunc(ctrl, tick);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void SetProcessTicks(bool tick)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTickCtrlSetProcessTicks(ObjectPtr->ObjPtr, tick);
      }
      
      #endregion

      
   }
}