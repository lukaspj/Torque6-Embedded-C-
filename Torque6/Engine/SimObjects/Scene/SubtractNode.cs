using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class SubtractNode : BaseNode
   {
      
      public SubtractNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.SubtractNodeCreateInstance());
      }

      public SubtractNode(uint pId) : base(pId)
      {
      }

      public SubtractNode(string pName) : base(pName)
      {
      }

      public SubtractNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public SubtractNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public SubtractNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr SubtractNodeGetInputASrc(IntPtr SubtractNode);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void SubtractNodeSetInputASrc(IntPtr SubtractNode, string src);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr SubtractNodeGetInputBSrc(IntPtr SubtractNode);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void SubtractNodeSetInputBSrc(IntPtr SubtractNode, string src);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr SubtractNodeCreateInstance();
      }
      
      #endregion

      #region Properties

      public string InputASrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SubtractNodeGetInputASrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.SubtractNodeSetInputASrc(ObjectPtr->ObjPtr, value);
         }
      }
      public string InputBSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SubtractNodeGetInputBSrc(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.SubtractNodeSetInputBSrc(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}