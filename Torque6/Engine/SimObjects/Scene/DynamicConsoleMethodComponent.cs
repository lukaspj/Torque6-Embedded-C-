using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class DynamicConsoleMethodComponent : SimComponent
   {
      
      public DynamicConsoleMethodComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.DynamicConsoleMethodComponentCreateInstance());
      }

      public DynamicConsoleMethodComponent(uint pId) : base(pId)
      {
      }

      public DynamicConsoleMethodComponent(string pName) : base(pName)
      {
      }

      public DynamicConsoleMethodComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public DynamicConsoleMethodComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public DynamicConsoleMethodComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr DynamicConsoleMethodComponentCreateInstance();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr DynamicConsoleMethodComponentCallOnBehaviors(IntPtr component, string methodName, int argc, string[] argv);
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public string CallOnBehaviors(string methodName, int argc, string[] argv)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.DynamicConsoleMethodComponentCallOnBehaviors(ObjectPtr->ObjPtr, methodName, argc, argv));
      }
      
      #endregion

      
   }
}