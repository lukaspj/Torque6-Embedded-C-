using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class CosNode : BaseNode
   {
      
      public CosNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.CosNodeCreateInstance());
      }

      public CosNode(uint pId) : base(pId)
      {
      }

      public CosNode(string pName) : base(pName)
      {
      }

      public CosNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public CosNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public CosNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr CosNodeGetXSrc(IntPtr cosNode);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void CosNodeSetXSrc(IntPtr cosNode, string src);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr CosNodeCreateInstance();
      }
      
      #endregion

      #region Properties

      public string XSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.CosNodeGetXSrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.CosNodeSetXSrc(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}