using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class LerpNode : BaseNode
   {
      
      public LerpNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.LerpNodeCreateInstance());
      }

      public LerpNode(uint pId) : base(pId)
      {
      }

      public LerpNode(string pName) : base(pName)
      {
      }

      public LerpNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public LerpNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public LerpNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string LerpNodeGetInputASrc(IntPtr LerpNode);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void LerpNodeSetInputASrc(IntPtr LerpNode, string src);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string LerpNodeGetInputBSrc(IntPtr LerpNode);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void LerpNodeSetInputBSrc(IntPtr LerpNode, string src);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr LerpNodeCreateInstance();
      }
      
      #endregion

      #region Properties

      public string InputASrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.LerpNodeGetInputASrc(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.LerpNodeSetInputASrc(ObjectPtr->ObjPtr, value);
         }
      }
      public string InputBSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.LerpNodeGetInputBSrc(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.LerpNodeSetInputBSrc(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}