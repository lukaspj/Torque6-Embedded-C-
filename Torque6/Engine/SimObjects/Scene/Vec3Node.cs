using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class Vec3Node : BaseNode
   {
      
      public Vec3Node()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.Vec3NodeCreateInstance());
      }

      public Vec3Node(uint pId) : base(pId)
      {
      }

      public Vec3Node(string pName) : base(pName)
      {
      }

      public Vec3Node(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public Vec3Node(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public Vec3Node(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Vec3NodeGetUniformName(IntPtr vec3Node);
         private static _Vec3NodeGetUniformName _Vec3NodeGetUniformNameFunc;
         internal static IntPtr Vec3NodeGetUniformName(IntPtr vec3Node)
         {
            if (_Vec3NodeGetUniformNameFunc == null)
            {
               _Vec3NodeGetUniformNameFunc =
                  (_Vec3NodeGetUniformName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Vec3NodeGetUniformName"), typeof(_Vec3NodeGetUniformName));
            }

            return _Vec3NodeGetUniformNameFunc(vec3Node);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Vec3NodeSetUniformName(IntPtr vec3Node, string name);
         private static _Vec3NodeSetUniformName _Vec3NodeSetUniformNameFunc;
         internal static void Vec3NodeSetUniformName(IntPtr vec3Node, string name)
         {
            if (_Vec3NodeSetUniformNameFunc == null)
            {
               _Vec3NodeSetUniformNameFunc =
                  (_Vec3NodeSetUniformName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Vec3NodeSetUniformName"), typeof(_Vec3NodeSetUniformName));
            }

            _Vec3NodeSetUniformNameFunc(vec3Node, name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Vec3NodeGetValue(IntPtr vec3Node, out Point3F val);
         private static _Vec3NodeGetValue _Vec3NodeGetValueFunc;
         internal static void Vec3NodeGetValue(IntPtr vec3Node, out Point3F val)
         {
            if (_Vec3NodeGetValueFunc == null)
            {
               _Vec3NodeGetValueFunc =
                  (_Vec3NodeGetValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Vec3NodeGetValue"), typeof(_Vec3NodeGetValue));
            }

            _Vec3NodeGetValueFunc(vec3Node, out val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Vec3NodeSetValue(IntPtr vec3Node, Point3F val);
         private static _Vec3NodeSetValue _Vec3NodeSetValueFunc;
         internal static void Vec3NodeSetValue(IntPtr vec3Node, Point3F val)
         {
            if (_Vec3NodeSetValueFunc == null)
            {
               _Vec3NodeSetValueFunc =
                  (_Vec3NodeSetValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Vec3NodeSetValue"), typeof(_Vec3NodeSetValue));
            }

            _Vec3NodeSetValueFunc(vec3Node, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Vec3NodeCreateInstance();
         private static _Vec3NodeCreateInstance _Vec3NodeCreateInstanceFunc;
         internal static IntPtr Vec3NodeCreateInstance()
         {
            if (_Vec3NodeCreateInstanceFunc == null)
            {
               _Vec3NodeCreateInstanceFunc =
                  (_Vec3NodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Vec3NodeCreateInstance"), typeof(_Vec3NodeCreateInstance));
            }

            return _Vec3NodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string UniformName
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Vec3NodeGetUniformName(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.Vec3NodeSetUniformName(ObjectPtr->ObjPtr, value);
         }
      }
      public Point3F Value
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point3F outVal;
            InternalUnsafeMethods.Vec3NodeGetValue(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.Vec3NodeSetValue(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}