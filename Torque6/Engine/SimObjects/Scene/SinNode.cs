using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class SinNode : BaseNode
   {
      
      public SinNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.SinNodeCreateInstance());
      }

      public SinNode(uint pId) : base(pId)
      {
      }

      public SinNode(string pName) : base(pName)
      {
      }

      public SinNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public SinNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public SinNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string SinNodeGetXSrc(IntPtr sinNode);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void SinNodeSetXSrc(IntPtr sinNode, string src);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr SinNodeCreateInstance();
      }
      
      #endregion

      #region Properties

      public string XSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SinNodeGetXSrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.SinNodeSetXSrc(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}