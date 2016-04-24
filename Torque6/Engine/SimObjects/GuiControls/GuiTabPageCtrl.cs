using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiTabPageCtrl : GuiTextCtrl
   {
      
      public GuiTabPageCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiTabPageCtrlCreateInstance());
      }

      public GuiTabPageCtrl(uint pId) : base(pId)
      {
      }

      public GuiTabPageCtrl(string pName) : base(pName)
      {
      }

      public GuiTabPageCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTabPageCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTabPageCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiTabPageCtrlCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}