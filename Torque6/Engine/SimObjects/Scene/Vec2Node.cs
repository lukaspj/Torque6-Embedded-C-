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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string Vec2NodeGetUniformName(IntPtr vec2Node);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Vec2NodeSetUniformName(IntPtr vec2Node, string name);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Vec2NodeGetValue(IntPtr vec2Node, out Point2F val);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Vec2NodeSetValue(IntPtr vec2Node, Point2F val);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr Vec2NodeCreateInstance();
      }
      
      #endregion

      #region Properties

      public string UniformName
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.Vec2NodeGetUniformName(ObjectPtr->ObjPtr);
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