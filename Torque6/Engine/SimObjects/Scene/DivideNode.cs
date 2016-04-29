using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class DivideNode : BaseNode
   {
      
      public DivideNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.DivideNodeCreateInstance());
      }

      public DivideNode(uint pId) : base(pId)
      {
      }

      public DivideNode(string pName) : base(pName)
      {
      }

      public DivideNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public DivideNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public DivideNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DivideNodeGetInputASrc(IntPtr DivideNode);
         private static _DivideNodeGetInputASrc _DivideNodeGetInputASrcFunc;
         internal static IntPtr DivideNodeGetInputASrc(IntPtr DivideNode)
         {
            if (_DivideNodeGetInputASrcFunc == null)
            {
               _DivideNodeGetInputASrcFunc =
                  (_DivideNodeGetInputASrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DivideNodeGetInputASrc"), typeof(_DivideNodeGetInputASrc));
            }

            return _DivideNodeGetInputASrcFunc(DivideNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _DivideNodeSetInputASrc(IntPtr DivideNode, string src);
         private static _DivideNodeSetInputASrc _DivideNodeSetInputASrcFunc;
         internal static void DivideNodeSetInputASrc(IntPtr DivideNode, string src)
         {
            if (_DivideNodeSetInputASrcFunc == null)
            {
               _DivideNodeSetInputASrcFunc =
                  (_DivideNodeSetInputASrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DivideNodeSetInputASrc"), typeof(_DivideNodeSetInputASrc));
            }

            _DivideNodeSetInputASrcFunc(DivideNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DivideNodeGetInputBSrc(IntPtr DivideNode);
         private static _DivideNodeGetInputBSrc _DivideNodeGetInputBSrcFunc;
         internal static IntPtr DivideNodeGetInputBSrc(IntPtr DivideNode)
         {
            if (_DivideNodeGetInputBSrcFunc == null)
            {
               _DivideNodeGetInputBSrcFunc =
                  (_DivideNodeGetInputBSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DivideNodeGetInputBSrc"), typeof(_DivideNodeGetInputBSrc));
            }

            return _DivideNodeGetInputBSrcFunc(DivideNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _DivideNodeSetInputBSrc(IntPtr DivideNode, string src);
         private static _DivideNodeSetInputBSrc _DivideNodeSetInputBSrcFunc;
         internal static void DivideNodeSetInputBSrc(IntPtr DivideNode, string src)
         {
            if (_DivideNodeSetInputBSrcFunc == null)
            {
               _DivideNodeSetInputBSrcFunc =
                  (_DivideNodeSetInputBSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DivideNodeSetInputBSrc"), typeof(_DivideNodeSetInputBSrc));
            }

            _DivideNodeSetInputBSrcFunc(DivideNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DivideNodeCreateInstance();
         private static _DivideNodeCreateInstance _DivideNodeCreateInstanceFunc;
         internal static IntPtr DivideNodeCreateInstance()
         {
            if (_DivideNodeCreateInstanceFunc == null)
            {
               _DivideNodeCreateInstanceFunc =
                  (_DivideNodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DivideNodeCreateInstance"), typeof(_DivideNodeCreateInstance));
            }

            return _DivideNodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string InputASrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.DivideNodeGetInputASrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.DivideNodeSetInputASrc(ObjectPtr->ObjPtr, value);
         }
      }
      public string InputBSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.DivideNodeGetInputBSrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.DivideNodeSetInputBSrc(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}