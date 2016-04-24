using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInspectorTypeColorI : GuiInspectorTypeColor
   {
      
      public GuiInspectorTypeColorI()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInspectorTypeColorICreateInstance());
      }

      public GuiInspectorTypeColorI(uint pId) : base(pId)
      {
      }

      public GuiInspectorTypeColorI(string pName) : base(pName)
      {
      }

      public GuiInspectorTypeColorI(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeColorI(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeColorI(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiInspectorTypeColorICreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}