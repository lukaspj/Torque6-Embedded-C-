using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class OpaqueNode : RootNode
   {
      
      public OpaqueNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.OpaqueNodeCreateInstance());
      }

      public OpaqueNode(uint pId) : base(pId)
      {
      }

      public OpaqueNode(string pName) : base(pName)
      {
      }

      public OpaqueNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public OpaqueNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public OpaqueNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _OpaqueNodeGetColorSrc(IntPtr opaqueNode);
         private static _OpaqueNodeGetColorSrc _OpaqueNodeGetColorSrcFunc;
         internal static IntPtr OpaqueNodeGetColorSrc(IntPtr opaqueNode)
         {
            if (_OpaqueNodeGetColorSrcFunc == null)
            {
               _OpaqueNodeGetColorSrcFunc =
                  (_OpaqueNodeGetColorSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpaqueNodeGetColorSrc"), typeof(_OpaqueNodeGetColorSrc));
            }

            return _OpaqueNodeGetColorSrcFunc(opaqueNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _OpaqueNodeSetColorSrc(IntPtr opaqueNode, string src);
         private static _OpaqueNodeSetColorSrc _OpaqueNodeSetColorSrcFunc;
         internal static void OpaqueNodeSetColorSrc(IntPtr opaqueNode, string src)
         {
            if (_OpaqueNodeSetColorSrcFunc == null)
            {
               _OpaqueNodeSetColorSrcFunc =
                  (_OpaqueNodeSetColorSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpaqueNodeSetColorSrc"), typeof(_OpaqueNodeSetColorSrc));
            }

            _OpaqueNodeSetColorSrcFunc(opaqueNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _OpaqueNodeGetNormalSrc(IntPtr opaqueNode);
         private static _OpaqueNodeGetNormalSrc _OpaqueNodeGetNormalSrcFunc;
         internal static IntPtr OpaqueNodeGetNormalSrc(IntPtr opaqueNode)
         {
            if (_OpaqueNodeGetNormalSrcFunc == null)
            {
               _OpaqueNodeGetNormalSrcFunc =
                  (_OpaqueNodeGetNormalSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpaqueNodeGetNormalSrc"), typeof(_OpaqueNodeGetNormalSrc));
            }

            return _OpaqueNodeGetNormalSrcFunc(opaqueNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _OpaqueNodeSetNormalSrc(IntPtr opaqueNode, string src);
         private static _OpaqueNodeSetNormalSrc _OpaqueNodeSetNormalSrcFunc;
         internal static void OpaqueNodeSetNormalSrc(IntPtr opaqueNode, string src)
         {
            if (_OpaqueNodeSetNormalSrcFunc == null)
            {
               _OpaqueNodeSetNormalSrcFunc =
                  (_OpaqueNodeSetNormalSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpaqueNodeSetNormalSrc"), typeof(_OpaqueNodeSetNormalSrc));
            }

            _OpaqueNodeSetNormalSrcFunc(opaqueNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _OpaqueNodeGetMetallicSrc(IntPtr opaqueNode);
         private static _OpaqueNodeGetMetallicSrc _OpaqueNodeGetMetallicSrcFunc;
         internal static IntPtr OpaqueNodeGetMetallicSrc(IntPtr opaqueNode)
         {
            if (_OpaqueNodeGetMetallicSrcFunc == null)
            {
               _OpaqueNodeGetMetallicSrcFunc =
                  (_OpaqueNodeGetMetallicSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpaqueNodeGetMetallicSrc"), typeof(_OpaqueNodeGetMetallicSrc));
            }

            return _OpaqueNodeGetMetallicSrcFunc(opaqueNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _OpaqueNodeSetMetallicSrc(IntPtr opaqueNode, string src);
         private static _OpaqueNodeSetMetallicSrc _OpaqueNodeSetMetallicSrcFunc;
         internal static void OpaqueNodeSetMetallicSrc(IntPtr opaqueNode, string src)
         {
            if (_OpaqueNodeSetMetallicSrcFunc == null)
            {
               _OpaqueNodeSetMetallicSrcFunc =
                  (_OpaqueNodeSetMetallicSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpaqueNodeSetMetallicSrc"), typeof(_OpaqueNodeSetMetallicSrc));
            }

            _OpaqueNodeSetMetallicSrcFunc(opaqueNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _OpaqueNodeGetRoughnessSrc(IntPtr opaqueNode);
         private static _OpaqueNodeGetRoughnessSrc _OpaqueNodeGetRoughnessSrcFunc;
         internal static IntPtr OpaqueNodeGetRoughnessSrc(IntPtr opaqueNode)
         {
            if (_OpaqueNodeGetRoughnessSrcFunc == null)
            {
               _OpaqueNodeGetRoughnessSrcFunc =
                  (_OpaqueNodeGetRoughnessSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpaqueNodeGetRoughnessSrc"), typeof(_OpaqueNodeGetRoughnessSrc));
            }

            return _OpaqueNodeGetRoughnessSrcFunc(opaqueNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _OpaqueNodeSetRoughnessSrc(IntPtr opaqueNode, string src);
         private static _OpaqueNodeSetRoughnessSrc _OpaqueNodeSetRoughnessSrcFunc;
         internal static void OpaqueNodeSetRoughnessSrc(IntPtr opaqueNode, string src)
         {
            if (_OpaqueNodeSetRoughnessSrcFunc == null)
            {
               _OpaqueNodeSetRoughnessSrcFunc =
                  (_OpaqueNodeSetRoughnessSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpaqueNodeSetRoughnessSrc"), typeof(_OpaqueNodeSetRoughnessSrc));
            }

            _OpaqueNodeSetRoughnessSrcFunc(opaqueNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _OpaqueNodeGetWorldPosOffsetSrc(IntPtr opaqueNode);
         private static _OpaqueNodeGetWorldPosOffsetSrc _OpaqueNodeGetWorldPosOffsetSrcFunc;
         internal static IntPtr OpaqueNodeGetWorldPosOffsetSrc(IntPtr opaqueNode)
         {
            if (_OpaqueNodeGetWorldPosOffsetSrcFunc == null)
            {
               _OpaqueNodeGetWorldPosOffsetSrcFunc =
                  (_OpaqueNodeGetWorldPosOffsetSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpaqueNodeGetWorldPosOffsetSrc"), typeof(_OpaqueNodeGetWorldPosOffsetSrc));
            }

            return _OpaqueNodeGetWorldPosOffsetSrcFunc(opaqueNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _OpaqueNodeSetWorldPosOffsetSrc(IntPtr opaqueNode, string src);
         private static _OpaqueNodeSetWorldPosOffsetSrc _OpaqueNodeSetWorldPosOffsetSrcFunc;
         internal static void OpaqueNodeSetWorldPosOffsetSrc(IntPtr opaqueNode, string src)
         {
            if (_OpaqueNodeSetWorldPosOffsetSrcFunc == null)
            {
               _OpaqueNodeSetWorldPosOffsetSrcFunc =
                  (_OpaqueNodeSetWorldPosOffsetSrc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpaqueNodeSetWorldPosOffsetSrc"), typeof(_OpaqueNodeSetWorldPosOffsetSrc));
            }

            _OpaqueNodeSetWorldPosOffsetSrcFunc(opaqueNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _OpaqueNodeCreateInstance();
         private static _OpaqueNodeCreateInstance _OpaqueNodeCreateInstanceFunc;
         internal static IntPtr OpaqueNodeCreateInstance()
         {
            if (_OpaqueNodeCreateInstanceFunc == null)
            {
               _OpaqueNodeCreateInstanceFunc =
                  (_OpaqueNodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpaqueNodeCreateInstance"), typeof(_OpaqueNodeCreateInstance));
            }

            return _OpaqueNodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string ColorSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.OpaqueNodeGetColorSrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.OpaqueNodeSetColorSrc(ObjectPtr->ObjPtr, value);
         }
      }
      public string NormalSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.OpaqueNodeGetNormalSrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.OpaqueNodeSetNormalSrc(ObjectPtr->ObjPtr, value);
         }
      }
      public string MetallicSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.OpaqueNodeGetMetallicSrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.OpaqueNodeSetMetallicSrc(ObjectPtr->ObjPtr, value);
         }
      }
      public string RoughnessSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.OpaqueNodeGetRoughnessSrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.OpaqueNodeSetRoughnessSrc(ObjectPtr->ObjPtr, value);
         }
      }
      public string WorldPosOffsetSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.OpaqueNodeGetWorldPosOffsetSrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.OpaqueNodeSetWorldPosOffsetSrc(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}