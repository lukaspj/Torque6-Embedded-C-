using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class TextComponent : BaseComponent
   {
      
      public TextComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.TextComponentCreateInstance());
      }

      public TextComponent(uint pId) : base(pId)
      {
      }

      public TextComponent(string pName) : base(pName)
      {
      }

      public TextComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public TextComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public TextComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr TextComponentCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}