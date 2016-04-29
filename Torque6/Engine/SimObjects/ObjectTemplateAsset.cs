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
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ObjectTemplateAssetGetTemplateFile(IntPtr ObjectTemplateAsset);
         private static _ObjectTemplateAssetGetTemplateFile _ObjectTemplateAssetGetTemplateFileFunc;
         internal static IntPtr ObjectTemplateAssetGetTemplateFile(IntPtr ObjectTemplateAsset)
         {
            if (_ObjectTemplateAssetGetTemplateFileFunc == null)
            {
               _ObjectTemplateAssetGetTemplateFileFunc =
                  (_ObjectTemplateAssetGetTemplateFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ObjectTemplateAssetGetTemplateFile"), typeof(_ObjectTemplateAssetGetTemplateFile));
            }

            return _ObjectTemplateAssetGetTemplateFileFunc(ObjectTemplateAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ObjectTemplateAssetSetTemplateFile(IntPtr ObjectTemplateAsset, string file);
         private static _ObjectTemplateAssetSetTemplateFile _ObjectTemplateAssetSetTemplateFileFunc;
         internal static void ObjectTemplateAssetSetTemplateFile(IntPtr ObjectTemplateAsset, string file)
         {
            if (_ObjectTemplateAssetSetTemplateFileFunc == null)
            {
               _ObjectTemplateAssetSetTemplateFileFunc =
                  (_ObjectTemplateAssetSetTemplateFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ObjectTemplateAssetSetTemplateFile"), typeof(_ObjectTemplateAssetSetTemplateFile));
            }

            _ObjectTemplateAssetSetTemplateFileFunc(ObjectTemplateAsset, file);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ObjectTemplateAssetCreateInstance();
         private static _ObjectTemplateAssetCreateInstance _ObjectTemplateAssetCreateInstanceFunc;
         internal static IntPtr ObjectTemplateAssetCreateInstance()
         {
            if (_ObjectTemplateAssetCreateInstanceFunc == null)
            {
               _ObjectTemplateAssetCreateInstanceFunc =
                  (_ObjectTemplateAssetCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ObjectTemplateAssetCreateInstance"), typeof(_ObjectTemplateAssetCreateInstance));
            }

            return _ObjectTemplateAssetCreateInstanceFunc();
         }
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