using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class NameTags : SimSet
   {
      
      public NameTags()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.NameTagsCreateInstance());
      }

      public NameTags(uint pId) : base(pId)
      {
      }

      public NameTags(string pName) : base(pName)
      {
      }

      public NameTags(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public NameTags(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public NameTags(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _NameTagsCreateInstance();
         private static _NameTagsCreateInstance _NameTagsCreateInstanceFunc;
         internal static IntPtr NameTagsCreateInstance()
         {
            if (_NameTagsCreateInstanceFunc == null)
            {
               _NameTagsCreateInstanceFunc =
                  (_NameTagsCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NameTagsCreateInstance"), typeof(_NameTagsCreateInstance));
            }

            return _NameTagsCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _NameTagsCreateTag(IntPtr nameTags, string newTagName);
         private static _NameTagsCreateTag _NameTagsCreateTagFunc;
         internal static int NameTagsCreateTag(IntPtr nameTags, string newTagName)
         {
            if (_NameTagsCreateTagFunc == null)
            {
               _NameTagsCreateTagFunc =
                  (_NameTagsCreateTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NameTagsCreateTag"), typeof(_NameTagsCreateTag));
            }

            return _NameTagsCreateTagFunc(nameTags, newTagName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _NameTagsRenameTag(IntPtr nameTags, int tagId, string newTagName);
         private static _NameTagsRenameTag _NameTagsRenameTagFunc;
         internal static int NameTagsRenameTag(IntPtr nameTags, int tagId, string newTagName)
         {
            if (_NameTagsRenameTagFunc == null)
            {
               _NameTagsRenameTagFunc =
                  (_NameTagsRenameTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NameTagsRenameTag"), typeof(_NameTagsRenameTag));
            }

            return _NameTagsRenameTagFunc(nameTags, tagId, newTagName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _NameTagsDeleteTag(IntPtr nameTags, int tagId);
         private static _NameTagsDeleteTag _NameTagsDeleteTagFunc;
         internal static int NameTagsDeleteTag(IntPtr nameTags, int tagId)
         {
            if (_NameTagsDeleteTagFunc == null)
            {
               _NameTagsDeleteTagFunc =
                  (_NameTagsDeleteTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NameTagsDeleteTag"), typeof(_NameTagsDeleteTag));
            }

            return _NameTagsDeleteTagFunc(nameTags, tagId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _NameTagsGetTagCount(IntPtr nameTags);
         private static _NameTagsGetTagCount _NameTagsGetTagCountFunc;
         internal static int NameTagsGetTagCount(IntPtr nameTags)
         {
            if (_NameTagsGetTagCountFunc == null)
            {
               _NameTagsGetTagCountFunc =
                  (_NameTagsGetTagCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NameTagsGetTagCount"), typeof(_NameTagsGetTagCount));
            }

            return _NameTagsGetTagCountFunc(nameTags);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _NameTagsGetTagName(IntPtr nameTags, int tagId);
         private static _NameTagsGetTagName _NameTagsGetTagNameFunc;
         internal static IntPtr NameTagsGetTagName(IntPtr nameTags, int tagId)
         {
            if (_NameTagsGetTagNameFunc == null)
            {
               _NameTagsGetTagNameFunc =
                  (_NameTagsGetTagName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NameTagsGetTagName"), typeof(_NameTagsGetTagName));
            }

            return _NameTagsGetTagNameFunc(nameTags, tagId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _NameTagsGetTagId(IntPtr nameTags, string tagName);
         private static _NameTagsGetTagId _NameTagsGetTagIdFunc;
         internal static int NameTagsGetTagId(IntPtr nameTags, string tagName)
         {
            if (_NameTagsGetTagIdFunc == null)
            {
               _NameTagsGetTagIdFunc =
                  (_NameTagsGetTagId)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NameTagsGetTagId"), typeof(_NameTagsGetTagId));
            }

            return _NameTagsGetTagIdFunc(nameTags, tagName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _NameTagsGetAllTags(IntPtr nameTags);
         private static _NameTagsGetAllTags _NameTagsGetAllTagsFunc;
         internal static IntPtr NameTagsGetAllTags(IntPtr nameTags)
         {
            if (_NameTagsGetAllTagsFunc == null)
            {
               _NameTagsGetAllTagsFunc =
                  (_NameTagsGetAllTags)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NameTagsGetAllTags"), typeof(_NameTagsGetAllTags));
            }

            return _NameTagsGetAllTagsFunc(nameTags);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _NameTagsTag(IntPtr nameTags, int objectId, int tagIdsC, int[] tagIdsV);
         private static _NameTagsTag _NameTagsTagFunc;
         internal static bool NameTagsTag(IntPtr nameTags, int objectId, int tagIdsC, int[] tagIdsV)
         {
            if (_NameTagsTagFunc == null)
            {
               _NameTagsTagFunc =
                  (_NameTagsTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NameTagsTag"), typeof(_NameTagsTag));
            }

            return _NameTagsTagFunc(nameTags, objectId, tagIdsC, tagIdsV);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _NameTagsUntag(IntPtr nameTags, int objectId, int tagIdsC, int[] tagIdsV);
         private static _NameTagsUntag _NameTagsUntagFunc;
         internal static bool NameTagsUntag(IntPtr nameTags, int objectId, int tagIdsC, int[] tagIdsV)
         {
            if (_NameTagsUntagFunc == null)
            {
               _NameTagsUntagFunc =
                  (_NameTagsUntag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NameTagsUntag"), typeof(_NameTagsUntag));
            }

            return _NameTagsUntagFunc(nameTags, objectId, tagIdsC, tagIdsV);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _NameTagsHasTag(IntPtr nameTags, int objectId, int tagIdsC, int[] tagIdsV);
         private static _NameTagsHasTag _NameTagsHasTagFunc;
         internal static bool NameTagsHasTag(IntPtr nameTags, int objectId, int tagIdsC, int[] tagIdsV)
         {
            if (_NameTagsHasTagFunc == null)
            {
               _NameTagsHasTagFunc =
                  (_NameTagsHasTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NameTagsHasTag"), typeof(_NameTagsHasTag));
            }

            return _NameTagsHasTagFunc(nameTags, objectId, tagIdsC, tagIdsV);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _NameTagsQueryTags(IntPtr nameTags, int tagIdsC, int[] tagIdsV, bool excluded);
         private static _NameTagsQueryTags _NameTagsQueryTagsFunc;
         internal static IntPtr NameTagsQueryTags(IntPtr nameTags, int tagIdsC, int[] tagIdsV, bool excluded)
         {
            if (_NameTagsQueryTagsFunc == null)
            {
               _NameTagsQueryTagsFunc =
                  (_NameTagsQueryTags)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NameTagsQueryTags"), typeof(_NameTagsQueryTags));
            }

            return _NameTagsQueryTagsFunc(nameTags, tagIdsC, tagIdsV, excluded);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public int CreateTag(string newTagName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.NameTagsCreateTag(ObjectPtr->ObjPtr, newTagName);
      }

      public int RenameTag(int tagId, string newTagName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.NameTagsRenameTag(ObjectPtr->ObjPtr, tagId, newTagName);
      }

      public int DeleteTag(int tagId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.NameTagsDeleteTag(ObjectPtr->ObjPtr, tagId);
      }

      public int GetTagCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.NameTagsGetTagCount(ObjectPtr->ObjPtr);
      }

      public string GetTagName(int tagId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.NameTagsGetTagName(ObjectPtr->ObjPtr, tagId));
      }

      public int GetTagId(string tagName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.NameTagsGetTagId(ObjectPtr->ObjPtr, tagName);
      }

      public string GetAllTags()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.NameTagsGetAllTags(ObjectPtr->ObjPtr));
      }

      public bool Tag(int objectId, int tagIdsC, int[] tagIdsV)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.NameTagsTag(ObjectPtr->ObjPtr, objectId, tagIdsC, tagIdsV);
      }

      public bool Untag(int objectId, int tagIdsC, int[] tagIdsV)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.NameTagsUntag(ObjectPtr->ObjPtr, objectId, tagIdsC, tagIdsV);
      }

      public bool HasTag(int objectId, int tagIdsC, int[] tagIdsV)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.NameTagsHasTag(ObjectPtr->ObjPtr, objectId, tagIdsC, tagIdsV);
      }

      public string QueryTags(int tagIdsC, int[] tagIdsV, bool excluded = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.NameTagsQueryTags(ObjectPtr->ObjPtr, tagIdsC, tagIdsV, excluded));
      }
      
      #endregion

      
   }
}