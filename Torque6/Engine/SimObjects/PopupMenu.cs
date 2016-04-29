using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class PopupMenu : SimObject
   {
      
      public PopupMenu()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.PopupMenuCreateInstance());
      }

      public PopupMenu(uint pId) : base(pId)
      {
      }

      public PopupMenu(string pName) : base(pName)
      {
      }

      public PopupMenu(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public PopupMenu(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public PopupMenu(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _PopupMenuGetIsPopup(IntPtr popupMenu);
         private static _PopupMenuGetIsPopup _PopupMenuGetIsPopupFunc;
         internal static bool PopupMenuGetIsPopup(IntPtr popupMenu)
         {
            if (_PopupMenuGetIsPopupFunc == null)
            {
               _PopupMenuGetIsPopupFunc =
                  (_PopupMenuGetIsPopup)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PopupMenuGetIsPopup"), typeof(_PopupMenuGetIsPopup));
            }

            return _PopupMenuGetIsPopupFunc(popupMenu);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _PopupMenuSetIsPopup(IntPtr popupMenu, bool value);
         private static _PopupMenuSetIsPopup _PopupMenuSetIsPopupFunc;
         internal static void PopupMenuSetIsPopup(IntPtr popupMenu, bool value)
         {
            if (_PopupMenuSetIsPopupFunc == null)
            {
               _PopupMenuSetIsPopupFunc =
                  (_PopupMenuSetIsPopup)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PopupMenuSetIsPopup"), typeof(_PopupMenuSetIsPopup));
            }

            _PopupMenuSetIsPopupFunc(popupMenu, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PopupMenuCreateInstance();
         private static _PopupMenuCreateInstance _PopupMenuCreateInstanceFunc;
         internal static IntPtr PopupMenuCreateInstance()
         {
            if (_PopupMenuCreateInstanceFunc == null)
            {
               _PopupMenuCreateInstanceFunc =
                  (_PopupMenuCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PopupMenuCreateInstance"), typeof(_PopupMenuCreateInstance));
            }

            return _PopupMenuCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _PopupMenuInsertItem(IntPtr popupMenu, int pos, string title, string accelerator);
         private static _PopupMenuInsertItem _PopupMenuInsertItemFunc;
         internal static int PopupMenuInsertItem(IntPtr popupMenu, int pos, string title, string accelerator)
         {
            if (_PopupMenuInsertItemFunc == null)
            {
               _PopupMenuInsertItemFunc =
                  (_PopupMenuInsertItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PopupMenuInsertItem"), typeof(_PopupMenuInsertItem));
            }

            return _PopupMenuInsertItemFunc(popupMenu, pos, title, accelerator);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _PopupMenuRemoveItem(IntPtr popupMenu, int pos);
         private static _PopupMenuRemoveItem _PopupMenuRemoveItemFunc;
         internal static void PopupMenuRemoveItem(IntPtr popupMenu, int pos)
         {
            if (_PopupMenuRemoveItemFunc == null)
            {
               _PopupMenuRemoveItemFunc =
                  (_PopupMenuRemoveItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PopupMenuRemoveItem"), typeof(_PopupMenuRemoveItem));
            }

            _PopupMenuRemoveItemFunc(popupMenu, pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _PopupMenuInsertSubMenu(IntPtr popupMenu, int pos, string title, IntPtr submenu);
         private static _PopupMenuInsertSubMenu _PopupMenuInsertSubMenuFunc;
         internal static int PopupMenuInsertSubMenu(IntPtr popupMenu, int pos, string title, IntPtr submenu)
         {
            if (_PopupMenuInsertSubMenuFunc == null)
            {
               _PopupMenuInsertSubMenuFunc =
                  (_PopupMenuInsertSubMenu)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PopupMenuInsertSubMenu"), typeof(_PopupMenuInsertSubMenu));
            }

            return _PopupMenuInsertSubMenuFunc(popupMenu, pos, title, submenu);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _PopupMenuEnableItem(IntPtr popupMenu, int pos, bool enable);
         private static _PopupMenuEnableItem _PopupMenuEnableItemFunc;
         internal static void PopupMenuEnableItem(IntPtr popupMenu, int pos, bool enable)
         {
            if (_PopupMenuEnableItemFunc == null)
            {
               _PopupMenuEnableItemFunc =
                  (_PopupMenuEnableItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PopupMenuEnableItem"), typeof(_PopupMenuEnableItem));
            }

            _PopupMenuEnableItemFunc(popupMenu, pos, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _PopupMenuCheckItem(IntPtr popupMenu, int pos, bool checkedValue);
         private static _PopupMenuCheckItem _PopupMenuCheckItemFunc;
         internal static void PopupMenuCheckItem(IntPtr popupMenu, int pos, bool checkedValue)
         {
            if (_PopupMenuCheckItemFunc == null)
            {
               _PopupMenuCheckItemFunc =
                  (_PopupMenuCheckItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PopupMenuCheckItem"), typeof(_PopupMenuCheckItem));
            }

            _PopupMenuCheckItemFunc(popupMenu, pos, checkedValue);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _PopupMenuCheckRadioItem(IntPtr popupMenu, int firstPos, int lastPos, int checkPos);
         private static _PopupMenuCheckRadioItem _PopupMenuCheckRadioItemFunc;
         internal static void PopupMenuCheckRadioItem(IntPtr popupMenu, int firstPos, int lastPos, int checkPos)
         {
            if (_PopupMenuCheckRadioItemFunc == null)
            {
               _PopupMenuCheckRadioItemFunc =
                  (_PopupMenuCheckRadioItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PopupMenuCheckRadioItem"), typeof(_PopupMenuCheckRadioItem));
            }

            _PopupMenuCheckRadioItemFunc(popupMenu, firstPos, lastPos, checkPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _PopupMenuIsItemChecked(IntPtr popupMenu, int pos);
         private static _PopupMenuIsItemChecked _PopupMenuIsItemCheckedFunc;
         internal static bool PopupMenuIsItemChecked(IntPtr popupMenu, int pos)
         {
            if (_PopupMenuIsItemCheckedFunc == null)
            {
               _PopupMenuIsItemCheckedFunc =
                  (_PopupMenuIsItemChecked)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PopupMenuIsItemChecked"), typeof(_PopupMenuIsItemChecked));
            }

            return _PopupMenuIsItemCheckedFunc(popupMenu, pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _PopupMenuAttachToMenuBar(IntPtr popupMenu, int pos, string title);
         private static _PopupMenuAttachToMenuBar _PopupMenuAttachToMenuBarFunc;
         internal static void PopupMenuAttachToMenuBar(IntPtr popupMenu, int pos, string title)
         {
            if (_PopupMenuAttachToMenuBarFunc == null)
            {
               _PopupMenuAttachToMenuBarFunc =
                  (_PopupMenuAttachToMenuBar)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PopupMenuAttachToMenuBar"), typeof(_PopupMenuAttachToMenuBar));
            }

            _PopupMenuAttachToMenuBarFunc(popupMenu, pos, title);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _PopupMenuRemoveFromMenuBar(IntPtr popupMenu);
         private static _PopupMenuRemoveFromMenuBar _PopupMenuRemoveFromMenuBarFunc;
         internal static void PopupMenuRemoveFromMenuBar(IntPtr popupMenu)
         {
            if (_PopupMenuRemoveFromMenuBarFunc == null)
            {
               _PopupMenuRemoveFromMenuBarFunc =
                  (_PopupMenuRemoveFromMenuBar)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PopupMenuRemoveFromMenuBar"), typeof(_PopupMenuRemoveFromMenuBar));
            }

            _PopupMenuRemoveFromMenuBarFunc(popupMenu);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _PopupMenuShowPopup(IntPtr popupMenu, int x, int y);
         private static _PopupMenuShowPopup _PopupMenuShowPopupFunc;
         internal static void PopupMenuShowPopup(IntPtr popupMenu, int x, int y)
         {
            if (_PopupMenuShowPopupFunc == null)
            {
               _PopupMenuShowPopupFunc =
                  (_PopupMenuShowPopup)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PopupMenuShowPopup"), typeof(_PopupMenuShowPopup));
            }

            _PopupMenuShowPopupFunc(popupMenu, x, y);
         }
      }
      
      #endregion

      #region Properties

      public bool IsPopup
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.PopupMenuGetIsPopup(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.PopupMenuSetIsPopup(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public int InsertItem(int pos, string title = null, string accelerator = "")
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.PopupMenuInsertItem(ObjectPtr->ObjPtr, pos, title, accelerator);
      }

      public void RemoveItem(int pos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.PopupMenuRemoveItem(ObjectPtr->ObjPtr, pos);
      }

      public int InsertSubMenu(int pos, string title, PopupMenu submenu)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.PopupMenuInsertSubMenu(ObjectPtr->ObjPtr, pos, title, submenu.ObjectPtr->ObjPtr);
      }

      public void EnableItem(int pos, bool enable)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.PopupMenuEnableItem(ObjectPtr->ObjPtr, pos, enable);
      }

      public void CheckItem(int pos, bool checkedValue)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.PopupMenuCheckItem(ObjectPtr->ObjPtr, pos, checkedValue);
      }

      public void CheckRadioItem(int firstPos, int lastPos, int checkPos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.PopupMenuCheckRadioItem(ObjectPtr->ObjPtr, firstPos, lastPos, checkPos);
      }

      public bool IsItemChecked(int pos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.PopupMenuIsItemChecked(ObjectPtr->ObjPtr, pos);
      }

      public void AttachToMenuBar(int pos, string title)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.PopupMenuAttachToMenuBar(ObjectPtr->ObjPtr, pos, title);
      }

      public void RemoveFromMenuBar()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.PopupMenuRemoveFromMenuBar(ObjectPtr->ObjPtr);
      }

      public void ShowPopup(int x = -1, int y = -1)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.PopupMenuShowPopup(ObjectPtr->ObjPtr, x, y);
      }
      
      #endregion

      
   }
}