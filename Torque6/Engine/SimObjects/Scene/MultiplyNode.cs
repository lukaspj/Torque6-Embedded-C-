using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class MultiplyNode : BaseNode
   {
      
      public MultiplyNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.MultiplyNodeCreateInstance());
      }

      public MultiplyNode(uint pId) : base(pId)
      {
      }

      public MultiplyNode(string pName) : base(pName)
      {
      }

      public MultiplyNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public MultiplyNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public MultiplyNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MultiplyNodeGetInputASrc(IntPtr MultiplyNode);
         private static _MultiplyNodeGetInputASrc _MultiplyNodeGetInputASrcFunc;
         internal static IntPtr MultiplyNodeGetInputASrc(IntPtr MultiplyNode)
         {
            if (_MultiplyNodeGetInputASrcFunc == null)
            {
               _MultiplyNodeGetInputASrcFunc =
                  (_MultiplyNodeGetInputASrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MultiplyNodeGetInputASrc"), typeof(_MultiplyNodeGetInputASrc));
            }

            return _MultiplyNodeGetInputASrcFunc(MultiplyNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _MultiplyNodeSetInputASrc(IntPtr MultiplyNode, string src);
         private static _MultiplyNodeSetInputASrc _MultiplyNodeSetInputASrcFunc;
         internal static void MultiplyNodeSetInputASrc(IntPtr MultiplyNode, string src)
         {
            if (_MultiplyNodeSetInputASrcFunc == null)
            {
               _MultiplyNodeSetInputASrcFunc =
                  (_MultiplyNodeSetInputASrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MultiplyNodeSetInputASrc"), typeof(_MultiplyNodeSetInputASrc));
            }

            _MultiplyNodeSetInputASrcFunc(MultiplyNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MultiplyNodeGetInputBSrc(IntPtr MultiplyNode);
         private static _MultiplyNodeGetInputBSrc _MultiplyNodeGetInputBSrcFunc;
         internal static IntPtr MultiplyNodeGetInputBSrc(IntPtr MultiplyNode)
         {
            if (_MultiplyNodeGetInputBSrcFunc == null)
            {
               _MultiplyNodeGetInputBSrcFunc =
                  (_MultiplyNodeGetInputBSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MultiplyNodeGetInputBSrc"), typeof(_MultiplyNodeGetInputBSrc));
            }

            return _MultiplyNodeGetInputBSrcFunc(MultiplyNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _MultiplyNodeSetInputBSrc(IntPtr MultiplyNode, string src);
         private static _MultiplyNodeSetInputBSrc _MultiplyNodeSetInputBSrcFunc;
         internal static void MultiplyNodeSetInputBSrc(IntPtr MultiplyNode, string src)
         {
            if (_MultiplyNodeSetInputBSrcFunc == null)
            {
               _MultiplyNodeSetInputBSrcFunc =
                  (_MultiplyNodeSetInputBSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MultiplyNodeSetInputBSrc"), typeof(_MultiplyNodeSetInputBSrc));
            }

            _MultiplyNodeSetInputBSrcFunc(MultiplyNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MultiplyNodeCreateInstance();
         private static _MultiplyNodeCreateInstance _MultiplyNodeCreateInstanceFunc;
         internal static IntPtr MultiplyNodeCreateInstance()
         {
            if (_MultiplyNodeCreateInstanceFunc == null)
            {
               _MultiplyNodeCreateInstanceFunc =
                  (_MultiplyNodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MultiplyNodeCreateInstance"), typeof(_MultiplyNodeCreateInstance));
            }

            return _MultiplyNodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string InputASrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.MultiplyNodeGetInputASrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.MultiplyNodeSetInputASrc(ObjectPtr->ObjPtr, value);
         }
      }
      public string InputBSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.MultiplyNodeGetInputBSrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.MultiplyNodeSetInputBSrc(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}