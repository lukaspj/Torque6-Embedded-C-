using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class Vec4Node : BaseNode
   {
      
      public Vec4Node()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.Vec4NodeCreateInstance());
      }

      public Vec4Node(uint pId) : base(pId)
      {
      }

      public Vec4Node(string pName) : base(pName)
      {
      }

      public Vec4Node(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public Vec4Node(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public Vec4Node(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Vec4NodeGetUniformName(IntPtr vec4Node);
         private static _Vec4NodeGetUniformName _Vec4NodeGetUniformNameFunc;
         internal static IntPtr Vec4NodeGetUniformName(IntPtr vec4Node)
         {
            if (_Vec4NodeGetUniformNameFunc == null)
            {
               _Vec4NodeGetUniformNameFunc =
                  (_Vec4NodeGetUniformName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Vec4NodeGetUniformName"), typeof(_Vec4NodeGetUniformName));
            }

            return _Vec4NodeGetUniformNameFunc(vec4Node);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Vec4NodeSetUniformName(IntPtr vec4Node, string name);
         private static _Vec4NodeSetUniformName _Vec4NodeSetUniformNameFunc;
         internal static void Vec4NodeSetUniformName(IntPtr vec4Node, string name)
         {
            if (_Vec4NodeSetUniformNameFunc == null)
            {
               _Vec4NodeSetUniformNameFunc =
                  (_Vec4NodeSetUniformName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Vec4NodeSetUniformName"), typeof(_Vec4NodeSetUniformName));
            }

            _Vec4NodeSetUniformNameFunc(vec4Node, name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Vec4NodeGetValue(IntPtr vec4Node, out Point4F val);
         private static _Vec4NodeGetValue _Vec4NodeGetValueFunc;
         internal static void Vec4NodeGetValue(IntPtr vec4Node, out Point4F val)
         {
            if (_Vec4NodeGetValueFunc == null)
            {
               _Vec4NodeGetValueFunc =
                  (_Vec4NodeGetValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Vec4NodeGetValue"), typeof(_Vec4NodeGetValue));
            }

            _Vec4NodeGetValueFunc(vec4Node, out val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Vec4NodeSetValue(IntPtr vec4Node, Point4F val);
         private static _Vec4NodeSetValue _Vec4NodeSetValueFunc;
         internal static void Vec4NodeSetValue(IntPtr vec4Node, Point4F val)
         {
            if (_Vec4NodeSetValueFunc == null)
            {
               _Vec4NodeSetValueFunc =
                  (_Vec4NodeSetValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Vec4NodeSetValue"), typeof(_Vec4NodeSetValue));
            }

            _Vec4NodeSetValueFunc(vec4Node, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Vec4NodeCreateInstance();
         private static _Vec4NodeCreateInstance _Vec4NodeCreateInstanceFunc;
         internal static IntPtr Vec4NodeCreateInstance()
         {
            if (_Vec4NodeCreateInstanceFunc == null)
            {
               _Vec4NodeCreateInstanceFunc =
                  (_Vec4NodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Vec4NodeCreateInstance"), typeof(_Vec4NodeCreateInstance));
            }

            return _Vec4NodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string UniformName
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Vec4NodeGetUniformName(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.Vec4NodeSetUniformName(ObjectPtr->ObjPtr, value);
         }
      }
      public Point4F Value
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point4F outVal;
            InternalUnsafeMethods.Vec4NodeGetValue(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.Vec4NodeSetValue(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}