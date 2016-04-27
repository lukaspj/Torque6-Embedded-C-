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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr Vec4NodeGetUniformName(IntPtr vec4Node);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Vec4NodeSetUniformName(IntPtr vec4Node, string name);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Vec4NodeGetValue(IntPtr vec4Node, out Point4F val);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Vec4NodeSetValue(IntPtr vec4Node, Point4F val);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr Vec4NodeCreateInstance();
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