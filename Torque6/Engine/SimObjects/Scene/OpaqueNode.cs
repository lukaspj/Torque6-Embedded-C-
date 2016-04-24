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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string OpaqueNodeGetColorSrc(IntPtr opaqueNode);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void OpaqueNodeSetColorSrc(IntPtr opaqueNode, string src);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string OpaqueNodeGetNormalSrc(IntPtr opaqueNode);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void OpaqueNodeSetNormalSrc(IntPtr opaqueNode, string src);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string OpaqueNodeGetMetallicSrc(IntPtr opaqueNode);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void OpaqueNodeSetMetallicSrc(IntPtr opaqueNode, string src);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string OpaqueNodeGetRoughnessSrc(IntPtr opaqueNode);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void OpaqueNodeSetRoughnessSrc(IntPtr opaqueNode, string src);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string OpaqueNodeGetWorldPosOffsetSrc(IntPtr opaqueNode);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void OpaqueNodeSetWorldPosOffsetSrc(IntPtr opaqueNode, string src);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr OpaqueNodeCreateInstance();
      }
      
      #endregion

      #region Properties

      public string ColorSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.OpaqueNodeGetColorSrc(ObjectPtr->ObjPtr);
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
            return InternalUnsafeMethods.OpaqueNodeGetNormalSrc(ObjectPtr->ObjPtr);
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
            return InternalUnsafeMethods.OpaqueNodeGetMetallicSrc(ObjectPtr->ObjPtr);
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
            return InternalUnsafeMethods.OpaqueNodeGetRoughnessSrc(ObjectPtr->ObjPtr);
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
            return InternalUnsafeMethods.OpaqueNodeGetWorldPosOffsetSrc(ObjectPtr->ObjPtr);
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