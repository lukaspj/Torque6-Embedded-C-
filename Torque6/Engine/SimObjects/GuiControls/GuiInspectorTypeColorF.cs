using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInspectorTypeColorF : GuiInspectorTypeColor
   {
      
      public GuiInspectorTypeColorF()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInspectorTypeColorFCreateInstance());
      }

      public GuiInspectorTypeColorF(uint pId) : base(pId)
      {
      }

      public GuiInspectorTypeColorF(string pName) : base(pName)
      {
      }

      public GuiInspectorTypeColorF(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeColorF(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeColorF(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiInspectorTypeColorFCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}