using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class SinNode : BaseNode
   {
      
      public SinNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.SinNodeCreateInstance());
      }

      public SinNode(uint pId) : base(pId)
      {
      }

      public SinNode(string pName) : base(pName)
      {
      }

      public SinNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public SinNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public SinNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SinNodeGetXSrc(IntPtr sinNode);
         private static _SinNodeGetXSrc _SinNodeGetXSrcFunc;
         internal static IntPtr SinNodeGetXSrc(IntPtr sinNode)
         {
            if (_SinNodeGetXSrcFunc == null)
            {
               _SinNodeGetXSrcFunc =
                  (_SinNodeGetXSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SinNodeGetXSrc"), typeof(_SinNodeGetXSrc));
            }

            return _SinNodeGetXSrcFunc(sinNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SinNodeSetXSrc(IntPtr sinNode, string src);
         private static _SinNodeSetXSrc _SinNodeSetXSrcFunc;
         internal static void SinNodeSetXSrc(IntPtr sinNode, string src)
         {
            if (_SinNodeSetXSrcFunc == null)
            {
               _SinNodeSetXSrcFunc =
                  (_SinNodeSetXSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SinNodeSetXSrc"), typeof(_SinNodeSetXSrc));
            }

            _SinNodeSetXSrcFunc(sinNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SinNodeCreateInstance();
         private static _SinNodeCreateInstance _SinNodeCreateInstanceFunc;
         internal static IntPtr SinNodeCreateInstance()
         {
            if (_SinNodeCreateInstanceFunc == null)
            {
               _SinNodeCreateInstanceFunc =
                  (_SinNodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SinNodeCreateInstance"), typeof(_SinNodeCreateInstance));
            }

            return _SinNodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string XSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SinNodeGetXSrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.SinNodeSetXSrc(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}