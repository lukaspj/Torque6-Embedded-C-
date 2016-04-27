using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class ObjectTemplateAsset : AssetBase
   {
      
      public ObjectTemplateAsset()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ObjectTemplateAssetCreateInstance());
      }

      public ObjectTemplateAsset(uint pId) : base(pId)
      {
      }

      public ObjectTemplateAsset(string pName) : base(pName)
      {
      }

      public ObjectTemplateAsset(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ObjectTemplateAsset(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ObjectTemplateAsset(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr ObjectTemplateAssetGetTemplateFile(IntPtr ObjectTemplateAsset);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void ObjectTemplateAssetSetTemplateFile(IntPtr ObjectTemplateAsset, string file);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr ObjectTemplateAssetCreateInstance();
      }
      
      #endregion

      #region Properties

      public string TemplateFile
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ObjectTemplateAssetGetTemplateFile(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ObjectTemplateAssetSetTemplateFile(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}