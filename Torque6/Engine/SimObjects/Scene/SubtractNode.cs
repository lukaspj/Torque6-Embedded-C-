using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class SubtractNode : BaseNode
   {
      
      public SubtractNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.SubtractNodeCreateInstance());
      }

      public SubtractNode(uint pId) : base(pId)
      {
      }

      public SubtractNode(string pName) : base(pName)
      {
      }

      public SubtractNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public SubtractNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public SubtractNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SubtractNodeGetInputASrc(IntPtr SubtractNode);
         private static _SubtractNodeGetInputASrc _SubtractNodeGetInputASrcFunc;
         internal static IntPtr SubtractNodeGetInputASrc(IntPtr SubtractNode)
         {
            if (_SubtractNodeGetInputASrcFunc == null)
            {
               _SubtractNodeGetInputASrcFunc =
                  (_SubtractNodeGetInputASrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SubtractNodeGetInputASrc"), typeof(_SubtractNodeGetInputASrc));
            }

            return _SubtractNodeGetInputASrcFunc(SubtractNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SubtractNodeSetInputASrc(IntPtr SubtractNode, string src);
         private static _SubtractNodeSetInputASrc _SubtractNodeSetInputASrcFunc;
         internal static void SubtractNodeSetInputASrc(IntPtr SubtractNode, string src)
         {
            if (_SubtractNodeSetInputASrcFunc == null)
            {
               _SubtractNodeSetInputASrcFunc =
                  (_SubtractNodeSetInputASrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SubtractNodeSetInputASrc"), typeof(_SubtractNodeSetInputASrc));
            }

            _SubtractNodeSetInputASrcFunc(SubtractNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SubtractNodeGetInputBSrc(IntPtr SubtractNode);
         private static _SubtractNodeGetInputBSrc _SubtractNodeGetInputBSrcFunc;
         internal static IntPtr SubtractNodeGetInputBSrc(IntPtr SubtractNode)
         {
            if (_SubtractNodeGetInputBSrcFunc == null)
            {
               _SubtractNodeGetInputBSrcFunc =
                  (_SubtractNodeGetInputBSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SubtractNodeGetInputBSrc"), typeof(_SubtractNodeGetInputBSrc));
            }

            return _SubtractNodeGetInputBSrcFunc(SubtractNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SubtractNodeSetInputBSrc(IntPtr SubtractNode, string src);
         private static _SubtractNodeSetInputBSrc _SubtractNodeSetInputBSrcFunc;
         internal static void SubtractNodeSetInputBSrc(IntPtr SubtractNode, string src)
         {
            if (_SubtractNodeSetInputBSrcFunc == null)
            {
               _SubtractNodeSetInputBSrcFunc =
                  (_SubtractNodeSetInputBSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SubtractNodeSetInputBSrc"), typeof(_SubtractNodeSetInputBSrc));
            }

            _SubtractNodeSetInputBSrcFunc(SubtractNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SubtractNodeCreateInstance();
         private static _SubtractNodeCreateInstance _SubtractNodeCreateInstanceFunc;
         internal static IntPtr SubtractNodeCreateInstance()
         {
            if (_SubtractNodeCreateInstanceFunc == null)
            {
               _SubtractNodeCreateInstanceFunc =
                  (_SubtractNodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SubtractNodeCreateInstance"), typeof(_SubtractNodeCreateInstance));
            }

            return _SubtractNodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string InputASrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SubtractNodeGetInputASrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.SubtractNodeSetInputASrc(ObjectPtr->ObjPtr, value);
         }
      }
      public string InputBSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SubtractNodeGetInputBSrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.SubtractNodeSetInputBSrc(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}