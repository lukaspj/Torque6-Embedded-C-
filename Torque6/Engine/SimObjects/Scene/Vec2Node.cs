using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class Vec2Node : BaseNode
   {
      
      public Vec2Node()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.Vec2NodeCreateInstance());
      }

      public Vec2Node(uint pId) : base(pId)
      {
      }

      public Vec2Node(string pName) : base(pName)
      {
      }

      public Vec2Node(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public Vec2Node(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public Vec2Node(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Vec2NodeGetUniformName(IntPtr vec2Node);
         private static _Vec2NodeGetUniformName _Vec2NodeGetUniformNameFunc;
         internal static IntPtr Vec2NodeGetUniformName(IntPtr vec2Node)
         {
            if (_Vec2NodeGetUniformNameFunc == null)
            {
               _Vec2NodeGetUniformNameFunc =
                  (_Vec2NodeGetUniformName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Vec2NodeGetUniformName"), typeof(_Vec2NodeGetUniformName));
            }

            return _Vec2NodeGetUniformNameFunc(vec2Node);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Vec2NodeSetUniformName(IntPtr vec2Node, string name);
         private static _Vec2NodeSetUniformName _Vec2NodeSetUniformNameFunc;
         internal static void Vec2NodeSetUniformName(IntPtr vec2Node, string name)
         {
            if (_Vec2NodeSetUniformNameFunc == null)
            {
               _Vec2NodeSetUniformNameFunc =
                  (_Vec2NodeSetUniformName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Vec2NodeSetUniformName"), typeof(_Vec2NodeSetUniformName));
            }

            _Vec2NodeSetUniformNameFunc(vec2Node, name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Vec2NodeGetValue(IntPtr vec2Node, out Point2F val);
         private static _Vec2NodeGetValue _Vec2NodeGetValueFunc;
         internal static void Vec2NodeGetValue(IntPtr vec2Node, out Point2F val)
         {
            if (_Vec2NodeGetValueFunc == null)
            {
               _Vec2NodeGetValueFunc =
                  (_Vec2NodeGetValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Vec2NodeGetValue"), typeof(_Vec2NodeGetValue));
            }

            _Vec2NodeGetValueFunc(vec2Node, out val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Vec2NodeSetValue(IntPtr vec2Node, Point2F val);
         private static _Vec2NodeSetValue _Vec2NodeSetValueFunc;
         internal static void Vec2NodeSetValue(IntPtr vec2Node, Point2F val)
         {
            if (_Vec2NodeSetValueFunc == null)
            {
               _Vec2NodeSetValueFunc =
                  (_Vec2NodeSetValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Vec2NodeSetValue"), typeof(_Vec2NodeSetValue));
            }

            _Vec2NodeSetValueFunc(vec2Node, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Vec2NodeCreateInstance();
         private static _Vec2NodeCreateInstance _Vec2NodeCreateInstanceFunc;
         internal static IntPtr Vec2NodeCreateInstance()
         {
            if (_Vec2NodeCreateInstanceFunc == null)
            {
               _Vec2NodeCreateInstanceFunc =
                  (_Vec2NodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Vec2NodeCreateInstance"), typeof(_Vec2NodeCreateInstance));
            }

            return _Vec2NodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string UniformName
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Vec2NodeGetUniformName(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.Vec2NodeSetUniformName(ObjectPtr->ObjPtr, value);
         }
      }
      public Point2F Value
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2F outVal;
            InternalUnsafeMethods.Vec2NodeGetValue(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.Vec2NodeSetValue(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}