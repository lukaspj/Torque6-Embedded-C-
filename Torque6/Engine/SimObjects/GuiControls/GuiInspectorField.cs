using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInspectorField : GuiControl
   {
      
      public GuiInspectorField()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInspectorFieldCreateInstance());
      }

      public GuiInspectorField(uint pId) : base(pId)
      {
      }

      public GuiInspectorField(string pName) : base(pName)
      {
      }

      public GuiInspectorField(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorField(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorField(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiInspectorFieldCreateInstance();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiInspectorFieldApply(IntPtr field, string newValue);
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void Apply(string newValue)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiInspectorFieldApply(ObjectPtr->ObjPtr, newValue);
      }
      
      #endregion

      
   }
}