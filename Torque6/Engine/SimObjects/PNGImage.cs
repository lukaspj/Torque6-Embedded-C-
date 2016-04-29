using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class PNGImage : SimObject
   {
      
      public PNGImage()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.PNGImageCreateInstance());
      }

      public PNGImage(uint pId) : base(pId)
      {
      }

      public PNGImage(string pName) : base(pName)
      {
      }

      public PNGImage(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public PNGImage(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public PNGImage(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PNGImageCreateInstance();
         private static _PNGImageCreateInstance _PNGImageCreateInstanceFunc;
         internal static IntPtr PNGImageCreateInstance()
         {
            if (_PNGImageCreateInstanceFunc == null)
            {
               _PNGImageCreateInstanceFunc =
                  (_PNGImageCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PNGImageCreateInstance"), typeof(_PNGImageCreateInstance));
            }

            return _PNGImageCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _PNGImageCreateBaseImage(IntPtr image, int width, int height, int imageType);
         private static _PNGImageCreateBaseImage _PNGImageCreateBaseImageFunc;
         internal static bool PNGImageCreateBaseImage(IntPtr image, int width, int height, int imageType)
         {
            if (_PNGImageCreateBaseImageFunc == null)
            {
               _PNGImageCreateBaseImageFunc =
                  (_PNGImageCreateBaseImage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PNGImageCreateBaseImage"), typeof(_PNGImageCreateBaseImage));
            }

            return _PNGImageCreateBaseImageFunc(image, width, height, imageType);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _PNGImageMergeOn(IntPtr image, int width, int height, string imageFile);
         private static _PNGImageMergeOn _PNGImageMergeOnFunc;
         internal static bool PNGImageMergeOn(IntPtr image, int width, int height, string imageFile)
         {
            if (_PNGImageMergeOnFunc == null)
            {
               _PNGImageMergeOnFunc =
                  (_PNGImageMergeOn)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PNGImageMergeOn"), typeof(_PNGImageMergeOn));
            }

            return _PNGImageMergeOnFunc(image, width, height, imageFile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _PNGImageSaveImage(IntPtr image, string fileName);
         private static _PNGImageSaveImage _PNGImageSaveImageFunc;
         internal static bool PNGImageSaveImage(IntPtr image, string fileName)
         {
            if (_PNGImageSaveImageFunc == null)
            {
               _PNGImageSaveImageFunc =
                  (_PNGImageSaveImage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PNGImageSaveImage"), typeof(_PNGImageSaveImage));
            }

            return _PNGImageSaveImageFunc(image, fileName);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public bool CreateBaseImage(int width, int height, int imageType)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.PNGImageCreateBaseImage(ObjectPtr->ObjPtr, width, height, imageType);
      }

      public bool MergeOn(int width, int height, string imageFile)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.PNGImageMergeOn(ObjectPtr->ObjPtr, width, height, imageFile);
      }

      public bool SaveImage(string fileName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.PNGImageSaveImage(ObjectPtr->ObjPtr, fileName);
      }
      
      #endregion

      
   }
}