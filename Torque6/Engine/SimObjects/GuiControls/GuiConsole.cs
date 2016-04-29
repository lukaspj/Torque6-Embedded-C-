using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiConsole : GuiArrayCtrl
   {
      
      public GuiConsole()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiConsoleCreateInstance());
      }

      public GuiConsole(uint pId) : base(pId)
      {
      }

      public GuiConsole(string pName) : base(pName)
      {
      }

      public GuiConsole(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiConsole(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiConsole(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiConsoleCreateInstance();
         private static _GuiConsoleCreateInstance _GuiConsoleCreateInstanceFunc;
         internal static IntPtr GuiConsoleCreateInstance()
         {
            if (_GuiConsoleCreateInstanceFunc == null)
            {
               _GuiConsoleCreateInstanceFunc =
                  (_GuiConsoleCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiConsoleCreateInstance"), typeof(_GuiConsoleCreateInstance));
            }

            return _GuiConsoleCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}