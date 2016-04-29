using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiBitmapButtonTextCtrl : GuiBitmapButtonCtrl
   {
      
      public GuiBitmapButtonTextCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiBitmapButtonTextCtrlCreateInstance());
      }

      public GuiBitmapButtonTextCtrl(uint pId) : base(pId)
      {
      }

      public GuiBitmapButtonTextCtrl(string pName) : base(pName)
      {
      }

      public GuiBitmapButtonTextCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiBitmapButtonTextCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiBitmapButtonTextCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBitmapButtonTextCtrlCreateInstance();
         private static _GuiBitmapButtonTextCtrlCreateInstance _GuiBitmapButtonTextCtrlCreateInstanceFunc;
         internal static IntPtr GuiBitmapButtonTextCtrlCreateInstance()
         {
            if (_GuiBitmapButtonTextCtrlCreateInstanceFunc == null)
            {
               _GuiBitmapButtonTextCtrlCreateInstanceFunc =
                  (_GuiBitmapButtonTextCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapButtonTextCtrlCreateInstance"), typeof(_GuiBitmapButtonTextCtrlCreateInstance));
            }

            return _GuiBitmapButtonTextCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}