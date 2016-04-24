using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class AddNode : BaseNode
   {
      
      public AddNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.AddNodeCreateInstance());
      }

      public AddNode(uint pId) : base(pId)
      {
      }

      public AddNode(string pName) : base(pName)
      {
      }

      public AddNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public AddNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public AddNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string AddNodeGetInputASrc(IntPtr AddNode);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void AddNodeSetInputASrc(IntPtr AddNode, string src);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string AddNodeGetInputBSrc(IntPtr AddNode);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void AddNodeSetInputBSrc(IntPtr AddNode, string src);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr AddNodeCreateInstance();
      }
      
      #endregion

      #region Properties

      public string InputASrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AddNodeGetInputASrc(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AddNodeSetInputASrc(ObjectPtr->ObjPtr, value);
         }
      }
      public string InputBSrc
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AddNodeGetInputBSrc(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AddNodeSetInputBSrc(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}