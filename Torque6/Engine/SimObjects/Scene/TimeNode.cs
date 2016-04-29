using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class TimeNode : BaseNode
   {
      
      public TimeNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.TimeNodeCreateInstance());
      }

      public TimeNode(uint pId) : base(pId)
      {
      }

      public TimeNode(string pName) : base(pName)
      {
      }

      public TimeNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public TimeNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public TimeNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _TimeNodeGetMultiplier(IntPtr timeNode);
         private static _TimeNodeGetMultiplier _TimeNodeGetMultiplierFunc;
         internal static float TimeNodeGetMultiplier(IntPtr timeNode)
         {
            if (_TimeNodeGetMultiplierFunc == null)
            {
               _TimeNodeGetMultiplierFunc =
                  (_TimeNodeGetMultiplier)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TimeNodeGetMultiplier"), typeof(_TimeNodeGetMultiplier));
            }

            return _TimeNodeGetMultiplierFunc(timeNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TimeNodeSetMultiplier(IntPtr timeNode, float slot);
         private static _TimeNodeSetMultiplier _TimeNodeSetMultiplierFunc;
         internal static void TimeNodeSetMultiplier(IntPtr timeNode, float slot)
         {
            if (_TimeNodeSetMultiplierFunc == null)
            {
               _TimeNodeSetMultiplierFunc =
                  (_TimeNodeSetMultiplier)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TimeNodeSetMultiplier"), typeof(_TimeNodeSetMultiplier));
            }

            _TimeNodeSetMultiplierFunc(timeNode, slot);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TimeNodeCreateInstance();
         private static _TimeNodeCreateInstance _TimeNodeCreateInstanceFunc;
         internal static IntPtr TimeNodeCreateInstance()
         {
            if (_TimeNodeCreateInstanceFunc == null)
            {
               _TimeNodeCreateInstanceFunc =
                  (_TimeNodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TimeNodeCreateInstance"), typeof(_TimeNodeCreateInstance));
            }

            return _TimeNodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public float Multiplier
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.TimeNodeGetMultiplier(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.TimeNodeSetMultiplier(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}