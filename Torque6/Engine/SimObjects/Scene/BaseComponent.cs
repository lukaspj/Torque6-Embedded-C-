using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class BaseComponent : SimObject
   {
      
      public BaseComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.BaseComponentCreateInstance());
      }

      public BaseComponent(uint pId) : base(pId)
      {
      }

      public BaseComponent(string pName) : base(pName)
      {
      }

      public BaseComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public BaseComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public BaseComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr BaseComponentCreateInstance();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void BaseComponentSetUniformVec4(IntPtr baseComponent, string name, Point4F value);
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void SetUniformVec4(string name, Point4F value)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.BaseComponentSetUniformVec4(ObjectPtr->ObjPtr, name, value);
      }
      
      #endregion

      
   }
}