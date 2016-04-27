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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiConsoleTextCtrlGetExpression(IntPtr ctrl);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiConsoleTextCtrlSetExpression(IntPtr ctrl, string expr);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiConsoleTextCtrlCreateInstance();
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