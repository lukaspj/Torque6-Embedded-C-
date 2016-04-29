using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class LerpNode : BaseNode
   {
      
      public LerpNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.LerpNodeCreateInstance());
      }

      public LerpNode(uint pId) : base(pId)
      {
      }

      public LerpNode(string pName) : base(pName)
      {
      }

      public LerpNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public LerpNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public LerpNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _LerpNodeGetInputASrc(IntPtr LerpNode);
         private static _LerpNodeGetInputASrc _LerpNodeGetInputASrcFunc;
         internal static IntPtr LerpNodeGetInputASrc(IntPtr LerpNode)
         {
            if (_LerpNodeGetInputASrcFunc == null)
            {
               _LerpNodeGetInputASrcFunc =
                  (_LerpNodeGetInputASrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "LerpNodeGetInputASrc"), typeof(_LerpNodeGetInputASrc));
            }

            return _LerpNodeGetInputASrcFunc(LerpNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _LerpNodeSetInputASrc(IntPtr LerpNode, string src);
         private static _LerpNodeSetInputASrc _LerpNodeSetInputASrcFunc;
         internal static void LerpNodeSetInputASrc(IntPtr LerpNode, string src)
         {
            if (_LerpNodeSetInputASrcFunc == null)
            {
               _LerpNodeSetInputASrcFunc =
                  (_LerpNodeSetInputASrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "LerpNodeSetInputASrc"), typeof(_LerpNodeSetInputASrc));
            }

            _LerpNodeSetInputASrcFunc(LerpNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _LerpNodeGetInputBSrc(IntPtr LerpNode);
         private static _LerpNodeGetInputBSrc _LerpNodeGetInputBSrcFunc;
         internal static IntPtr LerpNodeGetInputBSrc(IntPtr LerpNode)
         {
            if (_LerpNodeGetInputBSrcFunc == null)
            {
               _LerpNodeGetInputBSrcFunc =
                  (_LerpNodeGetInputBSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "LerpNodeGetInputBSrc"), typeof(_LerpNodeGetInputBSrc));
            }

            return _LerpNodeGetInputBSrcFunc(LerpNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _LerpNodeSetInputBSrc(IntPtr LerpNode, string src);
         private static _LerpNodeSetInputBSrc _LerpNodeSetInputBSrcFunc;
         internal static void LerpNodeSetInputBSrc(IntPtr LerpNode, string src)
         {
            if (_LerpNodeSetInputBSrcFunc == null)
            {
               _LerpNodeSetInputBSrcFunc =
                  (_LerpNodeSetInputBSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "LerpNodeSetInputBSrc"), typeof(_LerpNodeSetInputBSrc));
            }

            _LerpNodeSetInputBSrcFunc(LerpNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _LerpNodeCreateInstance();
         private static _LerpNodeCreateInstance _LerpNodeCreateInstanceFunc;
         internal static IntPtr LerpNodeCreateInstance()
         {
            if (_LerpNodeCreateInstanceFunc == null)
            {
               _LerpNodeCreateInstanceFunc =
                  (_LerpNodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "LerpNodeCreateInstance"), typeof(_LerpNodeCreateInstance));
            }

            return _LerpNodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string InputASrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.LerpNodeGetInputASrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.LerpNodeSetInputASrc(ObjectPtr->ObjPtr, value);
         }
      }
      public string InputBSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.LerpNodeGetInputBSrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.LerpNodeSetInputBSrc(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}