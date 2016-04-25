using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiMenuBackgroundCtrl : GuiControl
   {
      
      public GuiMenuBackgroundCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiMenuBackgroundCtrlCreateInstance());
      }

      public GuiMenuBackgroundCtrl(uint pId) : base(pId)
      {
      }

      public GuiMenuBackgroundCtrl(string pName) : base(pName)
      {
      }

      public GuiMenuBackgroundCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiMenuBackgroundCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiMenuBackgroundCtrl(SimObject pObj) : base(pObj)
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