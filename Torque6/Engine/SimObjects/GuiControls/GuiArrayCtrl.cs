using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiArrayCtrl : GuiControl
   {
      
      public GuiArrayCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiArrayCtrlCreateInstance());
      }

      public GuiArrayCtrl(uint pId) : base(pId)
      {
      }

      public GuiArrayCtrl(string pName) : base(pName)
      {
      }

      public GuiArrayCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiArrayCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiArrayCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiArrayCtrlCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}