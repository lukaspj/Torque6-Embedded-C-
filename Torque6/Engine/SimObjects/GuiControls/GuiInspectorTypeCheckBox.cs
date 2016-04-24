using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInspectorTypeCheckBox : GuiInspectorField
   {
      
      public GuiInspectorTypeCheckBox()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInspectorTypeCheckBoxCreateInstance());
      }

      public GuiInspectorTypeCheckBox(uint pId) : base(pId)
      {
      }

      public GuiInspectorTypeCheckBox(string pName) : base(pName)
      {
      }

      public GuiInspectorTypeCheckBox(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeCheckBox(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeCheckBox(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiInspectorTypeCheckBoxCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}