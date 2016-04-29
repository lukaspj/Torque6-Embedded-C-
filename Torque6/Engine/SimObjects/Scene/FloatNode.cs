using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class FloatNode : BaseNode
   {
      
      public FloatNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.FloatNodeCreateInstance());
      }

      public FloatNode(uint pId) : base(pId)
      {
      }

      public FloatNode(string pName) : base(pName)
      {
      }

      public FloatNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public FloatNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public FloatNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FloatNodeGetUniformName(IntPtr floatNode);
         private static _FloatNodeGetUniformName _FloatNodeGetUniformNameFunc;
         internal static IntPtr FloatNodeGetUniformName(IntPtr floatNode)
         {
            if (_FloatNodeGetUniformNameFunc == null)
            {
               _FloatNodeGetUniformNameFunc =
                  (_FloatNodeGetUniformName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FloatNodeGetUniformName"), typeof(_FloatNodeGetUniformName));
            }

            return _FloatNodeGetUniformNameFunc(floatNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _FloatNodeSetUniformName(IntPtr floatNode, string src);
         private static _FloatNodeSetUniformName _FloatNodeSetUniformNameFunc;
         internal static void FloatNodeSetUniformName(IntPtr floatNode, string src)
         {
            if (_FloatNodeSetUniformNameFunc == null)
            {
               _FloatNodeSetUniformNameFunc =
                  (_FloatNodeSetUniformName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FloatNodeSetUniformName"), typeof(_FloatNodeSetUniformName));
            }

            _FloatNodeSetUniformNameFunc(floatNode, src);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _FloatNodeGetValue(IntPtr floatNode);
         private static _FloatNodeGetValue _FloatNodeGetValueFunc;
         internal static float FloatNodeGetValue(IntPtr floatNode)
         {
            if (_FloatNodeGetValueFunc == null)
            {
               _FloatNodeGetValueFunc =
                  (_FloatNodeGetValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FloatNodeGetValue"), typeof(_FloatNodeGetValue));
            }

            return _FloatNodeGetValueFunc(floatNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _FloatNodeSetValue(IntPtr floatNode, float val);
         private static _FloatNodeSetValue _FloatNodeSetValueFunc;
         internal static void FloatNodeSetValue(IntPtr floatNode, float val)
         {
            if (_FloatNodeSetValueFunc == null)
            {
               _FloatNodeSetValueFunc =
                  (_FloatNodeSetValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FloatNodeSetValue"), typeof(_FloatNodeSetValue));
            }

            _FloatNodeSetValueFunc(floatNode, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FloatNodeCreateInstance();
         private static _FloatNodeCreateInstance _FloatNodeCreateInstanceFunc;
         internal static IntPtr FloatNodeCreateInstance()
         {
            if (_FloatNodeCreateInstanceFunc == null)
            {
               _FloatNodeCreateInstanceFunc =
                  (_FloatNodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FloatNodeCreateInstance"), typeof(_FloatNodeCreateInstance));
            }

            return _FloatNodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string UniformName
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.FloatNodeGetUniformName(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.FloatNodeSetUniformName(ObjectPtr->ObjPtr, value);
         }
      }
      public float Value
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.FloatNodeGetValue(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.FloatNodeSetValue(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}