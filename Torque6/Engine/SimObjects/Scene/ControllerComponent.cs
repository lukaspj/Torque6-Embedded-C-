using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class ControllerComponent : BaseComponent
   {
      
      public ControllerComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ControllerComponentCreateInstance());
      }

      public ControllerComponent(uint pId) : base(pId)
      {
      }

      public ControllerComponent(string pName) : base(pName)
      {
      }

      public ControllerComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ControllerComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ControllerComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern bool ControllerComponentGetCaptureMouse(IntPtr controller);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void ControllerComponentSetCaptureMouse(IntPtr controller, bool capture);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr ControllerComponentCreateInstance();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void ControllerComponentSetForwardVelocity(IntPtr controller, Point3F panVel);
      }
      
      #endregion

      #region Properties

      public bool CaptureMouse
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ControllerComponentGetCaptureMouse(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ControllerComponentSetCaptureMouse(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void SetForwardVelocity(Point3F panVel)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.ControllerComponentSetForwardVelocity(ObjectPtr->ObjPtr, panVel);
      }
      
      #endregion

      
   }
}