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
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DynamicConsoleMethodComponentCreateInstance();
         private static _DynamicConsoleMethodComponentCreateInstance _DynamicConsoleMethodComponentCreateInstanceFunc;
         internal static IntPtr DynamicConsoleMethodComponentCreateInstance()
         {
            if (_DynamicConsoleMethodComponentCreateInstanceFunc == null)
            {
               _DynamicConsoleMethodComponentCreateInstanceFunc =
                  (_DynamicConsoleMethodComponentCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DynamicConsoleMethodComponentCreateInstance"), typeof(_DynamicConsoleMethodComponentCreateInstance));
            }

            return _DynamicConsoleMethodComponentCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DynamicConsoleMethodComponentCallOnBehaviors(IntPtr component, string methodName, int argc, string[] argv);
         private static _DynamicConsoleMethodComponentCallOnBehaviors _DynamicConsoleMethodComponentCallOnBehaviorsFunc;
         internal static IntPtr DynamicConsoleMethodComponentCallOnBehaviors(IntPtr component, string methodName, int argc, string[] argv)
         {
            if (_DynamicConsoleMethodComponentCallOnBehaviorsFunc == null)
            {
               _DynamicConsoleMethodComponentCallOnBehaviorsFunc =
                  (_DynamicConsoleMethodComponentCallOnBehaviors)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DynamicConsoleMethodComponentCallOnBehaviors"), typeof(_DynamicConsoleMethodComponentCallOnBehaviors));
            }

            return _DynamicConsoleMethodComponentCallOnBehaviorsFunc(component, methodName, argc, argv);
         }
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