using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class BaseNode : SimObject
   {
      
      public BaseNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.BaseNodeCreateInstance());
      }

      public BaseNode(uint pId) : base(pId)
      {
      }

      public BaseNode(string pName) : base(pName)
      {
      }

      public BaseNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public BaseNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public BaseNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _BaseNodeGetPosition(IntPtr materialAsset, out Point2I pos);
         private static _BaseNodeGetPosition _BaseNodeGetPositionFunc;
         internal static void BaseNodeGetPosition(IntPtr materialAsset, out Point2I pos)
         {
            if (_BaseNodeGetPositionFunc == null)
            {
               _BaseNodeGetPositionFunc =
                  (_BaseNodeGetPosition)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BaseNodeGetPosition"), typeof(_BaseNodeGetPosition));
            }

            _BaseNodeGetPositionFunc(materialAsset, out pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _BaseNodeSetPosition(IntPtr materialAsset, Point2I pos);
         private static _BaseNodeSetPosition _BaseNodeSetPositionFunc;
         internal static void BaseNodeSetPosition(IntPtr materialAsset, Point2I pos)
         {
            if (_BaseNodeSetPositionFunc == null)
            {
               _BaseNodeSetPositionFunc =
                  (_BaseNodeSetPosition)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BaseNodeSetPosition"), typeof(_BaseNodeSetPosition));
            }

            _BaseNodeSetPositionFunc(materialAsset, pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BaseNodeCreateInstance();
         private static _BaseNodeCreateInstance _BaseNodeCreateInstanceFunc;
         internal static IntPtr BaseNodeCreateInstance()
         {
            if (_BaseNodeCreateInstanceFunc == null)
            {
               _BaseNodeCreateInstanceFunc =
                  (_BaseNodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BaseNodeCreateInstance"), typeof(_BaseNodeCreateInstance));
            }

            return _BaseNodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public Point2I Position
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2I outVal;
            InternalUnsafeMethods.BaseNodeGetPosition(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.BaseNodeSetPosition(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}