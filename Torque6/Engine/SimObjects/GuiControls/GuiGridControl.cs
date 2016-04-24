using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiGridControl : GuiControl
   {
      
      public GuiGridControl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiGridControlCreateInstance());
      }

      public GuiGridControl(uint pId) : base(pId)
      {
      }

      public GuiGridControl(string pName) : base(pName)
      {
      }

      public GuiGridControl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiGridControl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiGridControl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiGridControlCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}