using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiImageList : SimObject
   {
      
      public GuiImageList()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiImageListCreateInstance());
      }

      public GuiImageList(uint pId) : base(pId)
      {
      }

      public GuiImageList(string pName) : base(pName)
      {
      }

      public GuiImageList(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiImageList(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiImageList(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiImageListCreateInstance();
         private static _GuiImageListCreateInstance _GuiImageListCreateInstanceFunc;
         internal static IntPtr GuiImageListCreateInstance()
         {
            if (_GuiImageListCreateInstanceFunc == null)
            {
               _GuiImageListCreateInstanceFunc =
                  (_GuiImageListCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageListCreateInstance"), typeof(_GuiImageListCreateInstance));
            }

            return _GuiImageListCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiImageListGetImage(IntPtr list, int index);
         private static _GuiImageListGetImage _GuiImageListGetImageFunc;
         internal static IntPtr GuiImageListGetImage(IntPtr list, int index)
         {
            if (_GuiImageListGetImageFunc == null)
            {
               _GuiImageListGetImageFunc =
                  (_GuiImageListGetImage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageListGetImage"), typeof(_GuiImageListGetImage));
            }

            return _GuiImageListGetImageFunc(list, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiImageListClear(IntPtr list);
         private static _GuiImageListClear _GuiImageListClearFunc;
         internal static bool GuiImageListClear(IntPtr list)
         {
            if (_GuiImageListClearFunc == null)
            {
               _GuiImageListClearFunc =
                  (_GuiImageListClear)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageListClear"), typeof(_GuiImageListClear));
            }

            return _GuiImageListClearFunc(list);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiImageListCount(IntPtr list);
         private static _GuiImageListCount _GuiImageListCountFunc;
         internal static int GuiImageListCount(IntPtr list)
         {
            if (_GuiImageListCountFunc == null)
            {
               _GuiImageListCountFunc =
                  (_GuiImageListCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageListCount"), typeof(_GuiImageListCount));
            }

            return _GuiImageListCountFunc(list);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiImageListRemove(IntPtr list, int index);
         private static _GuiImageListRemove _GuiImageListRemoveFunc;
         internal static bool GuiImageListRemove(IntPtr list, int index)
         {
            if (_GuiImageListRemoveFunc == null)
            {
               _GuiImageListRemoveFunc =
                  (_GuiImageListRemove)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageListRemove"), typeof(_GuiImageListRemove));
            }

            return _GuiImageListRemoveFunc(list, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiImageListGetIndex(IntPtr list, string path);
         private static _GuiImageListGetIndex _GuiImageListGetIndexFunc;
         internal static int GuiImageListGetIndex(IntPtr list, string path)
         {
            if (_GuiImageListGetIndexFunc == null)
            {
               _GuiImageListGetIndexFunc =
                  (_GuiImageListGetIndex)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageListGetIndex"), typeof(_GuiImageListGetIndex));
            }

            return _GuiImageListGetIndexFunc(list, path);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiImageListInsert(IntPtr list, string path);
         private static _GuiImageListInsert _GuiImageListInsertFunc;
         internal static int GuiImageListInsert(IntPtr list, string path)
         {
            if (_GuiImageListInsertFunc == null)
            {
               _GuiImageListInsertFunc =
                  (_GuiImageListInsert)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageListInsert"), typeof(_GuiImageListInsert));
            }

            return _GuiImageListInsertFunc(list, path);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public string GetImage(int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiImageListGetImage(ObjectPtr->ObjPtr, index));
      }

      public bool Clear()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiImageListClear(ObjectPtr->ObjPtr);
      }

      public int Count()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiImageListCount(ObjectPtr->ObjPtr);
      }

      public bool Remove(int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiImageListRemove(ObjectPtr->ObjPtr, index);
      }

      public int GetIndex(string path)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiImageListGetIndex(ObjectPtr->ObjPtr, path);
      }

      public int Insert(string path)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiImageListInsert(ObjectPtr->ObjPtr, path);
      }
      
      #endregion

      
   }
}