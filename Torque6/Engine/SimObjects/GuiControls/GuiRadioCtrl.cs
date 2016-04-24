using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiRadioCtrl : GuiCheckBoxCtrl
   {
      
      public GuiRadioCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiRadioCtrlCreateInstance());
      }

      public GuiRadioCtrl(uint pId) : base(pId)
      {
      }

      public GuiRadioCtrl(string pName) : base(pName)
      {
      }

      public GuiRadioCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiRadioCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiRadioCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiRadioCtrlCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}