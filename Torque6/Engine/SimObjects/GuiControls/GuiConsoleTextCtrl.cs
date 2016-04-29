using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiConsoleTextCtrl : GuiControl
   {
      
      public GuiConsoleTextCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiConsoleTextCtrlCreateInstance());
      }

      public GuiConsoleTextCtrl(uint pId) : base(pId)
      {
      }

      public GuiConsoleTextCtrl(string pName) : base(pName)
      {
      }

      public GuiConsoleTextCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiConsoleTextCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiConsoleTextCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiConsoleTextCtrlGetExpression(IntPtr ctrl);
         private static _GuiConsoleTextCtrlGetExpression _GuiConsoleTextCtrlGetExpressionFunc;
         internal static IntPtr GuiConsoleTextCtrlGetExpression(IntPtr ctrl)
         {
            if (_GuiConsoleTextCtrlGetExpressionFunc == null)
            {
               _GuiConsoleTextCtrlGetExpressionFunc =
                  (_GuiConsoleTextCtrlGetExpression)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiConsoleTextCtrlGetExpression"), typeof(_GuiConsoleTextCtrlGetExpression));
            }

            return _GuiConsoleTextCtrlGetExpressionFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiConsoleTextCtrlSetExpression(IntPtr ctrl, string expr);
         private static _GuiConsoleTextCtrlSetExpression _GuiConsoleTextCtrlSetExpressionFunc;
         internal static void GuiConsoleTextCtrlSetExpression(IntPtr ctrl, string expr)
         {
            if (_GuiConsoleTextCtrlSetExpressionFunc == null)
            {
               _GuiConsoleTextCtrlSetExpressionFunc =
                  (_GuiConsoleTextCtrlSetExpression)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiConsoleTextCtrlSetExpression"), typeof(_GuiConsoleTextCtrlSetExpression));
            }

            _GuiConsoleTextCtrlSetExpressionFunc(ctrl, expr);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiConsoleTextCtrlCreateInstance();
         private static _GuiConsoleTextCtrlCreateInstance _GuiConsoleTextCtrlCreateInstanceFunc;
         internal static IntPtr GuiConsoleTextCtrlCreateInstance()
         {
            if (_GuiConsoleTextCtrlCreateInstanceFunc == null)
            {
               _GuiConsoleTextCtrlCreateInstanceFunc =
                  (_GuiConsoleTextCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiConsoleTextCtrlCreateInstance"), typeof(_GuiConsoleTextCtrlCreateInstance));
            }

            return _GuiConsoleTextCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string Expression
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiConsoleTextCtrlGetExpression(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiConsoleTextCtrlSetExpression(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}