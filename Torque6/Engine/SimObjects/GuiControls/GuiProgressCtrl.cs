using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiProgressCtrl : GuiTextCtrl
   {
      
      public GuiProgressCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiProgressCtrlCreateInstance());
      }

      public GuiProgressCtrl(uint pId) : base(pId)
      {
      }

      public GuiProgressCtrl(string pName) : base(pName)
      {
      }

      public GuiProgressCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiProgressCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiProgressCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiProgressCtrlCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}