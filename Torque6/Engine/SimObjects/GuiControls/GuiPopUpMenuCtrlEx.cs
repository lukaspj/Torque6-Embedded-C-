using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiPopUpMenuCtrlEx : GuiTextCtrl
   {
      
      public GuiPopUpMenuCtrlEx()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiPopUpMenuCtrlExCreateInstance());
      }

      public GuiPopUpMenuCtrlEx(uint pId) : base(pId)
      {
      }

      public GuiPopUpMenuCtrlEx(string pName) : base(pName)
      {
      }

      public GuiPopUpMenuCtrlEx(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiPopUpMenuCtrlEx(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiPopUpMenuCtrlEx(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}