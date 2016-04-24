using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiPopupTextListCtrlEx : GuiTextListCtrl
   {
      
      public GuiPopupTextListCtrlEx()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiPopupTextListCtrlExCreateInstance());
      }

      public GuiPopupTextListCtrlEx(uint pId) : base(pId)
      {
      }

      public GuiPopupTextListCtrlEx(string pName) : base(pName)
      {
      }

      public GuiPopupTextListCtrlEx(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiPopupTextListCtrlEx(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiPopupTextListCtrlEx(SimObject pObj) : base(pObj)
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