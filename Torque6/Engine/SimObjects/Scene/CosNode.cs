using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class CosNode : BaseNode
   {
      
      public CosNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.CosNodeCreateInstance());
      }

      public CosNode(uint pId) : base(pId)
      {
      }

      public CosNode(string pName) : base(pName)
      {
      }

      public CosNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public CosNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public CosNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _CosNodeGetXSrc(IntPtr cosNode);
         private static _CosNodeGetXSrc _CosNodeGetXSrcFunc;
         internal static IntPtr CosNodeGetXSrc(IntPtr cosNode)
         {
            if (_CosNodeGetXSrcFunc == null)
            {
               _CosNodeGetXSrcFunc =
                  (_CosNodeGetXSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "CosNodeGetXSrc"), typeof(_CosNodeGetXSrc));
            }

            return _CosNodeGetXSrcFunc(cosNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _CosNodeSetXSrc(IntPtr cosNode, string src);
         private static _CosNodeSetXSrc _CosNodeSetXSrcFunc;
         internal static void CosNodeSetXSrc(IntPtr cosNode, string src)
         {
            if (_CosNodeSetXSrcFunc == null)
            {
               _CosNodeSetXSrcFunc =
                  (_CosNodeSetXSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "CosNodeSetXSrc"), typeof(_CosNodeSetXSrc));
            }

            _CosNodeSetXSrcFunc(cosNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _CosNodeCreateInstance();
         private static _CosNodeCreateInstance _CosNodeCreateInstanceFunc;
         internal static IntPtr CosNodeCreateInstance()
         {
            if (_CosNodeCreateInstanceFunc == null)
            {
               _CosNodeCreateInstanceFunc =
                  (_CosNodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "CosNodeCreateInstance"), typeof(_CosNodeCreateInstance));
            }

            return _CosNodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string XSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.CosNodeGetXSrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.CosNodeSetXSrc(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}