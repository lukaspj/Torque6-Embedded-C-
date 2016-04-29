using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class AddNode : BaseNode
   {
      
      public AddNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.AddNodeCreateInstance());
      }

      public AddNode(uint pId) : base(pId)
      {
      }

      public AddNode(string pName) : base(pName)
      {
      }

      public AddNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public AddNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public AddNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AddNodeGetInputASrc(IntPtr AddNode);
         private static _AddNodeGetInputASrc _AddNodeGetInputASrcFunc;
         internal static IntPtr AddNodeGetInputASrc(IntPtr AddNode)
         {
            if (_AddNodeGetInputASrcFunc == null)
            {
               _AddNodeGetInputASrcFunc =
                  (_AddNodeGetInputASrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AddNodeGetInputASrc"), typeof(_AddNodeGetInputASrc));
            }

            return _AddNodeGetInputASrcFunc(AddNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AddNodeSetInputASrc(IntPtr AddNode, string src);
         private static _AddNodeSetInputASrc _AddNodeSetInputASrcFunc;
         internal static void AddNodeSetInputASrc(IntPtr AddNode, string src)
         {
            if (_AddNodeSetInputASrcFunc == null)
            {
               _AddNodeSetInputASrcFunc =
                  (_AddNodeSetInputASrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AddNodeSetInputASrc"), typeof(_AddNodeSetInputASrc));
            }

            _AddNodeSetInputASrcFunc(AddNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AddNodeGetInputBSrc(IntPtr AddNode);
         private static _AddNodeGetInputBSrc _AddNodeGetInputBSrcFunc;
         internal static IntPtr AddNodeGetInputBSrc(IntPtr AddNode)
         {
            if (_AddNodeGetInputBSrcFunc == null)
            {
               _AddNodeGetInputBSrcFunc =
                  (_AddNodeGetInputBSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AddNodeGetInputBSrc"), typeof(_AddNodeGetInputBSrc));
            }

            return _AddNodeGetInputBSrcFunc(AddNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AddNodeSetInputBSrc(IntPtr AddNode, string src);
         private static _AddNodeSetInputBSrc _AddNodeSetInputBSrcFunc;
         internal static void AddNodeSetInputBSrc(IntPtr AddNode, string src)
         {
            if (_AddNodeSetInputBSrcFunc == null)
            {
               _AddNodeSetInputBSrcFunc =
                  (_AddNodeSetInputBSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AddNodeSetInputBSrc"), typeof(_AddNodeSetInputBSrc));
            }

            _AddNodeSetInputBSrcFunc(AddNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AddNodeCreateInstance();
         private static _AddNodeCreateInstance _AddNodeCreateInstanceFunc;
         internal static IntPtr AddNodeCreateInstance()
         {
            if (_AddNodeCreateInstanceFunc == null)
            {
               _AddNodeCreateInstanceFunc =
                  (_AddNodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AddNodeCreateInstance"), typeof(_AddNodeCreateInstance));
            }

            return _AddNodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string InputASrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AddNodeGetInputASrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AddNodeSetInputASrc(ObjectPtr->ObjPtr, value);
         }
      }
      public string InputBSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AddNodeGetInputBSrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AddNodeSetInputBSrc(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}