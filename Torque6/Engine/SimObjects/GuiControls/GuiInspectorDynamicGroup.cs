using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInspectorDynamicGroup : GuiInspectorGroup
   {
      
      public GuiInspectorDynamicGroup()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInspectorDynamicGroupCreateInstance());
      }

      public GuiInspectorDynamicGroup(uint pId) : base(pId)
      {
      }

      public GuiInspectorDynamicGroup(string pName) : base(pName)
      {
      }

      public GuiInspectorDynamicGroup(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorDynamicGroup(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorDynamicGroup(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiInspectorDynamicGroupCreateInstance();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiInspectorDynamicGroupAddDynamicField(IntPtr group);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiInspectorDynamicGroupInspectGroup(IntPtr group);
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void AddDynamicField()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiInspectorDynamicGroupAddDynamicField(ObjectPtr->ObjPtr);
      }

      public void InspectGroup()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiInspectorDynamicGroupInspectGroup(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}